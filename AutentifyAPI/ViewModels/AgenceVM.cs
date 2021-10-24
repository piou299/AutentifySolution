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
    public class AgenceVM
    {
        [Key]
        public int AgenceId { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Libelle { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Adresse { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Email { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? DateEnregistrement { get; set; }
        public IFormFile Image { get; set; }
        public int VilleId { get; set; }
        [ForeignKey(nameof(VilleId))]
        public virtual Ville Ville { get; set; }
        public int SocieteId { get; set; }
        [ForeignKey(nameof(SocieteId))]
        public virtual Societe Societe { get; set; }
    }
}
