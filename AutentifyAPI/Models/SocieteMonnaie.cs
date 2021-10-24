using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public class SocieteMonnaie
    {
        [Key]
        public int SocieteMonnaieId { get; set; }
        public DateTime? DateEnregistrement { get; set; }
        public int SocieteId { get; set; }
        [ForeignKey(nameof(SocieteId))]
        public virtual Societe Societe { get; set; }

        public int MonnaieId { get; set; }
        [ForeignKey(nameof(MonnaieId))]
        public virtual Monnaie Monnaie { get; set; }
    }
}
