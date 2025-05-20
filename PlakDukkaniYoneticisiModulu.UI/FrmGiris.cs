using PlakDukkaniYoneticisiModulu.UI.DataAccess;
using PlakDukkaniYoneticisiModulu.UI.Helpers;

namespace PlakDukkaniYoneticisiModulu.UI
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Þifre gösterme kutusu iþaretlendiðinde, þifre alanýnýn karakter görünümünü deðiþtirir.
        /// Ýþaretliyse þifre açýk gösterilir, deðilse nokta karakteriyle gizlenir.
        /// </summary>
        private void chcSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = chcSifreGoster.Checked ? '\0' : '•';
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Kullanýcýdan gelen verileri al
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;

            // Boþ alan kontrolü
            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Kullanýcý adý ve þifre boþ býrakýlamaz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Þifre SHA256 ile hashlenir
            string hashliSifre = SifrelemeHelper.Sha256Hash(sifre);

            // Veritabaný baðlantýsý
            using (var context = new MyDbContext())
            {
                // Giriþ yapan admin veritabanýndan sorgulanýr
                var admin = context.Adminler
                    .FirstOrDefault(a => a.KullaniciAdi == kullaniciAdi && a.SifreHash == hashliSifre);

                if (admin != null)
                {
                    // Giriþ baþarýlýysa FrmAnaEkran formu açýlýr, bu form gizlenir
                    FrmAnaEkran frm = new FrmAnaEkran(admin, this);
                    frm.Show();
                    this.Hide();
                    Temizle();
                }
                else
                {
                    // Giriþ baþarýsýzsa uyarý gösterilir ve giriþ ekraný temizlenir
                    MessageBox.Show("Kullanýcý adý veya þifre hatalý!", "Giriþ Baþarýsýz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Temizle();
                    txtKullaniciAdi.Focus();
                }
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            FrmKayitOl frmKayit = new FrmKayitOl(); //Kayýt ekranýna git
            frmKayit.ShowDialog();
        }

        private void pbCikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bizi tercih ettiðiniz için teþekkür eder, Ýyi günler dileriz!", "Çýkýþ Yapýlýyor...");
            Application.Exit();
        }

        /// <summary>
        /// Giriþ formundaki kullanýcý adý, þifre alanlarýný ve þifre gösterme kutusunu sýfýrlar.
        /// Tüm alanlar temizlenir ve varsayýlan hale getirilir.
        /// </summary>
        private void Temizle()
        {
            txtKullaniciAdi.Text=string.Empty;
            txtSifre.Text=string.Empty;
            chcSifreGoster.Checked = false;
        }
    }
}
