using AForge.Video;
using AForge.Video.DirectShow;
using WMS.BusinessLogic.Dtos.Base;
using WMS.BusinessLogic.Dtos.Zones;
using WMS.BusinessLogic.Services.Inventories;
using WMS.BusinessLogic.Services.InventoryTransactions;
using WMS.BusinessLogic.Services.InventoryTransactionTypes;
using WMS.BusinessLogic.Services.Locations;
using WMS.BusinessLogic.Services.ProductCategories;
using WMS.BusinessLogic.Services.Products;
using WMS.BusinessLogic.Services.Zones;
using WMS.Domain.Enums;
using WMS.Domain.Models;
using WMS.UI.Common.Customize;
using WMS.UI.Shared;

namespace WMS.UI.Forms
{
    public partial class Form_Dashboard : Form
    {
        private readonly IZoneService _zoneService;
        private readonly ILocationService _locationService;
        private readonly IInventoryTransactionTypeService _inventoryTransactionTypeService;
        private readonly IProductService _productService;
        private readonly IInventoryService _inventoryService;
        private readonly IInventoryTransactionService _inventoryTransactionService;
        private readonly IProductCategoryService _productCategoryService;

        FilterInfoCollection? _filterInfoCollection;
        VideoCaptureDevice? _videoCaptureDevice;

        /// <summary>
        /// Truyền dữ liệu sang dialog tạo sản phẩm
        /// </summary>
        /// <param name="sku"></param>
        public delegate void SendDataToDialogEventHandler(string sku);
        public event SendDataToDialogEventHandler? SendDataToDialog;

        public Form_Dashboard(
            IZoneService zoneService,
            ILocationService locationService,
            IInventoryTransactionTypeService inventoryTransactionTypeService,
            IProductService productService,
            IInventoryService inventoryService,
            IInventoryTransactionService inventoryTransactionService,
            IProductCategoryService productCategoryService)
        {
            _zoneService = zoneService;
            _locationService = locationService;
            _inventoryTransactionTypeService = inventoryTransactionTypeService;
            _productService = productService;
            _inventoryService = inventoryService;
            _inventoryTransactionService = inventoryTransactionService;
            _productCategoryService = productCategoryService;

            InitializeComponent();

        }

        #region Events

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            GetZones();
            LoadDevice();
            Init(true);
            GetInventoryTransactionTypes(null);
        }

