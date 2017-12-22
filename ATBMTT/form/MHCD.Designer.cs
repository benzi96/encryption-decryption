namespace ATBMTT
{
    partial class MHCD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.khoatxt = new System.Windows.Forms.TextBox();
            this.mahoacaesarbtn = new System.Windows.Forms.Button();
            this.phamacaesarbtn = new System.Windows.Forms.Button();
            this.mahoavigenerebtn = new System.Windows.Forms.Button();
            this.phamavigenerebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mahoaplayfairbtn = new System.Windows.Forms.Button();
            this.phamaplayfairbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 67);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(240, 335);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Location = new System.Drawing.Point(394, 67);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(240, 335);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // khoatxt
            // 
            this.khoatxt.Location = new System.Drawing.Point(258, 86);
            this.khoatxt.Name = "khoatxt";
            this.khoatxt.Size = new System.Drawing.Size(130, 20);
            this.khoatxt.TabIndex = 2;
            this.khoatxt.TextChanged += new System.EventHandler(this.khoatxt_TextChanged);
            // 
            // mahoacaesarbtn
            // 
            this.mahoacaesarbtn.Location = new System.Drawing.Point(276, 127);
            this.mahoacaesarbtn.Name = "mahoacaesarbtn";
            this.mahoacaesarbtn.Size = new System.Drawing.Size(98, 25);
            this.mahoacaesarbtn.TabIndex = 3;
            this.mahoacaesarbtn.Text = "Mã hóa Caesar";
            this.mahoacaesarbtn.UseVisualStyleBackColor = true;
            this.mahoacaesarbtn.Click += new System.EventHandler(this.mahoacaesarbtn_Click);
            // 
            // phamacaesarbtn
            // 
            this.phamacaesarbtn.Location = new System.Drawing.Point(276, 158);
            this.phamacaesarbtn.Name = "phamacaesarbtn";
            this.phamacaesarbtn.Size = new System.Drawing.Size(98, 23);
            this.phamacaesarbtn.TabIndex = 4;
            this.phamacaesarbtn.Text = "Phá mã Caesar";
            this.phamacaesarbtn.UseVisualStyleBackColor = true;
            this.phamacaesarbtn.Click += new System.EventHandler(this.phamacaesarbtn_Click);
            // 
            // mahoavigenerebtn
            // 
            this.mahoavigenerebtn.Location = new System.Drawing.Point(276, 208);
            this.mahoavigenerebtn.Name = "mahoavigenerebtn";
            this.mahoavigenerebtn.Size = new System.Drawing.Size(98, 23);
            this.mahoavigenerebtn.TabIndex = 5;
            this.mahoavigenerebtn.Text = "Mã hóa Vigenere";
            this.mahoavigenerebtn.UseVisualStyleBackColor = true;
            this.mahoavigenerebtn.Click += new System.EventHandler(this.mahoavigenere_Click);
            // 
            // phamavigenerebtn
            // 
            this.phamavigenerebtn.Location = new System.Drawing.Point(276, 237);
            this.phamavigenerebtn.Name = "phamavigenerebtn";
            this.phamavigenerebtn.Size = new System.Drawing.Size(98, 23);
            this.phamavigenerebtn.TabIndex = 6;
            this.phamavigenerebtn.Text = "Phá mã Vigenere";
            this.phamavigenerebtn.UseVisualStyleBackColor = true;
            this.phamavigenerebtn.Click += new System.EventHandler(this.phamavigenere_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập khóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nhập văn bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kết quả";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Mở File";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // mahoaplayfairbtn
            // 
            this.mahoaplayfairbtn.Location = new System.Drawing.Point(276, 286);
            this.mahoaplayfairbtn.Name = "mahoaplayfairbtn";
            this.mahoaplayfairbtn.Size = new System.Drawing.Size(98, 23);
            this.mahoaplayfairbtn.TabIndex = 11;
            this.mahoaplayfairbtn.Text = "Mã hóa Playfair";
            this.mahoaplayfairbtn.UseVisualStyleBackColor = true;
            this.mahoaplayfairbtn.Click += new System.EventHandler(this.mahoaplayfairbtn_Click);
            // 
            // phamaplayfairbtn
            // 
            this.phamaplayfairbtn.Location = new System.Drawing.Point(276, 315);
            this.phamaplayfairbtn.Name = "phamaplayfairbtn";
            this.phamaplayfairbtn.Size = new System.Drawing.Size(98, 23);
            this.phamaplayfairbtn.TabIndex = 12;
            this.phamaplayfairbtn.Text = "Phá mã Playfair";
            this.phamaplayfairbtn.UseVisualStyleBackColor = true;
            this.phamaplayfairbtn.Click += new System.EventHandler(this.phamaplayfairbtn_Click);
            // 
            // MHCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 424);
            this.Controls.Add(this.phamaplayfairbtn);
            this.Controls.Add(this.mahoaplayfairbtn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phamavigenerebtn);
            this.Controls.Add(this.mahoavigenerebtn);
            this.Controls.Add(this.phamacaesarbtn);
            this.Controls.Add(this.mahoacaesarbtn);
            this.Controls.Add(this.khoatxt);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MHCD";
            this.Text = "MHCD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox khoatxt;
        private System.Windows.Forms.Button mahoacaesarbtn;
        private System.Windows.Forms.Button phamacaesarbtn;
        private System.Windows.Forms.Button mahoavigenerebtn;
        private System.Windows.Forms.Button phamavigenerebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button mahoaplayfairbtn;
        private System.Windows.Forms.Button phamaplayfairbtn;
    }
}