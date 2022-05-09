using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartman_Yonetimi_ms
{
    public partial class yonetici_panel : Form
    {
        public yonetici_panel()
        {
            InitializeComponent();
        }

        private void duyuruYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yonetici_tab_apge ChildForm = new yonetici_tab_apge();
            ChildForm.MdiParent = this;

            ChildForm.Show();

        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yonetici_tab_apge ChildForm = new yonetici_tab_apge(); 
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void sakinÖdemeleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yonetici_tab_apge ChildForm = new yonetici_tab_apge();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void yonetici_panel_Load(object sender, EventArgs e)
        {

        }
    }
}
