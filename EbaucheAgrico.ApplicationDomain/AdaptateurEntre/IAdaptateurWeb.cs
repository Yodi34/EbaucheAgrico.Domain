using EbaucheAgrico.Domain;
using System.Collections.Generic;

namespace EbaucheAgrico.ApplicationDomain.AdaptateurEntre
{
    public interface IAdaptateurWeb
    {
        List<Produit> ObtenirListeProduits();
    }
}