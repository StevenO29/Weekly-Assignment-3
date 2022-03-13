using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Take_Home_Assignment_Week_3
{
    public partial class FormPengaturanWarna : Form
    {
        public FormPengaturanWarna()
        {
            InitializeComponent();
        }
        
        private void BtnProses_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtBoxInput.Text.ToUpper() == "UP" || TxtBoxInput.Text.ToUpper() == "BESAR")
                    LblOutput.Font = new Font("Segoe UI", LblOutput.Font.Size + 1, FontStyle.Bold);
                else if (TxtBoxInput.Text.ToUpper() == "DOWN" || TxtBoxInput.Text.ToUpper() == "KECIL")
                    LblOutput.Font = new Font("Segoe UI", LblOutput.Font.Size - 1, FontStyle.Bold);
                else if (TxtBoxInput.Text.ToUpper() == "RESTART")
                {
                    LblOutput.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                    LblOutput.ForeColor = Color.Black;
                    LblOutput.Visible = true;
                    LblOutput.Text = "[EMPTY]";
                }
                else if (TxtBoxInput.Text.Substring(0, 4).ToUpper() == "ISI:")
                    LblOutput.Text = TxtBoxInput.Text.Substring(4);
                else if (TxtBoxInput.Text.ToUpper() == "SHOWN")
                    LblOutput.Visible = true;
                else if (TxtBoxInput.Text.ToUpper() == "HIDE")
                    LblOutput.Visible = false;
                else if (TxtBoxInput.Text.Substring(0, 6).ToUpper() == "WARNA:")
                {
                    if (TxtBoxInput.Text.Substring(6).ToUpper() == "MERAH" || TxtBoxInput.Text.Substring(6).ToUpper() == "RED")
                        LblOutput.ForeColor = Color.Red;
                    else if (TxtBoxInput.Text.Substring(6).ToUpper() == "HIJAU" || TxtBoxInput.Text.Substring(6).ToUpper() == "GREEN")
                        LblOutput.ForeColor = Color.Green;
                    else if (TxtBoxInput.Text.Substring(6).ToUpper() == "BIRU" || TxtBoxInput.Text.Substring(6).ToUpper() == "BLUE")
                        LblOutput.ForeColor = Color.Blue;
                    else if (TxtBoxInput.Text.Substring(6).ToUpper() == "DEFAULT" || TxtBoxInput.Text.Substring(6).ToUpper() == "BLACK" || TxtBoxInput.Text.Substring(6).ToUpper() == "HITAM")
                        LblOutput.ForeColor = Color.Black;
                    else
                        MessageBox.Show("Syntax tidak terdaftar!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Syntax tidak terdaftar");
            }
        }

        private void FormPengaturanWarna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnProses.PerformClick();
        }
    }
}
