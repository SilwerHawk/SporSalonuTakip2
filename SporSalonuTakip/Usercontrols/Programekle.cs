using SporSalonuTakip.Moduller;
using System;
using System.Data;
using System.Windows.Forms;

namespace SporSalonuTakip.Usercontrols
{
    public partial class Programekle : UserControl
    {
        public Programekle()
        {
            InitializeComponent();
            RenkDegistir renk = new RenkDegistir();
            renk.DataGridViewStilAyarla(dgvProgram);
            UyeleriYukle();
            ProgramListesiniYukle();
        }

        // Üyeleri listbox'a yükle
        private void UyeleriYukle()
        {
            try
            {
                Veritabanislemleri vt = new Veritabanislemleri();
                DataTable dt = vt.UyeAdSoyadListesiGetir();

                lb_Uyeler.DisplayMember = "AdSoyad";
                lb_Uyeler.ValueMember = "Id";
                lb_Uyeler.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Üyeler yüklenirken hata oluştu:\n" + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kayıtları DataGridView’e yükle
        private void ProgramListesiniYukle()
        {
            try
            {
                Veritabanislemleri vt = new Veritabanislemleri();
                dgvProgram.DataSource = vt.ProgramListele();

                dgvProgram.Columns["UyeId"].HeaderText = "Üye No";
                dgvProgram.Columns["AdSoyad"].HeaderText = "Üye Adı";
                dgvProgram.Columns["Gun1"].HeaderText = "1. Gün";
                dgvProgram.Columns["Gun2"].HeaderText = "2. Gün";
                dgvProgram.Columns["Gun3"].HeaderText = "3. Gün";
                dgvProgram.Columns["Gun4"].HeaderText = "4. Gün";
                dgvProgram.Columns["Gun5"].HeaderText = "5. Gün";
                dgvProgram.Columns["Gun6"].HeaderText = "6. Gün";
                dgvProgram.Columns["Gun7"].HeaderText = "7. Gün";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Programlar yüklenirken hata oluştu:\n" + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Program kaydet butonu
        private void btn_Pkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (lb_Uyeler.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir üye seçiniz.",
                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRowView seciliUye = (DataRowView)lb_Uyeler.SelectedItem;
                string uyeId = seciliUye["Id"].ToString();
                string adSoyad = seciliUye["AdSoyad"].ToString();

                Veritabanislemleri vt = new Veritabanislemleri();
                vt.ProgramEkle(
                    uyeId,
                    adSoyad,
                    cmb1Gun.Text,
                    cmb2Gun.Text,
                    cmb3Gun.Text,
                    cmb4Gun.Text,
                    cmb5Gun.Text,
                    cmb6Gun.Text,
                    cmb7Gun.Text
                );

                MessageBox.Show("Program başarıyla kaydedildi.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ProgramListesiniYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Program kaydedilirken hata oluştu:\n" + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
