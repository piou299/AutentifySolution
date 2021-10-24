using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public class Langue
    {
        [Key]
        public int LangueId { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Libelle { get; set; }
        public DateTime? DateEnregistrement { get; set; }
        public string Icone { get; set; }
        public ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}
