namespace SysntaxWinApp04
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtAge.Text == "")
            {
                MessageBox.Show("���� ä���ּ���.");
                return; // �޼��� Ż��
            }
            else
            {
                // ���� ������ ���� �� ����...
                LblResult.Text = "ó����� : ";
                TxtResult.Text = "�հ� ó���ɰ���";
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
