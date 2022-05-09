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
    public partial class istatistikler : Form
    {
        public istatistikler()
        {
            InitializeComponent();
        }

        Apartman_yonetimi_msEntities db = new Apartman_yonetimi_msEntities();

        void kullanici_sayisi()
        {
            try
            {
                var list = db.kullanicis.Count();

                textBox1.Text = Convert.ToString(list);
                lbl_kullanici_sayisi.Text = textBox1.Text;
            }
            catch (Exception)
            {

                MessageBox.Show("Kullanıcı sayısında hata meydana geldi.");
            }
        }

        void odenen_borc()
        {
            
        }

        void toplam_borc()
        {
            


        }
        private void istatistikler_Load(object sender, EventArgs e)
        {
            kullanici_sayisi(); 
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_kullanici_sayisi_Click(object sender, EventArgs e)
        {

        }
    }
}
