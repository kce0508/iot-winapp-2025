﻿namespace SysntaxWinApp1
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
            textBox7 = new TextBox();
            TxtPhone = new TextBox();
            label4 = new Label();
            TxtGender = new TextBox();
            label3 = new Label();
            TxtAge = new TextBox();
            label2 = new Label();
            TxtName = new TextBox();
            label1 = new Label();
            BtnCheck = new Button();
            label6 = new Label();
            TxtResult = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(TxtPhone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtGender);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtAge);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 287);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "사람 정보 입력";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(318, 58);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(129, 23);
            textBox7.TabIndex = 2;
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(64, 113);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(129, 23);
            TxtPhone.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 116);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 2;
            label4.Text = "핸드폰 : ";
            // 
            // TxtGender
            // 
            TxtGender.Location = new Point(64, 84);
            TxtGender.Name = "TxtGender";
            TxtGender.Size = new Size(129, 23);
            TxtGender.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 87);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "성별 : ";
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(64, 55);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(129, 23);
            TxtAge.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 58);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "나이 : ";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(64, 26);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(129, 23);
            TxtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 29);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "이름 : ";
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(472, 259);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(100, 40);
            BtnCheck.TabIndex = 6;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 27);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 0;
            label6.Text = "이름 : ";
            // 
            // TxtResult
            // 
            TxtResult.BorderStyle = BorderStyle.FixedSingle;
            TxtResult.Location = new Point(330, 45);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(242, 208);
            TxtResult.TabIndex = 5;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(TxtResult);
            Controls.Add(BtnCheck);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "문법학습 윈앱1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtPhone;
        private Label label4;
        private TextBox TxtGender;
        private Label label3;
        private TextBox TxtAge;
        private Label label2;
        private TextBox TxtName;
        private Label label1;
        private Button BtnCheck;
        private TextBox textBox7;
        private Label label6;
        private TextBox TxtResult;
    }
}
