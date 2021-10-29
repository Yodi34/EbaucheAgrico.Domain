
using EbaucheAgrico.Domain;
using EbaucheAgrico.Web.Models;
using System.Collections.Generic;

namespace EbaucheAgrico.Web.Presentateur
{
    internal static class PresentateurListeProduits
    {
        //public static ViewModelListProduits viewModel { get; set; }
        //public static List<ViewModelListProduits> listeViewModelListProduits { get; set; }


        internal static List<ViewModelListProduits> ConvertirProduitEnViewModel(List<Produit> listeBrut)
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
    }
}
