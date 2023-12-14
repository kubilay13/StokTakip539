using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip539.Models
{
    [Table("Satışlar")]
    public class Satış
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Müşteri))]
        [Required]
        public int MüşteriId { get; set; }
        public virtual Müşteri Müşteri { get; set; }
        [ForeignKey(nameof(Personel))]
        [Required]
        public int PersonelId { get; set; }
        public virtual Personel Personel { get; set; }
        [Required]
        public DateTime İşlemZamanı { get; set; }
        [MaxLength(255)]
        public string Açıklama { get; set; }
        public ICollection<SatışDetayı> SatışDetayları { get; set; } = new HashSet<SatışDetayı>();


    }
}
