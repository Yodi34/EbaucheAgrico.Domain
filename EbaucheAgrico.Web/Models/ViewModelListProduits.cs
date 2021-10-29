using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbaucheAgrico.Web.Models
{
    public class ViewModelListProduits
    {
        public string Id { get; set; }
        public string Prix { get; set; }
        public string Nom { get; set; }

        public ViewModelListProduits()
        {

        }

        public ViewModelListProduits(string id, string nom, string prix)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prix = prix;
        }
    }
}
