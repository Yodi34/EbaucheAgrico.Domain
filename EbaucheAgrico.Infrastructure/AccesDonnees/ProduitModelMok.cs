using EbaucheAgrico.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbaucheAgrico.Infrastructure.AccesDonnees
{
    public class ProduitModelMok
    {
        public int Id { get; set; }
        public double Prix { get; set; }
        public string Nom { get; set; }

        public ProduitModelMok(int id, double prix, string nom)
        {
            this.Id = id;
            this.Prix = prix;
            this.Nom = nom;
        }
    }
}
