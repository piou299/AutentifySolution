using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public enum EtatPassword
    {
        Active, Desactive
    }
    public class Password
    {
        [Key]
        public int PasswordId { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Pass { get; set; }
        public EtatPassword? Etat { get; set; }
        public int UtilisateurId { get; set; }
        [ForeignKey(nameof(UtilisateurId))]

        public virtual Utilisateur Utilisateur { get; set; }
    }
}
