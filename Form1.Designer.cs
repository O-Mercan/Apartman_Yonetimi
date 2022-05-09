namespace Apartman_Yonetimi_ms
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_admin = new System.Windows.Forms.Button();
            this.txt_admin_kullanici_sifre = new System.Windows.Forms.TextBox();
            this.txt_admin_kullanici_adi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_yonetici = new System.Windows.Forms.Button();
            this.txt_yonetici_kullanici_sifre = new System.Windows.Forms.TextBox();
            this.txt_yonetici_kullanici_adi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_sakin_goster = new System.Windows.Forms.Button();
            this.btn_daire_sakin_girisi = new System.Windows.Forms.Button();
            this.txt_sakin_kullanici_sifre = new System.Windows.Forms.TextBox();
            this.txt_sakin_kullanici_adi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_admin_goster = new System.Windows.Forms.Button();
            this.btn_yonetici_goster = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Yönetici";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 67);
            this.button3.TabIndex = 3;
            this.button3.Text = "Daire Sakini";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_admin_goster);
            this.panel1.Controls.Add(this.btn_admin);
            this.panel1.Controls.Add(this.txt_admin_kullanici_sifre);
            this.panel1.Controls.Add(this.txt_admin_kullanici_adi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(247, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 110);
            this.panel1.TabIndex = 4;
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(3, 78);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(103, 31);
            this.btn_admin.TabIndex = 4;
            this.btn_admin.Text = "Giriş";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // txt_admin_kullanici_sifre
            // 
            this.txt_admin_kullanici_sifre.Location = new System.Drawing.Point(102, 41);
            this.txt_admin_kullanici_sifre.Name = "txt_admin_kullanici_sifre";
            this.txt_admin_kullanici_sifre.PasswordChar = '*';
            this.txt_admin_kullanici_sifre.Size = new System.Drawing.Size(114, 26);
            this.txt_admin_kullanici_sifre.TabIndex = 3;
            // 
            // txt_admin_kullanici_adi
            // 
            this.txt_admin_kullanici_adi.Location = new System.Drawing.Point(102, 14);
            this.txt_admin_kullanici_adi.Name = "txt_admin_kullanici_adi";
            this.txt_admin_kullanici_adi.Size = new System.Drawing.Size(114, 26);
            this.txt_admin_kullanici_adi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC no:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_yonetici_goster);
            this.panel2.Controls.Add(this.btn_yonetici);
            this.panel2.Controls.Add(this.txt_yonetici_kullanici_sifre);
            this.panel2.Controls.Add(this.txt_yonetici_kullanici_adi);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(247, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 110);
            this.panel2.TabIndex = 5;
            // 
            // btn_yonetici
            // 
            this.btn_yonetici.Location = new System.Drawing.Point(3, 76);
            this.btn_yonetici.Name = "btn_yonetici";
            this.btn_yonetici.Size = new System.Drawing.Size(103, 31);
            this.btn_yonetici.TabIndex = 5;
            this.btn_yonetici.Text = "Giriş";
            this.btn_yonetici.UseVisualStyleBackColor = true;
            this.btn_yonetici.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_yonetici_kullanici_sifre
            // 
            this.txt_yonetici_kullanici_sifre.Location = new System.Drawing.Point(102, 41);
            this.txt_yonetici_kullanici_sifre.Name = "txt_yonetici_kullanici_sifre";
            this.txt_yonetici_kullanici_sifre.PasswordChar = '*';
            this.txt_yonetici_kullanici_sifre.Size = new System.Drawing.Size(114, 26);
            this.txt_yonetici_kullanici_sifre.TabIndex = 3;
            // 
            // txt_yonetici_kullanici_adi
            // 
            this.txt_yonetici_kullanici_adi.Location = new System.Drawing.Point(102, 14);
            this.txt_yonetici_kullanici_adi.Name = "txt_yonetici_kullanici_adi";
            this.txt_yonetici_kullanici_adi.Size = new System.Drawing.Size(114, 26);
            this.txt_yonetici_kullanici_adi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "TC no:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_sakin_goster);
            this.panel3.Controls.Add(this.btn_daire_sakin_girisi);
            this.panel3.Controls.Add(this.txt_sakin_kullanici_sifre);
            this.panel3.Controls.Add(this.txt_sakin_kullanici_adi);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(247, 298);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 110);
            this.panel3.TabIndex = 6;
            // 
            // btn_sakin_goster
            // 
            this.btn_sakin_goster.Location = new System.Drawing.Point(129, 76);
            this.btn_sakin_goster.Name = "btn_sakin_goster";
            this.btn_sakin_goster.Size = new System.Drawing.Size(87, 31);
            this.btn_sakin_goster.TabIndex = 8;
            this.btn_sakin_goster.Text = "Göster";
            this.btn_sakin_goster.UseVisualStyleBackColor = true;
            this.btn_sakin_goster.Click += new System.EventHandler(this.btn_sakin_goster_Click);
            // 
            // btn_daire_sakin_girisi
            // 
            this.btn_daire_sakin_girisi.Location = new System.Drawing.Point(3, 76);
            this.btn_daire_sakin_girisi.Name = "btn_daire_sakin_girisi";
            this.btn_daire_sakin_girisi.Size = new System.Drawing.Size(103, 31);
            this.btn_daire_sakin_girisi.TabIndex = 6;
            this.btn_daire_sakin_girisi.Text = "Giriş";
            this.btn_daire_sakin_girisi.UseVisualStyleBackColor = true;
            this.btn_daire_sakin_girisi.Click += new System.EventHandler(this.btn_daire_sakin_girisi_Click);
            // 
            // txt_sakin_kullanici_sifre
            // 
            this.txt_sakin_kullanici_sifre.Location = new System.Drawing.Point(102, 41);
            this.txt_sakin_kullanici_sifre.Multiline = true;
            this.txt_sakin_kullanici_sifre.Name = "txt_sakin_kullanici_sifre";
            this.txt_sakin_kullanici_sifre.PasswordChar = '*';
            this.txt_sakin_kullanici_sifre.Size = new System.Drawing.Size(114, 26);
            this.txt_sakin_kullanici_sifre.TabIndex = 3;
            // 
            // txt_sakin_kullanici_adi
            // 
            this.txt_sakin_kullanici_adi.Location = new System.Drawing.Point(102, 14);
            this.txt_sakin_kullanici_adi.Name = "txt_sakin_kullanici_adi";
            this.txt_sakin_kullanici_adi.Size = new System.Drawing.Size(114, 26);
            this.txt_sakin_kullanici_adi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "TC no:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Apartman_Yonetimi_ms.Properties.Resources.siteresmi1;
            this.pictureBox1.Location = new System.Drawing.Point(574, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 288);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btn_admin_goster
            // 
            this.btn_admin_goster.Location = new System.Drawing.Point(129, 78);
            this.btn_admin_goster.Name = "btn_admin_goster";
            this.btn_admin_goster.Size = new System.Drawing.Size(87, 32);
            this.btn_admin_goster.TabIndex = 8;
            this.btn_admin_goster.Text = "Göster";
            this.btn_admin_goster.UseVisualStyleBackColor = true;
            this.btn_admin_goster.Click += new System.EventHandler(this.btn_admin_goster_Click);
            // 
            // btn_yonetici_goster
            // 
            this.btn_yonetici_goster.Location = new System.Drawing.Point(129, 76);
            this.btn_yonetici_goster.Name = "btn_yonetici_goster";
            this.btn_yonetici_goster.Size = new System.Drawing.Size(87, 31);
            this.btn_yonetici_goster.TabIndex = 8;
            this.btn_yonetici_goster.Text = "Göster";
            this.btn_yonetici_goster.UseVisualStyleBackColor = true;
            this.btn_yonetici_goster.Click += new System.EventHandler(this.btn_yonetici_goster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Site Yönetimi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.TextBox txt_admin_kullanici_sifre;
        private System.Windows.Forms.TextBox txt_admin_kullanici_adi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_yonetici;
        private System.Windows.Forms.TextBox txt_yonetici_kullanici_sifre;
        private System.Windows.Forms.TextBox txt_yonetici_kullanici_adi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_daire_sakin_girisi;
        private System.Windows.Forms.TextBox txt_sakin_kullanici_sifre;
        private System.Windows.Forms.TextBox txt_sakin_kullanici_adi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sakin_goster;
        private System.Windows.Forms.Button btn_admin_goster;
        private System.Windows.Forms.Button btn_yonetici_goster;
    }
}

