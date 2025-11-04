namespace SporSalonuTakip.Usercontrols
{
    partial class Sorgulama
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
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            lbl_UyeKilosu = new Label();
            lbl_UyeBoyu = new Label();
            lbl_UyeCinsiyet = new Label();
            lbl_UyeYasi = new Label();
            lbl_UyeAdiSoyadi = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label2 = new Label();
            btn_UyeSorgula = new Button();
            cmb_UyeSorgu = new ComboBox();
            groupBox2 = new GroupBox();
            lbl_AntDeneyim = new Label();
            lbl_AntUzmanlik = new Label();
            lbl_AntCinsiyeti = new Label();
            lbl_AntYasi = new Label();
            lbl_AntAdiSoyadi = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btn_AntSorgula = new Button();
            label1 = new Label();
            cmb_AntSorgu = new ComboBox();
            panel5 = new Panel();
            groupBox4 = new GroupBox();
            dgvSorgu = new DataGridView();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel5.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSorgu).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(17, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(787, 18);
            panel3.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(804, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(19, 562);
            panel2.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(17, 562);
            panel1.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(17, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(787, 260);
            panel4.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(787, 260);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sorgulama";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbl_UyeKilosu);
            groupBox3.Controls.Add(lbl_UyeBoyu);
            groupBox3.Controls.Add(lbl_UyeCinsiyet);
            groupBox3.Controls.Add(lbl_UyeYasi);
            groupBox3.Controls.Add(lbl_UyeAdiSoyadi);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(btn_UyeSorgula);
            groupBox3.Controls.Add(cmb_UyeSorgu);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.ForeColor = SystemColors.ButtonHighlight;
            groupBox3.Location = new Point(390, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(394, 238);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Üyeye Göre Sorgula";
            // 
            // lbl_UyeKilosu
            // 
            lbl_UyeKilosu.AutoSize = true;
            lbl_UyeKilosu.Location = new Point(133, 212);
            lbl_UyeKilosu.Name = "lbl_UyeKilosu";
            lbl_UyeKilosu.Size = new Size(77, 15);
            lbl_UyeKilosu.TabIndex = 40;
            lbl_UyeKilosu.Text = "lbl_UyeKilosu";
            // 
            // lbl_UyeBoyu
            // 
            lbl_UyeBoyu.AutoSize = true;
            lbl_UyeBoyu.Location = new Point(133, 186);
            lbl_UyeBoyu.Name = "lbl_UyeBoyu";
            lbl_UyeBoyu.Size = new Size(72, 15);
            lbl_UyeBoyu.TabIndex = 39;
            lbl_UyeBoyu.Text = "lbl_UyeBoyu";
            // 
            // lbl_UyeCinsiyet
            // 
            lbl_UyeCinsiyet.AutoSize = true;
            lbl_UyeCinsiyet.Location = new Point(133, 159);
            lbl_UyeCinsiyet.Name = "lbl_UyeCinsiyet";
            lbl_UyeCinsiyet.Size = new Size(87, 15);
            lbl_UyeCinsiyet.TabIndex = 38;
            lbl_UyeCinsiyet.Text = "lbl_UyeCinsiyet";
            // 
            // lbl_UyeYasi
            // 
            lbl_UyeYasi.AutoSize = true;
            lbl_UyeYasi.Location = new Point(133, 132);
            lbl_UyeYasi.Name = "lbl_UyeYasi";
            lbl_UyeYasi.Size = new Size(65, 15);
            lbl_UyeYasi.TabIndex = 37;
            lbl_UyeYasi.Text = "lbl_UyeYasi";
            // 
            // lbl_UyeAdiSoyadi
            // 
            lbl_UyeAdiSoyadi.AutoSize = true;
            lbl_UyeAdiSoyadi.Location = new Point(133, 106);
            lbl_UyeAdiSoyadi.Name = "lbl_UyeAdiSoyadi";
            lbl_UyeAdiSoyadi.Size = new Size(98, 15);
            lbl_UyeAdiSoyadi.TabIndex = 36;
            lbl_UyeAdiSoyadi.Text = "lbl_UyeAdiSoyadi";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(25, 212);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 35;
            label13.Text = "Kilosu :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(25, 186);
            label14.Name = "label14";
            label14.Size = new Size(40, 15);
            label14.TabIndex = 34;
            label14.Text = "Boyu :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(25, 159);
            label15.Name = "label15";
            label15.Size = new Size(58, 15);
            label15.TabIndex = 33;
            label15.Text = "Cinsiyeti :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(25, 132);
            label16.Name = "label16";
            label16.Size = new Size(33, 15);
            label16.TabIndex = 32;
            label16.Text = "Yaşı :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(25, 106);
            label17.Name = "label17";
            label17.Size = new Size(69, 15);
            label17.TabIndex = 31;
            label17.Text = "Adı Soyadı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 28);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 22;
            label2.Text = "Üye Adı:";
            // 
            // btn_UyeSorgula
            // 
            btn_UyeSorgula.BackColor = Color.FromArgb(74, 76, 107);
            btn_UyeSorgula.FlatAppearance.BorderSize = 0;
            btn_UyeSorgula.FlatStyle = FlatStyle.Flat;
            btn_UyeSorgula.Location = new Point(25, 54);
            btn_UyeSorgula.Name = "btn_UyeSorgula";
            btn_UyeSorgula.Size = new Size(345, 40);
            btn_UyeSorgula.TabIndex = 21;
            btn_UyeSorgula.Text = "Sogula";
            btn_UyeSorgula.UseVisualStyleBackColor = false;
            // 
            // cmb_UyeSorgu
            // 
            cmb_UyeSorgu.FormattingEnabled = true;
            cmb_UyeSorgu.Location = new Point(109, 25);
            cmb_UyeSorgu.Name = "cmb_UyeSorgu";
            cmb_UyeSorgu.Size = new Size(261, 23);
            cmb_UyeSorgu.TabIndex = 21;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbl_AntDeneyim);
            groupBox2.Controls.Add(lbl_AntUzmanlik);
            groupBox2.Controls.Add(lbl_AntCinsiyeti);
            groupBox2.Controls.Add(lbl_AntYasi);
            groupBox2.Controls.Add(lbl_AntAdiSoyadi);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btn_AntSorgula);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cmb_AntSorgu);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(3, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(387, 238);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Antrenöre Göre Sorgula";
            // 
            // lbl_AntDeneyim
            // 
            lbl_AntDeneyim.AutoSize = true;
            lbl_AntDeneyim.Location = new Point(124, 212);
            lbl_AntDeneyim.Name = "lbl_AntDeneyim";
            lbl_AntDeneyim.Size = new Size(91, 15);
            lbl_AntDeneyim.TabIndex = 30;
            lbl_AntDeneyim.Text = "lbl_AntDeneyim";
            // 
            // lbl_AntUzmanlik
            // 
            lbl_AntUzmanlik.AutoSize = true;
            lbl_AntUzmanlik.Location = new Point(124, 186);
            lbl_AntUzmanlik.Name = "lbl_AntUzmanlik";
            lbl_AntUzmanlik.Size = new Size(93, 15);
            lbl_AntUzmanlik.TabIndex = 29;
            lbl_AntUzmanlik.Text = "lbl_AntUzmanlik";
            // 
            // lbl_AntCinsiyeti
            // 
            lbl_AntCinsiyeti.AutoSize = true;
            lbl_AntCinsiyeti.Location = new Point(124, 159);
            lbl_AntCinsiyeti.Name = "lbl_AntCinsiyeti";
            lbl_AntCinsiyeti.Size = new Size(89, 15);
            lbl_AntCinsiyeti.TabIndex = 28;
            lbl_AntCinsiyeti.Text = "lbl_AntCinsiyeti";
            // 
            // lbl_AntYasi
            // 
            lbl_AntYasi.AutoSize = true;
            lbl_AntYasi.Location = new Point(124, 132);
            lbl_AntYasi.Name = "lbl_AntYasi";
            lbl_AntYasi.Size = new Size(64, 15);
            lbl_AntYasi.TabIndex = 27;
            lbl_AntYasi.Text = "lbl_AntYasi";
            // 
            // lbl_AntAdiSoyadi
            // 
            lbl_AntAdiSoyadi.AutoSize = true;
            lbl_AntAdiSoyadi.Location = new Point(124, 106);
            lbl_AntAdiSoyadi.Name = "lbl_AntAdiSoyadi";
            lbl_AntAdiSoyadi.Size = new Size(97, 15);
            lbl_AntAdiSoyadi.TabIndex = 26;
            lbl_AntAdiSoyadi.Text = "lbl_AntAdiSoyadi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 212);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 25;
            label7.Text = "Deneyim Yılı :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 186);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 24;
            label6.Text = "Uzmanlık Alanı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 159);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 23;
            label5.Text = "Cinsiyeti :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 132);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 22;
            label4.Text = "Yaşı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 106);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 21;
            label3.Text = "Adı Soyadı :";
            // 
            // btn_AntSorgula
            // 
            btn_AntSorgula.BackColor = Color.FromArgb(74, 76, 107);
            btn_AntSorgula.FlatAppearance.BorderSize = 0;
            btn_AntSorgula.FlatStyle = FlatStyle.Flat;
            btn_AntSorgula.Location = new Point(16, 59);
            btn_AntSorgula.Name = "btn_AntSorgula";
            btn_AntSorgula.Size = new Size(345, 35);
            btn_AntSorgula.TabIndex = 20;
            btn_AntSorgula.Text = "Sogula";
            btn_AntSorgula.UseVisualStyleBackColor = false;
            btn_AntSorgula.Click += btn_AntSorgula_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 33);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "Antrenör Adı:";
            // 
            // cmb_AntSorgu
            // 
            cmb_AntSorgu.FormattingEnabled = true;
            cmb_AntSorgu.Location = new Point(100, 30);
            cmb_AntSorgu.Name = "cmb_AntSorgu";
            cmb_AntSorgu.Size = new Size(261, 23);
            cmb_AntSorgu.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(groupBox4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(17, 278);
            panel5.Name = "panel5";
            panel5.Size = new Size(787, 284);
            panel5.TabIndex = 15;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvSorgu);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.ForeColor = SystemColors.ButtonHighlight;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(787, 284);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sorgu Sonucu";
            // 
            // dgvSorgu
            // 
            dgvSorgu.BackgroundColor = Color.FromArgb(41, 44, 59);
            dgvSorgu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSorgu.Dock = DockStyle.Fill;
            dgvSorgu.Location = new Point(3, 19);
            dgvSorgu.Name = "dgvSorgu";
            dgvSorgu.Size = new Size(781, 262);
            dgvSorgu.TabIndex = 2;
            // 
            // Sorgulama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 59);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Sorgulama";
            Size = new Size(823, 562);
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSorgu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel4;
        private GroupBox groupBox1;
        private Panel panel5;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox cmb_AntSorgu;
        private GroupBox groupBox4;
        private Label label2;
        private Button btn_UyeSorgula;
        private ComboBox cmb_UyeSorgu;
        private Button btn_AntSorgula;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dgvSorgu;
        private Label lbl_AntYasi;
        private Label lbl_AntAdiSoyadi;
        private Label label7;
        private Label lbl_AntDeneyim;
        private Label lbl_AntUzmanlik;
        private Label lbl_AntCinsiyeti;
        private Label lbl_UyeKilosu;
        private Label lbl_UyeBoyu;
        private Label lbl_UyeCinsiyet;
        private Label lbl_UyeYasi;
        private Label lbl_UyeAdiSoyadi;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
    }
}
