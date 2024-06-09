using WMS.BusinessLogic.Services.Inventories;
using WMS.BusinessLogic.Services.InventoryTransactions;
using WMS.BusinessLogic.Services.InventoryTransactionTypes;
using WMS.BusinessLogic.Services.Locations;
using WMS.BusinessLogic.Services.ProductCategories;
using WMS.BusinessLogic.Services.Products;
using WMS.BusinessLogic.Services.Zones;

namespace WMS.UI.Forms
{
    public partial class Form_Main : Form
    {
        private readonly IProductCategoryService _productCategoryService;
        private readonly IProductService _productService;
        private readonly IZoneService _zoneService;
        private readonly ILocationService _locationService;
        private readonly IInventoryTransactionTypeService _inventoryTransactionTypeService;
        private readonly IInventoryService _inventoryService;
        private readonly IInventoryTransactionService _inventoryTransactionService;

        public Form_Main(
            IProductCategoryService productCategoryService,
            IProductService productService,
            IZoneService zoneService,
            ILocationService locationService,
            IInventoryTransactionTypeService inventoryTransactionTypeService,
            IInventoryService inventoryService,
            IInventoryTransactionService inventoryTransactionService)
        {
            _productCategoryService = productCategoryService;
            _productService = productService;
            _zoneService = zoneService;
            _locationService = locationService;
            _inventoryTransactionTypeService = inventoryTransactionTypeService;
            _inventoryService = inventoryService;
            _inventoryTransactionService = inventoryTransactionService;
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            OpenChildForm(new Form_Dashboard(
                _zoneService,
                _locationService,
                _inventoryTransactionTypeService,
                _productService,
                _inventoryService,
                _inventoryTransactionService,
                _productCategoryService));
        }

        private void MenuDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Dashboard(
                _zoneService,
                _locationService,
                _inventoryTransactionTypeService,
                _productService,
                _inventoryService,
                _inventoryTransactionService,
                _productCategoryService));
        }

        private void OpenChildForm(Form childForm)
        {
            if (panelBody.Controls.Count > 0)
            {
                panelBody.Controls.Clear();
            }

            childForm.TopLevel = false; 
            childForm.FormBorderStyle = FormBorderStyle.None; 
            childForm.Dock = DockStyle.Fill; 

            childForm.Width = panelBody.Width;
            childForm.Height = panelBody.Height;
            childForm.BringToFront();

            panelBody.Controls.Add(childForm); 
            childForm.Show();
        }
    }
}
