namespace PlakDukkaniYoneticisiModulu.UI
{
    partial class FrmAlbumDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlbumDuzenle));
            txtAd = new TextBox();
            txtSanatciGrup = new TextBox();
            dtpCikisTarihi = new DateTimePicker();
            nudFiyat = new NumericUpDown();
            nudIndirim = new NumericUpDown();
            chcSatisDevam = new CheckBox();
            btnKaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pbCikis = new PictureBox();
            pbGeri = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIndirim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCikis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGeri).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(367, 60);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(300, 31);
            txtAd.TabIndex = 0;
            // 
            // txtSanatciGrup
            // 
            txtSanatciGrup.Location = new Point(367, 123);
            txtSanatciGrup.Name = "txtSanatciGrup";
            txtSanatciGrup.Size = new Size(300, 31);
            txtSanatciGrup.TabIndex = 1;
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(367, 184);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(300, 31);
            dtpCikisTarihi.TabIndex = 2;
            // 
            // nudFiyat
            // 
            nudFiyat.DecimalPlaces = 2;
            nudFiyat.Location = new Point(367, 248);
            nudFiyat.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudFiyat.Name = "nudFiyat";
            nudFiyat.Size = new Size(180, 31);
            nudFiyat.TabIndex = 3;
            // 
            // nudIndirim
            // 
            nudIndirim.Location = new Point(367, 309);
            nudIndirim.Name = "nudIndirim";
            nudIndirim.Size = new Size(180, 31);
            nudIndirim.TabIndex = 4;
            // 
            // chcSatisDevam
            // 
            chcSatisDevam.AutoSize = true;
            chcSatisDevam.BackColor = Color.Transparent;
            chcSatisDevam.Location = new Point(367, 367);
            chcSatisDevam.Name = "chcSatisDevam";
            chcSatisDevam.Size = new Size(255, 29);
            chcSatisDevam.TabIndex = 5;
            chcSatisDevam.Text = "Albüm Aktif Olarak Satışta";
            chcSatisDevam.UseVisualStyleBackColor = false;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.AppWorkspace;
            btnKaydet.Location = new Point(556, 435);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(168, 34);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(258, 63);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 7;
            label1.Text = "Albüm Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(194, 126);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 8;
            label2.Text = "Sanatçı / Grup Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(258, 189);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 9;
            label3.Text = "Çıkış Tarihi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(306, 250);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 10;
            label4.Text = "Fiyat :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(235, 311);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 11;
            label5.Text = "İndirim Oranı :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(548, 312);
            label6.Name = "label6";
            label6.Size = new Size(27, 25);
            label6.TabIndex = 12;
            label6.Text = "%";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(548, 250);
            label7.Name = "label7";
            label7.Size = new Size(23, 28);
            label7.TabIndex = 13;
            label7.Text = "₺";
            // 
            // pbCikis
            // 
            pbCikis.BackColor = Color.Transparent;
            pbCikis.Image = (Image)resources.GetObject("pbCikis.Image");
            pbCikis.Location = new Point(755, 2);
            pbCikis.Name = "pbCikis";
            pbCikis.Size = new Size(43, 42);
            pbCikis.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCikis.TabIndex = 14;
            pbCikis.TabStop = false;
            pbCikis.Click += pbCikis_Click;
            // 
            // pbGeri
            // 
            pbGeri.BackColor = Color.Transparent;
            pbGeri.Image = (Image)resources.GetObject("pbGeri.Image");
            pbGeri.Location = new Point(161, 2);
            pbGeri.Name = "pbGeri";
            pbGeri.Size = new Size(43, 42);
            pbGeri.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGeri.TabIndex = 15;
            pbGeri.TabStop = false;
            pbGeri.Click += pbGeri_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.DarkRed;
            label8.Location = new Point(204, 12);
            label8.Name = "label8";
            label8.Size = new Size(47, 25);
            label8.TabIndex = 16;
            label8.Text = "Geri";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Haettenschweiler", 16F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.White;
            label9.Location = new Point(74, 493);
            label9.Name = "label9";
            label9.Size = new Size(346, 34);
            label9.TabIndex = 17;
            label9.Text = "\"Notaları değil, albümleri yönetin!\"";
            // 
            // FrmAlbumDuzenle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 639);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(pbGeri);
            Controls.Add(pbCikis);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Controls.Add(chcSatisDevam);
            Controls.Add(nudIndirim);
            Controls.Add(nudFiyat);
            Controls.Add(dtpCikisTarihi);
            Controls.Add(txtSanatciGrup);
            Controls.Add(txtAd);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAlbumDuzenle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAlbumDuzenle";
            Load += FrmAlbumDuzenle_Load;
            ((System.ComponentModel.ISupportInitialize)nudFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIndirim).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCikis).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGeri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSanatciGrup;
        private DateTimePicker dtpCikisTarihi;
        private NumericUpDown nudFiyat;
        private NumericUpDown nudIndirim;
        private CheckBox chcSatisDevam;
        private Button btnKaydet;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pbCikis;
        private PictureBox pbGeri;
        private Label label8;
        private Label label9;
    }
}