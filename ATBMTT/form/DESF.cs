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
    public partial class DESF : Form
    {
        public DESF()
        {
            InitializeComponent();
        }

        private void mahoadesbtn_Click(object sender, EventArgs e)
        {
            if (khoatxt.Text.Length == 16)
            {
                while (richTextBox1.Text.Length % 8 != 0)
                {
                    //thêm X để đủ 64 bit (8 kí tự)
                    richTextBox1.Text += "X";
                }
                if (richTextBox1.Text.Length % 8 == 0)
                {
                    for (int i = 0; i < richTextBox1.Text.Length; i+=8)
                    {
                        DES d = new DES();
                        richTextBox2.Text += d.encrypt(richTextBox1.Text.Substring(i, 8), khoatxt.Text);
                    }
                }
            }
        }

        private void phamabtn_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            for (int i = 0; i < richTextBox1.Text.Length; i+=16)
            {
                DES d = new DES();
                richTextBox2.Text += d.decrypt(richTextBox1.Text.Substring(i, 16), khoatxt.Text);
            }
        }

        private void khoatxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
