using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Collections;
using Microsoft.VisualBasic;
using ATBMTT.mahoa;

namespace ATBMTT
{
    public partial class MHCD : Form
    {
        public MHCD()
        {
            InitializeComponent();
        }

        #region caesar
        private void mahoacaesarbtn_Click(object sender, EventArgs e)
        {
            caesar c = new caesar();
            richTextBox2.Text = c.mahoa(richTextBox1.Text, khoatxt.Text);
        }

        private void phamacaesarbtn_Click(object sender, EventArgs e)
        {
            caesar c = new caesar();
            richTextBox2.Text = c.giaima(richTextBox1.Text, khoatxt.Text);
        }
        #endregion   

        //mở file
        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        #region vigenere
        private void mahoavigenere_Click(object sender, EventArgs e)
        {
            vigenere v = new vigenere();
            richTextBox2.Text = v.mahoa(richTextBox1.Text, khoatxt.Text);
        }

        private void phamavigenere_Click(object sender, EventArgs e)
        {
            vigenere v = new vigenere();
            richTextBox2.Text = v.giaima(richTextBox1.Text, khoatxt.Text);
        }
        
        #endregion

        #region playfair
        private void mahoaplayfairbtn_Click(object sender, EventArgs e)
        {
            if ((khoatxt.Text != "") && (richTextBox1.Text != ""))
            {
                playfair pf = new playfair();
                richTextBox2.Text = pf.mahoa(richTextBox1.Text, khoatxt.Text);
            }
            else
            {
                MessageBox.Show("Nhâp từ khóa và văn bản để mã hóa");
            }
        }

        private void phamaplayfairbtn_Click(object sender, EventArgs e)
        {
            if ((khoatxt.Text != "") && (richTextBox1.Text != ""))
            {
                playfair pf = new playfair();
                richTextBox2.Text = pf.giaima(richTextBox1.Text, khoatxt.Text);
            }
            else
            {
                MessageBox.Show("Nhập từ khóa và văn bản giải mã");
            }
        }
        #endregion

        private void khoatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
