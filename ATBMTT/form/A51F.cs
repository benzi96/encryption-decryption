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
    public partial class A51F : Form
    {
        public A51F()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files (*) | *";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != " ")
            {
                try
                {
                    txtInput.Text = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
            }
        }

        private string SinhKhoa(int length)
        {
            string S = "";
            Random ran = new Random();
            for (int i = 0; i < length; i++)
                S += (ran.Next(2));
            return S;
        }

        private void btnSinhkhoa_Click(object sender, EventArgs e)
        {
            txtKhoaX.Text = SinhKhoa(19);
            txtKhoaY.Text = SinhKhoa(22);
            txtKhoaZ.Text = SinhKhoa(23);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            try
            {
                if (txtInput.Text != "" & txtKhoaX.TextLength == 19 & txtKhoaY.TextLength == 22 & txtKhoaZ.TextLength == 23)
                {
                    
                    A51 a = new A51();
                    string p = a.encrypt(File.ReadAllText(txtInput.Text), txtKhoaX.Text + txtKhoaY.Text + txtKhoaZ.Text);
                    try
                    {
                        richTextBox1.Text = p;
                        MessageBox.Show("Thực hiện thành công");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else
                {
                    if (txtInput.Text == "") MessageBox.Show("Chưa chọn file !!");
                    if (txtKhoaX.TextLength != 19 || txtKhoaY.TextLength != 22 || txtKhoaZ.TextLength != 23) MessageBox.Show("Khóa chưa đúng");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void phamaa51btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            A51 a = new A51();
            string p = a.decrypt(File.ReadAllText(txtInput.Text), txtKhoaX.Text + txtKhoaY.Text + txtKhoaZ.Text);
            richTextBox1.Text = p;
        }
    }
}
