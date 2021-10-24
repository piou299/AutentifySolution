using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public class RamsesAuthContext : DbContext
    {

        public RamsesAuthContext(DbContextOptions<RamsesAuthContext> options) : base(options)
        {

        }
        public virtual DbSet<Agence> Agences {get;set;}
        public virtual DbSet<Connexion> Connexions{get;set;}
        public virtual DbSet<Departement> Departements{get;set;}
        public virtual DbSet<Exercice> Exercices{get;set;}
        public virtual DbSet<JourFeries> JourFeries{get;set;}
        public virtual DbSet<Langue> Langues {get;set;}
        public virtual DbSet<Monnaie> Monnaies {get;set;}
        public virtual DbSet<Partenaire> Partenaires {get;set;}
        public virtual DbSet<Password> Passwords {get;set;}
        public virtual DbSet<Pays> Pays {get;set;}
        public virtual DbSet<Periode> Periodes {get;set;}
        public virtual DbSet<Personne> Personnes {get;set;}
        public virtual DbSet<Region> Regions {get;set;}
        public virtual DbSet<Role> Roles {get;set;}
        public virtual DbSet<Societe> Societes {get;set;}
        public virtual DbSet<SocieteJourFeries> SocieteJourFeries {get;set;}
        public virtual DbSet<SocieteMonnaie> SocieteMonnaies {get;set;}
        public virtual DbSet<SocietePartenaire> SocietePartenaires {get;set;}
        public virtual DbSet<TypePartenaire> TypePartenaires {get;set;}
        public virtual DbSet<UserRole> UserRoles {get;set;}
        public virtual DbSet<Utilisateur> Utilisateurs {get;set;}
        public virtual DbSet<Ville> Villes {get;set;}
    }
}
