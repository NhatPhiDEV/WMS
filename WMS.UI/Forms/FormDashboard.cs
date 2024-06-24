using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Threading;
using MaterialSkin.Controls;
using MediatR;
using S7.Net;
using WMS.Application.Common;
using WMS.Application.Features.Inventories.Commands.Upsert;
using WMS.Application.Features.InventoryTransactions.Commands.Create;
using WMS.Application.Features.InventoryTransactions.Queries.GetMultiple;
using WMS.Application.Features.InventoryTransactionTypes.Queries.GetMultiple;
using WMS.Application.Features.Locations.Queries.GetAvailable;
using WMS.Application.Features.Locations.Queries.GetById;
using WMS.Application.Features.Locations.Queries.GetByLocationCode;
using WMS.Application.Features.Locations.Queries.GetByProductSku;
using WMS.Application.Features.Locations.Queries.GetByZoneId;
using WMS.Application.Features.PLC.Commands.Write;
using WMS.Application.Features.PLC.Queries.Connect;
using WMS.Application.Features.PLC.Queries.Disconnect;
using WMS.Application.Features.PLC.Queries.Read;
using WMS.Application.Features.PLC.Queries.ReadBytes;
using WMS.Application.Features.Products.Queries.GetBySku;
using WMS.Application.Features.Zones.Queries.GetMultiple;
using WMS.Domain.Enums;
using WMS.Domain.Models;
using WMS.Infrastructure.Common;
using WMS.UI.Common.Customize;
using WMS.UI.Common.Extensions;
using WMS.UI.Common.Messages;
using TextMessage = WMS.UI.Common.Messages.TextMessage.FormDashboard;

namespace WMS.UI.Forms
{
    public partial class FormDashboard : Form
    {
        private readonly IMediator _mediator;
        public bool IsLoadingInventoryTransTypes; // handle first loading

        // Send data to child form
        public delegate void AddProductEventHandler(string sku);
        public event AddProductEventHandler? AddProductEvent;

        public FormDashboard(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
        }

        private void Init(bool isActive)
        {

            CboInventoryTransactionType.Enabled = !isActive;
            CboStrategy.Enabled = !isActive;
            CboLocation.Enabled = !isActive;
            NumQuantity.Enabled = !isActive;
            NumQuantityLimit.Enabled = false;
            DtpCurrentDate.Enabled = !isActive;

            BtnExecuteAll.Enabled = true;
            BtnExecuteSelected.Enabled = true;

            CboLocation.DataSource = null;
            NumQuantity.Value = 1;
            NumQuantityLimit.Value = 1;

            TbSku.Focus();

        }

        private async Task BindInventoryTransactions(string search = "")
        {
            var query = new GetMultipleInventoryTransactionsQuery(search);
            var transactions = await _mediator.Send(query);

            dgvInventoryTransactionType.Rows.Clear();

            AddTransactionRows(transactions);
        }

        private void AddTransactionRows(IEnumerable<InventoryTransaction> transactions)
        {
            var rowIndex = 1;

            foreach (var transaction in transactions)
            {
                dgvInventoryTransactionType.Rows.Add(
                    rowIndex++,
                    transaction.Product.Sku,
                    transaction.Location.LocationCode,
                    transaction.InventoryTransactionType.InventoryTransactionTypeName,
                    transaction.Quantity.ToString(),
                    transaction.Status.ToString(),
                    transaction.TransactionDate.ToString("dd/MM/yyyy HH:mm:ss"),
                    transaction.Notes);
            }
        }

