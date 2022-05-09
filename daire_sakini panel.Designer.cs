namespace Apartman_Yonetimi_ms
{
    partial class daire_sakini_panel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.duyurularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartmanBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kişiselBilgilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aidatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duyurularToolStripMenuItem,
            this.apartmanBilgileriToolStripMenuItem,
            this.kişiselBilgilerToolStripMenuItem,
            this.aidatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 63);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // duyurularToolStripMenuItem
            // 
            this.duyurularToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.duyurularToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duyurularToolStripMenuItem.Name = "duyurularToolStripMenuItem";
            this.duyurularToolStripMenuItem.Size = new System.Drawing.Size(135, 57);
            this.duyurularToolStripMenuItem.Text = "Duyurular";
            this.duyurularToolStripMenuItem.Click += new System.EventHandler(this.duyurularToolStripMenuItem_Click);
            // 
            // apartmanBilgileriToolStripMenuItem
            // 
            this.apartmanBilgileriToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.apartmanBilgileriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.apartmanBilgileriToolStripMenuItem.Name = "apartmanBilgileriToolStripMenuItem";
            this.apartmanBilgileriToolStripMenuItem.Size = new System.Drawing.Size(220, 57);
            this.apartmanBilgileriToolStripMenuItem.Text = "Apartman Bilgileri";
            this.apartmanBilgileriToolStripMenuItem.Click += new System.EventHandler(this.apartmanBilgileriToolStripMenuItem_Click);
            // 
            // kişiselBilgilerToolStripMenuItem
            // 
            this.kişiselBilgilerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kişiselBilgilerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kişiselBilgilerToolStripMenuItem.Name = "kişiselBilgilerToolStripMenuItem";
            this.kişiselBilgilerToolStripMenuItem.Size = new System.Drawing.Size(175, 57);
            this.kişiselBilgilerToolStripMenuItem.Text = "Kişisel Bilgiler";
            this.kişiselBilgilerToolStripMenuItem.Click += new System.EventHandler(this.kişiselBilgilerToolStripMenuItem_Click);
            // 
            // aidatToolStripMenuItem
            // 
            this.aidatToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aidatToolStripMenuItem.Name = "aidatToolStripMenuItem";
            this.aidatToolStripMenuItem.Size = new System.Drawing.Size(85, 57);
            this.aidatToolStripMenuItem.Text = "Aidat";
            this.aidatToolStripMenuItem.Click += new System.EventHandler(this.aidatToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // daire_sakini_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "daire_sakini_panel";
            this.Text = "Daire Sakini Sayfası";
            this.Load += new System.EventHandler(this.daire_sakini_panel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem duyurularToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem apartmanBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kişiselBilgilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aidatToolStripMenuItem;
    }
}