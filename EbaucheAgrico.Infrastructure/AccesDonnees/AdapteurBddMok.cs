using EbaucheAgrico.ApplicationDomain.Ports;
using EbaucheAgrico.Domain;
using System;
using System.Collections.Generic;



namespace EbaucheAgrico.Infrastructure.AccesDonnees
{
    public class AdapteurBddMok : ILectureListeProduitBdd, IModifierListeProduitBdd
    {
        private readonly BddMok _bddMok;

        //Injection de dépendance de la bdd contenant une liste de produits test
        public AdapteurBddMok(BddMok bddMok)
        {
            this._bddMok = bddMok;
        }

        public List<Produit> ObtenirListeProduits()
        {
            List<ProduitModelMok> liste = this._bddMok.RenvoyerListeProduit();

            List<Produit> listeTransorme = new();
            foreach (var produit in liste)
            {
                Produit produitTransforme = new();

                produitTransforme.Id = produit.Id;
                produitTransforme.Nom = produit.Nom;
                produitTransforme.Prix = produit.Prix;

                listeTransorme.Add(produitTransforme);
            } 
            return listeTransorme;
        }

        public Produit RecupererProduit(int id)
        {
            Produit produitARetourner = new Produit();
            try
            {
                var produitMok = this._bddMok.ListeProduitBdd.Find(x => x.Id == id);

                produitARetourner.Id = produitMok.Id;
                produitARetourner.Nom = produitMok.Nom;
                produitARetourner.Prix = produitMok.Prix;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return produitARetourner;
        }

        public void AjouterUnProduit(Produit produit)
        {
            try
            {
                this._bddMok.ListeProduitBdd.Add(new(produit.Id, produit.Prix, produit.Nom));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ModifierUnProduit(Produit produit)
        {
            try
            {
                ProduitModelMok produitAModifierEnBdd = this._bddMok.ListeProduitBdd.Find(i => i.Id == produit.Id);
                //int indexProuduit = this._bddMok.ListeProduitBdd.FindIndex(i=>i.Id == produit.Id);
                produitAModifierEnBdd.Id = produit.Id;
                produitAModifierEnBdd.Nom = produit.Nom;
                produitAModifierEnBdd.Prix = produit.Prix;
                this._bddMok.ListeProduitBdd.Add(produitAModifierEnBdd);
                this._bddMok.ListeProduitBdd.RemoveAt(produit.Id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SupprimerUnProduit(int id)
        {
            try
            {
                this._bddMok.ListeProduitBdd.RemoveAt(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