        private async Task<(bool Success, int? ProductId)> ValidateProduct()
        {
            var query = new GetProductIdBySkuQuery(TbSku.Text);
            var product = await _mediator.Send(query);
            if (product != null) return (true, product.ProductId);

            TryParseInventoryTransType(out var invTransTypeId);
            switch (invTransTypeId)
            {
                case (int)EInventoryTransactionTypes.In:
                    {
                        var dialogMessage = new StringBuilder();
                        dialogMessage.Append(TextMessage.Product.NotExists);
                        dialogMessage.Append(TextMessage.Product.Create);

                        // Show dialog create product
                        var dialogResult =MaterialMessageBox.Show(
                            dialogMessage.ToString(),
                            CaptionMessage.System.Notification,
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Warning);

                        if (dialogResult != DialogResult.OK) return (false, null);

                        var dialog = new FormCreateProduct(_mediator);
                        dialog.SetOwner(this);
                        // Send data to dialog
                        AddProductEvent?.Invoke(TbSku.Text);
                        dialog.ShowDialog();

                        return (false, null);
                    }
                case (int)EInventoryTransactionTypes.Out:

                   MaterialMessageBox.Show(
                        TextMessage.Product.NotFound,
                        CaptionMessage.System.Notification,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return (false, null);
                default:
                    return (true, product?.ProductId);
            }
        }

        private async Task ProcessInventory(Inventory inventory)
        {
            if (!TryParseInventoryTransType(out var inventoryTransactionTypeId))
                return;

            var transactionType = (EInventoryTransactionTypes)inventoryTransactionTypeId;

            await UpsertInventory(inventory, transactionType);

            await CreateCreateInventoryTransaction(inventory, transactionType);

            await BindInventoryTransactions();
        }

        private async Task UpsertInventory(
            Inventory inventory,
            EInventoryTransactionTypes transactionType)
        {
            var query = new UpsertInventoryCommand(inventory, transactionType);
            await _mediator.Send(query);
        }

        private async Task CreateCreateInventoryTransaction(
            Inventory inventory,
            EInventoryTransactionTypes transactionType)
        {
            var query = new CreateInventoryTransactionCommand(
                inventory.LocationId,
                inventory.ProductId,
                (int)NumQuantity.Value,
                (int)transactionType,
                EInventoryTransactionStatus.Completed,
                string.Empty);

            await _mediator.Send(query);
        }

        private (bool Success, string ErrorMessage) ValidateInput()
        {
            if (!IsValidSku())
            {
                return (false, TextMessage.Validate.InvalidSku);
            }

            if (!IsValidInventoryTransactionType())
            {
                return (false, TextMessage.Validate.InvalidInventorTransType);
            }

            if (!IsValidLocation())
            {
                return (false, TextMessage.Validate.InvalidLocation);
            }

            return (true, "");
        }

        private bool IsValidSku()
        {
            return !string.IsNullOrEmpty(TbSku.Text.Trim());
        }

        private bool IsValidInventoryTransactionType()
        {
            return TryParseInventoryTransType(out _);
        }

        private bool IsValidLocation()
        {
            _ = int.TryParse(CboLocation.SelectedValue?.ToString(), out var locationId);

            return locationId > 0;
        }

        private bool TryParseInventoryTransType(out int inventoryTransTypeId)
        {
            return int.TryParse(CboInventoryTransactionType.SelectedValue?.ToString(), out inventoryTransTypeId);
        }

        private async Task BindInventoryTransactionTypes()
        {
            IsLoadingInventoryTransTypes = true;

            var query = new GetMultipleInventoryTransactionTypesQuery();
            var result = await _mediator.Send(query);

            CboInventoryTransactionType.SetDataSourceWithMembers(
                result,
                nameof(ComboBoxItem.Key),
                nameof(ComboBoxItem.Val));

            IsLoadingInventoryTransTypes = false;
        }

        private void BindStrategies()
        {
            var data = new List<ComboBoxItem>
            {
                new() { Key = 1, Val = "First in Last out" },
            };
            CboStrategy.SetDataSourceWithMembers(data, nameof(ComboBoxItem.Key), nameof(ComboBoxItem.Val));
        }

        private async Task BindZones()
        {
            flpZones.Controls.Clear();
            var query = new GetMultipleZoneQuery();
            var zones = await _mediator.Send(query);

            foreach (var zone in zones)
            {
                Button button = new()
                {
                    Text = zone.ZoneName,
                    Size = new Size(80, 30),
                    Tag = zone
                };
                button.Click += BtnZone_Click;

                flpZones.Controls.Add(button);
            }
        }

        private async Task<List<Location>> GetAvailableLocations(
            int? productId,
            int quantity,
            EInventoryTransactionTypes transactionType)
        {
            var query = new GetAvailableLocationsQuery(productId, quantity, transactionType);
            var locations = await _mediator.Send(query);

            return locations.ToList();
        }

        private async Task ChangeSku(int? productId)
        {
            var isSkuValid = !string.IsNullOrEmpty(TbSku.Text);

            if (isSkuValid)
            {
                TryParseInventoryTransType(out var inventoryTransactionTypeId);

                var transactionType = (EInventoryTransactionTypes)inventoryTransactionTypeId;

                var locations = await GetAvailableLocations(
                    productId,
                    (int)NumQuantity.Value,
                    transactionType);

                var dataSource = new List<ComboBoxItem>();
                foreach (var location in locations)
                {
                    var (val, additionalValue) = TryParseLocationValue(location, transactionType);
                    dataSource.Add(new ComboBoxItem
                    {
                        Key = location.LocationId,
                        Val = val,
                        AdditionalValue = additionalValue
                    });
                }

                CboLocation.SetDataSourceWithMembers(dataSource, nameof(ComboBoxItem.Key), nameof(ComboBoxItem.Val));

            }
        }

        private (string, int) TryParseLocationValue(Location location, EInventoryTransactionTypes transactionType)
        {
            var currentQuantity = location.Inventories.Sum(i => i.Quantity);
            var capacity = location.Capacity;

            var dgvRows = DgvProcess.Rows.Cast<DataGridViewRow>().ToList();
            foreach (var row in dgvRows)
            {
                int.TryParse(row.Cells[nameof(EDashboardGvProcess.GvProcessColLocationId)].Value.ToString(), out int locationId);
                if (location.LocationId == locationId)
                {
                    int.TryParse(row.Cells[nameof(EDashboardGvProcess.GvProcessColQuantity)].Value.ToString(),
                        out var quantityValue);
                    if (transactionType == EInventoryTransactionTypes.In)
                    {
                        currentQuantity += quantityValue;
                    }
                }
            }

            var value = BuilderLocationValue(location, currentQuantity, capacity);

            var additionalValue = transactionType == EInventoryTransactionTypes.In
                ? location.Capacity - currentQuantity
                : currentQuantity;

            return (value, additionalValue);
        }

        private static string BuilderLocationValue(Location location, int currentQuantity, int capacity)
        {
            var sb = new StringBuilder();
            sb.Append("Y: ");
            sb.Append(location.PointY);
            sb.Append(", Z: ");
            sb.Append(location.PointZ);
            sb.Append(", X: ");
            sb.Append(location.PointX);
            sb.Append(" (");
            sb.Append(currentQuantity);
            sb.Append('/');
            sb.Append(capacity);
            sb.Append(')');

            return sb.ToString();
        }


        public void DisplayLocations(IEnumerable<Location> data)
        {
            FlpLocations.Controls.Clear();
            var result = data.ToList().GroupBy(item => item.PointY)
                .ToDictionary(item => item.Key, item => item.ToList()).ToList();

            foreach (var item in result)
            {
                var groupedItems = item.Value.GroupBy(i => i.PointZ);

                var panel = new Panel
                {
                    BackColor = Color.BlueViolet,
                    Width = FlpLocations.ClientSize.Width - FlpLocations.Margin.Horizontal,
                    AutoScroll = true,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink
                };

                var flpGrid = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.Aqua,
                    AutoScroll = true,
                    WrapContents = false,
                    FlowDirection = FlowDirection.TopDown,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                };
                panel.Controls.Add(flpGrid);

                foreach (var locations in groupedItems)
                {
                    var userControl = new CellControl
                    {
                        Width = flpGrid.Width - flpGrid.Margin.Horizontal
                    };

                    foreach (var location in locations)
                    {
                        var pallet = new Button
                        {
                            Size = new Size(50, 50),
                            Text = location.LocationCode,
                            BackColor = GetColorLocation(location)
                        };
                        userControl.AddControlToFlpCell(pallet);
                        userControl.Title = location.PointZ;
                    }

                    flpGrid.Controls.Add(userControl);
                    FlpLocations.Controls.Add(panel);
                }
            }
            FlpLocations.PerformLayout();
            FlpLocations.Refresh();
        }

