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
    public partial class Cong : Form
    {
        public Cong()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = a + b;
                txtKQ.Text = c.ToString();
        }
    }
}
