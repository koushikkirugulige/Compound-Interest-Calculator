using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class NSC : Form
    {
        public NSC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount;
            double rate;
            amount = Convert.ToInt32(textBox1.Text);
            rate = Convert.ToDouble(textBox2.Text);
            double tot;
            tot = Math.Pow(1 + (rate/100), 5);
            tot = tot * amount;
            MessageBox.Show(tot.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
