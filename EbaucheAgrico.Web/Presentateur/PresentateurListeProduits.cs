
using EbaucheAgrico.Domain;
using EbaucheAgrico.Web.Models;
using System;
using System.Collections.Generic;

namespace EbaucheAgrico.Web.Presentateur
{
    public class PresentateurListeProduits
    {
        //public static ViewModelListProduits viewModel { get; set; }
        //public static List<ViewModelListProduits> listeViewModelListProduits { get; set; }


        internal List<ViewModelListProduits> ConvertirProduitEnViewModel(List<Produit> listeBrut)
        {
            List<ViewModelListProduits> listeViewModelListProduits = new();
            ViewModelListProduits viewModel = new();
            foreach (var produitBrut in listeBrut)
            {
                listeViewModelListProduits.Add(new(
                        viewModel.Id = produitBrut.Id.ToString(),
                        viewModel.Nom = produitBrut.Nom,
                        viewModel.Prix = produitBrut.Prix.ToString()
                    ));
            }
            return listeViewModelListProduits;
        }

        internal Produit ConvertirViewModelEnProduit(ViewModelListProduits produitViewModel)
        {
            double prixDouble = double.Parse(produitViewModel.Prix);
            if(produitViewModel.Id != string.Empty)
            {
                int idInt = Int32.Parse(produitViewModel.Id);
                Produit ProduitARenvoyer = new(idInt, produitViewModel.Nom, prixDouble);
                return ProduitARenvoyer;
            }
            else
            {
                Produit ProduitARenvoyer = new(produitViewModel.Nom, prixDouble);
                return ProduitARenvoyer;
            }
        }

    }
}
