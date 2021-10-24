using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutentifyAPI.Models
{
    public class TypePartenaire
    {
        [Key]
        public int TypePartenaireId { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Libelle { get; set; }
        public ICollection<Partenaire> Partenaires { get; set; }
    }
}
