using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.ViewModels
{
    public class PersonneVM
    {
        public int? EnseignantId { get; set; }
        public string Matricule { get; set; }
        public string Residence
        {
            get; set;
        }
        public string Entreprise { get; set; }

        public int? QuotaHoraire { get; set; }

       
        public string AnneeIntegration { get; set; }
     
        //-- Personne --
        public int? PersonneId { get; set; }
        public string Sexe { get; set; }
        
        public string Email { get; set; }
    
        public string Nom { get; set; }
        public string Prenom { get; set; }
        
        public DateTime? DateNaissance { get; set; }
        public DateTime? DateEnregistrement { get; set; }
        public string LieuNaissance { get; set; }
        

        //-- Diplome --
        public int? DiplomeId { get; set; }
        public string LibelleDiplome { get; set; }
        public string AbreviationDiplome { get; set; }

        //-- Grade --

        public int? GradeId { get; set; }
        public string LibelleGrade { get; set; }

        //-- Matrimonialite --

        public int? MatrimonialiteId { get; set; }
        public string LibelleMatrimonialite { get; set; }
    }
}
