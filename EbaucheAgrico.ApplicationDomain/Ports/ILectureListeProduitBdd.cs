using EbaucheAgrico.Domain;
using System.Collections.Generic;


namespace EbaucheAgrico.ApplicationDomain.Ports
{
    public interface ILectureListeProduitBdd
    {
       List<Produit> ObtenirListeProduits();
       Produit RecupererProduit(int id);
    }
}
