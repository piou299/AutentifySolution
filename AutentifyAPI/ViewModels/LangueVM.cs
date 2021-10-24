using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.ViewModels
{
    public class LangueVM
    {
        [Key]
        public int LangueId { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Libelle { get; set; }
        public DateTime? DateEnregistrement { get; set; }
        public IFormFile Icone { get; set; }
    }
}
