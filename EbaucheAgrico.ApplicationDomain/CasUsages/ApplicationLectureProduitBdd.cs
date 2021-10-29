using EbaucheAgrico.ApplicationDomain.Ports;
using EbaucheAgrico.Domain;
using System.Collections.Generic;

namespace EbaucheAgrico.ApplicationDomain.CasUsages
{
    public class ApplicationLectureProduitBdd : IApplicationLectureProduitBdd
    {
        private readonly ILectureListeProduitBdd _portLectureProduit;

        public ApplicationLectureProduitBdd(ILectureListeProduitBdd portLectureProduit)
        {
            this._portLectureProduit = portLectureProduit;
        }
        public ApplicationLectureProduitBdd()
        {

        }

        public List<Produit> ObtenirListeProduit()
        {
            var liste = this._portLectureProduit.ObtenirListeProduits();
            return liste;
        }

        internal Produit ObtenirUnProduit(int id)
        {
            var produit = this._portLectureProduit.RecupererProduit(id);
            return produit;
        }

        internal bool ExisteDejaEnBdd(int id)
        {
            var listeProduits = this._portLectureProduit.ObtenirListeProduits();
            var idProduit = this._portLectureProduit.RecupererProduit(id);
            //listeProduits.ForEach(p => p.Nom.Contains(idProduit.Nom));
            foreach (var produit in listeProduits)
            {
                if (produit.Nom.Equals(idProduit.Nom))
                    return true;
                else
                    return false;
            }
            return false;
        }
    }
}
