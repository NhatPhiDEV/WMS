using MediatR;
using WMS.Application.Common;
using WMS.Application.Features.ProductCategories.Queries.GetMultiple;
using WMS.Application.Features.Products.Commands.Delete;
using WMS.Application.Features.Products.Queries.Export;
using WMS.Application.Features.Products.Queries.GetById;
using WMS.Application.Features.Products.Queries.GetProducts;
using WMS.Domain.Models;
using WMS.UI.Common.Extensions;
using WMS.UI.Common.Messages;
using TextMessage = WMS.UI.Common.Messages.TextMessage.FormProductManagement;


namespace WMS.UI.Forms
{
    public partial class FormProductManagement : Form
    {
        private readonly IMediator _mediator;
        public bool IsLoadingData;

        public delegate void AddOrUpdateProductEventHandler(Product? product);
        public event AddOrUpdateProductEventHandler? AddOrUpdateProductEvent;


        public FormProductManagement(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
        }

        private async void FormProductManagement_Load(object sender, EventArgs e)
        {
            await BindProducts();
            BindPageSize();
        }

        private void BindPageSize()
        {
            IsLoadingData = true;

            var datasource = new List<ComboBoxItem>
            {
                new()
                {
                    Key = 10,
                    Val = 10
                },
                new()
                {
                    Key = 50,
                    Val = 50,
                },
                new()
                {
                    Key = 100,
                    Val = 100,
                },
                new()
                {
                    Key = 500,
                    Val = 500,
                }
            };
            CbPageSize.SetDataSourceWithMembers(datasource, nameof(ComboBoxItem.Key), nameof(ComboBoxItem.Val));

            IsLoadingData = false;

        }

        private async Task BindProducts(string searchTerm = "", int page = 1, int pageSize = 10)
        {
            var categoryColumn = GvProducts.Columns["ProductCategory"] as DataGridViewComboBoxColumn;
            var categoryQuery = new GetMultipleProductCategoriesQuery();
            var categories = await _mediator.Send(categoryQuery);
            if (categoryColumn != null)
            {
                categoryColumn.DataSource = categories;
                categoryColumn.ValueMember = "Key";
                categoryColumn.DisplayMember = "Val";
            }

            GvProducts.Rows.Clear();
            var query = new GetProductsQuery(searchTerm, page, pageSize);
            var products = await _mediator.Send(query);
            TbPageSearch.Text = products.Page.ToString();
            BtnNext.Enabled = products.HasNextPage;
            BtnPrev.Enabled = products.HasPreviousPage;

            GvProducts.AutoGenerateColumns = false; // Tắt tự động tạo cột

            // GánDataPropertyName cho từng cột
            GvProducts.Columns[nameof(EGvProducts.ProductSku)]!.DataPropertyName = "Sku";
            GvProducts.Columns[nameof(EGvProducts.ProductName)]!.DataPropertyName = "ProductName";
            GvProducts.Columns[nameof(EGvProducts.ExpirationDate)]!.DataPropertyName = "ExpirationDate";
            GvProducts.Columns[nameof(EGvProducts.ProductCategory)]!.DataPropertyName = "ProductCategoryId";
            GvProducts.Columns[nameof(EGvProducts.IsActive)]!.DataPropertyName = "IsActive";
            GvProducts.Columns[nameof(EGvProducts.ProductId)]!.DataPropertyName = "ProductId";
            GvProducts.Columns[nameof(EGvProducts.ProductImage)]!.DataPropertyName = "ImagePath";

            // Gán DataSource
            GvProducts.DataSource = products.Items;

        }

