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
    public partial class daire_sakini_tab_page : Form
    {
        public daire_sakini_tab_page()
        {
            InitializeComponent();
            

          
        }

        Apartman_yonetimi_msEntities db = new Apartman_yonetimi_msEntities();

        int gelenID = Form1.kullanıcıID3;

        private void daire_sakini_tab_page_Load(object sender, EventArgs e)
        {

            doldur_duyuru_icerik();
            doldur_duyuru_konu();
            kisisel_bilgiler();
            kisi_bilgisi();
            apartman_bilgisi();
        }

        private void kisisel_bilgiler()
        {
            
        }

        private void doldur_duyuru_konu()
        {


            try
            {
                listBox1.Items.Clear();

                var duyuru_goster = db.duyurus1.ToList();
                listBox1.Items.Add(("Konu:"));


                foreach (var item in duyuru_goster)
                {

                    listBox1.Items.Add(item.duyuru_konusu);


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Listelerken hata oluştu.");
            }
        }


        private void doldur_duyuru_icerik()
        {
            try
            {
                listBox3.Items.Clear();

                var duyuru_goster_icerik = db.duyurus1.ToList();
                listBox3.Items.Add(("İçerik:"));


                foreach (var item in duyuru_goster_icerik)
                {

                    listBox3.Items.Add(item.duyuru_adi);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Listelerken hata oluştu.");
            }
        }

        private void btn_odeme_Click(object sender, EventArgs e)
        {
            giderler borc_odeme = new giderler();
            
            borc_odeme.kategori = txt_kategori.Text;
            borc_odeme.aciklama = txt_tc.Text;
            borc_odeme.tutar = txt_tutar.Text;
            
            

            db.giderlers.Add(borc_odeme);

            int sonuc = db.SaveChanges();
            if (sonuc == 1)
            {
                MessageBox.Show("Kayıt başarılı bir şekilde eklendi");
            }
            else
            {
                MessageBox.Show("Kayıt oluşturulurken hata meydana geldi.");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void kisi_bilgisi()
        {
            var kisi = db.kullanicis.Where(x => x.id == gelenID).FirstOrDefault();

            
            lbltc.Text = kisi.tc_no;
            lblad.Text = kisi.ad;
            lblsoyad.Text = kisi.soyad;
            lblmail.Text = kisi.email;
            lbltel.Text = kisi.telefon;
            lblsifre.Text = kisi.sifre;

        }

        private void apartman_bilgisi()
        {
            var kisi = db.kullanicis.Where(x => x.id == gelenID).FirstOrDefault();
            var kisi1 = db.apartman_islemleri.Where(x=>x.id==kisi.apartman_id).FirstOrDefault();

            lbldaire.Text = kisi.daire_no;
            lblapt.Text = kisi1.aparman_adi;
            lblblok.Text = kisi1.blok;
            lbladres.Text = kisi1.adres;
        }

        private void lbladres_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
