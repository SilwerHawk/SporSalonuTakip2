using System;
using System.Drawing;
using System.Windows.Forms;

namespace SporSalonuTakip.Moduller
{
    public class RenkDegistir
    {
        // Ana sayfa butonu aktifken renk
        public void BtnRenk1(Form1 form)
        {
            form.btn_Anasayfa.BackColor = Color.FromArgb(140, 145, 204);
            form.btn_UyeEkle.BackColor = Color.FromArgb(74, 76, 107);
            form.btn_AntrenorEkle.BackColor = Color.FromArgb(74, 76, 107);
            form.btn_ProgramEkle.BackColor = Color.FromArgb(74, 76, 107);
            form.btn_Sorgulama.BackColor = Color.FromArgb(74, 76, 107);

            form.panelb1.BackColor = Color.FromArgb(0, 140, 178);
            form.panelB2.BackColor = Color.FromArgb(74, 76, 107);
            form.panelb3.BackColor = Color.FromArgb(74, 76, 107);
            form.panelb4.BackColor = Color.FromArgb(74, 76, 107);
            form.panelb5.BackColor = Color.FromArgb(74, 76, 107);

            form.lbl_Baslik.Text = form.btn_Anasayfa.Text;
        }

        // Üye ekle sayfası
        public void BtnRenk2(Form1 form)
        {
            form.btn_Anasayfa.BackColor = Color.FromArgb(74, 76, 107);
            form.btn_UyeEkle.BackColor = Color.FromArgb(140, 145, 204);
            form.btn_AntrenorEkle.BackColor = Color.FromArgb(74, 76, 107);
            form.btn_ProgramEkle.BackColor = Color.FromArgb(74, 76, 107);
            form.btn_Sorgulama.BackColor = Color.FromArgb(74, 76, 107);

            form.panelb1.BackColor = Color.FromArgb(74, 76, 107);
            form.panelB2.BackColor = Color.FromArgb(230, 215, 159);
            form.panelb3.BackColor = Color.FromArgb(74, 76, 107);
            form.panelb4.BackColor = Color.FromArgb(74, 76, 107);
            form.panelb5.BackColor = Color.FromArgb(74, 76, 107);

            form.lbl_Baslik.Text = form.btn_UyeEkle.Text;
        }

        // Antrenör ekle sayfası
        public void BtnRenk3(Form1 form)
        {
            form.btn_Anasayfa.BackColor = Color.FromArgb(74, 76, 107);
            form.btn_UyeEkle.BackColor = Color.FromArgb(74, 76, 107);
            form.btn_AntrenorEkle.BackColor = Color.FromArgb(140, 145, 204);
            form.btn_ProgramEkle.BackColor = Color.FromArgb(74, 76, 107);
            form.btn_Sorgulama.BackColor = Color.FromArgb(74, 76, 107);

            form.panelb1.BackColor = Color.FromArgb(74, 76, 107);
            form.panelB2.BackColor = Color.FromArgb(74, 76, 107);
            form.panelb3.BackColor = Color.FromArgb(0, 178, 89);
            form.panelb4.BackColor = Color.FromArgb(74, 76, 107);
            form.panelb5.BackColor = Color.FromArgb(74, 76, 107);

            form.lbl_Baslik.Text = form.btn_AntrenorEkle.Text;
        }

        // Program ekle sayfası
        public void BtnRenk4(Form1 form)
        {
            form.btn_Anasayfa.BackColor = Color.FromArgb(74, 76, 107);
            form.btn_UyeEkle.BackColor = Color.FromArgb(74, 76, 107);
            form.btn_AntrenorEkle.BackColor = Color.FromArgb(74, 76, 107);
            form.btn_ProgramEkle.BackColor = Color.FromArgb(140, 145, 204);
            form.btn_Sorgulama.BackColor = Color.FromArgb(74, 76, 107);

            form.panelb1.BackColor = Color.FromArgb(74, 76, 107);
            form.panelB2.BackColor = Color.FromArgb(74, 76, 107);
            form.panelb3.BackColor = Color.FromArgb(74, 76, 107);
            form.panelb4.BackColor = Color.FromArgb(178, 0, 89);
            form.panelb5.BackColor = Color.FromArgb(74, 76, 107);

            form.lbl_Baslik.Text = form.btn_ProgramEkle.Text;
        }

        // Sorgulama sayfası
        public void BtnRenk5(Form1 form)
        {
            form.btn_Anasayfa.BackColor = Color.FromArgb(74, 76, 107);
            form.btn_UyeEkle.BackColor = Color.FromArgb(74, 76, 107);
            form.btn_AntrenorEkle.BackColor = Color.FromArgb(74, 76, 107);
            form.btn_ProgramEkle.BackColor = Color.FromArgb(74, 76, 107);
            form.btn_Sorgulama.BackColor = Color.FromArgb(140, 145, 204);

            form.panelb1.BackColor = Color.FromArgb(74, 76, 107);
            form.panelB2.BackColor = Color.FromArgb(74, 76, 107);
            form.panelb3.BackColor = Color.FromArgb(74, 76, 107);
            form.panelb4.BackColor = Color.FromArgb(74, 76, 107);
            form.panelb5.BackColor = Color.FromArgb(0, 89, 178);

            form.lbl_Baslik.Text = form.btn_Sorgulama.Text;
        }

        // DataGridView stil ayarları (genel tema ile uyumlu)
        public void DataGridViewStilAyarla(DataGridView dgv)
        {
            if (dgv == null) return;

            // Arka planlar
            dgv.BackgroundColor = Color.FromArgb(41, 44, 59);
            dgv.BorderStyle = BorderStyle.None;
            dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(60, 63, 80);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 53, 70);

            // Yazı renkleri
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(90, 95, 130);

            // Başlıklar
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 76, 107);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 36;

            // Hücre kenarlıkları
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.FromArgb(80, 85, 110);
            dgv.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Single;
            dgv.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Single;
            dgv.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dgv.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

            // Satır biçimi
            dgv.RowTemplate.Height = 32;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;

            // Otomatik boyutlandırma
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Grid çerçevesi kenar yumuşatma (isteğe bağlı)
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
