using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbaucheAgrico.Infrastructure.AccesDonnees
{
    public class BddMok
    {
        public List<ProduitModelMok> ListeProduitBdd { get; set; } = RenvoyerListeProduit();


        public BddMok()
        {
            //this.ListeProduitBdd.Add(new ProduitModelMok(1, 4, "Tomate"));
            //this.ListeProduitBdd.Add(new ProduitModelMok(2, 2, "Courgette"));
            //this.ListeProduitBdd.Add(new ProduitModelMok(3, 2.5, "Orange"));
            //this.ListeProduitBdd.Add(new ProduitModelMok(4, 2, "Pomme"));
            //this.ListeProduitBdd = RenvoyerListeProduit();

        }

        private static List<ProduitModelMok> RenvoyerListeProduit()
        {
            List<ProduitModelMok> ListeProduitBdd = new();
            ListeProduitBdd.Add(new ProduitModelMok(1, 4, "Tomate"));
            ListeProduitBdd.Add(new ProduitModelMok(2, 2, "Courgette"));
            ListeProduitBdd.Add(new ProduitModelMok(3, 2.5, "Orange"));
            ListeProduitBdd.Add(new ProduitModelMok(4, 2, "Pomme"));
            return ListeProduitBdd;
        }

        //internal void AjouterUnProduitDansLaListe(ProduitModelMok produit)
        //{
        //    this.ListeProduitBdd.Add(produit);
        //}

        //internal ProduitModelMok SelectionnerUnProduitDeLaListe(int id)
        //{
        //    var produitTrouver = this.ListeProduitBdd.Find(p => p.Equals(id));
        //    return produitTrouver;
        //}

        //internal void ModifierUnProduitDeLaListe(ProduitModelMok produit)
        //{
        //    var produitAModifier = ObtenirUnProduit(produit.Id);
        //    produitAModifier.Nom = produit.Nom;
        //    produitAModifier.Prix = produit.Prix;
        //}

        //internal void SupprimerUnProduitDeLaListe(int id)
        //{
        //    this.ListeProduitBdd.RemoveAt(id);
        //}

    }
}
