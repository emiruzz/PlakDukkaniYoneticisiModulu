using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlakDukkaniYoneticisiModulu.UI.Entities;
using PlakDukkaniYoneticisiModulu.UI.Helpers;

namespace PlakDukkaniYoneticisiModulu.UI.DataAccess
{
    public class MyDbContext : DbContext
    {
        public DbSet<Admin> Adminler { get; set; }
        public DbSet<Album> Albumler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=DESKTOP-TPVMOR3\\SQLEXPRESS01;Database=PlakDukkaniYoneticisiDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        /// <summary>
        /// Veritabanı modeli oluşturulurken yapılacak özel yapılandırmaları içerir.
        /// Örneğin; indeks, veri tipi, ilişkiler ve seed data tanımlamaları burada yapılır.
        /// </summary>
        /// <param name="modelBuilder">Model oluşturma işlemlerini yöneten builder nesnesi</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Kullanıcı adı için benzersiz (unique) index oluştur
            modelBuilder.Entity<Admin>()
                .HasIndex(a => a.KullaniciAdi)
                .IsUnique();

            // Albüm fiyatı için decimal(10,2) veri tipi ayarla
            modelBuilder.Entity<Album>()
                .Property(a => a.Fiyat)
                .HasColumnType("decimal(10,2)");

            // Admin - Album ilişkisi (her albüm bir admin'e aittir)
            modelBuilder.Entity<Album>()
                .HasOne(a => a.Admin)              // Album - Admin navigation
                .WithMany()                        // Admin -  Albums (eğer Admin'de koleksiyon yoksa boş bırakılır)
                .HasForeignKey(a => a.AdminId)     // Album tablosundaki FK
                .OnDelete(DeleteBehavior.Cascade); // Admin silinirse albümleri de sil

            // Seed admin kullanıcısı oluştur (ilk açılışta varsayılan admin hesabı)
            string hashliSifre = SifrelemeHelper.Sha256Hash("Admin123!!"); // Şifre hashlenmiş şekilde

            modelBuilder.Entity<Admin>().HasData(
                new Admin
                {
                    Id = 1,
                    KullaniciAdi = "Admin",
                    SifreHash = hashliSifre
                }
            );
        }
    }
}
