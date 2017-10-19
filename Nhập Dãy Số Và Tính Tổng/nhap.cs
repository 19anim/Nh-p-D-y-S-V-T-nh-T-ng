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
    class nhap
    {
        public static DialogResult nhapso(string tenform, string tenlabel,ref string x)
        {
            Form form = new Form();
            Label lb = new Label();
            Button btok = new Button();
            TextBox tb = new TextBox();
            Button btcancel = new Button();
            btok.DialogResult = DialogResult.OK;
            btcancel.DialogResult = DialogResult.Cancel;
            tb.Text = x;
            form.Text = tenform;
            lb.Text = tenlabel;
            btcancel.Text = "Thoát";
            btok.Text = "OK";
            form.AcceptButton = btok;
            lb.SetBounds(12, 9, 64, 19);
            tb.SetBounds(13, 38, 359, 20);
            btok.SetBounds(85, 69, 75, 23);
            btcancel.SetBounds(225, 69, 75, 23);
            lb.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            lb.AutoSize = true;
            tb.Anchor = tb.Anchor | AnchorStyles.Right;
            btok.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btcancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            form.CancelButton = btcancel;
            form.ShowIcon = false;
            form.ClientSize = new Size(385, 110);
            form.Controls.AddRange(new Control[] { lb, tb, btcancel, btok });
            form.StartPosition = FormStartPosition.CenterScreen;
            DialogResult dr = form.ShowDialog();
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            x = tb.Text;
            return dr;
        }

    }
}
