using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip539.Models
{
    [Table("Personeller ")]
    internal class Personel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string Ad { get; set; }

        [Required]
        [MaxLength(45)]
        public string Soyad { get; set; }

        [Required]
        [MaxLength(20)]
        public string Telefon { get; set; }

        [Required]
        [MaxLength(20)]
        public string Eposta { get; set; }

        [MaxLength(255)]
        public string Adres { get; set; }

        [Required]
        [MaxLength(45)]
        public string KullaniciAdi { get; set; }

        [Required]
        [MaxLength(45)]
        public string Parola { get; set; }

        [ForeignKey(nameof(Yetki))]
        [Required]
        public string YetkiId { get; set; }
        public virtual Yetki Yetki { get; set; }
        public ICollection<Satış> Satışlar { get; set; } = new HashSet<Satış>();


    }
}
