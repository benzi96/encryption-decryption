using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATBMTT.mahoa;

namespace ATBMTT.form
{
    public partial class ExtEuclid : Form
    {
        public ExtEuclid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long p = long.Parse(textBox1.Text);
            long q = long.Parse(textBox2.Text);
            long n = (p-1)*(q-1);
            long e1 = long.Parse(textBox3.Text);
            Extended_Euclid euc = new Extended_Euclid();
            textBox4.Text = euc.Extended_GCD(n,e1).ToString();
        }
    }
}