        private async void CbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsLoadingData)
            {
                await BindProductsWithFilters();
            }
        }

        private async Task BindProductsWithFilters(bool hasPrev = false, bool hasNext = false)
        {
            var search = string.IsNullOrEmpty(TbSearch.Text?.Trim()) ? "" : TbPageSearch.Text;
            var pageSearch = TbPageSearch.Text;
            if (string.IsNullOrEmpty(pageSearch)) return;

            if (CbPageSize.SelectedItem is not ComboBoxItem pageSizeSelected) return;

            var pageSize = (int)pageSizeSelected.Key;
            int.TryParse(pageSearch, out var page);

            if (page < 1) return;

            page = hasPrev ? page - 1 : hasNext ? page + 1 : page;

            await BindProducts(searchTerm: search, page: page, pageSize: pageSize);
        }

        private async void BtnNext_Click(object sender, EventArgs e)
        {
            await BindProductsWithFilters(hasNext: true);
        }

        private async void BtnPrev_Click(object sender, EventArgs e)
        {
            await BindProductsWithFilters(hasPrev: true);
        }

        private async void TbPageSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await BindProductsWithFilters();
            }
        }

        private async void TbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await BindProductsWithFilters();
            }
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            var form = new FormCreateProduct(_mediator);
            form.SetOwner(this);
            AddOrUpdateProductEvent!.Invoke(null);
            form.ProductModified += FormProductModified;
            form.ShowDialog();
        }

        private async void FormProductModified(object sender, EventArgs e)
        {
            await Init();
        }

        private void BtnImportExcel_Click(object sender, EventArgs e)
        {

        }

        private async void BtnExportExcel_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = @"Excel Workbook|*.xlsx",
                Title = @"Lưu file Excel",
                FileName = "Product.xlsx"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            var filePath = saveFileDialog.FileName;
            var gridData = GvProducts.DataSource;
            var command = new ExportProductQuery(filePath, gridData);
            await _mediator.Send(command);

            MessageBox.Show(@"File đã được lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            await Init();
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async Task Init()
        {
            await BindProducts();
            BindPageSize();
            TbSearch.Text = null;
        }

        private async void GvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e is not { RowIndex: >= 0, ColumnIndex: >= 0 }) return;

            switch (GvProducts.Columns[e.ColumnIndex].Name)
            {
                case nameof(EGvProducts.UpdateProduct):
                    await UpdateProductHandle(e);
                    return;
                case nameof(EGvProducts.RemoveProduct):
                    {
                        await RemoveProductHandle(e);
                        return;
                    }
            }
        }

        private async Task UpdateProductHandle(DataGridViewCellEventArgs e)
        {
            if (ValidateDeleteRow(e, out var sku, out var productId)) return;

            var query = new GetProductByIdQuery(productId);
            var product = await _mediator.Send(query);
            if (product is null) return;

            var form = new FormCreateProduct(_mediator);
            form.SetOwner(this);
            AddOrUpdateProductEvent!.Invoke(product);
            form.ProductModified += FormProductModified;
            form.ShowDialog();

        }

        private async Task RemoveProductHandle(DataGridViewCellEventArgs e)
        {
            if (ValidateDeleteRow(e, out var sku, out var productId)) return;

            if (ConfirmDeleteRow(sku)) return;

            await ExecuteDeleteProduct(productId);
        }

        private async Task ExecuteDeleteProduct(int productId)
        {
            var query = new DeleteProductCommand(productId);
            await _mediator.Send(query);

            MessageBox.Show(TextMessage.DeleteSuccessfully,
                CaptionMessage.System.Warning,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            await Init();
        }

        private static bool ConfirmDeleteRow(string? sku)
        {
            var dialogResult = MessageBox.Show(
                TextMessage.Product.ConfirmDeleteAction(sku),
                CaptionMessage.System.Warning,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            return dialogResult != DialogResult.OK;
        }

        private bool ValidateDeleteRow(DataGridViewCellEventArgs e, out string? sku, out int productId)
        {
            var row = GvProducts.Rows[e.RowIndex];
            var cellProductIdValue = row.Cells[nameof(EGvProducts.ProductId)]?.Value?.ToString();
            sku = row.Cells[nameof(EGvProducts.ProductSku)]?.Value?.ToString();

            int.TryParse(cellProductIdValue, out productId);

            if (productId != 0 && sku is not null) return false;

            MessageBox.Show(
                TextMessage.Product.InvalidInput,
                CaptionMessage.System.Warning,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            return true;

        }

        private void GvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (GvProducts.Columns[e.ColumnIndex].Name == nameof(EGvProducts.ProductImage))
            {
                var imagePath = e.Value as string;

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    // Tải hình ảnh từ đường dẫn
                    e.Value = Image.FromFile(imagePath);
                }
                else
                {
                    // Hiển thị hình ảnh mặc định nếu không tìm thấy ảnh
                    e.Value = Properties.Resources.no_picture24; // Hoặc một hình ảnh mặc định khác
                }
            }
        }

        private enum EGvProducts
        {
            ProductImage = 0,
            ProductSku = 1,
            ProductName = 2,
            ExpirationDate = 3,
            ProductCategory = 4,
            IsActive = 5,
            ProductId = 6, // Hide
            UpdateProduct = 7,
            RemoveProduct = 8,

        }
    }
}

