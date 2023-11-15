using Composite;

class Program {
    static void Main(string[] args) { 
        Snek frantisek = new Snek();
        Snek fuuurian = new Snek();

        Pasovec pasovec = new Pasovec();

        StepMom stepMom = new StepMom(20.0f);
        StepMom MojzirMamka = new StepMom(14.0f);

        AnimalGang tym_mamka = new AnimalGang();
        tym_mamka.animals.Add(stepMom);
        tym_mamka.animals.Add(MojzirMamka);

        AnimalGang tym_frantiska = new AnimalGang();
        tym_frantiska.animals.Add(pasovec);
        
        AnimalGang tym_snek = new AnimalGang();
        tym_snek.animals.Add(fuuurian);

        AnimalGang VsechnyZviratka = new AnimalGang();
        VsechnyZviratka.animals.Add(tym_mamka);
        VsechnyZviratka.animals.Add(tym_frantiska);
        VsechnyZviratka.animals.Add(tym_snek);
        VsechnyZviratka.MakeSound();

        //Console.WriteLine(VsechnyZviratka.animals[0].);

        AnimalGang tmp = (AnimalGang)VsechnyZviratka.animals[0];
        foreach (var item in tmp.animals)
        {
            Console.WriteLine(((StepMom)item).vek);
        }
    }
}