using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public class Agence
    {
        //string p = "ljqsdnfd";
        [Key]
        public int AgenceId { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Libelle { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Adresse { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "L'addresse mail saisie est invalide")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public DateTime? DateCreation { get; set; }
        public DateTime? DateEnregistrement { get; set; }
        public string Image { get; set; }
        public int VilleId { get; set; }
        [ForeignKey(nameof(VilleId))]
        public virtual Ville Ville { get; set; }
        public int SocieteId { get; set; }
        [ForeignKey(nameof(SocieteId))]
        public virtual Societe Societe { get; set; }
        public ICollection<Exercice> Exercices { get; set; }
        public ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}
