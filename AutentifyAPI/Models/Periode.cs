using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public enum EtatPeriode
    {
        EnCours, Cloture
    }
    public class Periode
    {
        [Key]
        public int PeriodeId { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public EtatPeriode? Etat{ get; set; }
        public int NumeroMois { get; set; }
        public int ExerciceId { get; set; }
        [ForeignKey(nameof(ExerciceId))]
        public virtual Exercice Exercice { get; set; }

    }
}
