using MaterialSkin;
using MaterialSkin.Controls;
using MediatR;
using WMS.Domain.Enums;

namespace WMS.UI.Forms
{
    public partial class FormMain : MaterialForm
    {
        private readonly IMediator _mediator;
        private FormDashboard? _formDashboard;
        private FormProductManagement? _formProductManagement;

        public FormMain(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
            InitMaterialSkin();
            LoadTabDashboard();
        }

        private void InitMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;


            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue900,
                Primary.Blue900,
                Primary.LightBlue500,
                Accent.Blue700,
                TextShade.WHITE);
        }

        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabControl = (TabControl)sender;
            if (tabControl.SelectedTab == null) return;

            var selectedTabName = tabControl.SelectedTab.Name;
            switch (selectedTabName)
            {
                case nameof(ETabControls.TabDashboard):
                    LoadTabDashboard();
                    break;
                case nameof(ETabControls.TabLocation):
                    LoadTabLocation();
                    break;
            }
        }

        private static void LoadTab<T>(TabPage tabPage, ref T? formToLoad, IMediator mediator) where T : Form
        {
            if (tabPage.Controls.Count > 0)
            {
                tabPage.Controls.Clear();
            }

            formToLoad = (T)Activator.CreateInstance(typeof(T), mediator)!;

            formToLoad.Dock = DockStyle.Fill;
            formToLoad.TopLevel = false;
            formToLoad.FormBorderStyle = FormBorderStyle.None;
            formToLoad.Width = tabPage.Width;
            formToLoad.Height = tabPage.Height;

            formToLoad.BringToFront();
            tabPage.Controls.Add(formToLoad);
            formToLoad.Show();
        }



        private void LoadTabLocation()
        {
            LoadTab(TabLocation, ref _formProductManagement, _mediator);
        }

        private void LoadTabDashboard()
        {
            LoadTab(TabDashboard, ref _formDashboard, _mediator);
        }
    }
}
