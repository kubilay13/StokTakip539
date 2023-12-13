using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip539.Models
{
    [Table("Ürün")]
    internal class Ürün
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(45)]
        public string ÜrünAdı { get; set; }
        [ForeignKey(nameof(Kategori))]
        [Required]
        public virtual Kategori Kategori { get; set; }
        [ForeignKey(nameof(Tedarikci))]
        public int TedarikciId { get; set; }
        public virtual Tedarikci Tedarikci { get; set; }
        [Required]
        public int StokAdedi { get; set; }
        [Required]
        public decimal Fiyat { get; set; }
        public string Açıklama { get; set; }
        public virtual ICollection<SatışDetayı> SatışDetayıs { get; set; } = new HashSet<SatışDetayı>();

    }
}
