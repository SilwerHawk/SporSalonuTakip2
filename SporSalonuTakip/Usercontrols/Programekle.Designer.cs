namespace SporSalonuTakip.Usercontrols
{
    partial class Programekle
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
            btn_Pkaydet = new Button();
            lb_Uyeler = new ListBox();
            cmb7Gun = new ComboBox();
            label2 = new Label();
            cmb6Gun = new ComboBox();
            label3 = new Label();
            cmb5Gun = new ComboBox();
            label4 = new Label();
            cmb4Gun = new ComboBox();
            label5 = new Label();
            cmb3Gun = new ComboBox();
            label6 = new Label();
            cmb2Gun = new ComboBox();
            label7 = new Label();
            cmb1Gun = new ComboBox();
            label8 = new Label();
            label10 = new Label();
            label9 = new Label();
            panel5 = new Panel();
            grpb_Programlar = new GroupBox();
            dgvProgram = new DataGridView();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            grpb_Programlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProgram).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(51, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(720, 46);
            panel3.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(771, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(52, 562);
            panel2.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(51, 562);
            panel1.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(51, 46);
            panel4.Name = "panel4";
            panel4.Size = new Size(720, 245);
            panel4.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Pkaydet);
            groupBox1.Controls.Add(lb_Uyeler);
            groupBox1.Controls.Add(cmb7Gun);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmb6Gun);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmb5Gun);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmb4Gun);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmb3Gun);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmb2Gun);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmb1Gun);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(720, 245);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Program Ekle-Değiştir";
            // 
            // btn_Pkaydet
            // 
            btn_Pkaydet.BackColor = Color.FromArgb(74, 76, 107);
            btn_Pkaydet.FlatAppearance.BorderSize = 0;
            btn_Pkaydet.FlatStyle = FlatStyle.Flat;
            btn_Pkaydet.Location = new Point(19, 80);
            btn_Pkaydet.Name = "btn_Pkaydet";
            btn_Pkaydet.Size = new Size(95, 141);
            btn_Pkaydet.TabIndex = 19;
            btn_Pkaydet.Text = "Kaydet";
            btn_Pkaydet.UseVisualStyleBackColor = false;
            btn_Pkaydet.Click += btn_Pkaydet_Click;
            // 
            // lb_Uyeler
            // 
            lb_Uyeler.FormattingEnabled = true;
            lb_Uyeler.ItemHeight = 15;
            lb_Uyeler.Location = new Point(120, 22);
            lb_Uyeler.Name = "lb_Uyeler";
            lb_Uyeler.Size = new Size(219, 199);
            lb_Uyeler.TabIndex = 3;
            // 
            // cmb7Gun
            // 
            cmb7Gun.FormattingEnabled = true;
            cmb7Gun.Items.AddRange(new object[] { "Seçiniz", "İstirahat", "Kol", "Omuz", "Koşu", "Bacak", "Göğüs", "Göbek" });
            cmb7Gun.Location = new Point(427, 205);
            cmb7Gun.Name = "cmb7Gun";
            cmb7Gun.Size = new Size(255, 23);
            cmb7Gun.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(19, 22);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Üye Adı";
            // 
            // cmb6Gun
            // 
            cmb6Gun.FormattingEnabled = true;
            cmb6Gun.Items.AddRange(new object[] { "Seçiniz", "İstirahat", "Kol", "Omuz", "Koşu", "Bacak", "Göğüs", "Göbek" });
            cmb6Gun.Location = new Point(427, 175);
            cmb6Gun.Name = "cmb6Gun";
            cmb6Gun.Size = new Size(255, 23);
            cmb6Gun.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(19, 51);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 4;
            label3.Text = "Üye Numarası";
            // 
            // cmb5Gun
            // 
            cmb5Gun.FormattingEnabled = true;
            cmb5Gun.Items.AddRange(new object[] { "Seçiniz", "İstirahat", "Kol", "Omuz", "Koşu", "Bacak", "Göğüs", "Göbek" });
            cmb5Gun.Location = new Point(427, 144);
            cmb5Gun.Name = "cmb5Gun";
            cmb5Gun.Size = new Size(255, 23);
            cmb5Gun.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(367, 22);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 5;
            label4.Text = "1. Gün";
            // 
            // cmb4Gun
            // 
            cmb4Gun.FormattingEnabled = true;
            cmb4Gun.Items.AddRange(new object[] { "Seçiniz", "İstirahat", "Kol", "Omuz", "Koşu", "Bacak", "Göğüs", "Göbek" });
            cmb4Gun.Location = new Point(427, 112);
            cmb4Gun.Name = "cmb4Gun";
            cmb4Gun.Size = new Size(255, 23);
            cmb4Gun.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(367, 54);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 6;
            label5.Text = "2. Gün";
            // 
            // cmb3Gun
            // 
            cmb3Gun.FormattingEnabled = true;
            cmb3Gun.Items.AddRange(new object[] { "Seçiniz", "İstirahat", "Kol", "Omuz", "Koşu", "Bacak", "Göğüs", "Göbek" });
            cmb3Gun.Location = new Point(427, 81);
            cmb3Gun.Name = "cmb3Gun";
            cmb3Gun.Size = new Size(255, 23);
            cmb3Gun.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(367, 84);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 7;
            label6.Text = "3. Gün";
            // 
            // cmb2Gun
            // 
            cmb2Gun.FormattingEnabled = true;
            cmb2Gun.Items.AddRange(new object[] { "Seçiniz", "İstirahat", "Kol", "Omuz", "Koşu", "Bacak", "Göğüs", "Göbek" });
            cmb2Gun.Location = new Point(427, 51);
            cmb2Gun.Name = "cmb2Gun";
            cmb2Gun.Size = new Size(255, 23);
            cmb2Gun.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(367, 115);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 8;
            label7.Text = "4. Gün";
            // 
            // cmb1Gun
            // 
            cmb1Gun.FormattingEnabled = true;
            cmb1Gun.Items.AddRange(new object[] { "Seçiniz", "İstirahat", "Kol", "Omuz", "Koşu", "Bacak", "Göğüs", "Göbek" });
            cmb1Gun.Location = new Point(427, 19);
            cmb1Gun.Name = "cmb1Gun";
            cmb1Gun.Size = new Size(255, 23);
            cmb1Gun.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(367, 147);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 9;
            label8.Text = "5. Gün";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(367, 208);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 11;
            label10.Text = "7. Gün";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(367, 178);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 10;
            label9.Text = "6. Gün";
            // 
            // panel5
            // 
            panel5.Controls.Add(grpb_Programlar);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(51, 291);
            panel5.Name = "panel5";
            panel5.Size = new Size(720, 271);
            panel5.TabIndex = 12;
            // 
            // grpb_Programlar
            // 
            grpb_Programlar.Controls.Add(dgvProgram);
            grpb_Programlar.Dock = DockStyle.Fill;
            grpb_Programlar.ForeColor = SystemColors.ButtonHighlight;
            grpb_Programlar.Location = new Point(0, 0);
            grpb_Programlar.Name = "grpb_Programlar";
            grpb_Programlar.Size = new Size(720, 271);
            grpb_Programlar.TabIndex = 2;
            grpb_Programlar.TabStop = false;
            grpb_Programlar.Text = "Programlar";
            // 
            // dgvProgram
            // 
            dgvProgram.BackgroundColor = Color.FromArgb(41, 44, 59);
            dgvProgram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProgram.Dock = DockStyle.Fill;
            dgvProgram.Location = new Point(3, 19);
            dgvProgram.Name = "dgvProgram";
            dgvProgram.Size = new Size(714, 249);
            dgvProgram.TabIndex = 1;
            // 
            // Programekle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 59);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Programekle";
            Size = new Size(823, 562);
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel5.ResumeLayout(false);
            grpb_Programlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProgram).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private Label label5;
        private Label label4;
        private Label label3;
        private ListBox lb_Uyeler;
        private Label label2;
        private ComboBox cmb7Gun;
        private ComboBox cmb6Gun;
        private ComboBox cmb5Gun;
        private ComboBox cmb4Gun;
        private ComboBox cmb3Gun;
        private ComboBox cmb2Gun;
        private ComboBox cmb1Gun;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private DataGridView dgvProgram;
        private Button btn_Pkaydet;
        private GroupBox groupBox1;
        private GroupBox grpb_Programlar;
    }
}
