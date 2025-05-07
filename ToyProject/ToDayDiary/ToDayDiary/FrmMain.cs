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

            // 캘린더에서 날짜 선택 시, 텍스트 박스에 연/월/일 입력
            TxtYear.Text = selectedDate.Year.ToString();
            TxtMonth.Text = selectedDate.Month.ToString();
            TxtDay.Text = selectedDate.Day.ToString();

            // 선택된 날짜 기준으로 일기 제목 자동 입력
            InsertDiaryHeader(selectedDate);

            // 일기 파일 경로 설정
            string fileName = $"{selectedDate:yyyy-MM-dd}.txt"; // ex: 2025-04-30.txt
            string dirPath = Path.Combine(Application.StartupPath, "Diaries");
            string fullPath = Path.Combine(dirPath, fileName);

            if (File.Exists(fullPath))
            {
                RtbNote.Text = File.ReadAllText(fullPath); // 파일이 존재하면 일기 내용 불러오기
            }
            else
            {
                RtbNote.Text = $"[{selectedDate:yyyy년 MM월 dd일} 일기]" + Environment.NewLine + Environment.NewLine; // 파일 없으면 템플릿만 추가
            }
        }

        private void DtpBirth_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(DtpBirth.Value.ToString(), "생일", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // 오늘 날짜로 캘린더 설정
            DateTime today = DateTime.Today;
            CalSchedule.SetDate(today);

            // 텍스트박스에 오늘 날짜 입력
            TxtYear.Text = today.Year.ToString();
            TxtMonth.Text = today.Month.ToString();
            TxtDay.Text = today.Day.ToString();

            // 오늘 날짜 기준으로 일기 제목 자동 입력
            InsertDiaryHeader(today);
        }

        private void InsertDiaryHeader(DateTime today)
        {
            DateTime selectedDate = CalSchedule.SelectionStart;
            string header = $"[{selectedDate:yyyy년 MM월 dd일} 일기]";

            // 이미 같은 제목이 없을 경우에만 입력
            if (!RtbNote.Text.StartsWith(header))
            {
                RtbNote.Text = header + Environment.NewLine + Environment.NewLine;
            }
        }

        private void BtnOpenImage_Click(object sender, EventArgs e)
        {
            DlgOpenImage.Title = "이미지 열기";
            DlgOpenImage.FileName = "";
            DlgOpenImage.Filter = "Image Files(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";

            if (DlgOpenImage.ShowDialog() == DialogResult.OK)
            {
                PicImage.Image = Bitmap.FromFile(DlgOpenImage.FileName);
                PicImage.SizeMode = PictureBoxSizeMode.Zoom;            // PictureBoxSizeMode.Zoom 이미지 원본대로 볼 수 있는 모드
                //PictureBoxSizeMode.StretchImage 이미지가 넓이, 높이를 픽처박스크기에 맞춰서 이미지가 일그러짐
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DlgSave.FileName = string.Empty;
            DlgSave.Filter = "RTF파일 (*.rtf)|*.rtf|Txt파일 (*.txt)|*.txt";
            DlgSave.Title = "문서파일 저장";

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

                    MessageBox.Show("파일이 저장되었습니다.", "파일저장",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"저장 실패 : {ex.Message}", "파일저장",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            DlgOpen.FileName = string.Empty; // == "";
            DlgOpen.Filter = "RTF파일 (*.rtf)|*.rtf|Txt파일 (*.txt)|*.txt";
            DlgOpen.Title = "문서파일 읽기";

            // 다이얼로그창 열기
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
                    MessageBox.Show($"읽기 실패 : {ex.Message}", "파일읽기",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
