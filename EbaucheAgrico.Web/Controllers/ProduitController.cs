using EbaucheAgrico.ApplicationDomain.AdaptateurEntre;
using EbaucheAgrico.ApplicationDomain.CasUsages;
using EbaucheAgrico.Infrastructure.AccesDonnees;
using EbaucheAgrico.Web.Models;
using EbaucheAgrico.Web.Presentateur;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbaucheAgrico.Web.Controllers
{
    public class ProduitController : Controller
    {
        //private IAdaptateurWeb _adapteurWeb;
        private static AdaptateurWeb InstancierLesLesModulesEtinjections()
        {
            //BDD
            //AdapatateurSecondaire
            //CasUsages
            //WebAdaptateur
            BddMok bdd = new();
            AdapteurBddMok ad = new(bdd);
            IApplicationLectureProduitBdd casUsage = new ApplicationLectureProduitBdd(ad);
            IApplicationModifierProduitBdd casUsageModif = new ApplicationModifierProduitBdd (ad);
            AdaptateurWeb adpWeb = new AdaptateurWeb(casUsage, casUsageModif);
            return adpWeb;
        }



        private PresentateurListeProduits _presentateur { get; } = new();

        public ProduitController()
        {

        }

        [HttpGet]
        public IActionResult ListeProduits()
        {
            AdaptateurWeb InstanceAdaptateurWeb = InstancierLesLesModulesEtinjections();
            var liste = InstanceAdaptateurWeb.ObtenirListeProduits();
            var modelARetourner = this._presentateur.ConvertirProduitEnViewModel(liste);

            return View("ListeProduit", modelARetourner);
        }

        [HttpGet]
        public IActionResult AJouterUnProduit()
        {
            return View("AjouterProduit");
        }

        [HttpPost]
        public IActionResult AjouterProduit(ViewModelListProduits ProduitModel)
        {
            AdaptateurWeb InstanceAdaptateurWeb = InstancierLesLesModulesEtinjections();
            InstanceAdaptateurWeb.AjouterUnProduit(this._presentateur.ConvertirViewModelEnProduit(ProduitModel));
            return RedirectToAction("ListeProduits");
        }


    }
}
