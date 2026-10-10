using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.Data
{
    [AddINotifyPropertyChangedInterface]
    [Table("MernaJednotka")]
    public class MernaJednotka
    {
        [Key]
        public int MernaJednotkaId { get; set; }

        [StringLength(20, ErrorMessage = "Popis maximálně na 20 znaků.")]
        public string Popis { get; set; } = string.Empty;

        public virtual ObservableCollection<Materialy> Materialy { get; set; } = null!;
    }
}