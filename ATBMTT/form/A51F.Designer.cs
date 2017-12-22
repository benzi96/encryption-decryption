namespace ATBMTT
{
    partial class A51F
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.txtKhoaZ = new System.Windows.Forms.TextBox();
            this.txtKhoaY = new System.Windows.Forms.TextBox();
            this.txtKhoaX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.phamaa51btn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Enabled = false;
            this.txtInput.Location = new System.Drawing.Point(121, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(237, 20);
            this.txtInput.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Đường dẫn file nhập:";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(364, 9);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 24;
            this.btnInput.Text = "Chọn File";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtKhoaZ
            // 
            this.txtKhoaZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKhoaZ.Location = new System.Drawing.Point(64, 120);
            this.txtKhoaZ.MaxLength = 23;
            this.txtKhoaZ.Name = "txtKhoaZ";
            this.txtKhoaZ.Size = new System.Drawing.Size(303, 20);
            this.txtKhoaZ.TabIndex = 31;
            // 
            // txtKhoaY
            // 
            this.txtKhoaY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKhoaY.Location = new System.Drawing.Point(64, 86);
            this.txtKhoaY.MaxLength = 22;
            this.txtKhoaY.Name = "txtKhoaY";
            this.txtKhoaY.Size = new System.Drawing.Size(303, 20);
            this.txtKhoaY.TabIndex = 30;
            // 
            // txtKhoaX
            // 
            this.txtKhoaX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKhoaX.Location = new System.Drawing.Point(64, 49);
            this.txtKhoaX.MaxLength = 19;
            this.txtKhoaX.Name = "txtKhoaX";
            this.txtKhoaX.Size = new System.Drawing.Size(303, 20);
            this.txtKhoaX.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Z(23 bit)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Y(22 bit)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "X(19 bit)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 24);
            this.button1.TabIndex = 33;
            this.button1.Text = "Mã hóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // phamaa51btn
            // 
            this.phamaa51btn.Location = new System.Drawing.Point(390, 103);
            this.phamaa51btn.Name = "phamaa51btn";
            this.phamaa51btn.Size = new System.Drawing.Size(81, 24);
            this.phamaa51btn.TabIndex = 34;
            this.phamaa51btn.Text = "Phá mã";
            this.phamaa51btn.UseVisualStyleBackColor = true;
            this.phamaa51btn.Click += new System.EventHandler(this.phamaa51btn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 182);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(542, 78);
            this.richTextBox1.TabIndex = 35;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Kết quả";
            // 
            // A51F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.phamaa51btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKhoaZ);
            this.Controls.Add(this.txtKhoaY);
            this.Controls.Add(this.txtKhoaX);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label4);
            this.Name = "A51F";
            this.Text = "A51";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox txtKhoaZ;
        private System.Windows.Forms.TextBox txtKhoaY;
        private System.Windows.Forms.TextBox txtKhoaX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button phamaa51btn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}