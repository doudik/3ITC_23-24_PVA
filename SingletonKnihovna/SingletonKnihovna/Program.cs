namespace SingletonKnihovna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knihovna knihovna = new Knihovna("SPSUL knihovna");
            SpravaKnihovny.vratSpravce().spravovaneKnihovny.Add(knihovna);
            Kniha harryPotter = new Kniha("Harry Potter", "J.K.Rowling");
            SpravaKnihovny.vratSpravce().PridejKnihu(harryPotter, knihovna);
            

            Console.WriteLine($"O knihovnu {knihovna.nazevKnihovny} se stará správce {SpravaKnihovny.vratSpravce().Name}");

            foreach (var item in knihovna.vratSeznamKnih())
            {
                Console.WriteLine($"Kniha: {item.nazevKnihy} | autor: {item.autorKnihy}");
            }
        }
        /*
         * Knihovna
         * 
         * Class SpravaKnih --> singleton
         *  
         *  PridejKnihu(Kniha kniha)
         *  OdeberKnihu(Kniha kniha)
         *  AktualizujKnihu(Kniha kniha)
         *  
         * Class Knihovna
         *      
         *  string nazevKnihovny
         *  List<Kniha> seznamKnih
         *  
         *  List<Kniha> ZiskejSeznamKnih()
         *  
         * Class Kniha
         *  
         *  string nazevKnihy
         *  string autorKnihy
         *  
         */
    }
}