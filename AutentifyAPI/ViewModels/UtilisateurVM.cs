using AutentifyAPI.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.ViewModels
{
    public class UtilisateurVM
    {
         public int Id { get; set; }
        // personne
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
        public IFormFile Photo { get; set; }
        public DateTime? DateEnregistrement { get; set; }

        //Utilisateur
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Login { get; set; }
        public EtatUser? Etat { get; set; }
        public int AgenceId { get; set; }
        [ForeignKey(nameof(AgenceId))]
        public virtual Agence Agence { get; set; }
        public int PersonneId { get; set; }
        [ForeignKey(nameof(PersonneId))]
        public virtual Personne Personne { get; set; }
        public int LangueId { get; set; }
        [ForeignKey(nameof(LangueId))]
        public virtual Langue Langue { get; set; }

        //Rôle
        public int RoleId { get; set; }
        [ForeignKey(nameof(RoleId))]
        public virtual Role Role { get; set; }

        public int UtilisateurId { get; set; }
        [ForeignKey(nameof(UtilisateurId))]
        public virtual Utilisateur Utilisateur { get; set; }

    }
}
