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
    public partial class FrmAnaEkran : Form
    {
        private Form girisFormu;
        private Admin aktifAdmin;

        public FrmAnaEkran(Admin admin, Form girisFormu = null)
        {
            InitializeComponent();
            this.girisFormu = girisFormu;
            this.aktifAdmin = admin;
        }

        private void FrmAnaEkran_Load(object sender, EventArgs e)
        {
            TumAlbumleriListele();
            SatisDurmuslariListele();
            SatisDevamEdenleriListele();
            Son10AlbumListele();
            IndirimdekileriListele();

            ListViewAyarla(lvSatisDurmus);
            ListViewAyarla(lvSatisDevam);
            ListViewAyarla(lvSon10);
            ListViewAyarla(lvIndirimdekiler);

            dgvTumAlbumler.ClearSelection();
        }

        /// <summary>
        /// Giriş yapan admin'e ait albümleri veritabanından çeker ve DataGridView'e yükler.
        /// Her albüm için ID, ad, sanatçı, çıkış tarihi, fiyat, indirim oranı ve satış durumu bilgileri gösterilir.
        /// Kolon başlıkları düzenlenir ve ilk satır seçili gelmemesi için seçim temizlenir.
        /// </summary>
        private void TumAlbumleriListele()
        {
            using (var context = new MyDbContext())
            {
                // Aktif admin'e ait albümler filtrelenerek listelenir
                var albumler = context.Albumler
                    .Where(a => a.AdminId == aktifAdmin.Id)
                    .Select(a => new
                    {
                        a.Id,
                        a.Ad,
                        a.SanatciGrup,
                        CikisTarihi = a.CikisTarihi.ToString("dd.MM.yyyy"), // Tarih sadece gün.ay.yıl olarak gösterilir
                        a.Fiyat,
                        IndirimOrani = a.IndirimOrani.HasValue ? $"{a.IndirimOrani.Value}%" : "-", // null ise "-"
                        SatisDurumu = a.SatisDevamEdiyorMu ? "Devam Ediyor" : "Durmuş"
                    })
                    .ToList();

                dgvTumAlbumler.DataSource = albumler;
            }

            // ID kolonu görünmez yapılır (güncelle/sil için saklı tutulur)
            dgvTumAlbumler.Columns["Id"].Visible = false;

            // Form açıldığında ilk satırın seçili gelmemesi için seçim temizlenir
            this.BeginInvoke(new Action(() => dgvTumAlbumler.ClearSelection()));

            // Kolon başlıkları kullanıcı dostu isimlerle değiştirilir
            dgvTumAlbumler.Columns["Ad"].HeaderText = "Albüm Adı";
            dgvTumAlbumler.Columns["SanatciGrup"].HeaderText = "Sanatçı / Grup";
            dgvTumAlbumler.Columns["CikisTarihi"].HeaderText = "Çıkış Tarihi";
            dgvTumAlbumler.Columns["Fiyat"].HeaderText = "Fiyat (₺)";
            dgvTumAlbumler.Columns["IndirimOrani"].HeaderText = "İndirim";
            dgvTumAlbumler.Columns["SatisDurumu"].HeaderText = "Satış Durumu";

            dgvTumAlbumler.Columns["Id"].Visible = false; // ID tekrar gizlenir (güvenlik için)
        }

        /// <summary>
        /// Verilen albüm listesini belirtilen ListView kontrolüne yükler.
        /// Her albüm için ad ve sanatçı/grup bilgileri bir satır olarak eklenir.
        /// Önce mevcut öğeler temizlenir, sonra yeniden doldurulur.
        /// </summary>
        private void AlbumleriListVieweYukle(ListView lv, List<Album> albumler)
        {
            // Önce ListView'deki eski verileri temizle
            lv.Items.Clear();

            // Her albüm için bir ListViewItem oluştur ve ekle
            foreach (var album in albumler)
            {
                ListViewItem item = new ListViewItem(album.Ad); // İlk sütun: Albüm Adı
                item.SubItems.Add(album.SanatciGrup);           // İkinci sütun: Sanatçı / Grup
                lv.Items.Add(item);                             // Listeye ekle
            }
        }

        /// <summary>
        /// Giriş yapan adminin satışta olmayan (satışı durmuş) albümlerini veritabanından çeker.
        /// Albümler ada göre sıralanarak ilgili ListView'e yüklenir.
        /// </summary>
        private void SatisDurmuslariListele()
        {
            using (var context = new MyDbContext())
            {
                // Satışı durmuş ve giriş yapan admin'e ait albümleri getir
                var albumler = context.Albumler
                    .Where(a => !a.SatisDevamEdiyorMu && a.AdminId == aktifAdmin.Id)
                    .OrderBy(a => a.Ad) // Ada göre sıralama
                    .ToList();

                // Albümleri ListView'e yükle
                AlbumleriListVieweYukle(lvSatisDurmus, albumler);
            }
        }

        /// <summary>
        /// Giriş yapan adminin satışı devam eden albümlerini veritabanından çeker.
        /// Albümler ada göre sıralanarak ilgili ListView'e yüklenir.
        /// </summary>
        private void SatisDevamEdenleriListele()
        {
            using (var context = new MyDbContext())
            {
                // Satışı devam eden ve giriş yapan admin'e ait albümler
                var albumler = context.Albumler
                    .Where(a => a.SatisDevamEdiyorMu && a.AdminId == aktifAdmin.Id)
                    .OrderBy(a => a.Ad)
                    .ToList();

                // Albümleri ListView'e yükle
                AlbumleriListVieweYukle(lvSatisDevam, albumler);
            }
        }

        /// <summary>
        /// Giriş yapan adminin son eklediği 10 albümü, eklenme tarihine göre azalan şekilde listeler.
        /// Albümler ilgili ListView'e yüklenir.
        /// </summary>
        private void Son10AlbumListele()
        {
            using (var context = new MyDbContext())
            {
                // Admin'e ait albümlerden en son eklenen 10 tanesini al
                var albumler = context.Albumler
                    .Where(a => a.AdminId == aktifAdmin.Id)
                    .OrderByDescending(a => a.EklenmeTarihi)
                    .Take(10)
                    .ToList();

                // Albümleri ListView'e yükle
                AlbumleriListVieweYukle(lvSon10, albumler);
            }
        }

        /// <summary>
        /// Giriş yapan adminin indirimde olan albümlerini veritabanından çeker.
        /// İndirim oranına göre azalan şekilde sıralanarak ilgili ListView'e yüklenir.
        /// </summary>
        private void IndirimdekileriListele()
        {
            using (var context = new MyDbContext())
            {
                // İndirim oranı > 0 olan ve admin'e ait albümleri getir
                var albumler = context.Albumler
                    .Where(a => a.IndirimOrani.HasValue && a.IndirimOrani.Value > 0 && a.AdminId == aktifAdmin.Id)
                    .OrderByDescending(a => a.IndirimOrani)
                    .ToList();

                // Albümleri ListView'e yükle
                AlbumleriListVieweYukle(lvIndirimdekiler, albumler);
            }
        }

        /// <summary>
        /// Verilen ListView kontrolünün görünümünü detaylı liste olarak ayarlar.
        /// Satırların tamamı seçilebilir hale getirilir ve "Albüm Adı" ile "Sanatçı / Grup" olmak üzere iki sütun eklenir.
        /// </summary>
        private void ListViewAyarla(ListView lv)
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.Columns.Add("Albüm Adı", 150);
            lv.Columns.Add("Sanatçı / Grup", 150);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmAlbumDuzenle frm = new FrmAlbumDuzenle(aktifAdmin);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                TumAlbumleriListele();
                SatisDurmuslariListele();
                SatisDevamEdenleriListele();
                Son10AlbumListele();
                IndirimdekileriListele();
            }
        }

        /// <summary>
        /// DataGridView'de seçilen albümü düzenlemek için FrmAlbumDuzenle formunu açar.
        /// Güncelleme işlemi tamamlandığında tüm listeleme alanları yenilenir.
        /// </summary>
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Eğer hiç satır seçilmemişse kullanıcı uyarılır
            if (dgvTumAlbumler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir albüm seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen albümün ID’si alınır
            int id = Convert.ToInt32(dgvTumAlbumler.SelectedRows[0].Cells["Id"].Value);

            using (var context = new MyDbContext())
            {
                // Albüm veritabanından alınır
                var album = context.Albumler.FirstOrDefault(a => a.Id == id);

                if (album != null)
                {
                    // Güncelleme formu admin ile birlikte açılır
                    FrmAlbumDuzenle frm = new FrmAlbumDuzenle(album, aktifAdmin);

                    // Eğer düzenleme tamamlandıysa tüm listeler yenilenir
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        TumAlbumleriListele();
                        SatisDurmuslariListele();
                        SatisDevamEdenleriListele();
                        Son10AlbumListele();
                        IndirimdekileriListele();
                    }
                }
            }
        }

        /// <summary>
        /// DataGridView'de seçilen albümün silinmesini sağlar.
        /// Kullanıcıdan onay alındıktan sonra albüm veritabanından silinir.
        /// Silme işlemi tamamlandıktan sonra tüm listeleme alanları yenilenir.
        /// </summary>
        private void btnSil_Click(object sender, EventArgs e)
        {
            // Hiçbir satır seçilmemişse kullanıcı uyarılır
            if (dgvTumAlbumler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir albümü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen albümün adı alınır (onay mesajı için)
            string albumAd = dgvTumAlbumler.CurrentRow.Cells["Ad"].Value.ToString();

            // Kullanıcıdan silme onayı alınır
            DialogResult sonuc = MessageBox.Show(
                $"'{albumAd}' adlı albümü silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Kullanıcı 'Hayır' derse işlem iptal edilir
            if (sonuc != DialogResult.Yes)
                return;

            // Silinecek albümün ID’si alınır
            int id = Convert.ToInt32(dgvTumAlbumler.CurrentRow.Cells["Id"].Value);

            using (var context = new MyDbContext())
            {
                // Albüm veritabanında bulunur
                var silinecek = context.Albumler.FirstOrDefault(a => a.Id == id);

                if (silinecek != null)
                {
                    // Albüm silinir
                    context.Albumler.Remove(silinecek);
                    context.SaveChanges();

                    // Bilgilendirme mesajı
                    MessageBox.Show("Albüm başarıyla silindi.", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tüm listeler güncellenir
                    TumAlbumleriListele();
                    SatisDurmuslariListele();
                    SatisDevamEdenleriListele();
                    Son10AlbumListele();
                    IndirimdekileriListele();
                }
            }
        }

        private void FrmAnaEkran_Click(object sender, EventArgs e)
        {
            dgvTumAlbumler.ClearSelection();
        }

        private void dgvTumAlbumler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= dgvTumAlbumler.Rows.Count)
            {
                dgvTumAlbumler.ClearSelection();
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

            if (girisFormu != null)
                girisFormu.Show();
        }
    }
}
