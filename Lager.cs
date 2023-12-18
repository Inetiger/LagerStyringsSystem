
namespace LagerStyringsSystem
{
    internal class Lager
    {
        public List<IProdukt> Produkt = new List<IProdukt>
        {
            new Klær(250.50 , "Bukse", 'S'),
            new Matvare(250.50, "Øl", "Mai 2023"),
            new Elektronikk(250.50, "ØrePlugger", 24),
        };

        public void LeggTilProdukt()
        {
            switch (AskInt("Hva slags type produkt vil du legge til:\n1. Klær\n2. Matvare\n3. Elektronikk\n"))
            {
                case 1:
                    Produkt.Add(new Klær(AskInt("Hvor Mye koster produktet?"), Ask("Hva heter produktet?"), AskChar("Hva er størrelsen på produktet?")));
                    break;
                case 2:
                    Produkt.Add(new Matvare(AskInt("Hvor Mye koster produktet?"), Ask("Hva heter produktet?"), Ask("Når går produktet ut på dato?")));
                    break;
                case 3:
                    Produkt.Add(new Elektronikk(AskInt("Hvor Mye koster produktet?"), Ask("Hva heter produktet?"), AskInt("Når går garantien ut?")));
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Sorry, fant ikke hva du letet etter. Prøv igjen");
                    LeggTilProdukt();
                    break;
            }

        }

        public void FjernProdukt()
        {
            for (int i = 0; i < Produkt.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {Produkt[i].Navn}");
            }
            Produkt.RemoveAt(AskInt("Hvilket produkt vil du fjerne") - 1);
        }

        public void VisAlleProdukt()
        {
            foreach (var produkt in Produkt)
            {
                produkt.SkrivUtInfo();
            }
        }

        public string Ask(string question)
        {
            Console.Write($"{question}: ");
            return Console.ReadLine();
        }
        public int AskInt(string question)
        {
            return Convert.ToInt32(Ask(question));
        }
        public char AskChar(string question)
        {
            Console.Write($"{question}:");
            return Console.ReadKey().KeyChar;
        }
    }

}
