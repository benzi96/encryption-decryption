namespace ATBMTT.form
{
    partial class RSAF
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
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtq = new System.Windows.Forms.TextBox();
            this.txtd = new System.Windows.Forms.TextBox();
            this.txte = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.lbq = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnhand = new System.Windows.Forms.Button();
            this.txtinputRSA = new System.Windows.Forms.RichTextBox();
            this.btnfile = new System.Windows.Forms.Button();
            this.mahoarsabtn = new System.Windows.Forms.Button();
            this.phamarsabtn = new System.Windows.Forms.Button();
            this.txtinputRSA2 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(41, 30);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(106, 20);
            this.txtp.TabIndex = 1;
            this.txtp.TextChanged += new System.EventHandler(this.khoatxt_TextChanged);
            // 
            // txtq
            // 
            this.txtq.Location = new System.Drawing.Point(246, 31);
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(106, 20);
            this.txtq.TabIndex = 2;
            // 
            // txtd
            // 
            this.txtd.Enabled = false;
            this.txtd.Location = new System.Drawing.Point(440, 67);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(106, 20);
            this.txtd.TabIndex = 10;
            // 
            // txte
            // 
            this.txte.Location = new System.Drawing.Point(440, 30);
            this.txte.Name = "txte";
            this.txte.Size = new System.Drawing.Size(106, 20);
            this.txte.TabIndex = 3;
            // 
            // txtn
            // 
            this.txtn.Enabled = false;
            this.txtn.Location = new System.Drawing.Point(41, 67);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(106, 20);
            this.txtn.TabIndex = 12;
            // 
            // lbq
            // 
            this.lbq.AutoSize = true;
            this.lbq.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbq.Location = new System.Drawing.Point(5, 56);
            this.lbq.Name = "lbq";
            this.lbq.Size = new System.Drawing.Size(30, 31);
            this.lbq.TabIndex = 51;
            this.lbq.Text = "n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(404, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 52;
            this.label1.Text = "d";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(404, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 31);
            this.label2.TabIndex = 53;
            this.label2.Text = "e";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(210, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 31);
            this.label3.TabIndex = 54;
            this.label3.Text = "q";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(5, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 31);
            this.label4.TabIndex = 55;
            this.label4.Text = "p";
            // 
            // btnhand
            // 
            this.btnhand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnhand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnhand.Location = new System.Drawing.Point(246, 117);
            this.btnhand.Name = "btnhand";
            this.btnhand.Size = new System.Drawing.Size(127, 34);
            this.btnhand.TabIndex = 56;
            this.btnhand.Text = "Tính n, N và d";
            this.btnhand.UseVisualStyleBackColor = true;
            this.btnhand.Click += new System.EventHandler(this.btnhand_Click);
            // 
            // txtinputRSA
            // 
            this.txtinputRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtinputRSA.Location = new System.Drawing.Point(41, 229);
            this.txtinputRSA.Name = "txtinputRSA";
            this.txtinputRSA.Size = new System.Drawing.Size(234, 87);
            this.txtinputRSA.TabIndex = 57;
            this.txtinputRSA.Text = "";
            // 
            // btnfile
            // 
            this.btnfile.Location = new System.Drawing.Point(41, 172);
            this.btnfile.Name = "btnfile";
            this.btnfile.Size = new System.Drawing.Size(94, 33);
            this.btnfile.TabIndex = 68;
            this.btnfile.Text = "Mở file";
            this.btnfile.UseVisualStyleBackColor = true;
            this.btnfile.Click += new System.EventHandler(this.btnfile_Click);
            // 
            // mahoarsabtn
            // 
            this.mahoarsabtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mahoarsabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mahoarsabtn.Location = new System.Drawing.Point(41, 332);
            this.mahoarsabtn.Name = "mahoarsabtn";
            this.mahoarsabtn.Size = new System.Drawing.Size(100, 34);
            this.mahoarsabtn.TabIndex = 69;
            this.mahoarsabtn.Text = "Mã Hóa";
            this.mahoarsabtn.UseVisualStyleBackColor = true;
            this.mahoarsabtn.Click += new System.EventHandler(this.mahoarsabtn_Click);
            // 
            // phamarsabtn
            // 
            this.phamarsabtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.phamarsabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.phamarsabtn.Location = new System.Drawing.Point(175, 332);
            this.phamarsabtn.Name = "phamarsabtn";
            this.phamarsabtn.Size = new System.Drawing.Size(100, 35);
            this.phamarsabtn.TabIndex = 70;
            this.phamarsabtn.Text = "Phá Mã";
            this.phamarsabtn.UseVisualStyleBackColor = true;
            this.phamarsabtn.Click += new System.EventHandler(this.phamarsabtn_Click);
            // 
            // txtinputRSA2
            // 
            this.txtinputRSA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtinputRSA2.Location = new System.Drawing.Point(339, 229);
            this.txtinputRSA2.Name = "txtinputRSA2";
            this.txtinputRSA2.Size = new System.Drawing.Size(234, 87);
            this.txtinputRSA2.TabIndex = 71;
            this.txtinputRSA2.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(336, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 17);
            this.label15.TabIndex = 72;
            this.label15.Text = "Kết quả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(213, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 31);
            this.label5.TabIndex = 74;
            this.label5.Text = "N";
            // 
            // txtn1
            // 
            this.txtn1.Enabled = false;
            this.txtn1.Location = new System.Drawing.Point(249, 68);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(106, 20);
            this.txtn1.TabIndex = 73;
            // 
            // RSAF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 389);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtinputRSA2);
            this.Controls.Add(this.phamarsabtn);
            this.Controls.Add(this.mahoarsabtn);
            this.Controls.Add(this.btnfile);
            this.Controls.Add(this.txtinputRSA);
            this.Controls.Add(this.btnhand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbq);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.txte);
            this.Controls.Add(this.txtd);
            this.Controls.Add(this.txtq);
            this.Controls.Add(this.txtp);
            this.Name = "RSAF";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtq;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.TextBox txte;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Label lbq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnhand;
        private System.Windows.Forms.RichTextBox txtinputRSA;
        private System.Windows.Forms.Button btnfile;
        private System.Windows.Forms.Button mahoarsabtn;
        private System.Windows.Forms.Button phamarsabtn;
        private System.Windows.Forms.RichTextBox txtinputRSA2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtn1;

    }
}