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
    public  class SatışDetayı
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Satış))]
        public int SatışId { get; set; }
        public virtual Satış Satış { get; set; }
        [ForeignKey(nameof(Ürün))]
        [Required]
        public int ÜrünId { get; set; }
        public virtual Ürün Ürün { get; set; }
        [Required]
        public int Miktar { get; set; }
        [Required]
        public int Fiyat { get; set; }
        //public virtual ICollection<SatışDetayı> SatışDetayları { get; set; } = new HashSet<SatışDetayı>();

    }
}
