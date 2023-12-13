using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip539.Models
{
    [Table("SatışDetayları")]
    internal class SatışDetayı
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Satış))]
        public int SatışId { get; set; }
        public virtual Satış Satış { get; set; }
        [ForeignKey(nameof(Ürün))]
        [Required]
        public int ÜrünId { get; set; }
        public virtual ürün Ürün { get; set; }
        [Required]
        public int Miktar { get; set; }
        [Required]
        public int Fiyat { get; set; }


    }
}
