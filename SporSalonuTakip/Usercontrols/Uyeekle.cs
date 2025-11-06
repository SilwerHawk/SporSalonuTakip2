using SporSalonuTakip.Moduller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SporSalonuTakip.Usercontrols
{
    public partial class Uyeekle : UserControl
    {
        public Uyeekle()
        {
            InitializeComponent();
            RenkDegistir renk = new RenkDegistir();
            renk.DataGridViewStilAyarla(dgvUyeler);
            UyeListesiniYukle();

            AntrenorleriYukle(); // 🔹 yeni satır
            cmbAntrenor.Text = "Seçiniz";
            cmbCinsiyet.Text = "Seçiniz";

        }
        private void UyeListesiniYukle()
        {
            Veritabanislemleri vt = new Veritabanislemleri();
            DataTable dt = vt.UyeListele();

            dgvUyeler.DataSource = dt; // tabloyu doğrudan bağla

            // Başlık isimlerini düzenle (isteğe bağlı)
            dgvUyeler.Columns["Id"].HeaderText = "Üye No";
            dgvUyeler.Columns["Ad"].HeaderText = "Ad";
            dgvUyeler.Columns["Soyad"].HeaderText = "Soyad";
            dgvUyeler.Columns["Yas"].HeaderText = "Yaş";
            dgvUyeler.Columns["Cinsiyet"].HeaderText = "Cinsiyet";
            dgvUyeler.Columns["Boy"].HeaderText = "Boy (cm)";
            dgvUyeler.Columns["Kilo"].HeaderText = "Kilo (kg)";
            dgvUyeler.Columns["Antrenor"].HeaderText = "Antrenör";
        }
        private void AntrenorleriYukle()
        {
            try
            {
                Veritabanislemleri vt = new Veritabanislemleri();
                DataTable antTablo = vt.AntrenorAdSoyadListesiGetir();

                cmbAntrenor.DataSource = antTablo;
                cmbAntrenor.DisplayMember = "AdSoyad"; // kullanıcıya görünen
                cmbAntrenor.ValueMember = "Id";        // arka planda tutulacak
                cmbAntrenor.SelectedIndex = -1;         // varsayılan olarak boş bırak
            }
            catch (Exception ex)
            {
                MessageBox.Show("Antrenör listesi yüklenirken hata: " + ex.Message,
                    "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Yeni üye nesnesi oluştur
                Uye yeniUye = new Uye
                {
                    Id = txtUyeNo.Text,
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Yas = int.Parse(txtYas.Text),
                    cinsiyet = cmbCinsiyet.SelectedItem?.ToString(),
                    Kilo = double.Parse(txtKilo.Text),
                    Boy = double.Parse(txtBoy.Text),
                    AntrenorAdi = cmbAntrenor.Text ?? "Yok"
                };

                // 2️⃣ Veritabanına ekle
                Veritabanislemleri vt = new Veritabanislemleri();
                vt.UyeEkle(
                    yeniUye.Id,
                    yeniUye.Ad,
                    yeniUye.Soyad,
                    yeniUye.Yas,
                    yeniUye.cinsiyet,
                    yeniUye.Boy,
                    yeniUye.Kilo,
                    yeniUye.AntrenorAdi
                );

                MessageBox.Show("Üye başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UyeListesiniYukle();
            }
            catch (ArgumentException ex)
            {
                // 3️⃣ Uye sınıfından gelen özel hatalar (örneğin “Yaş 13–50 arasında olmalı”)
                MessageBox.Show(ex.Message, "Veri Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show("Sayısal alanları (Yaş, Boy, Kilo) doğru formatta giriniz.", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // 4️⃣ Diğer tüm hatalar (veritabanı vs.)
                MessageBox.Show("Beklenmeyen hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
