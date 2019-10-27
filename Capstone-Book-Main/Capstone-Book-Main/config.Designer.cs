namespace Capstone_Book_Main
{
    partial class Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResetButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GeneralPage = new System.Windows.Forms.TabPage();
            this.OutputPage = new System.Windows.Forms.TabPage();
            this.CancelButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(264, 409);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(89, 33);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "초기화";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(454, 409);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(89, 33);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "확인";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GeneralPage);
            this.tabControl1.Controls.Add(this.OutputPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 400);
            this.tabControl1.TabIndex = 2;
            // 
            // GeneralPage
            // 
            this.GeneralPage.Location = new System.Drawing.Point(4, 22);
            this.GeneralPage.Name = "GeneralPage";
            this.GeneralPage.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralPage.Size = new System.Drawing.Size(542, 374);
            this.GeneralPage.TabIndex = 0;
            this.GeneralPage.Text = "일반설정";
            this.GeneralPage.UseVisualStyleBackColor = true;
            // 
            // OutputPage
            // 
            this.OutputPage.Location = new System.Drawing.Point(4, 22);
            this.OutputPage.Name = "OutputPage";
            this.OutputPage.Padding = new System.Windows.Forms.Padding(3);
            this.OutputPage.Size = new System.Drawing.Size(542, 374);
            this.OutputPage.TabIndex = 1;
            this.OutputPage.Text = "내보내기 설정";
            this.OutputPage.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(359, 409);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(89, 33);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "취소";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.Text = "환경설정";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GeneralPage;
        private System.Windows.Forms.TabPage OutputPage;
        private System.Windows.Forms.Button CancelButton;
    }
}