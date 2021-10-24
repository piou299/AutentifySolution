using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public enum EtatExercice
    {
        EnCours, Cloture
    }
    public class Exercice
    {
        [Key]
        public int ExerciceId { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Nom { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Observation { get; set; }
        public double? TauxTVA { get; set; }
        public EtatExercice? Etat { get; set; }
        public DateTime? DateEnregistrement { get; set; }
        public int AgenceId { get; set; }
        [ForeignKey(nameof(AgenceId))]
        public virtual Agence Agence { get; set; }
        public ICollection<Periode> Periodes { get; set; }
    }
}
