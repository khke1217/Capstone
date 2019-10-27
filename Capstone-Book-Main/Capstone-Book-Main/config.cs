using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Capstone_Book_Main
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();

            Load_config();
        }

        string TempPW;
        bool ProtectByPW = false;
        bool HideByPW = false;
        bool OriginDel = false;

        private void Load_config()
        {
            AdultPasswordBox.Checked = Properties.UserConfig.Default.ProtectByPW;
            if (Properties.UserConfig.Default.ProtectByPW)
            {
                PwDelButton.Enabled = !PwDelButton.Enabled;
                PwResetButton.Enabled = !PwResetButton.Enabled;
                AdultHideBox.Enabled = !AdultHideBox.Enabled;
            }
            AdultHideBox.Checked = Properties.UserConfig.Default.HideByPW;
            TempPW = Properties.UserConfig.Default.Password;
        }


        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("모든 설정이 기본값으로 초기화됩니다. 괜찮으시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Load_config();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ConfigSave();
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ConfigSave();
        }

        private void AdultPasswordBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TempPW == "")
            {
                while (true)
                {
                    string password1 = Microsoft.VisualBasic.Interaction.InputBox("비밀번호를 입력하세요", "비밀번호 설정", "");
                    string password2 = Microsoft.VisualBasic.Interaction.InputBox("비밀번호를 한번 더 입력하세요", "비밀번호 설정", "");

                    if (password1 != password2)
                        MessageBox.Show("비밀번호가 일치하지 않습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if(password1 == "")
                    {
                        AdultPasswordBox.Checked = !AdultPasswordBox.Checked;
                        break;
                    }
                    else
                    {
                        ProtectByPW = true;
                        PwDelButton.Enabled = !PwDelButton.Enabled;
                        PwResetButton.Enabled = !PwResetButton.Enabled;
                        AdultHideBox.Enabled = !AdultHideBox.Enabled;
                        TempPW = password1;
                        break;
                    }
                }

            }

            if (!AdultPasswordBox.Checked)
            {
                string password1 = Microsoft.VisualBasic.Interaction.InputBox("비밀번호를 입력하세요", "비밀번호 입력", "");
                if (password1 != TempPW)
                {
                    MessageBox.Show("비밀번호가 일치하지 않습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    AdultPasswordBox.Checked = !AdultPasswordBox.Checked;
                }
                else
                {
                    ProtectByPW = true;
                    PwDelButton.Enabled = !PwDelButton.Enabled;
                    PwResetButton.Enabled = !PwResetButton.Enabled;
                    AdultHideBox.Enabled = !AdultHideBox.Enabled;
                }
            }
        }

        private void PwDelButton_Click(object sender, EventArgs e)
        {
            string password = Microsoft.VisualBasic.Interaction.InputBox("비밀번호를 입력하세요", "비밀번호 입력", "");
            if (password != TempPW)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TempPW = "";
            }
        }

        private void PwResetButton_Click(object sender, EventArgs e)
        {
            string password = Microsoft.VisualBasic.Interaction.InputBox("비밀번호를 입력하세요", "비밀번호 입력", "");
            if (password != TempPW)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                while (true)
                {
                    string password1 = Microsoft.VisualBasic.Interaction.InputBox("비밀번호를 입력하세요", "비밀번호 설정", "");
                    string password2 = Microsoft.VisualBasic.Interaction.InputBox("비밀번호를 한번 더 입력하세요", "비밀번호 설정", "");

                    if (password1 != password2)
                        MessageBox.Show("비밀번호가 일치하지 않습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (password1 == "")
                    {
                        AdultPasswordBox.Checked = !AdultPasswordBox.Checked;
                        break;
                    }
                    else
                    {
                        TempPW = password1;
                        break;
                    }
                }
            }
        }

        private void AdultHideBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!AdultHideBox.Checked)
            {
                string password1 = Microsoft.VisualBasic.Interaction.InputBox("비밀번호를 입력하세요", "비밀번호 입력", "");
                if (password1 != Properties.UserConfig.Default.Password)
                {
                    MessageBox.Show("비밀번호가 일치하지 않습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    AdultPasswordBox.Checked = !AdultHideBox.Checked;
                }
                else
                {
                    HideByPW = true;
                }
            }
        }

        private void ConfigSave()
        {
            Properties.UserConfig.Default.Password = TempPW;
            Properties.UserConfig.Default.ProtectByPW = ProtectByPW;
            Properties.UserConfig.Default.HideByPW = HideByPW;
            Properties.UserConfig.Default.Save();
        }

        private bool ConfigChanged()
        {
            return !(
                Properties.UserConfig.Default.Password == TempPW &&
                Properties.UserConfig.Default.ProtectByPW == ProtectByPW &&
                Properties.UserConfig.Default.HideByPW == HideByPW
            );
        }

        private void Config_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ConfigChanged())
            {
                if(MessageBox.Show("변경된 내용이 있습니다. 저장하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ConfigSave();
                }
            }
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("모든 설정이 이전값으로 되돌아갑니다. 괜찮으시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Load_config();
            }
        }

        private void OriginDelBox_CheckedChanged(object sender, EventArgs e)
        {
            OriginDel = OriginDelBox.Checked;
        }
    }
}

