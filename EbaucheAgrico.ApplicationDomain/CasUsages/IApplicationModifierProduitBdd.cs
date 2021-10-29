using EbaucheAgrico.Domain;

namespace EbaucheAgrico.ApplicationDomain.CasUsages
{
    public interface IApplicationModifierProduitBdd
    {
        void AjouterUnProduit(Produit produit);
        //void ModifierUnProduits(Produit produit);
        //void SupprimerUnProduits(int id);
    }
}