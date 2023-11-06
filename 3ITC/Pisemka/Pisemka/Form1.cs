namespace Pisemka
{
    public partial class Form1 : Form
    {
        private List<Kontakt> kontakty;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            kontakty = new List<Kontakt>();
            InitKontakty(3);
            NacistKontaktyDoListBoxu();
        }
        //Init
        private void InitKontakty(int number)
        {
            Random rnd = new Random();
            string[] jmena = { "Adam", "Karel", "Popel" };
            string[] email = { "gmail.com", "seznam.cz", "centrum.cz" };

            for (int i = 0; i < number; i++)
            {
                kontakty.Add(new Kontakt(jmena[rnd.Next(0, jmena.Length)], email[rnd.Next(0, email.Length)]));
            }
        }
        private void NacistKontaktyDoListBoxu()
        {
            listBox1.Items.Clear();
            foreach (Kontakt kontakt in kontakty)
            {
                listBox1.Items.Add($"{kontakt.jmeno} - {kontakt.email}");
            }
            //stejnì je to naprd, protože to není optimalizovaný.. ale není na to èas
        }
        
        //Events
        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text.Length > 0 && textBox_email.Text.Length > 0) {
                if (textBox_email.Text.Contains("@") && textBox_email.Text.Contains(".")) { 
                    string jmeno = textBox_name.Text;
                    string email = textBox_email.Text;
                    if (!string.IsNullOrWhiteSpace(jmeno) && !string.IsNullOrWhiteSpace(email))
                    {
                        
                        kontakty.Add(new Kontakt(jmeno, email));
                        NacistKontaktyDoListBoxu();
                        textBox_name.Clear();
                        textBox_email.Clear();
                    }
                }
            }
        }
        private void button_remove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string kontakt = listBox1.SelectedItem.ToString();
                kontakt = kontakt.Substring(0, kontakt.IndexOf(" - "));

                Kontakt vybranyKontakt = NajdiKontakt(kontakt);
                kontakty.Remove(vybranyKontakt);
                NacistKontaktyDoListBoxu();
            }
        }
        private Kontakt NajdiKontakt(string name)
        {
            foreach (Kontakt item in kontakty)
            {
                if (item.jmeno == name) {
                    return item;
                }
            }
            return null;
        }
    }
}