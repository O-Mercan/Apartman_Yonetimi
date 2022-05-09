using Apartman_Yonetimi_ms.Models_db;
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
    public partial class admin_paneli : Form
    {
        public admin_paneli()
        {
            InitializeComponent();
        }

        Apartman_yonetimi_msEntities db = new Apartman_yonetimi_msEntities();

        public static string Yetki = "";
        public static string yetki_kullanici = "0";
        public static string yetki_borc = "0";
        public static string yetki_daire = "0";
        public static string yetki_gelir = "0";
        public static string yetki_gider = "0";
        public static string yetki_kasa = "0";
        private string password = "1";
        private void admin_kısmı_Load(object sender, EventArgs e)
        {
            doldur_yetki();
        }

        public void doldur_yetki()
        {
            var Giris = db.yetkis.Where(x=>x.tc_no == Form1.giris).FirstOrDefault();
            yetki_kullanici = Giris.kullanici_islemleri.ToString();
            yetki_kasa = Giris.kasa_islemleri.ToString();
            yetki_gider = Giris.gider_islemleri.ToString();
            yetki_gelir=Giris.gelir_islemleri.ToString();   
            yetki_daire = Giris.daire_islemleri.ToString();
            yetki_borc = Giris.borc_islemleri.ToString();
        }

        private void apartmanYöneticiİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(yetki_kullanici=="1")
            {
                apartman_yonetici_islemleri ChildForm = new apartman_yonetici_islemleri();

                ChildForm.MdiParent = this;
                ChildForm.Show();
            }
            else
            {
                MessageBox.Show("Giriş Yetkiniz yoktur.");
            }
        }

        private void apartmanİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            apartman_islemlerii ChildForm = new apartman_islemlerii();
            ChildForm.MdiParent= this;

            ChildForm.Show();
        }

        private void istatistiklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            istatistikler ChildForm = new istatistikler();
            ChildForm.MdiParent = this;

            ChildForm.Show();
        }

        private void kategoriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //kategori_islemleri ChildForm = new kategori_islemleri();
            //ChildForm.MdiParent = this;

            //ChildForm.Show();
        }

        private void bilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bilgiler ChildForm = new bilgiler();
            ChildForm.MdiParent = this;

            ChildForm.Show();
        }
    }
}
