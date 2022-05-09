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
    public partial class daire_sakini_panel : Form
    {
        public daire_sakini_panel()
        {
            InitializeComponent();
        }

        private void duyurularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            daire_sakini_tab_page ChildForm = new daire_sakini_tab_page();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void apartmanBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            daire_sakini_tab_page ChildForm = new daire_sakini_tab_page();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void kişiselBilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            daire_sakini_tab_page ChildForm = new daire_sakini_tab_page();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void daire_sakini_panel_Load(object sender, EventArgs e)
        {

        }

        private void aidatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            daire_sakini_tab_page ChildForm = new daire_sakini_tab_page();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }
    }
}
