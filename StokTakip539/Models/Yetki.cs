using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip539.Models
{
    [Table("Yetki")]
    internal class Yetki
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(45)]
        public string YetkiAdı { get; set; }
        public virtual ICollection<Personel> Personels { get; set; } = new HashSet<Personel>();
    }
}
