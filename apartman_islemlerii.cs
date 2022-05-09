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
    public partial class apartman_islemlerii : Form
    {
        public apartman_islemlerii()
        {
            InitializeComponent();
        }

        Apartman_yonetimi_msEntities db = new Apartman_yonetimi_msEntities();
        void temizler()
        {
            txt_apartman_adı.Text = "";
            txt_blok.Text = "";
            txt_adres.Text = "";
            txt_daire_sayısı.Text = "";
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            apartman_islemleri yeni =new apartman_islemleri();
            yeni.aparman_adi = txt_apartman_adı.Text;
            yeni.blok = txt_blok.Text;  
            yeni.adres = txt_adres.Text;
            //yeni.daire_sayisi = Convert.ToInt32(txt_daire_sayısı);

            db.apartman_islemleri.Add(yeni);
            db.SaveChanges();
            MessageBox.Show("Apartman Eklendi");
            
        }

        void apartman_doldur()
        {
            try
            {
                var list = db.apartman_islemleri.ToList();
                dataGridView2.DataSource = list;
                dataGridView2.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
                dataGridView2.RowHeadersVisible = false;
                //dataGridView2.Columns[5].Visible = false;
                dataGridView2.Columns[0].Visible = false;


                dataGridView2.Columns[1].HeaderText = "Apartman Adı";
                dataGridView2.Columns[2].HeaderText = "Blok";
                dataGridView2.Columns[3].HeaderText = "Adres";
                dataGridView2.Columns[4].HeaderText = "Daire Sayısı";
                dataGridView2.Columns[5].HeaderText = "Yönetici ID";




            }
            catch (Exception)
            {

                MessageBox.Show("Listelerken hata oluştu.");
            }

        }

        private void apartman_islemlerii_Load(object sender, EventArgs e)
        {
            apartman_doldur();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
