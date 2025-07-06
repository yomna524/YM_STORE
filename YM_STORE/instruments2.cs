using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YM_STORE
{
    public partial class instruments2 : Form
    {
        private int total;
        public instruments2(int initialTotal)
        {
            InitializeComponent();
            total = initialTotal;
            totalLabel.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Checkout Button
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
