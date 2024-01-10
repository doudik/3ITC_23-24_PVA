namespace SpravaZamestnancu_Singleton_Dedicnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zamestnanec Honza = new Zamestnanec("Jan", "Adam", 3);
            Zamestnanec Petr = new Zamestnanec("Petr", "Polák", 11);
            Zamestnanec Frantisek = new Zamestnanec("František", "Pepa", 1);

            Manazer alfa = new Manazer("Adam", "Doležal", 30);
            alfa.PridatPodrizeny(Honza);
            alfa.PridatPodrizeny(Petr);

            alfa.VypisInformace();

            SpravaZamestnancu.spravaZamestnancu.PridatZamestnance(Honza);
            SpravaZamestnancu.spravaZamestnancu.PridatZamestnance(Petr);
            SpravaZamestnancu.spravaZamestnancu.PridatZamestnance(Frantisek);

            SpravaZamestnancu.spravaZamestnancu.VypisZamestnancu();

        }
    }
}