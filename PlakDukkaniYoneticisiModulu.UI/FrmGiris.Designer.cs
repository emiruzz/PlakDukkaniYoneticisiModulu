namespace PlakDukkaniYoneticisiModulu.UI
{
    partial class FrmGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            label1 = new Label();
            label2 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            btnKayitOl = new Button();
            chcSifreGoster = new CheckBox();
            pbCikis = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCikis).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(178, 95);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(243, 145);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Şifre :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtKullaniciAdi.Location = new Point(308, 92);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(193, 31);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtSifre.Location = new Point(308, 142);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '•';
            txtSifre.Size = new Size(193, 31);
            txtSifre.TabIndex = 1;
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGiris.Location = new Point(327, 196);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(148, 34);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "GİRİŞ YAP";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.Silver;
            btnKayitOl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKayitOl.ForeColor = Color.DarkRed;
            btnKayitOl.Location = new Point(600, 327);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(148, 34);
            btnKayitOl.TabIndex = 4;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // chcSifreGoster
            // 
            chcSifreGoster.AutoSize = true;
            chcSifreGoster.BackColor = Color.Transparent;
            chcSifreGoster.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chcSifreGoster.Location = new Point(516, 144);
            chcSifreGoster.Name = "chcSifreGoster";
            chcSifreGoster.Size = new Size(151, 29);
            chcSifreGoster.TabIndex = 2;
            chcSifreGoster.Text = "Şifreyi Göster";
            chcSifreGoster.UseVisualStyleBackColor = false;
            chcSifreGoster.CheckedChanged += chcSifreGoster_CheckedChanged;
            // 
            // pbCikis
            // 
            pbCikis.BackColor = Color.Transparent;
            pbCikis.Image = (Image)resources.GetObject("pbCikis.Image");
            pbCikis.Location = new Point(755, 1);
            pbCikis.Name = "pbCikis";
            pbCikis.Size = new Size(43, 42);
            pbCikis.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCikis.TabIndex = 7;
            pbCikis.TabStop = false;
            pbCikis.Click += pbCikis_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(443, 285);
            label3.Name = "label3";
            label3.Size = new Size(345, 25);
            label3.TabIndex = 100;
            label3.Text = "Hala bir kaydınız yok mu? Hemen Tıklayın!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Haettenschweiler", 16F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(227, 18);
            label4.Name = "label4";
            label4.Size = new Size(346, 34);
            label4.TabIndex = 100;
            label4.Text = "\"Notaları değil, albümleri yönetin!\"";
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pbCikis);
            Controls.Add(chcSifreGoster);
            Controls.Add(btnKayitOl);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pbCikis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGiris;
        private Button btnKayitOl;
        private CheckBox chcSifreGoster;
        private PictureBox pbCikis;
        private Label label3;
        private Label label4;
    }
}
