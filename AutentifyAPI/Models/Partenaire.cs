using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public class Partenaire
    {
        [Key]
        public int PartenaireId { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Nom { get; set; }
        public string Adresse { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "L'addresse mail saisie est invalide")]
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Telephone { get; set; }
        public int PaysId { get; set; }
        public int TypePartenaireId { get; set; }
        public DateTime DateEnregistrement { get; set; }
        [ForeignKey(nameof(TypePartenaireId))]
        public virtual TypePartenaire TypePartenaire { get; set; }
        [ForeignKey(nameof(PaysId))]
        public virtual Pays Pays { get; set; }
        public ICollection<SocietePartenaire> SocietePartenaires { get; set; }
    }
}
