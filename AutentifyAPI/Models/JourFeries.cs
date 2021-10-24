using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public class JourFeries
    {
        [Key]
        public int JourFeriesId { get; set; }
        public int Jour { get; set; }
        public int Mois { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Frequence { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string JourFerie { get; set; }
        public DateTime? DateEnregistrement { get; set; }
        public string Commentaire { get; set; }
        public ICollection<SocieteJourFeries> SocieteJourFeries { get; set; }
    }
}
