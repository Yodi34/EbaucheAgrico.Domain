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

        public AdaptateurWeb(IApplicationLectureProduitBdd interactuerLectureProduit)
        {
            this._interactuerLectureProduit = interactuerLectureProduit;
        }

        public List<Produit> ObtenirListeProduits()
        {
            return this._interactuerLectureProduit.ObtenirListeProduit();
        }
    }
}
