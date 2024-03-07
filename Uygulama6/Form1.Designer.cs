namespace Uygulama6
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYazili1 = new System.Windows.Forms.TextBox();
            this.txtYazili2 = new System.Windows.Forms.TextBox();
            this.txtYazili3 = new System.Windows.Forms.TextBox();
            this.txtYazili4 = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lbYazili = new System.Windows.Forms.ListBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(185, 176);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yazılı 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yazılı 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yazılı 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yazılı 4";
            // 
            // txtYazili1
            // 
            this.txtYazili1.Location = new System.Drawing.Point(108, 295);
            this.txtYazili1.Name = "txtYazili1";
            this.txtYazili1.Size = new System.Drawing.Size(32, 20);
            this.txtYazili1.TabIndex = 6;
            // 
            // txtYazili2
            // 
            this.txtYazili2.Location = new System.Drawing.Point(172, 295);
            this.txtYazili2.Name = "txtYazili2";
            this.txtYazili2.Size = new System.Drawing.Size(32, 20);
            this.txtYazili2.TabIndex = 7;
            // 
            // txtYazili3
            // 
            this.txtYazili3.Location = new System.Drawing.Point(234, 295);
            this.txtYazili3.Name = "txtYazili3";
            this.txtYazili3.Size = new System.Drawing.Size(32, 20);
            this.txtYazili3.TabIndex = 8;
            // 
            // txtYazili4
            // 
            this.txtYazili4.Location = new System.Drawing.Point(303, 295);
            this.txtYazili4.Name = "txtYazili4";
            this.txtYazili4.Size = new System.Drawing.Size(32, 20);
            this.txtYazili4.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(362, 269);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 34);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lbYazili
            // 
            this.lbYazili.FormattingEnabled = true;
            this.lbYazili.Location = new System.Drawing.Point(479, 176);
            this.lbYazili.Name = "lbYazili";
            this.lbYazili.Size = new System.Drawing.Size(120, 147);
            this.lbYazili.TabIndex = 11;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(638, 242);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 12;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lbYazili);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtYazili4);
            this.Controls.Add(this.txtYazili3);
            this.Controls.Add(this.txtYazili2);
            this.Controls.Add(this.txtYazili1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYazili1;
        private System.Windows.Forms.TextBox txtYazili2;
        private System.Windows.Forms.TextBox txtYazili3;
        private System.Windows.Forms.TextBox txtYazili4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lbYazili;
        private System.Windows.Forms.Button btnListele;
    }
}

