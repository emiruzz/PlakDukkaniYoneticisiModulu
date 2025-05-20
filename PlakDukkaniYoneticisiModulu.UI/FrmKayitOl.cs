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
using PlakDukkaniYoneticisiModulu.UI.Helpers;

namespace PlakDukkaniYoneticisiModulu.UI
{
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Kayıt ol butonuna tıklanınca çalışır.
        /// Girilen kullanıcı adı ve şifre bilgilerini kontrol eder.
        /// Şifre kurallarına ve tekrar eşleşmesine uygunsa,
        /// SHA256 ile şifreyi hashleyip veritabanına yeni admin olarak kaydeder.
        /// </summary>
        private void btnKaydol_Click(object sender, EventArgs e)
        {
            // Formdan gelen verileri al
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;
            string sifreTekrar = txtSifreTekrar.Text;

            // Boş alan kontrolü
            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(sifreTekrar))
            {
                MessageBox.Show("Tüm alanları doldurmalısınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Şifreler aynı mı kontrolü
            if (sifre != sifreTekrar)
            {
                MessageBox.Show("Şifreler uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSifre.Text = string.Empty;
                txtSifreTekrar.Text = string.Empty;
                txtSifre.Focus();
                return;
            }

            // Şifre kuralları kontrolü (karakter sayısı, büyük harf, özel karakter vs.)
            if (!SifreKurallariniKontrolEt(sifre))
            {
                // Hata mesajı bu metod içinde veriliyor
                return;
            }

            using (var context = new MyDbContext())
            {
                // Aynı kullanıcı adının olup olmadığını kontrol et
                bool kullaniciVarMi = context.Adminler.Any(a => a.KullaniciAdi == kullaniciAdi);

                if (kullaniciVarMi)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten alınmış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKullaniciAdi.Text = string.Empty;
                    txtKullaniciAdi.Focus();
                    return;
                }

                // Şifreyi SHA256 ile hashle
                string hashliSifre = SifrelemeHelper.Sha256Hash(sifre);

                // Yeni admin nesnesi oluştur
                Admin yeniAdmin = new Admin
                {
                    KullaniciAdi = kullaniciAdi,
                    SifreHash = hashliSifre
                };

                // Veritabanına kaydet
                context.Adminler.Add(yeniAdmin);
                context.SaveChanges();

                // Başarılı kayıt bildirimi
                MessageBox.Show("Kayıt başarılı! Giriş ekranına yönlendiriliyorsunuz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu kapat (FrmGiris'e dönüş)
                this.Close();
            }
        }

        /// <summary>
        /// Girilen şifrenin belirlenen kurallara uyup uymadığını kontrol eder.
        /// Şifre; en az 8 karakter uzunluğunda, en az 2 büyük harf, 3 küçük harf ve 2 özel karakter (!, :, +, *) içermelidir.
        /// Kurallara uymuyorsa kullanıcıya uyarı verir, şifre kutularını temizler ve false döner.
        /// </summary>
        private bool SifreKurallariniKontrolEt(string sifre)
        {
            // Uzunluk kontrolü
            if (sifre.Length < 8)
            {
                MessageBox.Show("Şifreniz en az 8 karakter uzunluğunda olmalıdır.", "Geçersiz Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSifre.Text = string.Empty;
                txtSifreTekrar.Text = string.Empty;
                txtSifre.Focus();
                return false;
            }

            // Büyük harf sayısı kontrolü
            int buyukHarfSayisi = sifre.Count(char.IsUpper);
            if (buyukHarfSayisi < 2)
            {
                MessageBox.Show("Şifreniz en az 2 büyük harf içermelidir.", "Geçersiz Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSifre.Text = string.Empty;
                txtSifreTekrar.Text = string.Empty;
                txtSifre.Focus();
                return false;
            }

            // Küçük harf sayısı kontrolü
            int kucukHarfSayisi = sifre.Count(char.IsLower);
            if (kucukHarfSayisi < 3)
            {
                MessageBox.Show("Şifreniz en az 3 küçük harf içermelidir.", "Geçersiz Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSifre.Text = string.Empty;
                txtSifreTekrar.Text = string.Empty;
                txtSifre.Focus();
                return false;
            }

            // Özel karakter (!, :, +, *) sayısı kontrolü
            int ozelKarakterSayisi = sifre.Count(c => "!:+*".Contains(c));
            if (ozelKarakterSayisi < 2)
            {
                MessageBox.Show("Şifreniz en az 2 özel karakter (!, :, +, *) içermelidir.", "Geçersiz Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSifre.Text = string.Empty;
                txtSifreTekrar.Text = string.Empty;
                txtSifre.Focus();
                return false;
            }

            // Tüm kurallar sağlanmışsa
            return true;
        }

        /// <summary>
        /// "Şifreyi Göster" checkbox'ının işaretlenme durumuna göre
        /// şifre ve şifre tekrar alanlarının görünümünü değiştirir.
        /// İşaretliyse şifreler açık şekilde gösterilir, değilse gizlenir (•).
        /// </summary>
        private void chcSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            char karakter = chcSifreGoster.Checked ? '\0' : '•';

            txtSifre.PasswordChar = karakter;
            txtSifreTekrar.PasswordChar = karakter;
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
