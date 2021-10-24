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
    public class GestionUtilisateursController : Controller
    {
        private IDAL dal;
        public GestionUtilisateursController(IDAL _dal)
        {
            dal = _dal;
        }

        //ROLE
        // GET: GestionUtilisateursController/Create
        [HttpGet]
        public ActionResult EnregistrerRole()
        {
            return View();
        }

        // POST: GestionUtilisateursController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EnregistrerRole(Role role)
        {
            if (ModelState.IsValid)
            {
                dal.EnregistreRole(role);
                return RedirectToAction("ConsulterListeRole");
            }
            else
            {
                return View("EnregistrerRole");
            }
        }

        [HttpGet]
        public ActionResult ModifierRole(int? Id)
        {
            Role r = dal.ObtenirRoleParId(Id.Value);
            return View("ModifierRole", r);
        }

        [HttpPost]
        public ActionResult ModifierRole(int Id, Role role)
        {
            if (ModelState.IsValid)
            {
                Role r = dal.ObtenirRoleParId(Id);
                r.Libelle = role.Libelle;
                r.RoleId = role.RoleId;
                dal.EnregistreRole(r);
                return RedirectToAction("ConsulterListeRole");
            }
            else
            {
                return View("ModifierRole");
            }
        }
        // GET: GestionUtilisateursController/List
        public ActionResult ConsulterListeRole()
        {
            List<Role> liste = dal.ObtenirToutLesRole();
            return View("ConsulterListeRole", liste);
        }



        //*********************UTLISATEURS
        // GET: GestionUtilisateursController/Create
        [HttpGet]
        public ActionResult EnregistrerUtilisateur()
        {
            ViewBag.Lang = dal.ObtenirToutteLesLangues();
            ViewBag.Agen = dal.ObtenirToutteLesAgence();
            ViewBag.Role = dal.ObtenirToutLesRole();
            return View();
        }

        // POST: GestionUtilisateursController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EnregistrerUtilisateur(UtilisateurVM user)
        {
            if (ModelState.IsValid)
            {
                dal.EnregistreUtilisateur(user);
                return RedirectToAction("ConsulterListeUtilisateur");
            }
            else
            {
                return View("EnregistrerUtilisateur");
            }
        }

        // GET: GestionUtilisateursController/List
        public ActionResult ConsulterListeUtilisateur()
        {
            return View();
        }





        // GET: GestionUtilisateursController
        public ActionResult Authentification()
        {
            return View();
        }

        // GET: GestionUtilisateursController
        public ActionResult MotDePasseOublier()
        {
            return View();
        }

        public ActionResult CreerUtilisateur()
        {
            return View();
        }
        // GET: GestionUtilisateursController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GestionUtilisateursController/Create
        public ActionResult CreatePerson()
        {
            return View();
        }

        // POST: GestionUtilisateursController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GestionUtilisateursController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GestionUtilisateursController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GestionUtilisateursController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GestionUtilisateursController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
