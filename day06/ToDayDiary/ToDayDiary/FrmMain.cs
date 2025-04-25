namespace ToDayDiary
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void CalSchedule_DateChanged(object sender, DateRangeEventArgs e)
        {
            TxtYear.Text = CalSchedule.SelectionStart.Year.ToString();
            TxtMonth.Text = CalSchedule.SelectionStart.Month.ToString();
            TxtDay.Text = CalSchedule.SelectionStart.Day.ToString();
        }

        private void DtpBirth_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(DtpBirth.Value.ToString(), "积老", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DtpBirth.Value.ToString(), "积老", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
