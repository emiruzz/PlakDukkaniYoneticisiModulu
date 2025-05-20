using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniYoneticisiModulu.UI.Entities
{
    public class Album
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Ad { get; set; }

        [Required, MaxLength(100)]
        public string SanatciGrup { get; set; }

        public DateTime CikisTarihi { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Fiyat { get; set; }

        [Range(0, 100)]
        public int? IndirimOrani { get; set; } // Null olabilir

        public bool SatisDevamEdiyorMu { get; set; }

        public DateTime EklenmeTarihi { get; set; } = DateTime.Now; // Son 10 albüm için

        public int AdminId { get; set; }                  // FK
        public Admin Admin { get; set; }
    }
}