        private static Color GetColorLocation(Location location)
        {
            var limitQuantity = 5;
            int inventoryQuantity = location.Inventories.Sum(i => i.Quantity);

            if (inventoryQuantity == location.Capacity)
            {
                return Color.Red;
            }

            if (inventoryQuantity > 0 && location.Capacity - inventoryQuantity > limitQuantity)
            {
                return Color.LightBlue;
            }

            if (location.Capacity - inventoryQuantity < limitQuantity)
            {
                return Color.Yellow;
            }

            return Color.Green;
        }

        private async void FromDashboard_Load(object sender, EventArgs e)
        {
            await BindZones();
            Init(true);
            await BindInventoryTransactions();
            await BindInventoryTransactionTypes();
            BindStrategies();
        }

        private async void BtnZone_Click(object? sender, EventArgs e)
        {
            if (sender is not Button clickedButton) return;

            var zone = (Zone?)clickedButton.Tag;

            if (zone == null) return;

            var query = new GetLocationsByZoneIdQuery(zone.ZoneId);
            var locations = await _mediator.Send(query);

            DisplayLocations(locations);

        }

        private async void TbSearchByLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            var query = new GetLocationsByLocationCodeQuery(TbSearchByLocation.Text);
            var locations = await _mediator.Send(query);
            DisplayLocations(locations);
            e.Handled = true;
        }

