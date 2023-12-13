namespace ManagementApp___Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Departments management = new Departments("Management");
            Departments economy = new Departments("Economy");
            Departments IT = new Departments("IT");

            IT.Add(new Employee("Karel", "Kovář", IT));
            IT.Add(new Employee("Franta", "Františků", IT));
            IT.Add(new Employee("Michal", "Procházka", IT));
            IT.Add(new Employee("Petr", "Černý", IT));

            management.Add(new Employee("Pavel", "Šotola", management));
            management.Add(new Employee("Antonín", "Svobodka", management));
            management.Add(new Employee("Svatopluk", "Němec", management));
            management.Add(new Employee("Vratislav", "Douda", management));
            management.Add(new Employee("František", "The Este", management));

            economy.Add(new Employee("Ludmila", "Černá", economy));
            economy.Add(new Employee("Miloslava", "Doudová", economy));
            economy.Add(new Employee("Matěj", "The Skůtr", economy));
            economy.Add(new Employee("Karolína", "Čechová", economy));
            economy.Add(new Employee("Jakub", "Ryba", economy));

            Company SPSUL = new Company("SPŠUL");
            SPSUL.Add(management);
            SPSUL.Add(economy);
            SPSUL.Add(IT);
            SPSUL.ExtractAllInformationToConsole();
        }
    }
}