namespace PlakDukkaniYoneticisiModulu.UI
{
    partial class FrmAnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaEkran));
            dgvTumAlbumler = new DataGridView();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            lvSatisDurmus = new ListView();
            lvSatisDevam = new ListView();
            lvSon10 = new ListView();
            lvIndirimdekiler = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pbCikis = new PictureBox();
            pbGeri = new PictureBox();
            label6 = new Label();
            fontDialog1 = new FontDialog();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTumAlbumler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCikis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGeri).BeginInit();
            SuspendLayout();
            // 
            // dgvTumAlbumler
            // 
            dgvTumAlbumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTumAlbumler.Location = new Point(141, 120);
            dgvTumAlbumler.MultiSelect = false;
            dgvTumAlbumler.Name = "dgvTumAlbumler";
            dgvTumAlbumler.RowHeadersWidth = 62;
            dgvTumAlbumler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTumAlbumler.Size = new Size(823, 225);
            dgvTumAlbumler.TabIndex = 0;
            dgvTumAlbumler.CellClick += dgvTumAlbumler_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.WhiteSmoke;
            btnEkle.Location = new Point(229, 397);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(156, 34);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ControlLight;
            btnSil.ForeColor = Color.DarkRed;
            btnSil.Location = new Point(474, 397);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(156, 34);
            btnSil.TabIndex = 1;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ScrollBar;
            btnGuncelle.Location = new Point(720, 397);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(156, 34);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // lvSatisDurmus
            // 
            lvSatisDurmus.Location = new Point(27, 598);
            lvSatisDurmus.Name = "lvSatisDurmus";
            lvSatisDurmus.Size = new Size(245, 236);
            lvSatisDurmus.TabIndex = 4;
            lvSatisDurmus.UseCompatibleStateImageBehavior = false;
            // 
            // lvSatisDevam
            // 
            lvSatisDevam.Location = new Point(302, 598);
            lvSatisDevam.Name = "lvSatisDevam";
            lvSatisDevam.Size = new Size(245, 236);
            lvSatisDevam.TabIndex = 5;
            lvSatisDevam.UseCompatibleStateImageBehavior = false;
            // 
            // lvSon10
            // 
            lvSon10.Location = new Point(576, 598);
            lvSon10.Name = "lvSon10";
            lvSon10.Size = new Size(245, 236);
            lvSon10.TabIndex = 6;
            lvSon10.UseCompatibleStateImageBehavior = false;
            // 
            // lvIndirimdekiler
            // 
            lvIndirimdekiler.Location = new Point(851, 598);
            lvIndirimdekiler.Name = "lvIndirimdekiler";
            lvIndirimdekiler.Size = new Size(245, 236);
            lvIndirimdekiler.TabIndex = 7;
            lvIndirimdekiler.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 558);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 8;
            label1.Text = "Satışı Durmuş";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(340, 558);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 9;
            label2.Text = "Satışı Devam Eden";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(602, 558);
            label3.Name = "label3";
            label3.Size = new Size(196, 25);
            label3.TabIndex = 10;
            label3.Text = "Son Eklenen 10 Albüm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(876, 558);
            label4.Name = "label4";
            label4.Size = new Size(189, 25);
            label4.TabIndex = 11;
            label4.Text = "İndirimdeki Albümler";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(487, 70);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 12;
            label5.Text = "Tüm Albümler";
            // 
            // pbCikis
            // 
            pbCikis.BackColor = Color.Transparent;
            pbCikis.Image = (Image)resources.GetObject("pbCikis.Image");
            pbCikis.Location = new Point(1080, 3);
            pbCikis.Name = "pbCikis";
            pbCikis.Size = new Size(43, 42);
            pbCikis.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCikis.TabIndex = 13;
            pbCikis.TabStop = false;
            pbCikis.Click += pbCikis_Click;
            // 
            // pbGeri
            // 
            pbGeri.BackColor = Color.Transparent;
            pbGeri.Image = (Image)resources.GetObject("pbGeri.Image");
            pbGeri.Location = new Point(229, 3);
            pbGeri.Name = "pbGeri";
            pbGeri.Size = new Size(43, 42);
            pbGeri.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGeri.TabIndex = 14;
            pbGeri.TabStop = false;
            pbGeri.Click += pbGeri_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(272, 13);
            label6.Name = "label6";
            label6.Size = new Size(47, 25);
            label6.TabIndex = 15;
            label6.Text = "Geri";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Haettenschweiler", 16F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.ControlDark;
            label7.Location = new Point(368, 462);
            label7.Name = "label7";
            label7.Size = new Size(346, 34);
            label7.TabIndex = 16;
            label7.Text = "\"Notaları değil, albümleri yönetin!\"";
            // 
            // FrmAnaEkran
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1125, 903);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pbGeri);
            Controls.Add(pbCikis);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvIndirimdekiler);
            Controls.Add(lvSon10);
            Controls.Add(lvSatisDevam);
            Controls.Add(lvSatisDurmus);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dgvTumAlbumler);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAnaEkran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAnaEkran";
            Load += FrmAnaEkran_Load;
            Click += FrmAnaEkran_Click;
            ((System.ComponentModel.ISupportInitialize)dgvTumAlbumler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCikis).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGeri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTumAlbumler;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private ListView lvSatisDurmus;
        private ListView lvSatisDevam;
        private ListView lvSon10;
        private ListView lvIndirimdekiler;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pbCikis;
        private PictureBox pbGeri;
        private Label label6;
        private FontDialog fontDialog1;
        private Label label7;
    }
}