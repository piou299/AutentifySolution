using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Libelle { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
