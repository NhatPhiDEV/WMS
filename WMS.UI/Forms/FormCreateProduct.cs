using MediatR;
using WMS.Application.Common;
using WMS.Application.Features.ProductCategories.Queries.GetMultiple;
using WMS.Application.Features.Products.Commands.Create;
using WMS.UI.Common.Extensions;

namespace WMS.UI.Forms
{
    public partial class FormCreateProduct : Form
    {
        private readonly IMediator _mediator;

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
                dashboard.SendDataToDialog += ReceiveDataFromDashboard;
            }
        }

        private void ReceiveDataFromDashboard(string sku)
        {
            tbSku.Text = sku;
        }

        private async void Form_CreateProduct_Load(object sender, EventArgs e)
        {
            await LoadProductCategories();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            var (isValid, errorMessage) = ValidateProduct();

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int.TryParse(cbProductCategory.SelectedValue?.ToString(), out var productCategoryId);

            var command = new CreateProductCommand(tbSku.Text, tbProductName.Text, productCategoryId);
            await _mediator.Send(command);

            MessageBox.Show($"Tạo thành công sản phẩm {tbSku.Text}.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Hide();
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

        private (bool Success, string ErrorMessage) ValidateProduct()
        {
            if (!IsValidSku())
            {
                return (false, "Mã hàng không được để trống!");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool IsValidInventoryTransactionType()
        {
            return TryParseProductCategory(out _);
        }

        private bool TryParseProductCategory(out int productCategoryId)
        {
            return int.TryParse(cbProductCategory.SelectedValue?.ToString(), out productCategoryId);
        }

    }
}
