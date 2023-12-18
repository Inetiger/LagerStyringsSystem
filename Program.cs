namespace LagerStyringsSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lager lager = new Lager();

            while (true)
            {
                Console.CursorLeft = (Console.WindowWidth / 2) - 17;
                Console.CursorTop = (Console.WindowHeight / 2) - 1;
                Ask("Trykk enter får å gå videre");
                Console.Clear();
                Start(lager);
            }
        }
        public static void Start(Lager lager)
        {

            switch (AskInt("Vil du:\n1. Se alle produktene\n2. Legge til nye produkter\n3. Fjerne produkter\n"))
            {
                case 1:
                    Console.Clear();
                    lager.VisAlleProdukt();
                    break;
                case 2:
                    Console.Clear();
                    lager.LeggTilProdukt();
                    break;
                case 3:
                    Console.Clear();
                    lager.FjernProdukt();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Sorry, fant ikke hva du letet etter. Prøv igjen");
                    Start(lager);
                    break;
            }
        }
        private static string Ask(string question)
        {
            Console.Write($"{question}: ");
            return Console.ReadLine();
        }

        private static int AskInt(string question)
        {
            return Convert.ToInt32(Ask(question));
        }
    }
}
