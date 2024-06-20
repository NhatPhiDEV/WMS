using System.Threading;

namespace WMS.UI.Forms;

public partial class FormProcessDialog : Form
{
    public delegate void CancelProcessEventHandler(object sender, EventArgs e);
    public event CancelProcessEventHandler? CancelProcess;
    private readonly CancellationTokenSource _cancellationTokenSource;

    public string ProcessName
    {
        get => LbProcessName.Text;
        set => LbProcessName.Text = value;
    }

    public FormProcessDialog(CancellationTokenSource cancellationTokenSource)
    {
        _cancellationTokenSource = cancellationTokenSource;
        InitializeComponent();
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        CancelProcess?.Invoke(this, EventArgs.Empty);
        _cancellationTokenSource.Cancel();
        this.Close();
    }
}