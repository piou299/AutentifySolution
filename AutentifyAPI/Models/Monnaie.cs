using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public class Monnaie
    {
        [Key]
        public int MonnaieId { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Suffixe { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Reference { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Parite { get; set; }
        public DateTime? DateEnregistrement { get; set; }
        public ICollection<SocieteJourFeries> SocieteJourFeries { get; set; }
        public ICollection<SocieteMonnaie> SocieteMonnaies { get; set; }
    }
}
