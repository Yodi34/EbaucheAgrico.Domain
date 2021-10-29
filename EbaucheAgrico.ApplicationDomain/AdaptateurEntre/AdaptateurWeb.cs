using EbaucheAgrico.ApplicationDomain.CasUsages;
using EbaucheAgrico.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbaucheAgrico.ApplicationDomain.AdaptateurEntre
{
    public class AdaptateurWeb : IAdaptateurWeb
    {
        private readonly IApplicationLectureProduitBdd _interactuerLectureProduit;
        private readonly IApplicationModifierProduitBdd _interactuerModificationProduit;

        public AdaptateurWeb(IApplicationLectureProduitBdd interactuerLectureProduit, IApplicationModifierProduitBdd interactuerModificationProduit)
        {
            this._interactuerLectureProduit = interactuerLectureProduit;
            this._interactuerModificationProduit = interactuerModificationProduit;
        }

        public List<Produit> ObtenirListeProduits()
        {
            return this._interactuerLectureProduit.ObtenirListeProduit();
        }

        public void AjouterUnProduit(Produit produit)
        {
            this._interactuerModificationProduit.AjouterUnProduit(produit);
        }
    }
}
