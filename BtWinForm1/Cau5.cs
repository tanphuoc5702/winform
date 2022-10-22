using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtWinForm1
{
    public partial class Cau5 : Form
    {
        public Cau5()
        {
            InitializeComponent();
        }

        private void btQuaySo_Click(object sender, EventArgs e)
        {
            int so1, so2, so3, diem = 0, kqua=0;
            Random random = new Random();
            lbSo1.Text = random.Next(0, 6).ToString();
            lbSo2.Text = random.Next(0, 6).ToString();
            lbSo3.Text = random.Next(0, 6).ToString();
            so1 = Int32.Parse(lbSo1.Text);
            so2 = Int32.Parse(lbSo2.Text);
            so3 = Int32.Parse(lbSo3.Text);
            if (rd3.Checked)
            {
                if (kqua <= 10)
                    diem += 10;
                else
                    diem -= 10;
            }
            lbDiem.Text = diem.ToString();
        }
    }
}
