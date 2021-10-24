using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public class SocieteJourFeries
    {
        [Key]
        public int SocieteJourFeriesId { get; set; }
        public DateTime? DateEnregistrement { get; set; }
        public int SocieteId { get; set; }
        [ForeignKey(nameof(SocieteId))]
        public virtual Societe Societe { get; set; }
        public int JourFeriesId { get; set; }
        [ForeignKey(nameof(JourFeriesId))]
        public virtual JourFeries JourFeries { get; set; }

    }
}
