using EbaucheAgrico.ApplicationDomain.Ports;
using EbaucheAgrico.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EbaucheAgrico.ApplicationDomain.CasUsages
{
    internal class ApplicationModifierProduitBdd : IApplicationModifierProduitBdd
    {
        private readonly IModifierListeProduitBdd _PortModifierProduit;

        public ApplicationModifierProduitBdd(IModifierListeProduitBdd portModificationProduit)
        {
            this._PortModifierProduit = portModificationProduit;
        }

        internal void AjouterUnProduit(Produit parametreProduitEntree)
        {
            Produit produitAModifier = parametreProduitEntree;
            AjouterSEnFinDeMot(produitAModifier.Nom);
            if (!ExisteDejaEnBdd(produitAModifier.Id))
            {
                produitAModifier.Prix = produitAModifier.Prix < 0 ? 0 : produitAModifier.Prix;
                this._PortModifierProduit.AjouterUnProduit(produitAModifier);
            }
        }

        private static void AjouterSEnFinDeMot(string s)
        {
            var derniereLettre = s.ToLower().Last();
            if(derniereLettre is not 's')
            {
                s += 's';
            }
        }

        private static bool ExisteDejaEnBdd(int id)
        {
            ApplicationLectureProduitBdd lectureProuduit = new();
            return lectureProuduit.ExisteDejaEnBdd(id);
        }
    }
}
