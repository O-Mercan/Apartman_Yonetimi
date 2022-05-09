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
    public partial class yonetici_tab_apge : Form
    {
        public yonetici_tab_apge()
        {
            InitializeComponent();
        }

        Apartman_yonetimi_msEntities db = new Apartman_yonetimi_msEntities();

        byte yetki_gelir = 0;
        byte yetki_gider = 0;
        byte yetki_kasa = 0;
        byte yetki_borc = 0;
        byte yetki_daire = 0;
        byte yetki_kullanici = 0;
        int gelenID = Form1.kullanıcıID2;
        int apartmanID;

        int daire_No;
        private void btn_kullanici_ekle_Click(object sender, EventArgs e)
        {
            if (txt_mail1.Text.Contains("@") && txt_mail1.Text.Contains(".com")) ;
            {
                kullanici yeni_kullanici1 = new kullanici();
                yeni_kullanici1.tc_no = msd_tcno1.Text;
                yeni_kullanici1.ad = txt_isim1.Text;
                yeni_kullanici1.soyad = txt_soyisim1.Text;
                yeni_kullanici1.telefon = msd_telefon1.Text;
                yeni_kullanici1.apartman_id = Convert.ToInt32(cmb_apartman_id1.SelectedValue);
                yeni_kullanici1.daire_no = cmb_daire1.Text;
                yeni_kullanici1.email = txt_mail1.Text;
                yeni_kullanici1.ev_durumu = cmb_durum1.Text;
                yeni_kullanici1.rol = cmb_rol1.Text;
                yeni_kullanici1.sifre = txt_sifre1.Text;

                
                db.kullanicis.Add(yeni_kullanici1);

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

            
        }
        public void doldurApartman()
        {


            

            try
            {
                var apt = db.apartman_islemleri.ToList();

                foreach (var item in apt)
                {
                    if (item.yonetici_id == gelenID)
                    {
                        cmb_apartman_id1.Items.Add(item.aparman_adi);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Apartmanlar listelenirken hata oluştu.");
            }




        }
        public void DoldurDaire()
        {
            try
            {
                cmb_daire1.Items.Clear();
                var daire = db.apartman_islemleri.Where(x => x.aparman_adi == cmb_apartman_id1.SelectedItem.ToString()).FirstOrDefault();
                if (daire.aparman_adi == cmb_apartman_id1.SelectedItem.ToString())
                {
                    for (int i = 1; i < daire.daire_sayisi.Value + 1; i++)
                    {
                        cmb_daire1.Items.Add(i);
                    }
                    apartmanID = daire.id;
                    
                }

            }
            catch (Exception)
            {

                throw;
            }


        }
        public void doldurkullanici(int apartman_id, int daire_No)
        {
            try
            {
                listBox2.Items.Clear();
                
                var apt = db.kullanicis.ToList();

                listBox2.Items.Add("TC: \t \t Ad: \t Soyad: \t Daire: \t Ev Durumu: \t Rol:");
                foreach (var item in apt)
                {
                    if (item.apartman_id == apartmanID)
                    {
                        listBox2.Items.Add(item.tc_no + "\t" + item.ad + "\t" + item.soyad + "\t" + item.daire_no + "\t" + item.ev_durumu + "\t\t" + item.rol);
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Listelerken hata oluştu.");
            }
        }

        private void cmb_apartman_id1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoldurDaire();
        }

        private void yonetici_tab_apge_Load(object sender, EventArgs e)
        {
            cmb_rol1.Items.Add("Admin");
            cmb_rol1.Items.Add("Sakin");
            doldurApartman();
            doldur_duyuru_konu();
            doldur_duyuru_icerik();
            data_goster();
            kisi_bilgisi();
        }
        

        public void data_goster()
        {

            try
            {
                var list = db.giderlers.ToList();

                dataGridView4.DataSource = list;
                dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView4.RowHeadersVisible = false;
                dataGridView4.Columns[0].Visible = false;
                dataGridView4.Columns[4].Visible = false;

                dataGridView4.Columns[1].HeaderText = "Kategori";
                dataGridView4.Columns[2].HeaderText = "Tutar";
                dataGridView4.Columns[3].HeaderText = "TC";

                
                
                




            }
            catch (Exception)
            {

                throw;
            }




        }
        private void richTextBox1_duyuru_konu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_yayınla_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1_duyuru.Text.Length > 0 && richTextBox1_duyuru_konu.Text.Length > 0)
                {

                    duyuru dyr = new duyuru();
                    dyr.duyuru_konusu = richTextBox1_duyuru_konu.Text;
                    dyr.yonetici_id = gelenID.ToString();
                    dyr.duyuru_adi = richTextBox1_duyuru.Text;
                    db.duyurus1.Add(dyr);
                    db.SaveChanges();
                    MessageBox.Show("Duyuru başarıyla yayınlanmıştır!");
                    
                }
                else
                    MessageBox.Show("Lütfen bilgileri doğru bir şekilde doldurunuz!");
            }
            catch
            { }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                    
                      listBox1.Items.Add(item.duyuru_konusu );
                    

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
    }
}
