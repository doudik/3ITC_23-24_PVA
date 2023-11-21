namespace SingletonKnihovna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SpravaKnihovny.vratSpravce.name);
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