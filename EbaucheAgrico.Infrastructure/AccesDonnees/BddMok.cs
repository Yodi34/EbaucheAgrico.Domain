using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbaucheAgrico.Infrastructure.AccesDonnees
{
    public class BddMok
    {
        public List<ProduitModelMok> ListeProduitBdd { get; set; } = new ();
        internal List<KeyValuePair<int,int>> ListeTest { get; set; } = new();


        public BddMok()
        {


        }

        public List<ProduitModelMok> RenvoyerListeProduit()
        {
            this.ListeProduitBdd.Add(new ProduitModelMok(1, 4, "Tomate"));
            this.ListeProduitBdd.Add(new ProduitModelMok(2, 2, "Courgette"));
            this.ListeProduitBdd.Add(new ProduitModelMok(3, 2.5, "Orange"));
            this.ListeProduitBdd.Add(new ProduitModelMok(4, 2, "Pomme"));
            return this.ListeProduitBdd;
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
