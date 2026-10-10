using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.Data
{
    [AddINotifyPropertyChangedInterface]
    [Table("Materialy")]//[]-Pravy alt (altgr) +f/g
    public class Materialy
    {
        [Key]
        public int Id { get; set; } //Pravy alt (altgr) + b/n

        [Required]
        [StringLength(30)]
        public string Nazev { get; set; } = string.Empty;// = "";

        public int MnozPoj { get; set; } = 0;

        public int MnozDoPal { get; set; } = 0;

        [Column(TypeName ="date")]
        public DateTime Datum { get; set; } = DateTime.Now;

        //Cizí klíč pro MernaJednotka
        public string Komentar { get; set; } = string.Empty;

        public int MernaJednotkaId { get; set; }
        [ForeignKey(nameof(MernaJednotkaId))]
        public virtual required MernaJednotka MernaJednotka { get; set; }
    }
}
