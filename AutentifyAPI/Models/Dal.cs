using AutentifyAPI.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public class Dal : IDAL
    {
        private readonly RamsesAuthContext db;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public Dal(RamsesAuthContext bdd, IWebHostEnvironment webHostEnvironment)
        {
            db = bdd;
            _webHostEnvironment = webHostEnvironment;
        }

        public IEnumerable<Periode> Getperiodes => db.Periodes.Include(p=>p.Exercice);
        public IEnumerable<Exercice> GetExercices => db.Exercices.Include(p=>p.Agence).Include(p => p.Periodes);
        public IEnumerable<Monnaie> GetMonnaies => db.Monnaies;
        public IEnumerable<Partenaire> GetPartenaires => db.Partenaires.Include(p=>p.TypePartenaire).Include(p => p.Pays);
        public IEnumerable<TypePartenaire> GetTypePartenaires => db.TypePartenaires.Include(p=>p.Partenaires);

        public bool AddPeriode(Periode periode)
        {
            try
            {
                db.Periodes.Add(periode);
                db.SaveChanges();
                return true;
            }catch(Exception e)
            {
                Console.WriteLine("RAMSESS Exception Api" + e.Message);
                return false;
            }
        }
        public bool AddExercice(Exercice exercice)
        {
            try
            {
                db.Exercices.Add(exercice);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("RAMSESS Exception Api" + e.Message);
                return false;
            }
        }
        public bool AddMonnaie(Monnaie monnaie)
        {
            try
            {
                db.Monnaies.Add(monnaie);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("RAMSESS Exception Api" + e.Message);
                return false;
            }
        }
        public bool AddPartenaire(Partenaire partenaire)
        {
            try
            {
                db.Partenaires.Add(partenaire);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("RAMSESS Exception Api" + e.Message);
                return false;
            }
        }
        public bool AddTypePartenaire(TypePartenaire typePartenaire)
        {
            try
            {
                db.TypePartenaires.Add(typePartenaire);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("RAMSESS Exception Api" + e.Message);
                return false;
            }
        }
        public void EnregistreAgence(AgenceVM agence)
        {
            if (agence.AgenceId == 0)
            {
                Agence agenceItem = new Agence();
                //***
                agenceItem.Libelle = agence.Libelle;
                agenceItem.Adresse = agence.Adresse;
                agenceItem.DateCreation = DateTime.Now;
                agenceItem.Email = agence.Email;
                agenceItem.DateEnregistrement = DateTime.Now;
                agenceItem.VilleId = agence.VilleId;
                agenceItem.SocieteId = agence.SocieteId;
                //***
                if (agence.Image != null)
                {
                    string ext = Path.GetExtension(agence.Image.FileName);
                    if (ext.ToLower() != ".jpeg" || ext.ToLower() != ".png" || ext.ToLower() == ".jpg")
                    {
                        var newName = "IMG_" + new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds().ToString() + "_" + agence.Libelle.ToUpper() + ext;
                        var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "IconeAgence", newName.ToString());

                        using (var filestram = new FileStream(filePath, FileMode.Create))
                        {
                            agence.Image.CopyTo(filestram);
                        }
                        agenceItem.Image = newName.ToString();

                    }
                }
                db.Agences.Add(agenceItem);
                db.SaveChanges();
            }
            else
            {
                Agence a = ObtenirAgenceParId(agence.AgenceId);
                a.Libelle = agence.Libelle;
                a.Adresse = agence.Adresse;
                a.DateCreation = DateTime.Now;
                a.Email = agence.Email;
                a.DateEnregistrement = DateTime.Now;
                a.VilleId = agence.VilleId;
                a.SocieteId = agence.SocieteId;
                db.SaveChanges();
            }
        }

        public void EnregistreLangue(LangueVM langue)
        {
            if (langue.LangueId == 0)
            {
                Langue lang = new Langue()
                {
                    DateEnregistrement = DateTime.Now,
                    Libelle = langue.Libelle,
                };
                if (langue.Icone != null)
                {
                    string ext = Path.GetExtension(langue.Icone.FileName);
                    if(ext.ToLower()!=".jpeg" || ext.ToLower()!=".png" || ext.ToLower() == ".jpg")
                    {
                        var newName = "IMG_" + new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds().ToString() + "_" + langue.Libelle.ToUpper() + ext;
                        var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "IconeLangue", newName.ToString());

                        using(var filestram = new FileStream(filePath, FileMode.Create))
                        {
                            langue.Icone.CopyTo(filestram);
                        }
                        lang.Icone = newName.ToString();
                        
                    }
                }
                db.Langues.Add(lang);
                db.SaveChanges();
            }
            else
            {
                db.SaveChanges();
            }
        }

        public void EnregistreRegion(Region region)
        {
            if(region.RegionId == 0)
            {
                region.DateEnregistrement = DateTime.Now;
                db.Regions.Add(region);
                db.SaveChanges();
            }
            else
            {
               db.SaveChanges();
            }
            
        }

        public void EnregistreSociete(SocieteVM societe)
        {
            if (societe.SocieteId == 0)
            {
                Societe societeItem = new Societe()
                {
                    Nom = societe.Nom,
                    Sigle = societe.Sigle,
                    DateCreation = DateTime.Now,
                    Adresse = societe.Adresse,
                    Email = societe.Email,
                    Telephone = societe.Telephone,
                    DateEnregistrement = DateTime.Now,
                };
                if (societe.Logo != null)
                {
                    string ext = Path.GetExtension(societe.Logo.FileName);
                    if (ext.ToLower() != ".jpeg" || ext.ToLower() != ".png" || ext.ToLower() == ".jpg")
                    {
                        var newName = "IMG_" + new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds().ToString() + "_" + societe.Nom.ToUpper() + ext;
                        var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "IconeSociete", newName.ToString());

                        using (var filestram = new FileStream(filePath, FileMode.Create))
                        {
                            societe.Logo.CopyTo(filestram);
                        }
                        societeItem.Logo = newName.ToString();

                    }
                }
                db.Societes.Add(societeItem);
                db.SaveChanges();
            }
            else
            {
                Societe s = ObtenirSocieteParId(societe.SocieteId);
                s.Nom = societe.Nom;
                s.Sigle = societe.Sigle;
                s.DateCreation = DateTime.Now;
                s.Adresse = societe.Adresse;
                s.Email = societe.Email;
                s.Telephone = societe.Telephone;
                s.DateEnregistrement = DateTime.Now;
                db.SaveChanges();
            }
        }

        public void EnregistreVille(Ville ville)
        {
            if (ville.VilleId == 0)
            {
                db.Villes.Add(ville);
                db.SaveChanges();
            }
            else
            {
                db.SaveChanges();
            }
        }

        public Agence ObtenirAgenceParId(int AgenceID)
        {
            return db.Agences.FirstOrDefault(a => a.AgenceId == AgenceID);
        }

        public Langue ObtenirLangueParId(int LangueID)
        {
            return db.Langues.FirstOrDefault(l => l.LangueId == LangueID);
        }

        public Pays ObtenirPaysParId(int PaysID)
        {
            return db.Pays.FirstOrDefault(p => p.PaysId == PaysID);
        }

        public Region ObtenirRegionParId(int RegionID)
        {
            return db.Regions.FirstOrDefault(r => r.RegionId == RegionID);
        }

        public Societe ObtenirSocieteParId(int SocieteID)
        {
            return db.Societes.FirstOrDefault(s => s.SocieteId == SocieteID);
        }

        public List<Pays> ObtenirToutLesPays()
        {
            return db.Pays.ToList();
        }

        public List<Agence> ObtenirToutteLesAgence()
        {
            return db.Agences.Include(e => e.Ville).Include(e => e.Societe).ToList();
        }

        public List<Langue> ObtenirToutteLesLangues()
        {
            return db.Langues.ToList();
        }

        public List<Region> ObtenirToutteLesRegions()
        {
            return db.Regions.Include(e=>e.Pays).ToList();
        }

        public List<Societe> ObtenirToutteLesSociete()
        {
            return db.Societes.ToList();
        }

        public List<Ville> ObtenirToutteLesVille()
        {
            return db.Villes.Include(e => e.Regions).ToList();
        }

        public Ville ObtenirVilleParId(int VilleID)
        {
            return db.Villes.FirstOrDefault(v => v.VilleId == VilleID);
        }

        public void EnregistreRole(Role role)
        {
            if (role.RoleId == 0)
            {
                db.Roles.Add(role);
                db.SaveChanges();
            }
            else
            {
                db.SaveChanges();
            }
        }

        public Role ObtenirRoleParId(int RoleId)
        {
            return db.Roles.FirstOrDefault(r => r.RoleId == RoleId);
        }

        public List<Role> ObtenirToutLesRole()
        {
            return db.Roles.ToList();
        }

        public void EnregistreUtilisateur(UtilisateurVM utilisateur)
        {
            if (utilisateur.Id == 0)
            {
                Personne personneItem = new Personne()
                {
                    Nom = utilisateur.Nom,
                    Prenom = utilisateur.Prenom,
                    Telephone = utilisateur.Telephone,
                    Email = utilisateur.Email,
                    Sexe = utilisateur.Sexe,
                    DateNaissance = DateTime.Now,
                    DateEnregistrement = DateTime.Now,
                    LieuNaissance = utilisateur.LieuNaissance
                };
                if (utilisateur.Photo != null)
                {
                    string ext = Path.GetExtension(utilisateur.Photo.FileName);
                    if (ext.ToLower() != ".jpeg" || ext.ToLower() != ".png" || ext.ToLower() == ".jpg")
                    {
                        var newName = "IMG_" + new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds().ToString() + "_" + utilisateur.Nom.ToUpper() + ext;
                        var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "IconeUser", newName.ToString());

                        using (var filestram = new FileStream(filePath, FileMode.Create))
                        {
                            utilisateur.Photo.CopyTo(filestram);
                        }
                        personneItem.Photo = newName.ToString();

                    }
                }
                db.Personnes.Add(personneItem);
                db.SaveChanges();
                //*****
                Utilisateur userItem = new Utilisateur()
                {
                    Login = utilisateur.Login,
                    Etat = utilisateur.Etat,
                    AgenceId = utilisateur.AgenceId,
                    PersonneId = personneItem.PersonneId,
                    LangueId = utilisateur.LangueId,
                };
                db.Utilisateurs.Add(userItem);
                db.SaveChanges();

                //***
                UserRole userRoleItem = new UserRole()
                {
                    DateEnregistrement = DateTime.Now,
                    RoleId = utilisateur.RoleId,
                    UtilisateurId = userItem.UtilisateurId
                };
                db.UserRoles.Add(userRoleItem);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public Utilisateur ObtenirUtilisateurParId(int UtilisateurID)
        {
            return db.Utilisateurs.FirstOrDefault(u => u.UtilisateurId == UtilisateurID);
        }

        public List<Utilisateur> ObtenirToutLesUtilisateur()
        {
            return db.Utilisateurs.Include(u => u.Langue).Include(u => u.Personne).Include(u => u.Agence).ToList();
        }
    }
}
