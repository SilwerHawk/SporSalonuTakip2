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

namespace SporSalonuTakip.Usercontrols
{
    public partial class Antrenorekle : UserControl
    {
        public Antrenorekle()
        {
            InitializeComponent();
            RenkDegistir renk = new RenkDegistir();
            renk.DataGridViewStilAyarla(dgvAntrenor);
            AntrenorListesiniYukle();
        }

        private void AntrenorListesiniYukle()
        {
            Veritabanislemleri vt = new Veritabanislemleri();
            DataTable dt = vt.AntrenorListele();

            dgvAntrenor.DataSource = dt;

            // Başlık isimlerini düzenle (isteğe bağlı)
            dgvAntrenor.Columns["Id"].HeaderText = "Antrenör No";
            dgvAntrenor.Columns["Ad"].HeaderText = "Ad";
            dgvAntrenor.Columns["Soyad"].HeaderText = "Soyad";
            dgvAntrenor.Columns["Yas"].HeaderText = "Yaş";
            dgvAntrenor.Columns["Cinsiyet"].HeaderText = "Cinsiyet";
            dgvAntrenor.Columns["UzmanlikAlani"].HeaderText = "Uzmanlık Alanı";
            dgvAntrenor.Columns["TecrubeYili"].HeaderText = "Deneyim (Yıl)";
        }

        private void btn_AntenorKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️ Yeni antrenör nesnesi oluştur
                Antrenor yeniAntrenor = new Antrenor
                {
                    Id = txtAntenorNo.Text.Trim(),
                    Ad = txtAntenorAd.Text.Trim(),
                    Soyad = txtAntenorSoyad.Text.Trim(),
                    Yas = int.Parse(txtAntenorYas.Text),
                    cinsiyet = cmbAntenorCinsiyet.SelectedItem?.ToString(),
                    UzmanlikAlani = cmbAntrenorUzmanlik.SelectedItem?.ToString(),
                    TecrubeYili = int.Parse(txtDeneyimYili.Text)
                };

                // 2️ Veritabanına gönder
                Veritabanislemleri vt = new Veritabanislemleri();
                vt.AntrenorEkle(
                    yeniAntrenor.Id,
                    yeniAntrenor.Ad,
                    yeniAntrenor.Soyad,
                    yeniAntrenor.Yas,
                    yeniAntrenor.cinsiyet,
                    yeniAntrenor.UzmanlikAlani,
                    yeniAntrenor.TecrubeYili
                );

                // 3️ Kullanıcıya bilgi ver
                MessageBox.Show("Antrenör başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4️ Listeyi yenile
                AntrenorListesiniYukle();

                // 5️ Formu temizle
                Temizle();
            }
            catch (ArgumentException ex)
            {
                // Antrenor sınıfındaki kurallar (örnek: ID hatalı, yaş aralığı yanlış)
                MessageBox.Show(ex.Message, "Veri Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show("Sayısal alanları (Yaş, Deneyim) doğru formatta giriniz.", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            txtAntenorNo.Clear();
            txtAntenorAd.Clear();
            txtAntenorSoyad.Clear();
            txtAntenorYas.Clear();
            txtDeneyimYili.Clear();
            cmbAntenorCinsiyet.SelectedIndex = -1;
            cmbAntrenorUzmanlik.SelectedIndex = -1;
        }
    }
}
