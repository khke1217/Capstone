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
            this.label1 = new System.Windows.Forms.Label();
            this.PwResetButton = new System.Windows.Forms.Button();
            this.PwDelButton = new System.Windows.Forms.Button();
            this.AdultPasswordBox = new System.Windows.Forms.CheckBox();
            this.AdultHideBox = new System.Windows.Forms.CheckBox();
            this.OutputPage = new System.Windows.Forms.TabPage();
            this.OriginDelBox = new System.Windows.Forms.CheckBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.GeneralPage.SuspendLayout();
            this.OutputPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(5, 409);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(74, 33);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "초기화";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(472, 409);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(74, 33);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "확인";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
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
            this.GeneralPage.BackColor = System.Drawing.SystemColors.Control;
            this.GeneralPage.Controls.Add(this.label1);
            this.GeneralPage.Controls.Add(this.PwResetButton);
            this.GeneralPage.Controls.Add(this.PwDelButton);
            this.GeneralPage.Controls.Add(this.AdultPasswordBox);
            this.GeneralPage.Controls.Add(this.AdultHideBox);
            this.GeneralPage.Location = new System.Drawing.Point(4, 22);
            this.GeneralPage.Name = "GeneralPage";
            this.GeneralPage.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralPage.Size = new System.Drawing.Size(542, 374);
            this.GeneralPage.TabIndex = 0;
            this.GeneralPage.Text = "일반설정";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "비밀번호 관리";
            // 
            // PwResetButton
            // 
            this.PwResetButton.Enabled = false;
            this.PwResetButton.Location = new System.Drawing.Point(188, 313);
            this.PwResetButton.Name = "PwResetButton";
            this.PwResetButton.Size = new System.Drawing.Size(60, 23);
            this.PwResetButton.TabIndex = 3;
            this.PwResetButton.Text = "재설정";
            this.PwResetButton.UseVisualStyleBackColor = true;
            this.PwResetButton.Click += new System.EventHandler(this.PwResetButton_Click);
            // 
            // PwDelButton
            // 
            this.PwDelButton.Enabled = false;
            this.PwDelButton.Location = new System.Drawing.Point(122, 313);
            this.PwDelButton.Name = "PwDelButton";
            this.PwDelButton.Size = new System.Drawing.Size(60, 23);
            this.PwDelButton.TabIndex = 2;
            this.PwDelButton.Text = "삭제";
            this.PwDelButton.UseVisualStyleBackColor = true;
            this.PwDelButton.Click += new System.EventHandler(this.PwDelButton_Click);
            // 
            // AdultPasswordBox
            // 
            this.AdultPasswordBox.AutoSize = true;
            this.AdultPasswordBox.Location = new System.Drawing.Point(8, 269);
            this.AdultPasswordBox.Name = "AdultPasswordBox";
            this.AdultPasswordBox.Size = new System.Drawing.Size(248, 16);
            this.AdultPasswordBox.TabIndex = 1;
            this.AdultPasswordBox.Text = "미성년자 관람 불가 도서 비밀번호로 보호";
            this.AdultPasswordBox.UseVisualStyleBackColor = true;
            this.AdultPasswordBox.CheckedChanged += new System.EventHandler(this.AdultPasswordBox_CheckedChanged);
            // 
            // AdultHideBox
            // 
            this.AdultHideBox.AutoSize = true;
            this.AdultHideBox.Enabled = false;
            this.AdultHideBox.Location = new System.Drawing.Point(35, 291);
            this.AdultHideBox.Name = "AdultHideBox";
            this.AdultHideBox.Size = new System.Drawing.Size(196, 16);
            this.AdultHideBox.TabIndex = 0;
            this.AdultHideBox.Text = "미성년자 관람 불가 도서 숨기기";
            this.AdultHideBox.UseVisualStyleBackColor = true;
            this.AdultHideBox.CheckedChanged += new System.EventHandler(this.AdultHideBox_CheckedChanged);
            // 
            // OutputPage
            // 
            this.OutputPage.BackColor = System.Drawing.SystemColors.Control;
            this.OutputPage.Controls.Add(this.OriginDelBox);
            this.OutputPage.Location = new System.Drawing.Point(4, 22);
            this.OutputPage.Name = "OutputPage";
            this.OutputPage.Padding = new System.Windows.Forms.Padding(3);
            this.OutputPage.Size = new System.Drawing.Size(542, 374);
            this.OutputPage.TabIndex = 1;
            this.OutputPage.Text = "내보내기 설정";
            // 
            // OriginDelBox
            // 
            this.OriginDelBox.AutoSize = true;
            this.OriginDelBox.BackColor = System.Drawing.SystemColors.Control;
            this.OriginDelBox.Location = new System.Drawing.Point(18, 18);
            this.OriginDelBox.Name = "OriginDelBox";
            this.OriginDelBox.Size = new System.Drawing.Size(200, 16);
            this.OriginDelBox.TabIndex = 0;
            this.OriginDelBox.Text = "내보내기 완료 후 원본 파일 삭제";
            this.OriginDelBox.UseVisualStyleBackColor = false;
            this.OriginDelBox.CheckedChanged += new System.EventHandler(this.OriginDelBox_CheckedChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(312, 409);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(74, 33);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "취소";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(392, 409);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(74, 33);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "저장";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.Location = new System.Drawing.Point(85, 409);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(74, 33);
            this.UndoButton.TabIndex = 5;
            this.UndoButton.Text = "되돌리기";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.Text = "환경설정";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Config_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.GeneralPage.ResumeLayout(false);
            this.GeneralPage.PerformLayout();
            this.OutputPage.ResumeLayout(false);
            this.OutputPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GeneralPage;
        private System.Windows.Forms.TabPage OutputPage;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox OriginDelBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PwResetButton;
        private System.Windows.Forms.Button PwDelButton;
        private System.Windows.Forms.CheckBox AdultPasswordBox;
        private System.Windows.Forms.CheckBox AdultHideBox;
        private System.Windows.Forms.Button UndoButton;
    }
}