namespace Ogrenci_Indirimi_checkbox
{
    partial class Form1
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
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.chkOgrenci = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOdenecek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdet.Location = new System.Drawing.Point(25, 27);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(46, 18);
            this.lblAdet.TabIndex = 0;
            this.lblAdet.Text = "Adet:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(21, 66);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(49, 18);
            this.lblFiyat.TabIndex = 1;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(85, 27);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(185, 20);
            this.txtAdet.TabIndex = 2;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(85, 67);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(185, 20);
            this.txtFiyat.TabIndex = 3;
            // 
            // chkOgrenci
            // 
            this.chkOgrenci.AutoSize = true;
            this.chkOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkOgrenci.Location = new System.Drawing.Point(85, 116);
            this.chkOgrenci.Name = "chkOgrenci";
            this.chkOgrenci.Size = new System.Drawing.Size(185, 22);
            this.chkOgrenci.TabIndex = 4;
            this.chkOgrenci.Text = "Öğrenci(%20 İndirim)";
            this.chkOgrenci.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(85, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOdenecek
            // 
            this.lblOdenecek.AutoSize = true;
            this.lblOdenecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenecek.Location = new System.Drawing.Point(82, 240);
            this.lblOdenecek.Name = "lblOdenecek";
            this.lblOdenecek.Size = new System.Drawing.Size(115, 18);
            this.lblOdenecek.TabIndex = 6;
            this.lblOdenecek.Text = "Ödecek Tutar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(308, 290);
            this.Controls.Add(this.lblOdenecek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkOgrenci);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblAdet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.CheckBox chkOgrenci;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOdenecek;
    }
}

