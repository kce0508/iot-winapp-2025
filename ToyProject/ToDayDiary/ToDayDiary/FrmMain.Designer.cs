namespace ToDayDiary
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            groupBox1 = new GroupBox();
            TxtDay = new TextBox();
            TxtMonth = new TextBox();
            TxtYear = new TextBox();
            BtnCheck = new Button();
            DtpBirth = new DateTimePicker();
            label1 = new Label();
            CalSchedule = new MonthCalendar();
            groupBox2 = new GroupBox();
            BtnLoad = new Button();
            RtbNote = new RichTextBox();
            BtnSave = new Button();
            BtnOpenImage = new Button();
            PicImage = new PictureBox();
            DlgOpenImage = new OpenFileDialog();
            PicBox = new GroupBox();
            DlgSave = new SaveFileDialog();
            DlgOpen = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicImage).BeginInit();
            PicBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtDay);
            groupBox1.Controls.Add(TxtMonth);
            groupBox1.Controls.Add(TxtYear);
            groupBox1.Controls.Add(BtnCheck);
            groupBox1.Controls.Add(DtpBirth);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CalSchedule);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 243);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "스케줄";
            // 
            // TxtDay
            // 
            TxtDay.Location = new Point(234, 101);
            TxtDay.Name = "TxtDay";
            TxtDay.Size = new Size(90, 23);
            TxtDay.TabIndex = 4;
            // 
            // TxtMonth
            // 
            TxtMonth.Location = new Point(234, 72);
            TxtMonth.Name = "TxtMonth";
            TxtMonth.Size = new Size(90, 23);
            TxtMonth.TabIndex = 4;
            // 
            // TxtYear
            // 
            TxtYear.Location = new Point(234, 43);
            TxtYear.Name = "TxtYear";
            TxtYear.Size = new Size(90, 23);
            TxtYear.TabIndex = 4;
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(234, 210);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(90, 25);
            BtnCheck.TabIndex = 1;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // DtpBirth
            // 
            DtpBirth.Location = new Point(12, 210);
            DtpBirth.Name = "DtpBirth";
            DtpBirth.Size = new Size(200, 23);
            DtpBirth.TabIndex = 2;
            DtpBirth.ValueChanged += DtpBirth_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "오늘 날짜";
            // 
            // CalSchedule
            // 
            CalSchedule.Location = new Point(12, 43);
            CalSchedule.Name = "CalSchedule";
            CalSchedule.TabIndex = 0;
            CalSchedule.DateChanged += CalSchedule_DateChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnLoad);
            groupBox2.Controls.Add(RtbNote);
            groupBox2.Controls.Add(BtnSave);
            groupBox2.Location = new Point(348, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 486);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "오늘의 일기";
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(224, 455);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(100, 25);
            BtnLoad.TabIndex = 5;
            BtnLoad.Text = "읽기";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // RtbNote
            // 
            RtbNote.Location = new Point(6, 22);
            RtbNote.Name = "RtbNote";
            RtbNote.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            RtbNote.Size = new Size(318, 427);
            RtbNote.TabIndex = 3;
            RtbNote.Text = "";
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(118, 455);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(100, 25);
            BtnSave.TabIndex = 4;
            BtnSave.Text = "저장";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnOpenImage
            // 
            BtnOpenImage.Location = new Point(224, 212);
            BtnOpenImage.Name = "BtnOpenImage";
            BtnOpenImage.Size = new Size(100, 25);
            BtnOpenImage.TabIndex = 2;
            BtnOpenImage.Text = "이미지열기";
            BtnOpenImage.UseVisualStyleBackColor = true;
            BtnOpenImage.Click += BtnOpenImage_Click;
            // 
            // PicImage
            // 
            PicImage.BackColor = SystemColors.GradientInactiveCaption;
            PicImage.Location = new Point(6, 22);
            PicImage.Name = "PicImage";
            PicImage.Size = new Size(318, 184);
            PicImage.TabIndex = 2;
            PicImage.TabStop = false;
            // 
            // DlgOpenImage
            // 
            DlgOpenImage.FileName = "openFileDialog1";
            // 
            // PicBox
            // 
            PicBox.Controls.Add(BtnOpenImage);
            PicBox.Controls.Add(PicImage);
            PicBox.Location = new Point(12, 256);
            PicBox.Name = "PicBox";
            PicBox.Size = new Size(330, 243);
            PicBox.TabIndex = 1;
            PicBox.TabStop = false;
            PicBox.Text = "오늘하루";
            // 
            // DlgOpen
            // 
            DlgOpen.FileName = "openFileDialog1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 505);
            Controls.Add(PicBox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "Diary";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicImage).EndInit();
            PicBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button BtnCheck;
        private DateTimePicker DtpBirth;
        private Label label1;
        private MonthCalendar CalSchedule;
        private Button BtnSave;
        private TextBox TxtDay;
        private TextBox TxtMonth;
        private TextBox TxtYear;
        private Button BtnOpenImage;
        private PictureBox PicImage;
        private OpenFileDialog DlgOpenImage;
        private GroupBox PicBox;
        private RichTextBox RtbNote;
        private SaveFileDialog DlgSave;
        private Button BtnLoad;
        private OpenFileDialog DlgOpen;
    }
}
