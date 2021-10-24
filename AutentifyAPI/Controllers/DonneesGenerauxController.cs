using AutentifyAPI.Models;
using AutentifyAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Controllers
{
    public class DonneesGenerauxController : Controller
    {
        private IDAL dal ;
        public DonneesGenerauxController(IDAL _dal)
        {
            dal = _dal;
        }
        // PAYS....
        // GET: DonneesGenerauxController
        public ActionResult ConsulterListepays()
        {
            List<Pays> liste = dal.ObtenirToutLesPays();
            return View("ConsulterListepays", liste);
        }
        
        //REGION
        // GET: DonneesGenerauxController/Create
        [HttpGet]
        public ActionResult EnregistrerRegion()
        {
            ViewBag.liste = dal.ObtenirToutLesPays();
            return View("EnregistrerRegion");
        }

        // POST: DonneesGenerauxController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EnregistrerRegion(Region region)
        {
            ViewBag.liste = dal.ObtenirToutLesPays();
            if (ModelState.IsValid)
            {
                dal.EnregistreRegion(region);
                return RedirectToAction("ConsulterListeRegion");
            }
            else
            {
                return View("EnregistrerRegion");
            }
        }

        [HttpGet]
        public ActionResult ModifierRegion(int? Id)
        {
            ViewBag.liste = dal.ObtenirToutLesPays();

            Region r = dal.ObtenirRegionParId(Id.Value);
            return View("ModifierRegion", r);
        }

        // POST: DonneesGenerauxController/Update
        [HttpPost]
        public ActionResult ModifierRegion(int Id ,Region region)
        {
            if (ModelState.IsValid)
            {
                Region r = dal.ObtenirRegionParId(Id);

                r.Nom = region.Nom;
                r.PaysId = region.PaysId;
                dal.EnregistreRegion(r);
                return RedirectToAction("ConsulterListeRegion");
            }
            else
            {
                return View("ModifierRegion");
            }
        }

        // GET: DonneesGenerauxController
        public ActionResult ConsulterListeRegion()
        {
            List<Region> liste = dal.ObtenirToutteLesRegions();

            return View("ConsulterListeRegion", liste);
        }



        //GESTION DES LANGUES
        // GET: DonneesGenerauxController/Create
        public ActionResult EnregistrerLangue()
        {
            return View();
        }

        // POST: DonneesGenerauxController/Edit/5
        [HttpPost]
        public ActionResult EnregistrerLangue(LangueVM langue)
        {
            if (ModelState.IsValid)
            {
                dal.EnregistreLangue(langue);
                return RedirectToAction("ConsulterListeLangue");
            }
            else
            {
                return View("EnregistrerLangue");
            }
        }

        // GET: DonneesGenerauxController
        public ActionResult ConsulterListeLangue()
        {
           List<Langue> liste = dal.ObtenirToutteLesLangues();
           return View("ConsulterListeLangue", liste);
        }



        //GESTION DES VILLES
        // GET: DonneesGenerauxController/Create
        public ActionResult EnregistrerVille()
        {
            ViewBag.liste = dal.ObtenirToutteLesRegions();
            return View();
        }

        // POST: DonneesGenerauxController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EnregistrerVille(Ville ville)
        {
            ViewBag.liste = dal.ObtenirToutteLesRegions();
            if (ModelState.IsValid)
            {
                dal.EnregistreVille(ville);
                return RedirectToAction("ConsulterListeVille");
            }
            else
            {
                return View("EnregistrerVille");
            }
        }

        [HttpGet]
        public ActionResult ModifierVille(int? Id)
        {
            ViewBag.liste = dal.ObtenirToutteLesRegions();

            Ville v = dal.ObtenirVilleParId(Id.Value);
            return View("ModifierVille", v);
        }

        [HttpPost]
        public ActionResult ModifierVille(int Id, Ville ville)
        {
            if (ModelState.IsValid)
            {
                Ville v = dal.ObtenirVilleParId(Id);

                v.Nom = ville.Nom;
                v.RegionId = ville.RegionId;
                dal.EnregistreVille(v);
                return RedirectToAction("ConsulterListeVille");
            }
            else
            {
                return View("ModifierVille");
            }
        }

        // GET: DonneesGenerauxController
        public ActionResult ConsulterListeVille()
        {
            List<Ville> liste = dal.ObtenirToutteLesVille();
            return View("ConsulterListeVille", liste);
        }




        //GESTION DES SOCIETES
        // GET: DonneesGenerauxController/Create
        public ActionResult EnregistrerSociete()
        {
            return View();
        }

        // POST: DonneesGenerauxController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EnregistrerSociete(SocieteVM societe)
        {
            if (ModelState.IsValid)
            {
                dal.EnregistreSociete(societe);
                return RedirectToAction("ConsulterListeSociete");
            }
            else
            {
                return View("EnregistrerSociete");
            }
        }

        [HttpGet]
        public ActionResult ModifierSociete(int? Id)
        {
            Societe societe = dal.ObtenirSocieteParId(Id.Value);
            SocieteVM s = new SocieteVM();
            s.SocieteId = societe.SocieteId;
            s.Nom = societe.Nom;
            s.Sigle = societe.Sigle;
            s.DateCreation = DateTime.Now;
            s.Adresse = societe.Adresse;
            s.Email = societe.Email;
            s.Telephone = societe.Telephone;
            s.DateEnregistrement = DateTime.Now;
            return View("ModifierSociete", s);
        }

        // POST: DonneesGenerauxController/Update
        [HttpPost]
        public ActionResult ModifierSociete(SocieteVM societe)
        {
            if (ModelState.IsValid)
            {              
                dal.EnregistreSociete(societe);
                return RedirectToAction("ConsulterListeSociete");
            }
            else
            {
                return View("ModifierSociete");
            }
        }

        // GET: DonneesGenerauxController
        public ActionResult ConsulterListeSociete()
        {
            List<Societe> liste = dal.ObtenirToutteLesSociete();

            return View("ConsulterListeSociete", liste);
        }





        //GESTION DES AGENCES ################################
        // GET: DonneesGenerauxController/Create
        [HttpGet]
        public ActionResult EnregistrerAgence()
        {
            ViewBag.Societe = dal.ObtenirToutteLesSociete();
            ViewBag.Ville = dal.ObtenirToutteLesVille();
            return View("EnregistrerAgence");
        }

        // POST: DonneesGenerauxController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EnregistrerAgence(AgenceVM agence)
        {
            if (ModelState.IsValid)
            {
                dal.EnregistreAgence(agence);
                return RedirectToAction("ConsulterListeAgence");
            }
            else
            {
                return View("EnregistrerAgence");
            }
        }

        [HttpGet]
        public ActionResult ModifierAgence(int? Id)
        {
            ViewBag.Societe = dal.ObtenirToutteLesSociete();
            ViewBag.Ville = dal.ObtenirToutteLesVille();

            Agence agence = dal.ObtenirAgenceParId(Id.Value);
            AgenceVM a = new AgenceVM();
            a.AgenceId = agence.AgenceId;
            a.Libelle = agence.Libelle;
            a.Adresse = agence.Adresse;
            a.DateCreation = DateTime.Now;
            a.Email = agence.Email;
            a.DateEnregistrement = DateTime.Now;
            a.VilleId = agence.VilleId;
            a.SocieteId = agence.SocieteId;
            return View("ModifierAgence", a);
        }

        // POST: DonneesGenerauxController/Update
        [HttpPost]
        public ActionResult ModifierAgence(AgenceVM agence)
        {
            if (ModelState.IsValid)
            {
                dal.EnregistreAgence(agence);
                return RedirectToAction("ConsulterListeAgence");
            }
            else
            {
                return View("ModifierAgence");
            }
        }

        // GET: DonneesGenerauxController
        public ActionResult ConsulterListeAgence()
        {
            List<Agence> liste = dal.ObtenirToutteLesAgence();
            return View("ConsulterListeAgence", liste);
        }
        public IActionResult ListePeriode()
        {
            List<Periode> lst = dal.Getperiodes.ToList();
            return View(lst);
        }
        public IActionResult ListeExercice()
        {
            List<Exercice> lst = dal.GetExercices.ToList();
            return View(lst);
        }
        public IActionResult ListeMonnaie()
        {
            List<Monnaie> lst = dal.GetMonnaies.ToList();
            return View(lst);
        }
        public IActionResult ListePartenaire()
        {
            List<Partenaire> lst = dal.GetPartenaires.ToList();
            return View(lst);
        }
        public IActionResult ListeTypePartenaire()
        {
            List<TypePartenaire> lst = dal.GetTypePartenaires.ToList();
            return View(lst);
        }

        public IActionResult AddExercices()
        {
            ViewBag.Agence = dal.ObtenirToutteLesAgence();
            return View(); 
        }
        [HttpPost]
        public IActionResult AddExercices(Exercice exercice)
        {
            if (ModelState.IsValid)
            {
                exercice.DateEnregistrement = DateTime.Now;
                exercice.Etat = EtatExercice.EnCours;
                dal.AddExercice(exercice);
                return RedirectToAction("ListeExercice");
            }
            else
            {
                ModelState.AddModelError("", "Veuillez remplir correctement tous les champs");
                return View();
            }
        }
        public IActionResult AddPeriode()
        {
            ViewBag.Exercice = dal.GetExercices;
            return View();
        }
        [HttpPost]
        public IActionResult AddPeriode(Periode periode)
        {
            if (ModelState.IsValid)
            {
                periode.Etat = EtatPeriode.EnCours;
                dal.AddPeriode(periode);
                return RedirectToAction("ListePeriode");
            }
            else
            {
                ModelState.AddModelError("", "Veuillez remplir correctement tous les champs");
                return View();
            }
        }
        public IActionResult AddMonnaie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMonnaie(Monnaie monnaie)
        {
            if (ModelState.IsValid)
            {
                monnaie.DateEnregistrement = DateTime.Now;
                dal.AddMonnaie(monnaie);
                return RedirectToAction("ListeMonnaie");
            }
            else
            {
                ModelState.AddModelError("", "Veuillez remplir correctement tous les champs");
                return View();
            }
        }
        public IActionResult Addpartenaire()
        {
            ViewBag.Pays = dal.ObtenirToutLesPays();
            ViewBag.TypePartenaire = dal.GetTypePartenaires;
            return View();
        }
        [HttpPost]
        public IActionResult Addpartenaire(Partenaire partenaire)
        {
            if (ModelState.IsValid)
            {
                partenaire.DateEnregistrement = DateTime.Now;
                dal.AddPartenaire(partenaire);
                return RedirectToAction("ListePartenaire");
            }
            else
            {
                ModelState.AddModelError("", "Veuillez remplir correctement tous les champs");
                return View();
            }
        }
        public IActionResult AddTypePartenaire()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTypePartenaire(TypePartenaire typePartenaire)
        {
            if (ModelState.IsValid)
            {
                dal.AddTypePartenaire(typePartenaire);
                return RedirectToAction("ListeTypePartenaire");
            }
            else
            {
                ModelState.AddModelError("", "Veuillez remplir correctement tous les champs");
                return View();
            }
        }
    }
    
}
