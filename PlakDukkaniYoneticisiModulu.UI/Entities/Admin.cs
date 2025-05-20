using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniYoneticisiModulu.UI.Entities
{
    public class Admin
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string KullaniciAdi { get; set; }

        [Required]
        public string SifreHash { get; set; } // SHA256 ile hashlenmiş şifre
    }
}
