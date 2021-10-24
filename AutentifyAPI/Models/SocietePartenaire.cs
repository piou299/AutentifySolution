using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public class SocietePartenaire
    {
        [Key]
        public int SocietePartenaireId { get; set; }
        public DateTime? DateEnregistrement { get; set; }

        public int SocieteId { get; set; }
        [ForeignKey(nameof(SocieteId))]
        public virtual Societe Societe { get; set; }

        public int PartenaireId { get; set; }
        [ForeignKey(nameof(PartenaireId))]
        public virtual Partenaire Partenaire { get; set; }
    }
}
