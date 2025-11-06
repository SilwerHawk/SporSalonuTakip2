using SporSalonuTakip.Moduller;
using System;
using System.Data;
using System.Windows.Forms;

namespace SporSalonuTakip.Usercontrols
{
    public partial class Sorgulama : UserControl
    {
        private readonly Veritabanislemleri _vt = new Veritabanislemleri();

        public Sorgulama()
        {
            InitializeComponent();
            this.Load += Sorgula_Load;
            lbl_AntAdiSoyadi.Visible = false;
            lbl_AntAdiSoyadi.Visible = false;
            lbl_AntYasi.Visible = false;
            lbl_AntCinsiyeti.Visible = false;
            lbl_AntUzmanlik.Visible = false;
            lbl_AntDeneyim.Visible = false;
            lbl_UyeAdiSoyadi.Visible = false;
            lbl_UyeYasi.Visible = false;
            lbl_UyeBoyu.Visible = false;
            lbl_UyeKilosu.Visible = false;
            lbl_UyeCinsiyet.Visible = false;
        }

        private void Sorgula_Load(object sender, EventArgs e)
        {
            try
            {
                _vt.VeritabaniKontrolEt();

                // Antrenör listesi (Ad + Soyad)
                cmb_AntSorgu.DataSource = _vt.AntrenorAdSoyadListesiGetir();
                cmb_AntSorgu.DisplayMember = "AdSoyad";
                cmb_AntSorgu.ValueMember = "Id";
                cmb_AntSorgu.SelectedIndex = -1;

                // Üye listesi (Ad + Soyad)
                cmb_UyeSorgu.DataSource = _vt.UyeAdSoyadListesiGetir();
                cmb_UyeSorgu.DisplayMember = "AdSoyad";
                cmb_UyeSorgu.ValueMember = "Id";
                cmb_UyeSorgu.SelectedIndex = -1;

                dgvSorgu.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Antrenör sorgula (Ad + Soyad’a göre)
        private void btn_AntSorgula_Click(object sender, EventArgs e)
        {
            if (cmb_AntSorgu.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir antrenör seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string secilenAdSoyad = cmb_AntSorgu.Text;
            var antBilgi = _vt.AntrenorBilgiGetir(secilenAdSoyad);

            if (antBilgi == null)
            {
                MessageBox.Show("Antrenör bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Label’lara bilgileri yaz
            lbl_AntAdiSoyadi.Text = $"{antBilgi["Ad"]} {antBilgi["Soyad"]}";
            lbl_AntYasi.Text = antBilgi["Yas"].ToString();
            lbl_AntCinsiyeti.Text = antBilgi["Cinsiyet"].ToString();
            lbl_AntUzmanlik.Text = antBilgi["UzmanlikAlani"].ToString();
            lbl_AntDeneyim.Text = antBilgi["TecrubeYili"].ToString();

            // Labellerin görünürlüğünü aç
            lbl_AntAdiSoyadi.Visible = true;
            lbl_AntAdiSoyadi.Visible = true;
            lbl_AntYasi.Visible = true;
            lbl_AntCinsiyeti.Visible = true;
            lbl_AntUzmanlik.Visible = true;
            lbl_AntDeneyim.Visible = true;

            //  Bu antrenöre bağlı üyeleri getir (Ad + Soyad’a göre)
            DataTable tablo = _vt.AntrenorUyeListesi(secilenAdSoyad);
            dgvSorgu.DataSource = tablo;

            if (tablo.Rows.Count > 0)
            {
                dgvSorgu.Columns["UyeNo"].HeaderText = "Üye No";
                dgvSorgu.Columns["Ad"].HeaderText = "Ad";
                dgvSorgu.Columns["Soyad"].HeaderText = "Soyad";
                dgvSorgu.Columns["Yas"].HeaderText = "Yaş";
                dgvSorgu.Columns["Cinsiyet"].HeaderText = "Cinsiyet";
                dgvSorgu.Columns["Boy"].HeaderText = "Boy (cm)";
                dgvSorgu.Columns["Kilo"].HeaderText = "Kilo (kg)";

                new RenkDegistir().DataGridViewStilAyarla(dgvSorgu);
            }
            else
            {
                dgvSorgu.DataSource = null;
                MessageBox.Show("Bu antrenöre bağlı üye bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //  Üye sorgula (ID’ye göre)

        private void btn_UyeSorgula_Click_1(object sender, EventArgs e)
        {
            if (cmb_UyeSorgu.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir üye seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string uyeId = cmb_UyeSorgu.SelectedValue.ToString();
            var uyeBilgi = _vt.UyeBilgiGetirById(uyeId);

            if (uyeBilgi == null)
            {
                MessageBox.Show("Üye bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //  Label’lara bilgileri yaz
            lbl_UyeAdiSoyadi.Text = $"{uyeBilgi["Ad"]} {uyeBilgi["Soyad"]}";
            lbl_UyeYasi.Text = uyeBilgi["Yas"].ToString();
            lbl_UyeCinsiyet.Text = uyeBilgi["Cinsiyet"].ToString();
            lbl_UyeBoyu.Text = uyeBilgi["Boy"].ToString();
            lbl_UyeKilosu.Text = uyeBilgi["Kilo"].ToString();

            //  Labellerin görünürlüğünü aç
            lbl_UyeAdiSoyadi.Visible = true;
            lbl_UyeYasi.Visible = true;
            lbl_UyeBoyu.Visible = true;
            lbl_UyeKilosu.Visible = true;
            lbl_UyeCinsiyet.Visible = true;

            //  Üyenin haftalık programını getir
            DataTable programTablo = _vt.UyeProgramGetir(uyeId);

            if (programTablo.Rows.Count > 0)
            {
                DataTable goruntuTablo = new();
                goruntuTablo.Columns.Add("Gün");
                goruntuTablo.Columns.Add("Egzersiz");

                var row = programTablo.Rows[0];
                for (int i = 1; i <= 7; i++)
                {
                    goruntuTablo.Rows.Add($"Gün {i}", row[$"Gun{i}"].ToString());
                }

                dgvSorgu.DataSource = goruntuTablo;
                dgvSorgu.Columns[0].Width = 120;
                dgvSorgu.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                new RenkDegistir().DataGridViewStilAyarla(dgvSorgu);
            }
            else
            {
                dgvSorgu.DataSource = null;
                MessageBox.Show("Bu üyeye ait program bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    
}


