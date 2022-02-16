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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Bread bread = new Bread();
            bread.Show();
            this.Hide();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Cola cola = new Cola();
            cola.Show();
            this.Hide();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            krastavica krastavica = new krastavica();
            krastavica.Show();
            this.Hide();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Tomato tomato = new Tomato();
            tomato.Show();
            this.Hide();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Milk milk = new Milk();
            milk.Show();
            this.Hide();
        }
    }
}
