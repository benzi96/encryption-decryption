namespace ATBMTT.form
{
    partial class DESF
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
            this.khoatxt = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.mahoadesbtn = new System.Windows.Forms.Button();
            this.phamabtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // khoatxt
            // 
            this.khoatxt.Location = new System.Drawing.Point(13, 40);
            this.khoatxt.Name = "khoatxt";
            this.khoatxt.Size = new System.Drawing.Size(313, 20);
            this.khoatxt.TabIndex = 5;
            this.khoatxt.TextChanged += new System.EventHandler(this.khoatxt_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Location = new System.Drawing.Point(395, 78);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(240, 335);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(240, 335);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // mahoadesbtn
            // 
            this.mahoadesbtn.Location = new System.Drawing.Point(275, 233);
            this.mahoadesbtn.Name = "mahoadesbtn";
            this.mahoadesbtn.Size = new System.Drawing.Size(98, 25);
            this.mahoadesbtn.TabIndex = 6;
            this.mahoadesbtn.Text = "Mã hóa DES";
            this.mahoadesbtn.UseVisualStyleBackColor = true;
            this.mahoadesbtn.Click += new System.EventHandler(this.mahoadesbtn_Click);
            // 
            // phamabtn
            // 
            this.phamabtn.Location = new System.Drawing.Point(275, 264);
            this.phamabtn.Name = "phamabtn";
            this.phamabtn.Size = new System.Drawing.Size(98, 25);
            this.phamabtn.TabIndex = 7;
            this.phamabtn.Text = "Phá mã DES";
            this.phamabtn.UseVisualStyleBackColor = true;
            this.phamabtn.Click += new System.EventHandler(this.phamabtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập khóa thập lục phân (VD: 0123456789ABCDEF)";
            // 
            // DESF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phamabtn);
            this.Controls.Add(this.mahoadesbtn);
            this.Controls.Add(this.khoatxt);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "DESF";
            this.Text = "DES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox khoatxt;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button mahoadesbtn;
        private System.Windows.Forms.Button phamabtn;
        private System.Windows.Forms.Label label1;
    }
}