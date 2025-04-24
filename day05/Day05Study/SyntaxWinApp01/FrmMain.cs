namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        // 대리자(delegate) 선언
        delegate void MyDelegate(string msg);

        // 대리자에서 호출할 메서드 - 대리자와 파라미터가 일치
        void SayHello(string msg)
        { 
            MessageBox.Show($"안녕, { msg}" , "메시지",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // 직접호출
            SayHello("Hugo");

            // 대리자 호출
            MyDelegate del = SayHello;  // 대리자에 호출할 메서드를 묶어줌
            del("Ashely");
        }
    }
}
