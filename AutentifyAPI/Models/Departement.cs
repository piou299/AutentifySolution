using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public class Departement
    {
        [Key]
        public int DepartementId { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Nom { get; set; }
        public DateTime? DateEnregistremnt { get; set; }
        public int RegionId { get; set; }
        [ForeignKey(nameof(RegionId))]
        public virtual Region Region { get; set; }
    }
}
