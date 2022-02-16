using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Milk : Form
    {
        public Milk()
        {
            InitializeComponent();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            End1 end = new End1();
            end.Show();
            this.Hide();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            End2 end = new End2();
            end.Show();
            this.Hide();
        }
    }
}
