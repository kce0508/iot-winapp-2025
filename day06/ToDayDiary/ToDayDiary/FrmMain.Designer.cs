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
            groupBox1 = new GroupBox();
            TxtDay = new TextBox();
            TxtMonth = new TextBox();
            TxtYear = new TextBox();
            BtnCheck = new Button();
            DtpBirth = new DateTimePicker();
            label1 = new Label();
            CalSchedule = new MonthCalendar();
            groupBox2 = new GroupBox();
            BtnOpenImage = new Button();
            pictureBox1 = new PictureBox();
            BtnSave = new Button();
            textBox1 = new TextBox();
            DlgOpenImage = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            groupBox1.Size = new Size(330, 477);
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
            BtnCheck.Location = new Point(234, 215);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(90, 25);
            BtnCheck.TabIndex = 3;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // DtpBirth
            // 
            DtpBirth.Location = new Point(12, 215);
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
            groupBox2.Controls.Add(BtnOpenImage);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(BtnSave);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(348, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 477);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "일기장";
            // 
            // BtnOpenImage
            // 
            BtnOpenImage.Location = new Point(224, 218);
            BtnOpenImage.Name = "BtnOpenImage";
            BtnOpenImage.Size = new Size(100, 25);
            BtnOpenImage.TabIndex = 3;
            BtnOpenImage.Text = "이미지열기";
            BtnOpenImage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(318, 190);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(224, 446);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(100, 25);
            BtnSave.TabIndex = 1;
            BtnSave.Text = "저장";
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 249);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(318, 190);
            textBox1.TabIndex = 0;
            // 
            // DlgOpenImage
            // 
            DlgOpenImage.FileName = "openFileDialog1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 494);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmMain";
            Text = "Diary";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox textBox1;
        private TextBox TxtDay;
        private TextBox TxtMonth;
        private TextBox TxtYear;
        private Button BtnOpenImage;
        private PictureBox pictureBox1;
        private OpenFileDialog DlgOpenImage;
    }
}
