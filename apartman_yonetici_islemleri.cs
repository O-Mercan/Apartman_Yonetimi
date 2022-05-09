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
    public partial class apartman_yonetici_islemleri : Form
    {
        public apartman_yonetici_islemleri()
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
        int gelenID = Form1.kullanıcıID1;
        int apartmanID;

        int daire_No;

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_kullanici_ekle_Click(object sender, EventArgs e)
        {
            if (txt_mail.Text.Contains("@") && txt_mail.Text.Contains(".com"));
            {
                kullanici yeni_kullanici = new kullanici();
                yeni_kullanici.tc_no = msd_tcno.Text;
                yeni_kullanici.ad = txt_isim.Text;
                yeni_kullanici.soyad = txt_soyisim.Text;
                yeni_kullanici.telefon = msd_telefon.Text;
                yeni_kullanici.apartman_id = Convert.ToInt32(cmb_apartman_id.SelectedValue);
                yeni_kullanici.daire_no = cmb_daire.Text;
                yeni_kullanici.email = txt_mail.Text;
                yeni_kullanici.ev_durumu = cmb_durum.Text;
                yeni_kullanici.rol = cmb_rol.Text;
                yeni_kullanici.sifre = txt_sifre.Text;

                db.kullanicis.Add(yeni_kullanici);

                int sonuc = db.SaveChanges();
                if(sonuc == 1)
                {
                    MessageBox.Show("Kayıt başarılı bir şekilde eklendi");
                }
                else
                {
                    MessageBox.Show("Kayıt oluşturulurken hata meydana geldi.");
                }

                if(cmb_rol.Text == "Admin" | cmb_rol.Text == "Apartman Yöneticisi")
                {
                    if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
                    {
                        yetki_gelir = 1;
                    }
                    else
                    {
                        yetki_gelir = 0;
                    }
                    if(checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
                    {
                        yetki_gider = 1;
                    }
                    else
                    {
                        yetki_gider = 0;
                    }
                    if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
                    {
                        yetki_kasa = 1;
                    }
                    else
                    {
                        yetki_kasa = 0;
                    }
                    if (checkedListBox1.GetItemCheckState(3) == CheckState.Checked)
                    {
                        yetki_borc = 1;
                    }
                    else
                    {
                        yetki_borc = 0;
                    }
                    if (checkedListBox1.GetItemCheckState(4) == CheckState.Checked)
                    {
                        yetki_daire = 1;
                    }
                    else
                    {
                        yetki_daire = 0;
                    }
                    if (checkedListBox1.GetItemCheckState(5) == CheckState.Checked)
                    {
                        yetki_kullanici = 1;
                    }
                    else
                    {
                        yetki_kullanici = 0;
                    }

                    yetki yetkilendir = new yetki();
                    yetkilendir.borc_islemleri = yetki_borc;
                    yetkilendir.daire_islemleri = yetki_daire;
                    yetkilendir.gelir_islemleri = yetki_gelir;
                    yetkilendir.gider_islemleri = yetki_gider;
                    yetkilendir.kasa_islemleri = yetki_kasa;
                    yetkilendir.kullanici_islemleri = yetki_kullanici;
                    yetkilendir.tc_no = msd_tcno.Text;

                    db.yetkis.Add(yetkilendir);
                    db.SaveChanges();

                }
            }
        }


       
        private void apartman_yonetici_islemleri_Load(object sender, EventArgs e)
        {
            

            dataGridView1.DataSource = db.kullanicis.ToList();
            
            this.kullaniciTableAdapter.Fill(this.apartman_yonetimi_msDataSet.kullanici);

            cmb_rol.Items.Add("Admin");
            cmb_rol.Items.Add("Yönetici");
            doldurApartman();
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
                        cmb_apartman_id.Items.Add(item.aparman_adi);
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
                cmb_daire.Items.Clear();
                var daire = db.apartman_islemleri.Where(x => x.aparman_adi == cmb_apartman_id.SelectedItem.ToString()).FirstOrDefault();
                if (daire.aparman_adi == cmb_apartman_id.SelectedItem.ToString())
                {
                    for (int i = 1; i < daire.daire_sayisi.Value+1; i++)
                    {
                        cmb_daire.Items.Add(i);
                    }
                    apartmanID = daire.id;
                    doldurkullanici(apartmanID, daire_No);
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
                listBox1.Items.Clear();
               
                var apt = db.kullanicis.ToList();

                listBox1.Items.Add("TC: \t \t Ad: \t Soyad: \t Daire: \t Ev Durumu: \t Rol:");
                foreach (var item in apt)
                {
                    if (item.apartman_id==apartmanID)
                    {
                        listBox1.Items.Add(item.tc_no + "\t"+item.ad+"\t"+item.soyad+"\t"+item.daire_no+"\t"+item.ev_durumu+"\t\t"+item.rol);
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Listelerken hata oluştu.");
            }
        }

        public void kullanici2()
        {
            try
            {
                var list = db.kullanicis.ToList();

                dataGridView1.DataSource = list;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;

                dataGridView1.Columns[1].HeaderText = "TC Kimlik";
                dataGridView1.Columns[2].HeaderText = "İsim";
                dataGridView1.Columns[3].HeaderText = "Soyisim";
                dataGridView1.Columns[4].HeaderText = "Email";
                dataGridView1.Columns[5].HeaderText = "Telefon No";
                dataGridView1.Columns[6].HeaderText = "Apartman No";
                dataGridView1.Columns[7].HeaderText = "Daire";
                dataGridView1.Columns[8].HeaderText = "Ev Durumu";




            }
            catch (Exception)
            {

                throw;
            }
        }
        private void cmb_apartman_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoldurDaire();
        }

        private void cmb_rol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void apartman_yoneticisi_yap_Click(object sender, EventArgs e)
        {
            kullanici guncelle = new kullanici();

            var secilen = listBox1.SelectedItem.ToString();
            var deger = secilen.Substring(0, 11);
            var gelen_kullanici = db.kullanicis.Where(x => x.tc_no == deger).FirstOrDefault();
            gelen_kullanici.rol = "Yönetici";
            db.SaveChanges();
        }

        private void btn_apartman_yoneticliginden_cikar_Click(object sender, EventArgs e)
        {
            kullanici guncelle = new kullanici();

            var secilen = listBox1.SelectedItem.ToString();
            var deger = secilen.Substring(0, 11);
            var gelen_kullanici = db.kullanicis.Where(x => x.tc_no == deger).FirstOrDefault();
            gelen_kullanici.rol = "Sakin";
            db.SaveChanges();
        }

        private void btn_yetki_degistir_Click(object sender, EventArgs e)
        {

            var kullanici_getir = db.yetkis.Where(x => x.tc_no == txt_tc_no.Text).FirstOrDefault();




            if (checkedListBox3.GetItemCheckState(0) == CheckState.Checked)
            {
                yetki_gelir = 1;
            }
            else
            {
                yetki_gelir = 0;
            }
            if (checkedListBox3.GetItemCheckState(1) == CheckState.Checked)
            {
                yetki_gider = 1;
            }
            else
            {
                yetki_gider = 0;
            }
            if (checkedListBox3.GetItemCheckState(2) == CheckState.Checked)
            {
                yetki_kasa = 1;
            }
            else
            {
                yetki_kasa = 0;
            }
            if (checkedListBox3.GetItemCheckState(3) == CheckState.Checked)
            {
                yetki_borc = 1;
            }
            else
            {
                yetki_borc = 0;
            }
            if (checkedListBox3.GetItemCheckState(4) == CheckState.Checked)
            {
                yetki_daire = 1;
            }
            else
            {
                yetki_daire = 0;
            }
            if (checkedListBox3.GetItemCheckState(5) == CheckState.Checked)
            {
                yetki_kullanici = 1;
            }
            else
            {
                yetki_kullanici = 0;
            }

            kullanici_getir.borc_islemleri = yetki_borc;
            kullanici_getir.daire_islemleri = yetki_daire;
            kullanici_getir.gelir_islemleri = yetki_gelir;
            kullanici_getir.gider_islemleri= yetki_gider;
            kullanici_getir.kasa_islemleri = yetki_kasa;
            kullanici_getir.kullanici_islemleri = yetki_kullanici;

            db.SaveChanges();
            MessageBox.Show("Yetki değişikliği gerçekleştirildi.");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            

            try
            {
                var tc = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                var sil = db.kullanicis.Where(x => x.tc_no == tc).FirstOrDefault();
                db.kullanicis.Remove(sil);
                db.SaveChanges();
                MessageBox.Show("Silme işlemi başarılı");
                kullanici2();
            }
            catch (Exception)
            {

                MessageBox.Show("Silme işlemi yapılırken hata oluştu.");
            }


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var secili_tc = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_tc_no.Text = secili_tc;
                tabControl1.SelectedTab = tabPage2;
            }
            catch (Exception)
            {

                MessageBox.Show("Listeleme hatası");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int apt_id;
            string apartman_adi = "";
            try
            {
                var secili_tc = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                var kullanici_getir = db.kullanicis.Where(x=>x.tc_no == secili_tc).FirstOrDefault();

                apt_id = kullanici_getir.apartman_id.Value;
                var apt = db.apartman_islemleri.Where(x => x.id == apt_id).FirstOrDefault();
                Convert.ToBoolean(apartman_adi == apt.aparman_adi).ToString(); 
            }
            catch (Exception)
            {

                MessageBox.Show("Listeleme hatası");
            }

            maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

            tabControl1.SelectedTab = tabPage4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var tc = maskedTextBox2.Text;
                var kullanici_getir = db.kullanicis.Where(x => x.tc_no == tc).FirstOrDefault();
                kullanici_getir.ad = textBox7.Text;
                kullanici_getir.tc_no = maskedTextBox2.Text;
                kullanici_getir.soyad = textBox6.Text;
                kullanici_getir.email = textBox5.Text;
                kullanici_getir.telefon = maskedTextBox1.Text;
                kullanici_getir.daire_no = comboBox4.Text;
                kullanici_getir.ev_durumu = comboBox2.Text;
                kullanici_getir.sifre = textBox4.Text;

                db.SaveChanges();
                MessageBox.Show("Güncelleme başarılı.");
                kullanici2();
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb_durum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_daire_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_soyisim_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_isim_TextChanged(object sender, EventArgs e)
        {

        }

        private void msd_telefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void msd_tcno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        public void dinamik_yetki()
        {
            
                var list2 = db.apartman_islemleri.OrderBy(x => x.id).ToList();
                int i = 0;
                int eklenen_butonlar_Height = 80;
                int soldan = 0;
                int ustten = 0;

                foreach(var item in list2)
                {
                    Button btn = new Button();
                    Name = "btn"+(i+1).ToString();
                    btn.ForeColor = Color.Black;
                    btn.Text=item.aparman_adi.ToString();
                    btn.Size = new System.Drawing.Size(100, 50);
                    btn.Font = new Font(btn.Font.Name,btn.Font.Size,FontStyle.Bold);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.TextAlign=ContentAlignment.MiddleLeft;
                    //btn.Image = Apartman_Yonetimi_ms.Properties.Resources.ev_resmi;
                    btn.ImageAlign = ContentAlignment.MiddleRight;
                    btn.Tag = Convert.ToInt32(item.id);
                    btn.Click += Btn_Click;
                    tabPage5.Controls.Add(btn);

                    i++;
                    ustten = (btn.Height * (eklenen_butonlar_Height / btn.Height));
                    eklenen_butonlar_Height+=btn.Height;

                    switch (eklenen_butonlar_Height>tabPage5.Height)
                    {
                        case true:
                            ustten = 0;
                            soldan += btn.Width;
                            eklenen_butonlar_Height = btn.Height;
                            break;
                    }

                    btn.Location = new Point(soldan + 10, ustten + 10);
                }
            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            apartmanID = int.Parse(btn.Tag.ToString());
            panel5.Show();

            dinamik_daire();
        }

        public void dinamik_daire()
        {
            var list = db.kullanicis.ToList();
            int i = 0;
            int eklenen_butonlar_Height = 80;
            int soldan = 0;
            int ustten = 0;

            foreach (var item in list)
            {
                Button btn = new Button();
                Name = "btn1_"+(i+1).ToString();
                btn.ForeColor = Color.Black;
                btn.Text = "Daire Tipi: " + item.ev_durumu + "Daire No: " + item.daire_no;
                btn.Size = new System.Drawing.Size(100, 50);
                btn.Font = new Font(btn.Font.Name,btn.Font.Size,FontStyle.Bold);
                btn.FlatStyle = FlatStyle.Flat;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                //btn.Image = Apartman_Yonetimi_ms.Properties.Resources.ev_resmi;
                btn.ImageAlign= ContentAlignment.MiddleRight;
                //btn.Tag = Convert.ToInt32(item.daire_no);
                btn.Click += Btn_Click2;
                panel5.Controls.Add(btn);
                i++;


                ustten = (btn.Height * (eklenen_butonlar_Height / btn.Height));
                eklenen_butonlar_Height += btn.Height;

                switch (eklenen_butonlar_Height>tabPage5.Height)
                {
                    case true:
                        soldan += btn.Width;
                        eklenen_butonlar_Height = btn.Height;
                        break;

                }

                btn.Location = new Point(soldan + 10, ustten + 10);
            }
        }

        private void Btn_Click2(object sender , EventArgs e)
        {
            listBox1.Items.Clear();

            Button btn = sender as Button;
            
            doldurkullanici(daire_No, apartmanID);

            groupBox1.Visible = true;
            
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            groupBox1.Visible = false;
            panel5.Controls.Clear();
            panel5.Visible = false;
            dinamik_yetki();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
