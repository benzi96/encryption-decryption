using ATBMTT.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATBMTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MHCD mhcd = new MHCD();
            mhcd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A51F form = new A51F();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DESF des = new DESF();
            des.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RSAF rsa = new RSAF();
            rsa.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExtEuclid euc = new ExtEuclid();
            euc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BinhPhuongLienTiep bplt = new BinhPhuongLienTiep();
            bplt.Show();
        }
    }
}
