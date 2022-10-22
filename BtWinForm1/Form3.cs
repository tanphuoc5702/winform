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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private Label GetLabel()
        {
            return label1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Point p = new Point(100);
            p.X = 50;
            MessageBox.Show(p.X + " " + p.Y);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
