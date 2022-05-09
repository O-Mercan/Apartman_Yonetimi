namespace Apartman_Yonetimi_ms
{
    partial class istatistikler
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_kullanici_sayisi = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_kullanici_sayisi);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(32, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 514);
            this.panel1.TabIndex = 0;
            // 
            // lbl_kullanici_sayisi
            // 
            this.lbl_kullanici_sayisi.AutoSize = true;
            this.lbl_kullanici_sayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullanici_sayisi.Location = new System.Drawing.Point(698, 173);
            this.lbl_kullanici_sayisi.Name = "lbl_kullanici_sayisi";
            this.lbl_kullanici_sayisi.Size = new System.Drawing.Size(58, 64);
            this.lbl_kullanici_sayisi.TabIndex = 1;
            this.lbl_kullanici_sayisi.Text = "0";
            this.lbl_kullanici_sayisi.Click += new System.EventHandler(this.lbl_kullanici_sayisi_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(117, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(418, 64);
            this.label11.TabIndex = 1;
            this.label11.Text = "Kullanıcı Sayısı:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 704);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 10);
            this.textBox1.TabIndex = 2;
            // 
            // istatistikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 747);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "istatistikler";
            this.Text = "istatistikler";
            this.Load += new System.EventHandler(this.istatistikler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_kullanici_sayisi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
    }
}