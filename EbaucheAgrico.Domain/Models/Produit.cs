 using System;

namespace EbaucheAgrico.Domain
{
    public record Produit : IProduit
    {
        private double _prix;
        public double Prix
        {
            get => _prix;
            set
            {
                if (value < 0)
                    _prix = 0;
                else
                    _prix = value;
            }
        }

        public int Id { get; set; }
        public string Nom { get; set; }

        public Produit(){}

        public Produit(string nom, double prix)
        {
            this.Nom = nom;
            this.Prix = prix;
        }
        public Produit(int id, string nom, double prix)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prix = prix;
        }
    }

}
