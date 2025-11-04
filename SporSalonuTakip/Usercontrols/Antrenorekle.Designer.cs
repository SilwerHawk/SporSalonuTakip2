namespace SporSalonuTakip.Usercontrols
{
    partial class Antrenorekle
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            dgvAntrenor = new DataGridView();
            groupBox1 = new GroupBox();
            btn_AntenorKaydet = new Button();
            cmbAntrenorUzmanlik = new ComboBox();
            txtDeneyimYili = new TextBox();
            cmbAntenorCinsiyet = new ComboBox();
            txtAntenorYas = new TextBox();
            txtAntenorSoyad = new TextBox();
            txtAntenorAd = new TextBox();
            txtAntenorNo = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAntrenor).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(51, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(720, 46);
            panel3.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(771, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(52, 562);
            panel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(51, 562);
            panel1.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox2);
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(51, 46);
            panel4.Name = "panel4";
            panel4.Size = new Size(720, 516);
            panel4.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvAntrenor);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(0, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(720, 268);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Antrenor Listesi";
            // 
            // dgvAntrenor
            // 
            dgvAntrenor.BackgroundColor = Color.FromArgb(41, 44, 59);
            dgvAntrenor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAntrenor.Dock = DockStyle.Fill;
            dgvAntrenor.Location = new Point(3, 19);
            dgvAntrenor.Name = "dgvAntrenor";
            dgvAntrenor.Size = new Size(714, 246);
            dgvAntrenor.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_AntenorKaydet);
            groupBox1.Controls.Add(cmbAntrenorUzmanlik);
            groupBox1.Controls.Add(txtDeneyimYili);
            groupBox1.Controls.Add(cmbAntenorCinsiyet);
            groupBox1.Controls.Add(txtAntenorYas);
            groupBox1.Controls.Add(txtAntenorSoyad);
            groupBox1.Controls.Add(txtAntenorAd);
            groupBox1.Controls.Add(txtAntenorNo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(720, 248);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Antrenor Ekle";
            // 
            // btn_AntenorKaydet
            // 
            btn_AntenorKaydet.BackColor = Color.FromArgb(74, 76, 107);
            btn_AntenorKaydet.FlatAppearance.BorderSize = 0;
            btn_AntenorKaydet.FlatStyle = FlatStyle.Flat;
            btn_AntenorKaydet.ForeColor = Color.Transparent;
            btn_AntenorKaydet.Location = new Point(366, 102);
            btn_AntenorKaydet.Name = "btn_AntenorKaydet";
            btn_AntenorKaydet.Size = new Size(326, 85);
            btn_AntenorKaydet.TabIndex = 16;
            btn_AntenorKaydet.Text = "Kaydet";
            btn_AntenorKaydet.UseVisualStyleBackColor = false;
            btn_AntenorKaydet.Click += btn_AntenorKaydet_Click;
            // 
            // cmbAntrenorUzmanlik
            // 
            cmbAntrenorUzmanlik.FormattingEnabled = true;
            cmbAntrenorUzmanlik.Items.AddRange(new object[] { "Seçiniz", "Kas Geliştirme", "Sağlıklı Yaşam", "Zayıflama", "Egzersiz" });
            cmbAntrenorUzmanlik.Location = new Point(458, 30);
            cmbAntrenorUzmanlik.Name = "cmbAntrenorUzmanlik";
            cmbAntrenorUzmanlik.Size = new Size(234, 23);
            cmbAntrenorUzmanlik.TabIndex = 15;
            // 
            // txtDeneyimYili
            // 
            txtDeneyimYili.Location = new Point(458, 66);
            txtDeneyimYili.MaxLength = 2;
            txtDeneyimYili.Name = "txtDeneyimYili";
            txtDeneyimYili.Size = new Size(234, 23);
            txtDeneyimYili.TabIndex = 14;
            // 
            // cmbAntenorCinsiyet
            // 
            cmbAntenorCinsiyet.FormattingEnabled = true;
            cmbAntenorCinsiyet.Items.AddRange(new object[] { "Seçiniz", "Erkek", "Kadın" });
            cmbAntenorCinsiyet.Location = new Point(112, 164);
            cmbAntenorCinsiyet.Name = "cmbAntenorCinsiyet";
            cmbAntenorCinsiyet.Size = new Size(234, 23);
            cmbAntenorCinsiyet.TabIndex = 12;
            // 
            // txtAntenorYas
            // 
            txtAntenorYas.Location = new Point(112, 130);
            txtAntenorYas.Name = "txtAntenorYas";
            txtAntenorYas.Size = new Size(234, 23);
            txtAntenorYas.TabIndex = 11;
            // 
            // txtAntenorSoyad
            // 
            txtAntenorSoyad.Location = new Point(112, 99);
            txtAntenorSoyad.Name = "txtAntenorSoyad";
            txtAntenorSoyad.Size = new Size(234, 23);
            txtAntenorSoyad.TabIndex = 10;
            // 
            // txtAntenorAd
            // 
            txtAntenorAd.Location = new Point(112, 66);
            txtAntenorAd.Name = "txtAntenorAd";
            txtAntenorAd.Size = new Size(234, 23);
            txtAntenorAd.TabIndex = 9;
            // 
            // txtAntenorNo
            // 
            txtAntenorNo.Location = new Point(112, 30);
            txtAntenorNo.Name = "txtAntenorNo";
            txtAntenorNo.Size = new Size(234, 23);
            txtAntenorNo.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(366, 69);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 6;
            label7.Text = "Deneyim Yılı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(366, 33);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 5;
            label6.Text = "Uzmanlık Alanı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 167);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Cinsiyeti";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 133);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 3;
            label4.Text = "Yaşı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 102);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Soyadı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 69);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 1;
            label2.Text = "Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 33);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Üye Numarası";
            // 
            // Antrenorekle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 59);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Antrenorekle";
            Size = new Size(823, 562);
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAntrenor).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel4;
        private GroupBox groupBox1;
        private Button btn_AntenorKaydet;
        private ComboBox cmbAntrenorUzmanlik;
        private TextBox txtDeneyimYili;
        private ComboBox cmbAntenorCinsiyet;
        private TextBox txtAntenorYas;
        private TextBox txtAntenorSoyad;
        private TextBox txtAntenorAd;
        private TextBox txtAntenorNo;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvAntrenor;
    }
}
