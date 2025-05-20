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
        /// �ifre g�sterme kutusu i�aretlendi�inde, �ifre alan�n�n karakter g�r�n�m�n� de�i�tirir.
        /// ��aretliyse �ifre a��k g�sterilir, de�ilse nokta karakteriyle gizlenir.
        /// </summary>
        private void chcSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = chcSifreGoster.Checked ? '\0' : '�';
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Kullan�c�dan gelen verileri al
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;

            // Bo� alan kontrol�
            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Kullan�c� ad� ve �ifre bo� b�rak�lamaz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // �ifre SHA256 ile hashlenir
            string hashliSifre = SifrelemeHelper.Sha256Hash(sifre);

            // Veritaban� ba�lant�s�
            using (var context = new MyDbContext())
            {
                // Giri� yapan admin veritaban�ndan sorgulan�r
                var admin = context.Adminler
                    .FirstOrDefault(a => a.KullaniciAdi == kullaniciAdi && a.SifreHash == hashliSifre);

                if (admin != null)
                {
                    // Giri� ba�ar�l�ysa FrmAnaEkran formu a��l�r, bu form gizlenir
                    FrmAnaEkran frm = new FrmAnaEkran(admin, this);
                    frm.Show();
                    this.Hide();
                    Temizle();
                }
                else
                {
                    // Giri� ba�ar�s�zsa uyar� g�sterilir ve giri� ekran� temizlenir
                    MessageBox.Show("Kullan�c� ad� veya �ifre hatal�!", "Giri� Ba�ar�s�z", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Temizle();
                    txtKullaniciAdi.Focus();
                }
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            FrmKayitOl frmKayit = new FrmKayitOl(); //Kay�t ekran�na git
            frmKayit.ShowDialog();
        }

        private void pbCikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bizi tercih etti�iniz i�in te�ekk�r eder, �yi g�nler dileriz!", "��k�� Yap�l�yor...");
            Application.Exit();
        }

        /// <summary>
        /// Giri� formundaki kullan�c� ad�, �ifre alanlar�n� ve �ifre g�sterme kutusunu s�f�rlar.
        /// T�m alanlar temizlenir ve varsay�lan hale getirilir.
        /// </summary>
        private void Temizle()
        {
            txtKullaniciAdi.Text=string.Empty;
            txtSifre.Text=string.Empty;
            chcSifreGoster.Checked = false;
        }
    }
}
