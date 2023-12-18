namespace LagerStyringsSystem
{
    internal class Matvare : IProdukt
    {
        public double Pris { get; set; }
        public string Navn { get; set; }
        public string Utløpsdato { get; set; }

        public Matvare(double pris, string navn, string utløpsdato)
        {
            Pris = pris;
            Navn = navn;
            Utløpsdato = utløpsdato;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"{Navn} koster {Pris} og går ut {Utløpsdato}");
        }
    }
}
