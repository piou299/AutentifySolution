using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public enum EtatUser
    {
        Actif, Suspendu, Renvoye
    }
    public class Utilisateur
    {
        [Key]
        public int UtilisateurId { get; set; }
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

        public ICollection<Password> Passwords { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<Connexion> Connexions { get; set; }

    }
}
