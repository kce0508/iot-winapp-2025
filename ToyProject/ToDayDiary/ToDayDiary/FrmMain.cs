using static System.Runtime.InteropServices.JavaScript.JSType;

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
            DateTime selectedDate = CalSchedule.SelectionStart;

            // Ķ�������� ��¥ ���� ��, �ؽ�Ʈ �ڽ��� ��/��/�� �Է�
            TxtYear.Text = selectedDate.Year.ToString();
            TxtMonth.Text = selectedDate.Month.ToString();
            TxtDay.Text = selectedDate.Day.ToString();

            // ���õ� ��¥ �������� �ϱ� ���� �ڵ� �Է�
            InsertDiaryHeader(selectedDate);

            // �ϱ� ���� ��� ����
            string fileName = $"{selectedDate:yyyy-MM-dd}.txt"; // ex: 2025-04-30.txt
            string dirPath = Path.Combine(Application.StartupPath, "Diaries");
            string fullPath = Path.Combine(dirPath, fileName);

            if (File.Exists(fullPath))
            {
                RtbNote.Text = File.ReadAllText(fullPath); // ������ �����ϸ� �ϱ� ���� �ҷ�����
            }
            else
            {
                RtbNote.Text = $"[{selectedDate:yyyy�� MM�� dd��} �ϱ�]" + Environment.NewLine + Environment.NewLine; // ���� ������ ���ø��� �߰�
            }
        }

        private void DtpBirth_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(DtpBirth.Value.ToString(), "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // ���� ��¥�� Ķ���� ����
            DateTime today = DateTime.Today;
            CalSchedule.SetDate(today);

            // �ؽ�Ʈ�ڽ��� ���� ��¥ �Է�
            TxtYear.Text = today.Year.ToString();
            TxtMonth.Text = today.Month.ToString();
            TxtDay.Text = today.Day.ToString();

            // ���� ��¥ �������� �ϱ� ���� �ڵ� �Է�
            InsertDiaryHeader(today);
        }

        private void InsertDiaryHeader(DateTime today)
        {
            DateTime selectedDate = CalSchedule.SelectionStart;
            string header = $"[{selectedDate:yyyy�� MM�� dd��} �ϱ�]";

            // �̹� ���� ������ ���� ��쿡�� �Է�
            if (!RtbNote.Text.StartsWith(header))
            {
                RtbNote.Text = header + Environment.NewLine + Environment.NewLine;
            }
        }

        private void BtnOpenImage_Click(object sender, EventArgs e)
        {
            DlgOpenImage.Title = "�̹��� ����";
            DlgOpenImage.FileName = "";
            DlgOpenImage.Filter = "Image Files(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";

            if (DlgOpenImage.ShowDialog() == DialogResult.OK)
            {
                PicImage.Image = Bitmap.FromFile(DlgOpenImage.FileName);
                PicImage.SizeMode = PictureBoxSizeMode.Zoom;            // PictureBoxSizeMode.Zoom �̹��� ������� �� �� �ִ� ���
                //PictureBoxSizeMode.StretchImage �̹����� ����, ���̸� ��ó�ڽ�ũ�⿡ ���缭 �̹����� �ϱ׷���
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DlgSave.FileName = string.Empty;
            DlgSave.Filter = "RTF���� (*.rtf)|*.rtf|Txt���� (*.txt)|*.txt";
            DlgSave.Title = "�������� ����";

            if (DlgSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fullPath = DlgSave.FileName;
                    string ext = Path.GetExtension(fullPath);  // .rtf, .txt 

                    if (ext == ".rtf")
                        RtbNote.SaveFile(fullPath, RichTextBoxStreamType.RichText);
                    else if (ext == ".txt")
                        RtbNote.SaveFile(fullPath, RichTextBoxStreamType.PlainText);

                    MessageBox.Show("������ ����Ǿ����ϴ�.", "��������",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"���� ���� : {ex.Message}", "��������",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            DlgOpen.FileName = string.Empty; // == "";
            DlgOpen.Filter = "RTF���� (*.rtf)|*.rtf|Txt���� (*.txt)|*.txt";
            DlgOpen.Title = "�������� �б�";

            // ���̾�α�â ����
            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fullPath = DlgOpen.FileName;
                    string ext = Path.GetExtension(fullPath);  // .rtf, .txt 

                    if (ext == ".rtf")
                        RtbNote.LoadFile(fullPath, RichTextBoxStreamType.RichText);
                    else if (ext == ".txt")
                        RtbNote.LoadFile(fullPath, RichTextBoxStreamType.PlainText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"�б� ���� : {ex.Message}", "�����б�",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
