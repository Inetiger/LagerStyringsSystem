namespace LagerStyringsSystem
{
    internal class Elektronikk : IProdukt
    {
        public double Pris { get; set; }
        public string Navn { get; set; }
        public int Garantitid { get; set; }

        public Elektronikk(double pris, string navn, int garantitid)
        {
            Pris = pris;
            Navn = navn;
            Garantitid = garantitid;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"{Navn} koster {Pris} og har garanti i {Garantitid} måneder");
        }
    }
}
