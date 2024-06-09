using WMS.BusinessLogic.Services.ProductCategories;
using WMS.Domain.Models;
using WMS.BusinessLogic.Services.Products;

namespace WMS.UI.Forms
{
    public partial class Form_CreateProduct : Form
    {
        private readonly IProductCategoryService _productCategoryService;
        private readonly IProductService _productService;

        public Form_CreateProduct(IProductCategoryService productCategoryService, IProductService productService)
        {
            InitializeComponent();
            _productCategoryService = productCategoryService;
            _productService = productService;
        }

        public void SetOwner(Form owner)
        {
            this.Owner = owner;

            if (this.Owner is Form_Dashboard dashboard)
            {
                dashboard.SendDataToDialog += ReceiveDataFromDashboard;
            }
        }

        private void ReceiveDataFromDashboard(string sku)
        {
            tbSku.Text = sku;
        }

        private void Form_CreateProduct_Load(object sender, EventArgs e)
        {
            LoadcbProductCategory();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var (IsValid, ErrorMessage) = ValidateProduct();

            if (!IsValid)
            {
                MessageBox.Show(ErrorMessage, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int.TryParse(cbProductCategory.SelectedValue?.ToString(), out int productCategoryId);
            
            var product = new Product
            {
                Sku = tbSku.Text,
                ProductName = tbProductName.Text,
                ImagePath = "",
                IsActive = true,
                ProductCategoryId = productCategoryId
            };

            _productService.CreateProduct(product);

            MessageBox.Show($"Tạo thành công sản phẩm {tbSku.Text}.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
        }

        // Load Controls
        private void LoadcbProductCategory()
        {
            cbProductCategory.DataSource = null;

            var data = _productCategoryService.GetOptions();

            cbProductCategory.DataSource = data;
            cbProductCategory.DisplayMember = "Value";
            cbProductCategory.ValueMember = "Key";
            cbProductCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbProductCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
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
