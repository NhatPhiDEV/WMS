namespace WMS.UI.Common.Customize
{
    public partial class CellControl : UserControl
    {
        public CellControl()
        {
            InitializeComponent();
        }

        private string _title;
        public string Title
        {
            get => _title;
            set { _title = value; BtnText.Text = value; }
        }

        public FlowLayoutPanel FlpCell => flpCell;

        // Hàm để thêm control vào flpCell
        public void AddControlToFlpCell(Control control)
        {
            flpCell.Controls.Add(control);
        }
    }
}
