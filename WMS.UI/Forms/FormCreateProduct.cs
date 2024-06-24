using MediatR;
using WMS.Application.Common;
using WMS.Application.Features.ProductCategories.Queries.GetMultiple;
using WMS.Application.Features.Products.Commands.Create;
using WMS.Application.Features.Products.Commands.Update;
using WMS.Application.Features.Products.Queries.GetBySku;
using WMS.Domain.Models;
using WMS.Domain.Utils;
using WMS.UI.Common.Extensions;

namespace WMS.UI.Forms
{
    public partial class FormCreateProduct : Form
    {
        private readonly IMediator _mediator;

        public delegate void ProductModifiedEventHandler(object sender, EventArgs e);
        public event ProductModifiedEventHandler? ProductModified;
        private bool _actionUpdate;
        private Product? _productTemp;

        public FormCreateProduct(
            IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
        }

        public void SetOwner(Form owner)
        {
            this.Owner = owner;

            if (this.Owner is FormDashboard dashboard)
            {
                dashboard.AddProductEvent += EventFormDashboard;
            }

            if (this.Owner is FormProductManagement productManagement)
            {
                productManagement.AddOrUpdateProductEvent += EventFormProductManagement;
            }
        }

        private async void EventFormProductManagement(Product? product)
        {
            await Init();
            if (product == null) return;
            tbSku.Text = product.Sku;
            tbProductName.Text = product.ProductName;
            NumExpirationDate.Value = product.ExpirationDate;
            cbProductCategory.SelectedValue = product.ProductCategoryId;
            _actionUpdate = true;
            _productTemp = product;
        }

        private async void EventFormDashboard(string sku)
        {
            await Init();
            tbSku.Text = sku;
        }

        private async Task Init()
        {
            tbSku.Text = null;
            tbProductName.Text = null;
            NumExpirationDate.Value = 1;
            cbProductCategory.DataSource = null;
            _actionUpdate = false;

            await LoadProductCategories();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            var (isValid, errorMessage) = await ValidateProduct();

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int.TryParse(cbProductCategory.SelectedValue?.ToString(), out var productCategoryId);
            if (_actionUpdate == true && _productTemp != null)
            {
                _productTemp.Sku = tbSku.Text.Trim();
                _productTemp.ProductName = tbProductName.Text;
                _productTemp.ExpirationDate = (int)NumExpirationDate.Value;
                _productTemp.ProductCategoryId = productCategoryId;
                _productTemp.UpdatedAt = TimeHelper.GetCurrentTime();
                var updateCommand = new UpdateProductCommand(_productTemp);
                await _mediator.Send(updateCommand);

                MessageBox.Show($@"Cập nhật thành công sản phẩm {_productTemp.Sku}.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ProductModified?.Invoke(this, EventArgs.Empty);

                Hide();

                return;
            }

            var command = new CreateProductCommand(
                tbSku.Text,
                tbProductName.Text,
                productCategoryId,
                (int)NumExpirationDate.Value);

            await _mediator.Send(command);

            MessageBox.Show($@"Tạo thành công sản phẩm {tbSku.Text}.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ProductModified?.Invoke(this, EventArgs.Empty);

            Close();
        }

        private async Task LoadProductCategories()
        {
            var query = new GetMultipleProductCategoriesQuery();
            var result = await _mediator.Send(query);

            cbProductCategory.SetDataSourceWithMembers(
                result,
                nameof(ComboBoxItem.Key),
                nameof(ComboBoxItem.Val));
        }

        private async Task<(bool Success, string ErrorMessage)> ValidateProduct()
        {
            if (!IsValidSku())
            {
                return (false, "Mã hàng không được để trống!");
            }

            if (!await IsExistsSku())
            {
                return (false, "Mã hàng đã tồn tại trong hệ thống!");
            }

            if (!IsValidInventoryTransactionType())
            {
                return (false, "Loại sản phẩm không được để trống!");
            }

            return (true, "");
        }

        private bool IsValidSku()
        {
            return !string.IsNullOrEmpty(tbSku.Text.Trim());
        }

        private async Task<bool> IsExistsSku()
        {
            var query = new GetProductIdBySkuQuery(tbSku.Text.Trim());
            var product = await _mediator.Send(query);
            return _actionUpdate == false
                ? product == null
                : _productTemp!.Sku == tbSku.Text.Trim() || product == null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private bool IsValidInventoryTransactionType()
        {
            return TryParseProductCategory(out _);
        }

        private bool TryParseProductCategory(out int productCategoryId)
        {
            return int.TryParse(cbProductCategory.SelectedValue?.ToString(), out productCategoryId);
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"Image Files (*.png;*.jpg)|*.png;*.jpg";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var filePath = openFileDialog.FileName;

            // Hiển thị ảnh lên PictureBox
            pbProductImage.ImageLocation = filePath;
        }
    }
}
