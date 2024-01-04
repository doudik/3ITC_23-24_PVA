namespace BeatGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Umelec cl = new Umelec("Jozef");
            Producent.Instance.Clear();
            Producent.Instance.generujSlova();
            Producent.Instance.InfoPisnicka();
            
        }
    }
}