using EbaucheAgrico.Domain;
using System.Collections.Generic;

namespace EbaucheAgrico.ApplicationDomain.CasUsages
{
    public interface IApplicationLectureProduitBdd
    {
       public List<Produit> ObtenirListeProduit();

    }
}