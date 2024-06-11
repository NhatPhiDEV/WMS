using AForge.Video;
using AForge.Video.DirectShow;
using MediatR;
using WMS.Application.Common;
using WMS.Application.Features.Inventories.Commands.Upsert;
using WMS.Application.Features.InventoryTransactions.Commands.Create;
using WMS.Application.Features.InventoryTransactions.Queries.GetMultiple;
using WMS.Application.Features.InventoryTransactionTypes.Queries.GetMultiple;
using WMS.Application.Features.Locations.Queries.GetAvailable;
using WMS.Application.Features.Locations.Queries.GetByLocationCode;
using WMS.Application.Features.Locations.Queries.GetByZoneId;
using WMS.Application.Features.Products.Queries.GetBySku;
using WMS.Application.Features.Zones.Queries.GetMultiple;
using WMS.Domain.Enums;
using WMS.Domain.Models;
using WMS.UI.Common.Customize;
using WMS.UI.Common.Extensions;

namespace WMS.UI.Forms
{
    public partial class FormDashboard : Form
    {
        private readonly IMediator _mediator;

        FilterInfoCollection? _filterInfoCollection;
        VideoCaptureDevice? _videoCaptureDevice;

        /// <summary>
        /// Truyền dữ liệu sang dialog tạo sản phẩm
        /// </summary>
        /// <param name="sku"></param>
        public delegate void SendDataToDialogEventHandler(string sku);
        public event SendDataToDialogEventHandler? SendDataToDialog;

        public FormDashboard(IMediator mediator)
        {
            _mediator = mediator;

            InitializeComponent();

        }

        #region Events

        private async void Form_Dashboard_Load(object sender, EventArgs e)
        {
            await GetZones();
            LoadDevice();
            await Init(true);
            await GetInventoryTransactionTypes();
        }

        private async void BtnZone_Click(object? sender, EventArgs e)
        {
            if (sender is not Button clickedButton) return;

            var zone = (Zone?)clickedButton.Tag;
            if (zone == null)
            {
                return;
            }
            else
            {
                var query = new GetLocationsByZoneIdQuery(zone.ZoneId);
                var locations = await _mediator.Send(query);

                LoadLocations(locations);
            }

        }

        private async void TbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            var query = new GetLocationsByLocationCodeQuery(tbSearch.Text);
            var locations = await _mediator.Send(query);
            LoadLocations(locations);
            e.Handled = true;
        }

        #region QR Code

