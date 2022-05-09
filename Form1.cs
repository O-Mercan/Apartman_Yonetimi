using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Apartman_Yonetimi_ms.Models_db;

namespace Apartman_Yonetimi_ms
{
    public partial class Form1 : Form
    {
        
        

        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            
        }

        public static string giris = "";
        public static string sifre = "";
        public static string Yetki = "";
        public static string apartman_id ="0";
        public static string yetki_kullanici = "0";
        public static string yetki_borc = "0";
        public static string yetki_daire = "0";
        public static string yetki_gelir = "0";
        public static string yetki_gider = "0";
        public static string yetki_kasa = "0";
        public static int kullanıcıID1;
        public static int kullanıcıID2;
        public static int kullanıcıID3;


        Apartman_yonetimi_msEntities db = new Apartman_yonetimi_msEntities();

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }


        private void btn_admin_Click(object sender, EventArgs e)
        {

            

            try
            {
                var Giris = db.kullanicis.Where(x => x.tc_no == txt_admin_kullanici_adi.Text && x.sifre == txt_admin_kullanici_sifre.Text).FirstOrDefault();

                if (Giris == null)
                {
                    MessageBox.Show("Bu alana giriş yetkiniz yoktur.");

                }
                else if (Giris.rol == "Admin                                             ")
                {
                    giris = txt_admin_kullanici_adi.Text;
                    sifre = txt_admin_kullanici_sifre.Text;
                    Yetki = Giris.tc_no.ToString();
                    apartman_id = Giris.apartman_id.ToString();

                    kullanıcıID1 = Giris.id;

                    if (Yetki != null)
                    {
                        var yetkili = db.yetkis.Where(x => x.tc_no == Yetki).FirstOrDefault();

                        if (yetkili != null)
                        {
                            yetki_kullanici = yetkili.kullanici_islemleri.ToString();
                            yetki_borc = yetkili.borc_islemleri.ToString();
                            yetki_daire = yetkili.daire_islemleri.ToString();
                            yetki_gelir = yetkili.gelir_islemleri.ToString();
                            yetki_gider = yetkili.gider_islemleri.ToString();
                            yetki_kasa = yetkili.kasa_islemleri.ToString();

                        }


                        admin_paneli ynt = new admin_paneli();
                        ynt.Show();
                        this.Hide();
                    }


                    else if (Giris.rol == "Yönetici")
                    {
                        MessageBox.Show("Admin değilsiniz! Lütfen yönetici girişi yapınız");
                    }
                    else if (Giris.rol == "Sakin")
                    {
                        MessageBox.Show("Admin değilsiniz! Lütfen sakin girişi yapınız");
                    }
                    else
                    {
                        MessageBox.Show("Bu alanlara giriş yetkiniz yoktur.");
                    }

                }
            }

            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen bir hata ile karşılaşıldı.");
            }
        }

            private void button5_Click(object sender, EventArgs e)
        {


            try
            {
                var Giris = db.kullanicis.Where(x => x.tc_no == txt_yonetici_kullanici_adi.Text && x.sifre == txt_yonetici_kullanici_sifre.Text).FirstOrDefault();

                if (Giris == null)
                {
                    MessageBox.Show("Bu alanlara giriş yetkiniz yoktur.");

                }
                else if (Giris.rol == "Yönetici                                          ")
                {
                    giris = txt_admin_kullanici_adi.Text;
                    sifre = txt_admin_kullanici_sifre.Text;
                    Yetki = Giris.tc_no.ToString();
                    apartman_id = Giris.apartman_id.ToString();

                    kullanıcıID2 = Giris.id;


                    if (Yetki != null)
                    {
                        var yetkili = db.yetkis.Where(x => x.tc_no == Yetki).FirstOrDefault();

                        if (yetkili != null)
                        {
                            yetki_kullanici = yetkili.kullanici_islemleri.ToString();
                            yetki_borc = yetkili.borc_islemleri.ToString();
                            yetki_daire = yetkili.daire_islemleri.ToString();
                            yetki_gelir = yetkili.gelir_islemleri.ToString();
                            yetki_gider = yetkili.gider_islemleri.ToString();
                            yetki_kasa = yetkili.kasa_islemleri.ToString();
                        }

                        yonetici_panel yntc = new yonetici_panel();
                        yntc.Show();
                        this.Hide();
                    }


                    else if (Giris.rol == "Admin")
                    {
                        MessageBox.Show("Yönetici değilsiniz! Lütfen Admin girişi yapınız");
                    }
                    else if (Giris.rol == "Sakin")
                    {
                        MessageBox.Show("Yönetici değilsiniz! Lütfen sakin girişi yapınız");
                    }
                    else
                    {
                        MessageBox.Show("Bu alanlara giriş yetkiniz yoktur.");
                    }

                }
            }

            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen bir hata ile karşılaşıldı.");
            }
        }

        private void btn_daire_sakin_girisi_Click(object sender, EventArgs e)
        {
            try
            {
                var Giris = db.kullanicis.Where(x => x.tc_no == txt_sakin_kullanici_adi.Text && x.sifre == txt_sakin_kullanici_sifre.Text).FirstOrDefault();

                if (Giris == null)
                {
                    MessageBox.Show("Bu alanlara giriş yetkiniz yoktur.");

                }
                else if (Giris.rol == "Sakin                                             ")
                {
                    giris = txt_admin_kullanici_adi.Text;
                    sifre = txt_admin_kullanici_sifre.Text;
                    Yetki = Giris.tc_no.ToString();
                    apartman_id = Giris.apartman_id.ToString();

                    kullanıcıID3 = Giris.id;

                    if (Yetki != null)
                    {
                        var yetkili = db.yetkis.Where(x => x.tc_no == Yetki).FirstOrDefault();

                        if (yetkili != null)
                        {
                            yetki_kullanici = yetkili.kullanici_islemleri.ToString();
                            yetki_borc = yetkili.borc_islemleri.ToString();
                            yetki_daire = yetkili.daire_islemleri.ToString();
                            yetki_gelir = yetkili.gelir_islemleri.ToString();
                            yetki_gider = yetkili.gider_islemleri.ToString();
                            yetki_kasa = yetkili.kasa_islemleri.ToString();
                        }

                       daire_sakini_panel daire_sakini = new daire_sakini_panel();
                        daire_sakini.Show();
                        this.Hide();

                    }


                    else if (Giris.rol == "Admin")
                    {
                        MessageBox.Show("Yönetici değilsiniz! Lütfen Admin girişi yapınız");
                    }
                    else if (Giris.rol == "Yönetici")
                    {
                        MessageBox.Show("Sakin değilsiniz! Lütfen yönetici girişi yapınız");
                    }
                    else
                    {
                        MessageBox.Show("Bu alanlara giriş yetkiniz yoktur.");
                    }

                }}
                catch (Exception)
            {
                MessageBox.Show("Bilinmeyen bir hata ile karşılaşıldı.");
            }
        }

        private void admin_sifre_goster_CheckedChanged(object sender, EventArgs e)
        {

            
       // if (admin_sifre_goster_CheckedChanged.Checked)
        //{
         //   txt_admin_kullanici_sifre.PasswordChar = '\0';

        //}
          //  else
            //{
              //  txt_admin_kullanici_sifre.PasswordChar = '*';

            //}
        }

        private void yonetici_sifre_göster_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)
            //{
              //  txt_yonetici_kullanici_adi.PasswordChar = '\0';

            //}
            //else
            //{
              //  txtSifre.PasswordChar = '*';


            //}
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image, 500, 500);
            pictureBox1.Image = bmp;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void uye_sifre_goster_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.CheckState == CheckState.Checked)
            //{
            //    txt_sakin_kullanici_sifre.UseSystemPasswordChar = true;
            //    checkBox1.Text = "Şifre Gizle";
            //}
            //else if (checkBox1.CheckState == CheckState.Unchecked)
            //{
            //    txt_sakin_kullanici_sifre.UseSystemPasswordChar = false;
            //    checkBox1.Text = "şifre göster";

            //}

            

        }

        private void btn_sakin_goster_Click(object sender, EventArgs e)
        {
            if (txt_sakin_kullanici_sifre.PasswordChar.ToString() == "*")
            {
                txt_sakin_kullanici_sifre.PasswordChar = char.Parse("\0");
                btn_sakin_goster.Text = "Gizle";
            }
            else
            {
                txt_sakin_kullanici_sifre.PasswordChar = char.Parse("*");
                btn_sakin_goster.Text = "Göster";
            }
        }

        private void btn_admin_goster_Click(object sender, EventArgs e)
        {
            if (txt_admin_kullanici_sifre.PasswordChar.ToString() == "*")
            {
                txt_admin_kullanici_sifre.PasswordChar = char.Parse("\0");
                btn_admin_goster.Text = "Gizle";
            }
            else
            {
                txt_admin_kullanici_sifre.PasswordChar = char.Parse("*");
                btn_admin_goster.Text = "Göster";
            }
        }

        private void btn_yonetici_goster_Click(object sender, EventArgs e)
        {
            if (txt_yonetici_kullanici_sifre.PasswordChar.ToString() == "*")
            {
                txt_yonetici_kullanici_sifre.PasswordChar = char.Parse("\0");
                btn_yonetici_goster.Text = "Gizle";
            }
            else
            {
                txt_yonetici_kullanici_sifre.PasswordChar = char.Parse("*");
                btn_yonetici_goster.Text = "Göster";
            }
        }
    }
}