        private void DgvInventoryTransactionType_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.CellStyle == null)
            {
                return;
            }

            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            const int indexColStatus = 5;

            if (e.ColumnIndex != indexColStatus) return;

            var status = e.Value?.ToString();

            e.CellStyle.ForeColor = status switch
            {
                nameof(EInventoryTransactionStatus.Completed) => Color.Green,
                nameof(EInventoryTransactionStatus.Cancelled) => Color.Red,
                nameof(EInventoryTransactionStatus.Pending) => Color.FromArgb(157, 109, 37),
                _ => e.CellStyle.ForeColor
            };
        }

        private async void TbSearchInventoryTransaction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await BindInventoryTransactions(tbSearchInventoryTransaction.Text);
            }
        }

        private void CboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboLocation.SelectedItem is not ComboBoxItem selectedItem) return;

            _ = decimal.TryParse(selectedItem.AdditionalValue.ToString(), out var value);
            NumQuantity.Maximum = value;
            NumQuantityLimit.Value = value;

        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            Init(true);
            await BindInventoryTransactions();
            TbSku.Text = null;
        }

        private async void BtnAddToQueue_Click(object sender, EventArgs e)
        {
            var (isValid, errorMessage) = ValidateInput();

            if (!isValid)
            {
               MaterialMessageBox.Show(errorMessage,
                    CaptionMessage.System.Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var (isValidProduct, _) = await ValidateProduct();

            if (!isValidProduct)
            {
                return;
            }

            AddRowToDgvProcess();

            Init(true);

            TbSku.Text = null;

        }

        private void AddRowToDgvProcess()
        {
            var transactionType = CboInventoryTransactionType.SelectedItem as ComboBoxItem;

            if (CboLocation.SelectedItem is not ComboBoxItem location)
            {
                return;
            }

            var rowExists = CheckRowExists(location, transactionType?.Val.ToString());

            if (rowExists) return;

            var row = new DataGridViewRow();
            row.CreateCells(DgvProcess);

            row.Cells[(int)EDashboardGvProcess.GvProcessColStt].Value = DgvProcess.Rows.Count + 1;
            row.Cells[(int)EDashboardGvProcess.GvProcessColSku].Value = TbSku.Text;
            row.Cells[(int)EDashboardGvProcess.GvProcessColTransactionType].Value = transactionType?.Val.ToString();
            row.Cells[(int)EDashboardGvProcess.GvProcessColLocation].Value = GetLocationValue(location.Val.ToString());
            row.Cells[(int)EDashboardGvProcess.GvProcessColQuantity].Value = NumQuantity.Value.ToString(CultureInfo.InvariantCulture);
            row.Cells[(int)EDashboardGvProcess.GvProcessColLocationId].Value = location.Key;
            row.Cells[(int)EDashboardGvProcess.GvProcessColTransactionTypeId].Value = transactionType?.Key.ToString();

            DgvProcess.Rows.Add(row);

        }

        private static string GetLocationValue(string? value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;

            int index = value.IndexOf(" (", StringComparison.Ordinal);

            return index != -1 ? value[..index] : string.Empty;
        }

        private bool CheckRowExists(ComboBoxItem location, string? transactionType)
        {
            var sku = TbSku.Text;
            var locationKey = location.Key.ToString();

            var matchingRow = DgvProcess.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(row =>
                    row.Cells[nameof(EDashboardGvProcess.GvProcessColSku)].Value?.ToString() == sku &&
                    row.Cells[nameof(EDashboardGvProcess.GvProcessColTransactionType)].Value?.ToString() == transactionType &&
                    row.Cells[nameof(EDashboardGvProcess.GvProcessColLocationId)].Value?.ToString() == locationKey
                );

            if (matchingRow == null) return false;
            UpdateRowQuantity(matchingRow);
            return true;
        }

        private void UpdateRowQuantity(DataGridViewRow row)
        {
            var quantityCellValue = row.Cells[nameof(EDashboardGvProcess.GvProcessColQuantity)].Value;
            _ = int.TryParse(quantityCellValue?.ToString(), out var currentQuantity);
            var newQuantity = currentQuantity + (int)NumQuantity.Value;
            row.Cells[nameof(EDashboardGvProcess.GvProcessColQuantity)].Value = newQuantity.ToString(CultureInfo.InvariantCulture);
        }

        private async void CboInventoryTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsLoadingInventoryTransTypes) return;

            var (isValidProduct, productId) = await ValidateProduct();

            if (!isValidProduct)
            {
                return;
            }
            await ChangeSku(productId);
        }

        private async void TbSku_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || string.IsNullOrEmpty(TbSku.Text)) return;

            var (isValidProduct, productId) = await ValidateProduct();

            if (!isValidProduct)
            {
                return;
            }

            Init(false);

            await ChangeSku(productId);

            e.Handled = true;
        }

        private List<DataGridViewRow> GetCheckedRows()
        {
            return DgvProcess.Rows.Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells[nameof(EDashboardGvProcess.GvProcessColCheckBox)].Value))
                .ToList();
        }

        private void BtnDeleteSelected_Click(object sender, EventArgs e)
        {
            var checkedRows = GetCheckedRows();
            if (checkedRows.Count < 1) return;

            var dialogResult = MaterialMessageBox.Show(
                TextMessage.ConfirmDeleteProcess,
                CaptionMessage.System.Notification,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (dialogResult != DialogResult.OK) return;

            for (var i = DgvProcess.Rows.Count - 1; i >= 0; i--)
            {
                var row = DgvProcess.Rows[i];

                if (Convert.ToBoolean(row.Cells[nameof(EDashboardGvProcess.GvProcessColCheckBox)].Value))
                {
                    DgvProcess.Rows.RemoveAt(i);
                }
            }

            MaterialMessageBox.Show(
                TextMessage.DeleteProcessSuccessfully,
                CaptionMessage.System.Notification,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {
            if (DgvProcess.Rows.Count < 1) return;

            var dialogResult = MaterialMessageBox.Show(
                TextMessage.ConfirmDeleteAllProcess,
                CaptionMessage.System.Notification,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (dialogResult != DialogResult.OK) return;

            DgvProcess.Rows.Clear();

            MaterialMessageBox.Show(
                TextMessage.DeleteProcessSuccessfully,
                CaptionMessage.System.Notification,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private CancellationTokenSource? _cancellationTokenSource;

        private async void BtnExecuteSelected_Click(object sender, EventArgs e)
        {
            if (DgvProcess.Rows.Count == 0) return;

            var selectedRow = GetCheckedRows();

            if (selectedRow.Count == 0) return;
            
            var dialogResult =MaterialMessageBox.Show(
                TextMessage.ExecuteSelected,
                CaptionMessage.System.Notification,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            if (dialogResult != DialogResult.OK) return;

            _cancellationTokenSource = new CancellationTokenSource();
            await Execute(selectedRow, _cancellationTokenSource);
        }

        private async void BtnExecuteAll_Click(object sender, EventArgs e)
        {
            if (DgvProcess.Rows.Count == 0) return;

            var dialogResult =MaterialMessageBox.Show(
                TextMessage.ExecuteAll,
                CaptionMessage.System.Notification,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            if (dialogResult != DialogResult.OK) return;

            var rows = DgvProcess.Rows.Cast<DataGridViewRow>().ToList();
            _cancellationTokenSource = new CancellationTokenSource();
            await Execute(rows, _cancellationTokenSource);
        }

        private async void FormOnCancelProcess(object sender, EventArgs e)
        {
            if (_cancellationTokenSource != null)
                await _cancellationTokenSource.CancelAsync();

            await Task.Delay(2000);

           MaterialMessageBox.Show(TextMessage.CancelExecutedSuccessfully,
                CaptionMessage.System.Notification,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            BtnExecuteAll.Enabled = true;
            BtnExecuteSelected.Enabled = true;

            // Send Incorrect to PLC
            await _mediator.Send(new WritePlcDataCommand(AppConfig.Plc.Address.Incorrect, 1));
        }

        private async Task Execute(List<DataGridViewRow> rows, CancellationTokenSource cancellationTokenSource)
        {
            var processDialog = new FormProcessDialog(cancellationTokenSource);
            processDialog.CancelProcess += FormOnCancelProcess;

            var cancellationToken = cancellationTokenSource.Token;

            BtnExecuteAll.Enabled = false;
            BtnExecuteSelected.Enabled = false;

            // Open Connection To PLC
            await _mediator.Send(new OpenPlcConnectQuery(), cancellationToken);

            int count = 0;

            foreach (var row in rows.TakeWhile(row => !cancellationToken.IsCancellationRequested))
            {
                // Delay 1s
                await Task.Delay(200, cancellationToken);

                var sku = row.Cells[nameof(EDashboardGvProcess.GvProcessColSku)].Value.ToString()!;
                var transactionType = row.Cells[nameof(EDashboardGvProcess.GvProcessColTransactionType)].Value.ToString()!;
                int.TryParse(row.Cells[nameof(EDashboardGvProcess.GvProcessColLocationId)].Value.ToString(), out int locationId);

                var query = new GetProductIdBySkuQuery(sku);
                var product = await _mediator.Send(query, cancellationToken);

                var location = await _mediator.Send(new GetLocationByIdQuery(locationId), cancellationToken);
                int.TryParse(row.Cells[nameof(EDashboardGvProcess.GvProcessColTransactionTypeId)].Value.ToString(), out int transactionTypeId);

                // Show Process Dialog
                processDialog.ProcessName = TextMessage.ProcessName(transactionType, sku);
                processDialog.Show();

                if (product is null)
                {
                    continue;
                }

                if (location is null)
                {
                    continue;
                }

                await WriteDataToPlc(location, transactionTypeId, cancellationToken);

                var isValidSku = await ValidateSkuFromPlc(sku, cancellationToken);
                if (!isValidSku)
                {
                   MaterialMessageBox.Show(TextMessage.Product.SkuNotMatch,
                        CaptionMessage.System.Notification,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

                var isSuccess = await GetStatusPlcRunning(cancellationToken);

                // Error
                if (!isSuccess) return;

                // In prod remove it
                await Task.Delay(2000); // Delay 2s

                if (cancellationToken.IsCancellationRequested) break;

                var inventory = new Inventory
                {
                    LocationId = locationId,
                    ProductId = product.ProductId,
                    Quantity = (int)NumQuantity.Value,
                    StorageDate = DtpCurrentDate.Value,
                    IsActive = true
                };

                await ProcessInventory(inventory);
                DgvProcess.Rows.Remove(row);
                count++;
                processDialog.Hide();
            }

            BtnExecuteAll.Enabled = true;
            BtnExecuteSelected.Enabled = true;

           MaterialMessageBox.Show(TextMessage.ExecutedSuccessfully(count),
                CaptionMessage.System.Notification,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Close Connection To PLC
            await _mediator.Send(new ClosePlcConnectQuery(), cancellationToken);
        }

        private async Task WriteDataToPlc(Location location, int transactionTypeId, CancellationToken cancellationToken)
        {
            await _mediator.Send(new WritePlcDataCommand(AppConfig.Plc.Address.PointX, location.PointX), cancellationToken);
            await _mediator.Send(new WritePlcDataCommand(AppConfig.Plc.Address.PointY, location.PointY), cancellationToken);
            await _mediator.Send(new WritePlcDataCommand(AppConfig.Plc.Address.PointZ, location.PointZ), cancellationToken);

            if ((EInventoryTransactionTypes)transactionTypeId == EInventoryTransactionTypes.In)
            {
                await _mediator.Send(new WritePlcDataCommand(AppConfig.Plc.Address.In, 1), cancellationToken);
            }
            if ((EInventoryTransactionTypes)transactionTypeId == EInventoryTransactionTypes.Out)
            {
                await _mediator.Send(new WritePlcDataCommand(AppConfig.Plc.Address.Out, 1), cancellationToken);
            }
        }

        private async Task<bool> GetStatusPlcRunning(CancellationToken cancellationToken)
        {
            var isSuccess = false;

            // Cancel time limit
            var query = new ReadBytesPlcDataQuery(DataType.DataBlock, 26, 0, 19);

            while (!isSuccess)
            {
                var dataReceive = await _mediator.Send(query, cancellationToken);

                isSuccess = dataReceive[18].SelectBit(2);

                if (isSuccess)
                    break;
            }

           MaterialMessageBox.Show(TextMessage.GetStatusFromPlcUnsuccessfully,
                CaptionMessage.System.Notification,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return isSuccess;

        }

        private async Task<bool> ValidateSkuFromPlc(string sku, CancellationToken cancellationToken)
        {
            var isSuccess = true;

            var readPlcDataQuery = new ReadPlcDataQuery(AppConfig.Plc.Address.ReadBarcode);
            var correctCommand = new WritePlcDataCommand(AppConfig.Plc.Address.Correct, 1);
            var incorrectCommand = new WritePlcDataCommand(AppConfig.Plc.Address.Incorrect, 1);

            while (isSuccess)
            {
                var barcode = await _mediator.Send(readPlcDataQuery, cancellationToken);

                if (barcode?.ToString() == null) continue;

                if (barcode.ToString() == sku)
                {
                    await _mediator.Send(correctCommand, cancellationToken);
                    isSuccess = false;
                }
                else
                {
                    await _mediator.Send(incorrectCommand, cancellationToken);
                    break;
                }
            }

            return isSuccess;
        }

        private void FlpLocations_Resize(object sender, EventArgs e)
        {
            foreach (Control control in FlpLocations.Controls)
            {
                control.Width = FlpLocations.ClientSize.Width - FlpLocations.Margin.Horizontal;

            }
        }

        private async void TbSearchByProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            var query = new GetLocationByProductSkuQuery(TbSearchByProduct.Text);
            var locations = await _mediator.Send(query);
            DisplayLocations(locations);
        }

    }
}
