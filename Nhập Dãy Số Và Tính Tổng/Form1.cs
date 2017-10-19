using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhập_Dãy_Số_Và_Tính_Tổng
{
    public partial class Form1 : Form
    {
        int a = 0;
        int tongday = 0;
        int tongchan = 0;
        int tongle = 0;
        string x = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult nut = new DialogResult();
            do
            {
                x = "";
                nut = nhap.nhapso("Nhập Số", "Nhập Số", ref x);
                if (int.TryParse(x, out a))
                {
                    tongday += a;
                    tbdanhap.Text += x + "  ";
                    tbtong.Text = tongday.ToString();
                    if (a % 2 == 0)
                    {
                        tongchan += a;
                    }
                    else
                        tongle += a;
                    tble.Text = tongle.ToString();
                    tbchan.Text = tongchan.ToString();
                }
                else if (nut == DialogResult.Cancel)
                {
                    break;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } while (nut == DialogResult.OK && x != "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbchan.Clear();
            tbdanhap.Clear();
            tble.Clear();
            tbtong.Clear();
            tongchan = 0;
            tongle = 0;
            tongday = 0;
            x = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
