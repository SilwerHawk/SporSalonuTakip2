namespace SporSalonuTakip.Usercontrols
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(35, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(737, 29);
            panel3.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(772, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(51, 562);
            panel2.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(35, 562);
            panel1.TabIndex = 11;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(41, 44, 59);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.ForeColor = SystemColors.Window;
            richTextBox1.Location = new Point(35, 29);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(737, 533);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 59);
            Controls.Add(richTextBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Giris";
            Size = new Size(823, 562);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private RichTextBox richTextBox1;
    }
}
