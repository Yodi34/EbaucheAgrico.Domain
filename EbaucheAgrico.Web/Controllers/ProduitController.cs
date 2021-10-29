using EbaucheAgrico.ApplicationDomain.AdaptateurEntre;
using EbaucheAgrico.ApplicationDomain.CasUsages;
using EbaucheAgrico.Infrastructure.AccesDonnees;
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
            ApplicationLectureProduitBdd casUsage = new ApplicationLectureProduitBdd(ad);
            AdaptateurWeb adpWeb = new AdaptateurWeb(casUsage);
            return adpWeb;
        }

        public ProduitController()
        {
        }


        [HttpGet]
        public IActionResult ListeProduits()
        {
            AdaptateurWeb InstanceAdaptateurWeb = InstancierLesLesModulesEtinjections();
            var liste = InstanceAdaptateurWeb.ObtenirListeProduits();
            var modelARetourner =  PresentateurListeProduits.ConvertirProduitEnViewModel(liste);

            return View("ListeProduit", modelARetourner);
        }

        [HttpGet]
        public IActionResult AJouterUnProduit()
        {
            return View("AjouterProduit");
        }
    }
}
