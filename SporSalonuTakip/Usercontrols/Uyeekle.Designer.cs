namespace SporSalonuTakip.Usercontrols
{
    partial class Uyeekle
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
            label1 = new Label();
            groupBoxu1 = new GroupBox();
            btn_Kaydet = new Button();
            cmbAntrenor = new ComboBox();
            txtKilo = new TextBox();
            txtBoy = new TextBox();
            cmbCinsiyet = new ComboBox();
            txtYas = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtUyeNo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            dgvUyeler = new DataGridView();
            groupBoxu1.SuspendLayout();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            SuspendLayout();
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
            // groupBoxu1
            // 
            groupBoxu1.Controls.Add(btn_Kaydet);
            groupBoxu1.Controls.Add(cmbAntrenor);
            groupBoxu1.Controls.Add(txtKilo);
            groupBoxu1.Controls.Add(txtBoy);
            groupBoxu1.Controls.Add(cmbCinsiyet);
            groupBoxu1.Controls.Add(txtYas);
            groupBoxu1.Controls.Add(txtSoyad);
            groupBoxu1.Controls.Add(txtAd);
            groupBoxu1.Controls.Add(txtUyeNo);
            groupBoxu1.Controls.Add(label8);
            groupBoxu1.Controls.Add(label7);
            groupBoxu1.Controls.Add(label6);
            groupBoxu1.Controls.Add(label5);
            groupBoxu1.Controls.Add(label4);
            groupBoxu1.Controls.Add(label3);
            groupBoxu1.Controls.Add(label2);
            groupBoxu1.Controls.Add(label1);
            groupBoxu1.Dock = DockStyle.Fill;
            groupBoxu1.ForeColor = SystemColors.ButtonHighlight;
            groupBoxu1.Location = new Point(0, 0);
            groupBoxu1.Name = "groupBoxu1";
            groupBoxu1.Size = new Size(720, 248);
            groupBoxu1.TabIndex = 1;
            groupBoxu1.TabStop = false;
            groupBoxu1.Text = "Yeni Üye Kayıt";
            // 
            // btn_Kaydet
            // 
            btn_Kaydet.BackColor = Color.FromArgb(74, 76, 107);
            btn_Kaydet.FlatAppearance.BorderSize = 0;
            btn_Kaydet.FlatStyle = FlatStyle.Flat;
            btn_Kaydet.ForeColor = Color.Transparent;
            btn_Kaydet.Location = new Point(382, 145);
            btn_Kaydet.Name = "btn_Kaydet";
            btn_Kaydet.Size = new Size(310, 42);
            btn_Kaydet.TabIndex = 16;
            btn_Kaydet.Text = "Kaydet";
            btn_Kaydet.UseVisualStyleBackColor = false;
            btn_Kaydet.Click += btn_Kaydet_Click;
            // 
            // cmbAntrenor
            // 
            cmbAntrenor.FormattingEnabled = true;
            cmbAntrenor.Location = new Point(458, 99);
            cmbAntrenor.Name = "cmbAntrenor";
            cmbAntrenor.Size = new Size(234, 23);
            cmbAntrenor.TabIndex = 15;
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(458, 66);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(234, 23);
            txtKilo.TabIndex = 14;
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(458, 30);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(234, 23);
            txtBoy.TabIndex = 13;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Items.AddRange(new object[] { "Seçiniz", "Erkek", "Kadın" });
            cmbCinsiyet.Location = new Point(112, 164);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(234, 23);
            cmbCinsiyet.TabIndex = 12;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(112, 130);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(234, 23);
            txtYas.TabIndex = 11;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(112, 99);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(234, 23);
            txtSoyad.TabIndex = 10;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(112, 66);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(234, 23);
            txtAd.TabIndex = 9;
            // 
            // txtUyeNo
            // 
            txtUyeNo.Location = new Point(112, 30);
            txtUyeNo.Name = "txtUyeNo";
            txtUyeNo.Size = new Size(234, 23);
            txtUyeNo.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(382, 102);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 7;
            label8.Text = "Antrenörü";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(382, 69);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 6;
            label7.Text = "Kilosu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(382, 33);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 5;
            label6.Text = "Boyu";
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
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(51, 562);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(771, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(52, 562);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(51, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(720, 46);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBoxu1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(51, 46);
            panel4.Name = "panel4";
            panel4.Size = new Size(720, 248);
            panel4.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvUyeler);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(51, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(720, 268);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Üye Listesi";
            // 
            // dgvUyeler
            // 
            dgvUyeler.BackgroundColor = Color.FromArgb(41, 44, 59);
            dgvUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUyeler.Dock = DockStyle.Fill;
            dgvUyeler.Location = new Point(3, 19);
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.Size = new Size(714, 246);
            dgvUyeler.TabIndex = 0;
            // 
            // Uyeekle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 59);
            Controls.Add(groupBox2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Uyeekle";
            Size = new Size(823, 562);
            groupBoxu1.ResumeLayout(false);
            groupBoxu1.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBoxu1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cmbCinsiyet;
        private TextBox txtYas;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtUyeNo;
        private Label label8;
        private Button btn_Kaydet;
        private ComboBox cmbAntrenor;
        private TextBox txtKilo;
        private TextBox txtBoy;
        private GroupBox groupBox2;
        private DataGridView dgvUyeler;
    }
}
