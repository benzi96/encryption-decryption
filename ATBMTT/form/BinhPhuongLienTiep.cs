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
    public partial class BinhPhuongLienTiep : Form
    {
        public BinhPhuongLienTiep()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            binhphuonglientiep bplt = new binhphuonglientiep();
            textBox4.Text = bplt.modulo(int.Parse(textBox1.Text),int.Parse(textBox2.Text),int.Parse(textBox3.Text)).ToString();
        }
    }
}
