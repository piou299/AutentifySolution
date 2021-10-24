using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public class Connexion
    {
        [Key]
        public int ConnexionId { get; set; }
        public int UtilisateurId { get; set; }
        public DateTime? DateHeure { get; set; }

        [ForeignKey(nameof(UtilisateurId))]
        public virtual Utilisateur Utilisateur { get; set; }

    }
}
