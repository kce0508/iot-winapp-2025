namespace SyntaxWinApp02
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
            BtnMsg_Click = new Button();
            SuspendLayout();
            // 
            // BtnMsg_Click
            // 
            BtnMsg_Click.Location = new Point(401, 288);
            BtnMsg_Click.Name = "BtnMsg_Click";
            BtnMsg_Click.Size = new Size(100, 40);
            BtnMsg_Click.TabIndex = 0;
            BtnMsg_Click.Text = "메시지";
            BtnMsg_Click.UseVisualStyleBackColor = true;
            BtnMsg_Click.Click += button1_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 340);
            Controls.Add(BtnMsg_Click);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "문법학습 윈앱 02";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnMsg_Click;
    }
}
