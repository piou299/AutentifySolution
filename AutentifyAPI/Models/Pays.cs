using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutentifyAPI.Models
{
    public enum Continent
    {
        Asie, Afrique,AmeriqueNord,AmeriqueSud,Europe,Antarctique,Oceanie
    }
    public class Pays
    {
        [Key]
        public int PaysId { get; set; }
        public string Code { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string NomPays { get; set; }
        public string Indicatif { get; set; }
        public string Logo { get; set; }

    }
}