        private void LoadDevice()
        {
            _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (_filterInfoCollection != null)
            {
                foreach (FilterInfo filterInfo in _filterInfoCollection)
                {
                    cbDevice.Items.Add(filterInfo.Name);
                }
            }
            // Load item đầu tiên
            cbDevice.SelectedIndex = 0;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (_filterInfoCollection != null)
            {
                _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[cbDevice.SelectedIndex].MonikerString);
                _videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                _videoCaptureDevice.Start();
                // Ẩn nút manual khi chọn quét mã
                btnManual.Enabled = false;
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            var reader = new ZXing.Windows.Compatibility.BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                tbSku.Invoke(new MethodInvoker(delegate ()
                {
                    tbSku.Text = result.ToString();
                }));
            }
            pbCamera.Image = bitmap;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (_videoCaptureDevice != null)
            {
                if (_videoCaptureDevice.IsRunning)
                {
                    _videoCaptureDevice.SignalToStop();
                    _videoCaptureDevice.WaitForStop();
                    pbCamera.Image = null;
                    btnManual.Enabled = true;
                }
            }
        }

        #endregion

        private async void tbSku_TextChanged(object sender, EventArgs e)
        {
            await ChangeSku();
        }

        private void dgvInventoryTransactionType_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.CellStyle == null) { return; }

            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            const int indexColStatus = 5;

            if (e.ColumnIndex != indexColStatus) return; // Cột trạng thái

            var status = e.Value?.ToString();

            switch (status)
            {
                case nameof(EInventoryTransactionStatus.Completed):
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);

                    break;
                case nameof(EInventoryTransactionStatus.Cancelled):
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);

                    break;
                case nameof(EInventoryTransactionStatus.Pending):
                    e.CellStyle.ForeColor = Color.FromArgb(157, 109, 37);
                    e.CellStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);

                    break;
                default:
                    break;

            }
        }

        private async void tbSearchInventoryTransaction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await GetInventoryTransactionTypes(tbSearchInventoryTransaction.Text);
            }
        }

        private async void cboInventoryTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            await ChangeSku();
        }

        private void cboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLocation.SelectedItem is not ComboBoxItem selectedItem) return;

            _ = decimal.TryParse(selectedItem.AdditionalValue.ToString(), out var value);
            numQuantity.Maximum = value;
            numQuanlityLimit.Value = value;

        }

        private async void btnManual_Click(object sender, EventArgs e)
        {
            // Chế độ thủ công
            await Init(false);
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await Init(true);
            await GetInventoryTransactionTypes();
        }

        private async void ButtonOk_Click(object sender, EventArgs e)
        {
            var (isValid, errorMessage) = ValidateInput();

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var (isValidProduct, _) = await ValidateProduct();

            if (!isValidProduct)
            {
                return;
            }

            var result = MessageBox.Show(
                       $"Bạn có chắn chắn muốn {cboInventoryTransactionType.Text} cho {tbSku.Text}?",
                       "Thông báo",
                       MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Warning);

            if (result != DialogResult.OK) return;

            var inventory = await CreateInventory();

            await ProcessInventory(inventory);

            await Init(true);
        }
        #endregion

        #region Functions
        private async Task Init(bool isActive)
        {
            btnStart.Enabled = isActive;
            btnStop.Enabled = isActive;

            tbSku.Enabled = !isActive;

            tbSku.Text = string.Empty;

            cboLocation.DataSource = null;

            numQuantity.Value = 1;
            numQuanlityLimit.Value = 1;

            btnStart.Focus();

            await GetInventoryTransactionTypeSelector();
            GetStrategySelector();
        }

        private async Task GetInventoryTransactionTypes(string search = "")
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

        private async Task<(bool Success, int? Product)> ValidateProduct()
        {
            var query = new GetProductIdBySkuQuery(tbSku.Text);
            var product = await _mediator.Send(query);
            if (product != null) return (true, product.ProductId);

            TryParseInventoryTransactionType(out var inventoryTransactionTypeId);
            switch (inventoryTransactionTypeId)
            {
                case (int)EInventoryTransactionTypes.In:
                    {
                        // Hiển thị dialog thông báo tạo sản phẩm mới (nếu cần)
                        var dialogResult = MessageBox.Show(
                            "Mã hàng không tồn tại trong kho, bạn có muốn tạo mới sản phẩm với mã hàng này?",
                            "Thông báo",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Warning);

                        if (dialogResult != DialogResult.OK) return (false, null);

                        var dialog = new FormCreateProduct(_mediator);
                        dialog.SetOwner(this);
                        // Send data to dialog
                        SendDataToDialog?.Invoke(tbSku.Text);
                        dialog.ShowDialog();

                        return (false, null);
                    }
                case (int)EInventoryTransactionTypes.Out:

                    MessageBox.Show("Sản phẩm bạn chọn không tồn tại trong kho, vui lòng kiểm tra lại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return (false, null);
                default:
                    return (true, product?.ProductId);
            }
        }

        private async Task<Inventory> CreateInventory()
        {
            var query = new GetProductIdBySkuQuery(tbSku.Text);
            var result = await _mediator.Send(query);

            _ = int.TryParse(cboLocation.SelectedValue?.ToString(), out var locationId);

            var productId = result?.ProductId ?? 0;

            return new Inventory
            {
                LocationId = locationId,
                ProductId = productId,
                Quantity = (int)numQuantity.Value,
                StorageDate = dtpCurrentDate.Value,
                IsActive = true
            };
        }

        private async Task ProcessInventory(Inventory inventory)
        {
            if (!TryParseInventoryTransactionType(out var inventoryTransactionTypeId))
                return;

            var transactionType = (EInventoryTransactionTypes)inventoryTransactionTypeId;

            await UpsertInventory(inventory, transactionType);

            await CreateCreateInventoryTransaction(inventory, transactionType);

            await GetInventoryTransactionTypes();
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
                (int)numQuantity.Value,
                (int)transactionType,
                EInventoryTransactionStatus.Completed,
                string.Empty);

            await _mediator.Send(query);

            switch (transactionType)
            {
                case EInventoryTransactionTypes.In:
                    MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case EInventoryTransactionTypes.Out:
                    MessageBox.Show("Xuất hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case EInventoryTransactionTypes.None:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }

        private (bool Success, string ErrorMessage) ValidateInput()
        {
            if (!IsValidSku())
            {
                return (false, "Mã hàng không được để trống!");
            }

            if (!IsValidInventoryTransactionType())
            {
                return (false, "Vui lòng chọn lệnh!");
            }

            if (!IsValidLocation())
            {
                return (false, "Không xác định được vị trí, vui lòng thử lại!");
            }

            return (true, "");
        }

        private bool IsValidSku()
        {
            return !string.IsNullOrEmpty(tbSku.Text.Trim());
        }

        private bool IsValidInventoryTransactionType()
        {
            return TryParseInventoryTransactionType(out _);
        }

        private bool IsValidLocation()
        {
            _ = int.TryParse(cboLocation.SelectedValue?.ToString(), out var locationId);

            return locationId > 0;
        }

        private bool TryParseInventoryTransactionType(out int inventoryTransactionTypeId)
        {
            return int.TryParse(cboInventoryTransactionType.SelectedValue?.ToString(), out inventoryTransactionTypeId);
        }

        private async Task GetInventoryTransactionTypeSelector()
        {
            var query = new GetMultipleInventoryTransactionTypesQuery();
            var result = await _mediator.Send(query);

            cboInventoryTransactionType.SetDataSourceWithMembers(
                result,
                nameof(ComboBoxItem.Key),
                nameof(ComboBoxItem.Val));
        }

        private void GetStrategySelector()
        {
            var data = new List<ComboBoxItem>
            {
                new() { Key = 1, Val = "First in Last out" },
            };
            cboStrategy.SetDataSourceWithMembers(data, nameof(ComboBoxItem.Key), nameof(ComboBoxItem.Val));
        }

        private async Task GetZones()
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

        private async Task<List<ComboBoxItem>> GetAvailableLocations(
            int? productId,
            int quantity,
            EInventoryTransactionTypes transactionType)
        {
            var query = new GetAvailableLocationsQuery(productId, quantity, transactionType);
            var locations = await _mediator.Send(query);
            return locations.Select(location => new ComboBoxItem
            {
                Key = location.LocationId,
                Val = $"VT:{location.Position}, H{location.Row}, C{location.Col} ({location.Inventories.Sum(i => i.Quantity)}/{location.Capacity})",
                AdditionalValue = transactionType == EInventoryTransactionTypes.In
                    ? location.Capacity - location.Inventories.Sum(i => i.Quantity)
                    : location.Inventories.Sum(i => i.Quantity)
            }).ToList();
        }

        private async Task ChangeSku()
        {
            var isSkuValid = !string.IsNullOrEmpty(tbSku.Text);

            if (isSkuValid)
            {
                var query = new GetProductIdBySkuQuery(tbSku.Text);
                var result = await _mediator.Send(query);
                TryParseInventoryTransactionType(out var inventoryTransactionTypeId);

                var transactionType = (EInventoryTransactionTypes)inventoryTransactionTypeId;

                var locations = await GetAvailableLocations(
                    result?.ProductId,
                    (int)numQuantity.Value,
                    transactionType);

                cboLocation.SetDataSourceWithMembers(locations, nameof(ComboBoxItem.Key), nameof(ComboBoxItem.Val));

            }
        }

        #region Function xử lý cho group Danh sách vị trí
        public void LoadLocations(IEnumerable<Location>? data)
        {
            flpLocations.Controls.Clear();

            if (data == null) return;

            var locationResponses = data as Location[] ?? data.ToArray();

            var rootLocations = locationResponses.Where(location => location.ParentLocationId == null).ToList();

            foreach (var rootLocation in rootLocations)
            {
                var childLocations = rootLocation.InverseParentLocation;

                var locationPanel = CreateLocationPanel(rootLocation.LocationName);
                var tableLayoutPanel = CreateTableLayoutPanel();
                locationPanel.Controls.Add(tableLayoutPanel);

                AddHeaderRow(tableLayoutPanel, rootLocation.LocationName, childLocations.Count);
                AddLocationRows(tableLayoutPanel, childLocations, locationResponses);

                flpLocations.Controls.Add(locationPanel);
            }


        }

        // Hàm tạo Panel cho mỗi vị trí
        private Panel CreateLocationPanel(string locationName)
        {
            return new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Fill,
                Padding = new Padding(5),
                AutoSize = true,
                Text = locationName // Thêm tên vị trí vào panel
            };
        }

        // Hàm tạo TableLayoutPanel
        private TableLayoutPanel CreateTableLayoutPanel()
        {
            return new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = true
            };
        }

        // Hàm thêm header row
        private void AddHeaderRow(TableLayoutPanel tableLayoutPanel, string rootLocationName, int columnCount)
        {
            var headerButton = CreateDisabledButton($"{rootLocationName} (R/C)");
            tableLayoutPanel.Controls.Add(headerButton, 1, 0);
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }

        // Hàm thêm location rows
        private void AddLocationRows(
            TableLayoutPanel tableLayoutPanel,
            IEnumerable<Location> childLocations,
            IEnumerable<Location>? allLocations)
        {
            int rowIndex = 1;
            foreach (var childLocation in childLocations)
            {
                var palletLocations = allLocations.Where(l => l.ParentLocationId == childLocation.LocationId).ToList();
                //var rowButton = CreateDisabledButton($"{rowIndex}");
                //tableLayoutPanel.Controls.Add(rowButton, 0, rowIndex);

                int colIndex = 1;
                foreach (var palletLocation in palletLocations)
                {
                    var button = CreatePalletButton(palletLocation.LocationCode);
                    tableLayoutPanel.Controls.Add(button, colIndex, rowIndex);
                    colIndex++;
                }

                rowIndex++;
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
        }

        // Hàm tạo button disabled
        private CustomizeButton CreateDisabledButton(string text)
        {
            return new CustomizeButton
            {
                Text = text,
                //Size = new Size(90, 20),
                //AutoSize = true,
                Margin = new Padding(0),
                Enabled = false,
                BackColor = Color.Transparent
            };
        }

        // Hàm tạo button cho pallet
        private CustomizeButton CreatePalletButton(string locationCode)
        {
            return new CustomizeButton
            {
                //Size = new Size(90, 20),
                BorderRadius = 5,
                Text = locationCode,
                // AutoSize = true,
                BackColor = Color.FromArgb(159, 96, 96),
                Margin = new Padding(0)
            };
        }
        #endregion
        #endregion
    }

}