        private void BtnZone_Click(object? sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                ZoneDto? zone = (ZoneDto?)clickedButton.Tag;
                if (zone == null)
                {
                    return;
                }
                else
                {
                    // Lấy ra danh sách location theo zone
                    var locations = _locationService.GetLocationsByZoneId(zone.ZoneId);
                    // Lấy ra danh sách Level 0 (Kệ)
                    LoadLocations(locations);

                }
            }

        }

        private void TbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var locations = _locationService.GetLocationsByLocationCode(tbSearch.Text);
                LoadLocations(locations);
                e.Handled = true;
            }
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

        private void tbSku_TextChanged(object sender, EventArgs e)
        {
            ChangeSku();
        }
        private void dgvInventoryTransactionType_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.CellStyle == null) { return; }

            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            int indexColStatus = 5;

            if (e.ColumnIndex == indexColStatus) // Cột trạng thái
            {
                string? status = e.Value?.ToString();

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
        }

        private void tbSearchInventoryTransaction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetInventoryTransactionTypes(tbSearchInventoryTransaction.Text);
            }
        }

        private void cboInventoryTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSku();
        }

        private void cboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLocation.SelectedItem is SelectorDto selectedItem)
            {
                _ = decimal.TryParse(selectedItem.AdditionalValue.ToString(), out var value);
                numQuanlity.Maximum = value;
                numQuanlityLimit.Value = value;
            }

        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            // Chế độ thủ công
            Init(false);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Init(true);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var (IsValid, ErrorMessage) = ValidateInput();

            if (!IsValid)
            {
                MessageBox.Show(ErrorMessage, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var (IsValidProduct, Product) = ValidateProduct();

            if (!IsValidProduct)
            {
                return;
            }

            var location = _locationService.GetAvailableLocations(
                Product?.ProductId,
                (int)numQuanlity.Value,
                EInventoryTransactionTypes.In);
            if (!IsValidLocation(location))
            {
                MessageBox.Show("Không xác định được vị trí, vui lòng thử lại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                       $"Bạn có chắn chắn muốn {cboInventoryTransactionType.Text} cho {tbSku.Text}?",
                       "Thông báo",
                       MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                var inventory = CreateInventory();
                if (inventory == null) return;

                ProcessInventory(inventory);

                Init(true);

            }
        }
        #endregion

        #region Functions
        private void Init(bool isActive)
        {
            btnStart.Enabled = isActive;
            btnStop.Enabled = isActive;

            tbSku.Enabled = !isActive;

            tbSku.Text = string.Empty;

            cboLocation.DataSource = null;

            numQuanlity.Value = 1;
            numQuanlityLimit.Value = 1;

            btnStart.Focus();

            GetInventoryTransactionTypeSelector();
            GetStrategySelector();
        }

        private void GetInventoryTransactionTypes(string? search)
        {
            var data = _inventoryTransactionService.GetTransaction(search);
            dgvInventoryTransactionType.Rows.Clear();

            int index = 1;
            foreach (var item in data)
            {
                int rowIndex = dgvInventoryTransactionType.Rows.Add(
                    index,
                    item.ProductSku,
                    item.Location,
                    item.InventoryTransactionType,
                    item.Quanlity,
                    item.Status,
                    item.TransactionDate,
                    item.Notes
                );
                index++;
            }
        }

        private (bool Success, Product? Product) ValidateProduct()
        {
            var product = _productService.GetProductBySku(tbSku.Text);
            if (product == null)
            {
                TryParseInventoryTransactionType(out int inventoryTransactionTypeId);
                if (inventoryTransactionTypeId == (int)EInventoryTransactionTypes.In)
                {
                    // Hiển thị dialog thông báo tạo sản phẩm mới (nếu cần)
                    DialogResult result = MessageBox.Show(
                        "Mã hàng không tồn tại trong kho, bạn có muốn tạo mới sản phẩm với mã hàng này?",
                        "Thông báo",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        var dialog = new Form_CreateProduct(_productCategoryService, _productService);
                        dialog.SetOwner(this);
                        // Truyền dữ liệu sang dialog
                        SendDataToDialog?.Invoke(tbSku.Text);
                        dialog.ShowDialog();
                    }

                    return (false, null);

                }
                if (inventoryTransactionTypeId == (int)EInventoryTransactionTypes.Out)
                {
                    MessageBox.Show("Sản phẩm bạn chọn không tồn tại trong kho, vui lòng kiểm tra lại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return (false, null);
                }
            }

            return (true, product);
        }

        private Inventory CreateInventory()
        {
            var product = _productService.GetProductBySku(tbSku.Text);
            int productId = product != null ? product.ProductId : 0;

            _ = int.TryParse(cboLocation.SelectedValue?.ToString(), out var locationId);

            return new Inventory
            {
                LocationId = locationId,
                ProductId = productId,
                Quantity = (int)numQuanlity.Value,
                StorageDate = dtpCurrentDate.Value,
                IsActive = true
            };
        }

        private void ProcessInventory(Inventory inventory)
        {
            if (!TryParseInventoryTransactionType(out int inventoryTransactionTypeId))
                return;

            var transactionType = (EInventoryTransactionTypes)inventoryTransactionTypeId;
            _inventoryService.InsertOrUpdateInventory(inventory, transactionType);

            var inventoryTransaction = new InventoryTransaction
            {
                LocationId = inventory.LocationId,
                ProductId = inventory.ProductId,
                Quantity = (int)numQuanlity.Value,
                InventoryTransactionTypeId = inventoryTransactionTypeId,
                TransactionDate = TimeHelper.GetLocalTime(),
                ReferenceId = 0,
                Notes = string.Empty,
                Status = EInventoryTransactionStatus.Completed
            };

            _inventoryTransactionService.CreateInventoryTransaction(inventoryTransaction);

            if (transactionType == EInventoryTransactionTypes.In)
            {
                MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (transactionType == EInventoryTransactionTypes.Out)
            {
                MessageBox.Show("Xuất hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            GetInventoryTransactionTypes(null);
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

        private bool IsValidLocation(List<Location> locations)
        {
            _ = int.TryParse(cboLocation.SelectedValue?.ToString(), out var locationId);

            return locations.Count > 0 && locationId > 0;
        }

        private bool TryParseInventoryTransactionType(out int inventoryTransactionTypeId)
        {
            return int.TryParse(cboInventoryTransactionType.SelectedValue?.ToString(), out inventoryTransactionTypeId);
        }

        private void GetLocationSelector(List<SelectorDto> items)
        {
            cboLocation.DataSource = null;

            cboLocation.DataSource = items;
            cboLocation.DisplayMember = "Value";
            cboLocation.ValueMember = "Key";
            cboLocation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboLocation.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void GetInventoryTransactionTypeSelector()
        {
            cboInventoryTransactionType.DataSource = null;

            var data = _inventoryTransactionTypeService.GetOptions();

            cboInventoryTransactionType.DataSource = data;
            cboInventoryTransactionType.DisplayMember = "Value";
            cboInventoryTransactionType.ValueMember = "Key";
            cboInventoryTransactionType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboInventoryTransactionType.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void GetStrategySelector()
        {
            var data = new List<SelectorDto>
            {
                new SelectorDto { Key = 1, Value = "First in Last out" },
            };
            cboStrategy.DataSource = data;
            cboStrategy.DisplayMember = "Value";
            cboStrategy.ValueMember = "Key";
            cboStrategy.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboStrategy.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void GetZones()
        {
            flpZones.Controls.Clear();

            var zones = _zoneService.GetZones();

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

        private List<SelectorDto> GetAvailableLocations(int? productId, int quantity, EInventoryTransactionTypes transactionType)
        {
            var locations = _locationService.GetAvailableLocations(productId, quantity, transactionType);
            return locations.Select(location => new SelectorDto
            {
                Key = location.LocationId,
                Value = $"VT:{location.Position}, H{location.Row}, C{location.Col} ({location.Inventories.Sum(i => i.Quantity)}/{location.Capacity})",
                AdditionalValue = transactionType == EInventoryTransactionTypes.In
                    ? location.Capacity - location.Inventories.Sum(i => i.Quantity)
                    : location.Inventories.Sum(i => i.Quantity)
            }).ToList();
        }

        private void ChangeSku()
        {
            bool isSkuValid = !string.IsNullOrEmpty(tbSku.Text);
            if (isSkuValid)
            {
                var product = _productService.GetProductBySku(tbSku.Text);
                TryParseInventoryTransactionType(out int inventoryTransactionTypeId);

                var transactionType = (EInventoryTransactionTypes)inventoryTransactionTypeId;

                var locationDtos = GetAvailableLocations(product?.ProductId, (int)numQuanlity.Value, transactionType);

                GetLocationSelector(locationDtos);
            }
        }

        #region Function xử lý cho group Danh sách vị trí
        public void LoadLocations(List<Location> locations)
        {
            flpLocations.Controls.Clear();
            var rootLocations = locations.Where(location => location.ParentLocationId == null).ToList();

            foreach (var rootLocation in rootLocations)
            {
                var childLocations = rootLocation.InverseParentLocation;

                var locationPanel = CreateLocationPanel(rootLocation.LocationName);
                var tableLayoutPanel = CreateTableLayoutPanel();
                locationPanel.Controls.Add(tableLayoutPanel);

                AddHeaderRow(tableLayoutPanel, rootLocation.LocationName, childLocations.Count);
                AddLocationRows(tableLayoutPanel, childLocations, locations);

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
            List<Location> allLocations)
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
                Size = new Size(90, 20),
                AutoSize = true,
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
                Size = new Size(90, 20),
                BorderRadius = 5,
                Text = locationCode,
                AutoSize = true,
                BackColor = Color.FromArgb(159, 96, 96),
                Margin = new Padding(0)
            };
        }
        #endregion
        #endregion
    }

}
