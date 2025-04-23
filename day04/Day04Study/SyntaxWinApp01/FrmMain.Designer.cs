namespace SyntaxWinApp01
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
            BtnCheck = new Button();
            TxtName = new TextBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            TxtResult = new TextBox();
            TxtGender = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            NudAge = new NumericUpDown();
            TxtPhone = new MaskedTextBox();
            label1 = new Label();
            PicResult = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicResult).BeginInit();
            SuspendLayout();
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(501, 280);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(100, 30);
            BtnCheck.TabIndex = 6;
            BtnCheck.Text = "체크";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(78, 38);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(140, 23);
            TxtName.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TxtResult);
            groupBox1.Controls.Add(TxtGender);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(NudAge);
            groupBox1.Controls.Add(TxtPhone);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 298);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "정보입력/결과";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 165);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 10;
            label5.Text = "결과 : ";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(6, 183);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(325, 109);
            TxtResult.TabIndex = 5;
            // 
            // TxtGender
            // 
            TxtGender.Location = new Point(78, 98);
            TxtGender.MaxLength = 1;
            TxtGender.Name = "TxtGender";
            TxtGender.Size = new Size(140, 23);
            TxtGender.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 131);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "폰번호 : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 101);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "성별 : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 70);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "나이 :";
            // 
            // NudAge
            // 
            NudAge.Location = new Point(78, 68);
            NudAge.Name = "NudAge";
            NudAge.Size = new Size(140, 23);
            NudAge.TabIndex = 2;
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(78, 128);
            TxtPhone.Mask = "000-0000-0000";
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(140, 23);
            TxtPhone.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 41);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "이름 : ";
            // 
            // PicResult
            // 
            PicResult.BackColor = SystemColors.ControlLightLight;
            PicResult.Location = new Point(355, 12);
            PicResult.Name = "PicResult";
            PicResult.Size = new Size(250, 250);
            PicResult.SizeMode = PictureBoxSizeMode.StretchImage;
            PicResult.TabIndex = 3;
            PicResult.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 322);
            Controls.Add(PicResult);
            Controls.Add(groupBox1);
            Controls.Add(BtnCheck);
            Name = "FrmMain";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCheck;
        private TextBox TxtName;
        private GroupBox groupBox1;
        private TextBox TxtGender;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown NudAge;
        private MaskedTextBox TxtPhone;
        private Label label1;
        private PictureBox PicResult;
        private TextBox TxtResult;
        private Label label5;
    }
}
