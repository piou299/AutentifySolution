using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public class Ville
    {
        [Key]
        public int VilleId { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Nom { get; set; }
        public int RegionId { get; set; }
        [ForeignKey(nameof(RegionId))]
        public virtual Region Regions { get; set; }
        public ICollection<Agence> Agences { get; set; } 
    }
}
