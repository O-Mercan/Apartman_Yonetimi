namespace Apartman_Yonetimi_ms
{
    partial class apartman_islemlerii
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
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_apartman_adı = new System.Windows.Forms.TextBox();
            this.grp_apartman_bilgileri = new System.Windows.Forms.GroupBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_daire_sayısı = new System.Windows.Forms.TextBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_blok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.grp_apartman_bilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(357, 301);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(102, 41);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apartman Adı:";
            // 
            // txt_apartman_adı
            // 
            this.txt_apartman_adı.Location = new System.Drawing.Point(127, 85);
            this.txt_apartman_adı.Name = "txt_apartman_adı";
            this.txt_apartman_adı.Size = new System.Drawing.Size(137, 26);
            this.txt_apartman_adı.TabIndex = 2;
            // 
            // grp_apartman_bilgileri
            // 
            this.grp_apartman_bilgileri.Controls.Add(this.btn_temizle);
            this.grp_apartman_bilgileri.Controls.Add(this.btn_guncelle);
            this.grp_apartman_bilgileri.Controls.Add(this.btn_sil);
            this.grp_apartman_bilgileri.Controls.Add(this.btn_ekle);
            this.grp_apartman_bilgileri.Controls.Add(this.txt_daire_sayısı);
            this.grp_apartman_bilgileri.Controls.Add(this.txt_adres);
            this.grp_apartman_bilgileri.Controls.Add(this.txt_blok);
            this.grp_apartman_bilgileri.Controls.Add(this.txt_apartman_adı);
            this.grp_apartman_bilgileri.Controls.Add(this.label4);
            this.grp_apartman_bilgileri.Controls.Add(this.label3);
            this.grp_apartman_bilgileri.Controls.Add(this.label2);
            this.grp_apartman_bilgileri.Controls.Add(this.label1);
            this.grp_apartman_bilgileri.Location = new System.Drawing.Point(12, 66);
            this.grp_apartman_bilgileri.Name = "grp_apartman_bilgileri";
            this.grp_apartman_bilgileri.Size = new System.Drawing.Size(510, 361);
            this.grp_apartman_bilgileri.TabIndex = 3;
            this.grp_apartman_bilgileri.TabStop = false;
            this.grp_apartman_bilgileri.Text = "Apartman Düzenleme";
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(33, 301);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(102, 41);
            this.btn_temizle.TabIndex = 0;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(141, 301);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(102, 41);
            this.btn_guncelle.TabIndex = 0;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(249, 301);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(102, 41);
            this.btn_sil.TabIndex = 0;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txt_daire_sayısı
            // 
            this.txt_daire_sayısı.Location = new System.Drawing.Point(127, 181);
            this.txt_daire_sayısı.Name = "txt_daire_sayısı";
            this.txt_daire_sayısı.Size = new System.Drawing.Size(137, 26);
            this.txt_daire_sayısı.TabIndex = 2;
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(127, 149);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(137, 26);
            this.txt_adres.TabIndex = 2;
            // 
            // txt_blok
            // 
            this.txt_blok.Location = new System.Drawing.Point(127, 117);
            this.txt_blok.Name = "txt_blok";
            this.txt_blok.Size = new System.Drawing.Size(137, 26);
            this.txt_blok.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Daire Sayısı:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adres:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Blok:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(571, 66);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(725, 361);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(809, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "İşlem yapmak İçin veriyi alttan seçiniz.";
            // 
            // apartman_islemlerii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 576);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.grp_apartman_bilgileri);
            this.Name = "apartman_islemlerii";
            this.Text = "apartman_islemleri";
            this.Load += new System.EventHandler(this.apartman_islemlerii_Load);
            this.grp_apartman_bilgileri.ResumeLayout(false);
            this.grp_apartman_bilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_apartman_adı;
        private System.Windows.Forms.GroupBox grp_apartman_bilgileri;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txt_daire_sayısı;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_blok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label label5;
    }
}