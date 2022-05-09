namespace Apartman_Yonetimi_ms
{
    partial class admin_paneli
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.apartmanYöneticiİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartmanİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlCeDataAdapter1 = new System.Data.SqlServerCe.SqlCeDataAdapter();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartmanYöneticiİşlemleriToolStripMenuItem,
            this.apartmanİşlemleriToolStripMenuItem,
            this.istatistiklerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // apartmanYöneticiİşlemleriToolStripMenuItem
            // 
            this.apartmanYöneticiİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.apartmanYöneticiİşlemleriToolStripMenuItem.Name = "apartmanYöneticiİşlemleriToolStripMenuItem";
            this.apartmanYöneticiİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(307, 36);
            this.apartmanYöneticiİşlemleriToolStripMenuItem.Text = "Apartman Admin İşlemleri";
            this.apartmanYöneticiİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.apartmanYöneticiİşlemleriToolStripMenuItem_Click);
            // 
            // apartmanİşlemleriToolStripMenuItem
            // 
            this.apartmanİşlemleriToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.apartmanİşlemleriToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.apartmanİşlemleriToolStripMenuItem.Name = "apartmanİşlemleriToolStripMenuItem";
            this.apartmanİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(184, 36);
            this.apartmanİşlemleriToolStripMenuItem.Text = "Apartman Ekle";
            this.apartmanİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.apartmanİşlemleriToolStripMenuItem_Click);
            // 
            // istatistiklerToolStripMenuItem
            // 
            this.istatistiklerToolStripMenuItem.Name = "istatistiklerToolStripMenuItem";
            this.istatistiklerToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.istatistiklerToolStripMenuItem.Text = "Toplam Kullanıcı Sayısı";
            this.istatistiklerToolStripMenuItem.Click += new System.EventHandler(this.istatistiklerToolStripMenuItem_Click);
            // 
            // sqlCeDataAdapter1
            // 
            this.sqlCeDataAdapter1.DeleteCommand = null;
            this.sqlCeDataAdapter1.InsertCommand = null;
            this.sqlCeDataAdapter1.SelectCommand = null;
            this.sqlCeDataAdapter1.UpdateCommand = null;
            // 
            // admin_paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 546);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "admin_paneli";
            this.Text = "Admin Sayfası";
            this.Load += new System.EventHandler(this.admin_kısmı_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem apartmanYöneticiİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apartmanİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istatistiklerToolStripMenuItem;
        private System.Data.SqlServerCe.SqlCeDataAdapter sqlCeDataAdapter1;
    }
}