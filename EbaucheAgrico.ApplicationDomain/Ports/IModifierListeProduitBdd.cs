using EbaucheAgrico.Domain;

namespace EbaucheAgrico.ApplicationDomain.Ports
{
    public interface IModifierListeProduitBdd
    {
        void AjouterUnProduit(Produit produit);
        void ModifierUnProduit(Produit id);
        void SupprimerUnProduit(int id);
    }
}
