using MaterialSkin;
using MaterialSkin.Controls;
using MediatR;
using WMS.Domain.Enums;
using static WMS.UI.Common.Messages.TextMessage;

namespace WMS.UI.Forms
{
    public partial class FormMain : MaterialForm
    {
        private readonly IMediator _mediator;

        public enum TabName
        {
            TabDashboard,
            TabLocationManagement,
            TabProductManagement
        }

        public FormMain(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
            InitMaterialSkin();
            LoadFormDashboard();
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
                case nameof(TabName.TabDashboard):
                    LoadFormDashboard();
                    break;
                case nameof(TabName.TabLocationManagement):
                    LoadFormLocationManagement();
                    break;
                case nameof(TabName.TabProductManagement):
                    LoadFormProductManagement();
                    break;
            }
        }

        private void LoadFormLocationManagement()
        {
            var form = new FormLocationManagement(_mediator);
            LoadTab(TabLocationManagement, ref form);
        }

        private void LoadFormDashboard()
        {
            var form = new FormDashboard(_mediator);
            LoadTab(TabDashboard, ref form);
        }

        private void LoadFormProductManagement()
        {
            var form = new FormProductManagement(_mediator);
            LoadTab(TabProductManagement, ref form);
        }

        private static void LoadTab<T>(TabPage tabPage, ref T form) where T : Form
        {
            if (tabPage.Controls.Count > 0)
            {
                tabPage.Controls.Clear();
            }

            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.Width = tabPage.Width;
            form.Height = tabPage.Height;

            form.BringToFront();
            tabPage.Controls.Add(form);
            form.Show();
        }
    }
}
