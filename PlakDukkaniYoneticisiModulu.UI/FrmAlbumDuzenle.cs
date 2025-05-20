using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlakDukkaniYoneticisiModulu.UI.DataAccess;
using PlakDukkaniYoneticisiModulu.UI.Entities;

namespace PlakDukkaniYoneticisiModulu.UI
{
    public partial class FrmAlbumDuzenle : Form
    {
        private Admin aktifAdmin;

        /// <summary>
        /// Yeni bir albüm eklemek için kullanılan yapıcı metottur.
        /// Giriş yapan admin bilgisi alınır ve form başlatılır.
        /// </summary>
        public FrmAlbumDuzenle(Admin admin)
        {
            InitializeComponent();

            // Giriş yapan admin referansı tutulur
            aktifAdmin = admin;
        }

        private Album seciliAlbum = null;

        /// <summary>
        /// Mevcut bir albüm bilgisini güncellemek için kullanılan yapıcı metottur.
        /// Hem giriş yapan admin hem de güncellenecek albüm nesnesi alınır.
        /// </summary>
        public FrmAlbumDuzenle(Album album, Admin admin) : this(admin)
        {
            // Güncellenecek albüm formda kullanılmak üzere saklanır
            seciliAlbum = album;
        }

        /// <summary>
        /// Form yüklendiğinde çalışır. Eğer güncellenecek bir albüm varsa,
        /// form üzerindeki kontroller ilgili albüm bilgileriyle doldurulur.
        /// </summary>
        private void FrmAlbumDuzenle_Load(object sender, EventArgs e)
        {
            // Eğer seciliAlbum null değilse, form güncelleme modunda açılmıştır
            if (seciliAlbum != null)
            {
                // Albüm bilgileri form kontrollerine aktarılır
                txtAd.Text = seciliAlbum.Ad;
                txtSanatciGrup.Text = seciliAlbum.SanatciGrup;
                dtpCikisTarihi.Value = seciliAlbum.CikisTarihi;
                nudFiyat.Value = seciliAlbum.Fiyat;
                nudIndirim.Value = seciliAlbum.IndirimOrani ?? 0; // null ise 0 olarak ayarlanır
                chcSatisDevam.Checked = seciliAlbum.SatisDevamEdiyorMu;
            }
        }

        /// <summary>
        /// Albüm bilgilerini kaydeder. Eğer yeni albüm ekleniyorsa yeni kayıt oluşturur,
        /// var olan albüm düzenleniyorsa bilgileri günceller. Giriş yapan admin'e göre işlem yapılır.
        /// Tüm alan kontrolleri yapılır ve doğrulama hatalarında kullanıcı uyarılır.
        /// </summary>
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Girişleri al ve boşlukları temizle
            string ad = txtAd.Text.Trim();
            string sanatci = txtSanatciGrup.Text.Trim();

            // Albüm adı ve sanatçı boş olamaz
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(sanatci))
            {
                MessageBox.Show("Albüm adı ve sanatçı/grup boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Fiyat pozitif olmalı
            if (nudFiyat.Value <= 0)
            {
                MessageBox.Show("Fiyat pozitif bir değer olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudFiyat.Focus();
                return;
            }

            // İndirim oranı 0-100 aralığında olmalı
            if (nudIndirim.Value < 0 || nudIndirim.Value > 100)
            {
                MessageBox.Show("İndirim oranı 0 ile 100 arasında olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudIndirim.Value = 0;
                nudIndirim.Focus();
                return;
            }

            // Çıkış tarihi gelecekte olamaz
            if (dtpCikisTarihi.Value > DateTime.Now)
            {
                MessageBox.Show("Çıkış tarihi gelecekte olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpCikisTarihi.Value = DateTime.Now;
                dtpCikisTarihi.Focus();
                return;
            }

            using (var context = new MyDbContext())
            {
                if (seciliAlbum == null)
                {
                    // Yeni albüm ekleme işlemi
                    Album yeni = new Album
                    {
                        Ad = ad,
                        SanatciGrup = sanatci,
                        CikisTarihi = dtpCikisTarihi.Value.Date, // Saat kısmı hariç
                        Fiyat = nudFiyat.Value,
                        IndirimOrani = (int?)nudIndirim.Value,
                        SatisDevamEdiyorMu = chcSatisDevam.Checked,
                        EklenmeTarihi = DateTime.Now,
                        AdminId = aktifAdmin.Id // Ekleyen admin bilgisi
                    };

                    context.Albumler.Add(yeni);
                }
                else
                {
                    // Güncelleme işlemi
                    var guncellenecek = context.Albumler.FirstOrDefault(a => a.Id == seciliAlbum.Id);

                    if (guncellenecek != null)
                    {
                        guncellenecek.Ad = ad;
                        guncellenecek.SanatciGrup = sanatci;
                        guncellenecek.CikisTarihi = dtpCikisTarihi.Value;
                        guncellenecek.Fiyat = nudFiyat.Value;
                        guncellenecek.IndirimOrani = (int?)nudIndirim.Value;
                        guncellenecek.SatisDevamEdiyorMu = chcSatisDevam.Checked;
                    }
                }

                // Veritabanı kaydı
                context.SaveChanges();

                // Kullanıcıya bilgi verilir ve form kapatılır
                MessageBox.Show("Albüm başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void pbCikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bizi tercih ettiğiniz için teşekkür eder, İyi günler dileriz!", "Çıkış Yapılıyor...");
            Application.Exit();
        }

        private void pbGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

