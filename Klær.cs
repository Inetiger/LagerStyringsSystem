namespace LagerStyringsSystem
{
    internal class Klær : IProdukt
    {
        public double Pris { get; set; }
        public string Navn { get; set; }
        public char Størrelse { get; set; }

        public Klær(double pris, string navn, char størrelse)
        {
            Pris = pris;
            Navn = navn;
            Størrelse = størrelse;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"{Navn} koster {Pris} og er en {Størrelse}");
        }
    }
}
