using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip539.Models
{
    [Table("Tedarikçi")]
    internal class Tedarikci
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string FirmaAdi { get; set; }

        [Required]
        [MaxLength(45)]
        public string YetkiliAdi { get; set; }

        [Required]
        [MaxLength(20)]
        public string Telefon { get; set; }

        [MaxLength(45)]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]
        public string Adres { get; set; }

        public virtual ICollection<Ürün> Ürünler { get; set; } = new HashSet<Ürün>();
    }
}
