using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;

namespace SingletonDBConnect
{
    internal sealed class ConnectionManager
    {
        public static ConnectionManager connManager = new ConnectionManager();
        string connStr = "server=localhost;user=root;database=World;port=3306;password=";
        MySqlConnection conn;
        MySqlCommand cmd;

        public MySqlConnection Conn { get { return conn; } }

        private ConnectionManager()
        {
            conn = new MySqlConnection(connStr);
            Connect();
        }
        public void Connect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("Connected!");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AddCoutry(string country, string shortCode)
        {
            string sql = $"INSERT INTO country(country, short_code) VALUES ('{country}', '{shortCode}')";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public void UIMenu()
        {
            Console.Clear();
            Console.WriteLine("" +
                "1. Výpis všech záznamů \n" +
                "2. Vložení záznamu \n" +
                "3. Smazání záznamu");
            int volba = int.Parse(Console.ReadLine());
            UIDialog(volba);
        }
        private void UIDialog(int volba)
        {
            string kodZeme = "";
            string zeme = "";
            switch (volba)
            {
                case 1:
                    //vypis
                    VypisZaznamy();
                    UIMenu();
                    break;
                case 2:
                    
                    //vlozeni
                    Console.WriteLine("Napište název země:");
                    zeme = Console.ReadLine();

                    Console.WriteLine("Napište zkratku(kód) země:");
                    if ((Console.ReadLine().Length <= 3))
                    {
                        kodZeme = Console.ReadLine();
                    }
                    else {
                        Console.WriteLine("Zkratka země nesmí být delší než 3 znaky!");
                        UIMenu();
                    }
                    
                    VlozeniZaznamu(zeme, kodZeme);
                    UIMenu();
                    break;
                case 3:
                    //smaz
                    Console.WriteLine("Jaký je kód země, kterou chcete smazat?");
                    kodZeme = Console.ReadLine();
                    SmazZaznamy(kodZeme);
                    UIMenu();
                    break;
                default:
                    Console.WriteLine("Špatná operace");
                    Console.ReadLine();
                    UIMenu();
                    break;
                    //mazani
                    //vypis
                    //vloz
            }
        }
        void VypisZaznamy()
        {
            string sql = "SELECT * FROM country";
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " -- " + rdr[1] + " -- " + rdr[2]);
            }
            rdr.Close();
            Console.ReadLine();
        }
        void SmazZaznamy(string kodZeme)
        {
            string sql = $"DELETE FROM country WHERE short_code = {kodZeme}";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        void VlozeniZaznamu(string zeme, string kodZeme)
        {
            string sql = $"INSERT INTO country(country, short_code) VALUES ('{zeme}', '{kodZeme}')";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
