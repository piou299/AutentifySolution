using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public class Region
    {
        [Key]
        public int RegionId { get; set;}
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Nom { get; set; }
        public DateTime? DateEnregistrement { get; set; }
        public int PaysId { get; set; }
        [ForeignKey(nameof(PaysId))]
        public virtual Pays Pays { get; set; }
        public ICollection<Departement> Departements { get; set; }
        public ICollection<Ville> Villes { get; set; }
    }
}
