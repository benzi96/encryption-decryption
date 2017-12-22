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
using System.Numerics;


namespace ATBMTT.form
{
    public partial class RSAF : Form
    {
        public RSAF()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void khoatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnhand_Click(object sender, EventArgs e)
        {
            RSA r = new RSA();
            r.calkey(txte.Text, txtp.Text, txtq.Text);
            txtn.Text = r.xuatn().ToString();
            txtn1.Text = r.xuatfn().ToString();
            txtd.Text = r.privatekey().ToString();
        }

        private void btnfile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtinputRSA.Text = File.ReadAllText(openFileDialog1.FileName);
            }

        }

        private void mahoarsabtn_Click(object sender, EventArgs e)
        {
            RSA r = new RSA();
            txtinputRSA2.Text = r.encrypt(txtinputRSA.Text, txte.Text, txtp.Text, txtq.Text);
        }
        private void phamarsabtn_Click(object sender, EventArgs e)
        {
            RSA r = new RSA();
            txtinputRSA2.Text = r.decrypt(txtinputRSA.Text, txtd.Text, txtn.Text);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }            
}
}
