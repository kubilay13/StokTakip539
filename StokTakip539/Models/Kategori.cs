using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip539.Models
{
    [Table("Kategoriler")]
    public class Kategori
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength( 45)]
        public string KategoriAdi { get; set; }
        public virtual ICollection<Ürün> Ürünler { get; set; } = new HashSet<Ürün>();
    }
}
