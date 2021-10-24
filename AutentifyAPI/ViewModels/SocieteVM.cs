using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.ViewModels
{
    public class SocieteVM
    {
        [Key]
        public int SocieteId { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Sigle { get; set; }
        public DateTime? DateCreation { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Adresse { get; set; }
        [Required(ErrorMessage = "Veuillez entrer son adresse mail")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "L'addresse mail saisie est invalide")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Telephone { get; set; }
        public IFormFile Logo { get; set; }
        public DateTime? DateEnregistrement { get; set; }
    }
}
