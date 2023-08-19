using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiriusX
{
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
        }



        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_MouseFocus(object sender, EventArgs e)
        {
            label2.Visible = true;
        }
        private void kryptonButton1_LostFocus(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dash_Load(object sender, EventArgs e)
        {
            //this.Focus();
        }
    }
}
