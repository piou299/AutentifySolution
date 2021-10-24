using AutentifyAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public interface IDAL
    {
        // Signature des méthodes pour les pays
        Pays ObtenirPaysParId(int PaysID);
        List <Pays> ObtenirToutLesPays();

        // Signature des méthodes pour les régions
        void EnregistreRegion(Region region);
        Region ObtenirRegionParId(int RegionID);
        List<Region> ObtenirToutteLesRegions();

        // Signature des méthodes pour les Langues
        void EnregistreLangue(LangueVM langue);
        Langue ObtenirLangueParId(int LangueID);
        List<Langue> ObtenirToutteLesLangues();

        // Signature des méthodes pour les Villes
        void EnregistreVille(Ville ville);
        Ville ObtenirVilleParId(int VilleID);
        List<Ville> ObtenirToutteLesVille();

        // Signature des méthodes pour les Societes
        void EnregistreSociete(SocieteVM societe);
        Societe ObtenirSocieteParId(int SocieteID);
        List<Societe> ObtenirToutteLesSociete();

        // Signature des méthodes pour les Agences
        void EnregistreAgence(AgenceVM agence);
        Agence ObtenirAgenceParId(int AgenceID);
        List<Agence> ObtenirToutteLesAgence();
        IEnumerable<Periode> Getperiodes { get; }
        public IEnumerable<Exercice> GetExercices { get; }
        public IEnumerable<Monnaie> GetMonnaies { get; }
        public IEnumerable<Partenaire> GetPartenaires { get; }
        public IEnumerable<TypePartenaire> GetTypePartenaires { get; }
        public bool AddPeriode(Periode periode);
        public bool AddExercice(Exercice exercice);
        public bool AddMonnaie(Monnaie monnaie);
        public bool AddPartenaire(Partenaire partenaire);
        public bool AddTypePartenaire(TypePartenaire typePartenaire);

        // Signature des méthodes pour les Rôles
        void EnregistreRole(Role role);
        Role ObtenirRoleParId(int RoleId);
        List<Role> ObtenirToutLesRole();

        // Signature des méthodes pour les Utilisateur
        void EnregistreUtilisateur(UtilisateurVM utilisateur);
        Utilisateur ObtenirUtilisateurParId(int UtilisateurID);
        List<Utilisateur> ObtenirToutLesUtilisateur();
    }
}
