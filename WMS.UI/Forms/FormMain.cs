using MediatR;

namespace WMS.UI.Forms
{
    public partial class FormMain : Form
    {
        private readonly IMediator _mediator;

        public FormMain(
            IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            OpenChildForm(new FormDashboard(_mediator));
        }

        private void MenuDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDashboard(_mediator));
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
