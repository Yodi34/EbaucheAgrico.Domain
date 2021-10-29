namespace EbaucheAgrico.Domain
{
    public interface IProduit
    {
        double Prix { get; set; }
        public int Id { get; set; }
        public string Nom { get; set; }
    }
}