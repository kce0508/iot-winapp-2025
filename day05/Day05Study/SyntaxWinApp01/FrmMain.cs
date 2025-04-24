namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        // �븮��(delegate) ����
        delegate void MyDelegate(string msg);

        // �븮�ڿ��� ȣ���� �޼��� - �븮�ڿ� �Ķ���Ͱ� ��ġ
        void SayHello(string msg)
        { 
            MessageBox.Show($"�ȳ�, { msg}" , "�޽���",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // ����ȣ��
            SayHello("Hugo");

            // �븮�� ȣ��
            MyDelegate del = SayHello;  // �븮�ڿ� ȣ���� �޼��带 ������
            del("Ashely");
        }
    }
}
