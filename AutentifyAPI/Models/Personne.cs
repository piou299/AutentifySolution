using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public enum Sexe
    {
        Homme, Femme
    }
    public class Personne
    {
        [Key]
        public int PersonneId { get; set; }

        [Required(ErrorMessage = "Veuillez saisir son nom")]
        [MinLength(3, ErrorMessage = "Le nom peut pas avoir moins de 3 lettres")]
        [MaxLength(20, ErrorMessage = "Le nom peut pas avoir plus de 20 lettres")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Veuillez saisir son prénom")]
        [MinLength(3, ErrorMessage = "Le Prénom peut pas avoir moins de 3 lettres")]
        [MaxLength(20, ErrorMessage = "Le Prénom peut pas avoir plus de 20 lettres")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Veuillez saisir son numéro de téléphone")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Veuillez entrer son adresse mail")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "L'addresse mail saisie est invalide")]
        public string Email { get; set; }
        public Sexe? Sexe { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string LieuNaissance { get; set; }
        public string Photo { get; set; }
        public DateTime? DateEnregistrement { get; set; }
       
        public virtual Utilisateur Utilisateur { get; set; }


    }
}
