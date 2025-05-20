namespace PlakDukkaniYoneticisiModulu.UI
{
    partial class FrmKayitOl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKayitOl));
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            txtSifreTekrar = new TextBox();
            btnKaydol = new Button();
            chcSifreGoster = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pbCikis = new PictureBox();
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            pbGeri = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCikis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGeri).BeginInit();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(291, 106);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(227, 31);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(291, 160);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '•';
            txtSifre.Size = new Size(227, 31);
            txtSifre.TabIndex = 1;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(291, 216);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.PasswordChar = '•';
            txtSifreTekrar.Size = new Size(227, 31);
            txtSifreTekrar.TabIndex = 2;
            // 
            // btnKaydol
            // 
            btnKaydol.BackColor = Color.LightGray;
            btnKaydol.Location = new Point(327, 300);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(151, 34);
            btnKaydol.TabIndex = 4;
            btnKaydol.Text = "KAYIT OL";
            btnKaydol.UseVisualStyleBackColor = false;
            btnKaydol.Click += btnKaydol_Click;
            // 
            // chcSifreGoster
            // 
            chcSifreGoster.AutoSize = true;
            chcSifreGoster.BackColor = Color.Transparent;
            chcSifreGoster.Location = new Point(541, 218);
            chcSifreGoster.Name = "chcSifreGoster";
            chcSifreGoster.Size = new Size(151, 29);
            chcSifreGoster.TabIndex = 3;
            chcSifreGoster.Text = "Şifreyi Göster";
            chcSifreGoster.UseVisualStyleBackColor = false;
            chcSifreGoster.CheckedChanged += chcSifreGoster_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(167, 109);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(227, 163);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 6;
            label2.Text = "Şifre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(176, 219);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 7;
            label3.Text = "Şifre Tekrar :";
            // 
            // pbCikis
            // 
            pbCikis.BackColor = Color.Transparent;
            pbCikis.Image = (Image)resources.GetObject("pbCikis.Image");
            pbCikis.Location = new Point(755, 2);
            pbCikis.Name = "pbCikis";
            pbCikis.Size = new Size(43, 42);
            pbCikis.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCikis.TabIndex = 8;
            pbCikis.TabStop = false;
            pbCikis.Click += pbCikis_Click;
            // 
            // pbGeri
            // 
            pbGeri.BackColor = Color.Transparent;
            pbGeri.Image = (Image)resources.GetObject("pbGeri.Image");
            pbGeri.Location = new Point(167, 2);
            pbGeri.Name = "pbGeri";
            pbGeri.Size = new Size(43, 42);
            pbGeri.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGeri.TabIndex = 9;
            pbGeri.TabStop = false;
            pbGeri.Click += pbGeri_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(210, 11);
            label4.Name = "label4";
            label4.Size = new Size(47, 25);
            label4.TabIndex = 10;
            label4.Text = "Geri";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Haettenschweiler", 16F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(327, 35);
            label5.Name = "label5";
            label5.Size = new Size(346, 34);
            label5.TabIndex = 11;
            label5.Text = "\"Notaları değil, albümleri yönetin!\"";
            // 
            // FrmKayitOl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 503);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pbGeri);
            Controls.Add(pbCikis);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chcSifreGoster);
            Controls.Add(btnKaydol);
            Controls.Add(txtSifreTekrar);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmKayitOl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmKayitOl";
            ((System.ComponentModel.ISupportInitialize)pbCikis).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGeri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private TextBox txtSifreTekrar;
        private Button btnKaydol;
        private CheckBox chcSifreGoster;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pbCikis;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private PictureBox pbGeri;
        private Label label4;
        private Label label5;
    }
}