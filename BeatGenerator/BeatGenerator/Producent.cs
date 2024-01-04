using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatGenerator
{
    internal sealed class Producent
    {
        static Producent rasistaProducent = new Producent("Jožo", "ÚnL");
        public string jmeno { get; private set; }
        public string mesto { get; private set; }
        string nahodnaSlova = "Jemná, sametová, strukturovaná, třpytivá, hedvábná, křehká, oslnivá, hladká, růžová, karamelová, béžová, bledá, bronzová, matná, svěží, lesklá, olivová, sluneční, tónovaná, krémová, porcelánová, bronzer, luminiscenční, tmavá, smyslná, perlová, zářivá, osvěžující, rozjasněná, přirozená, hřejivá, exotická, třešňová, opálená, šampaňská, tmavší, harmonická, výrazná, šerosvitná, ananasová, broskvová, mahagonová, rozdýchaná, šťavnatá, zlatavá, šedá, plavná, světlá, rozpálená, kyprá, vínová, kávová, levandulová, popelavá, meruňková, sladká, bílá, pestrá, pórovitá, odpočatá, šeříková, hroznová, harmonická, perleťová, vyrovnaná, načervenalá, krémová, očarující, nažloutlá, vyzývavá, stříbrná, fialová, plápolající, záhadná, zrnitá, křišťálová, elegantní, třešňová, jasná, sytá, dojímavá, dozlatova, růžovější, hrušková, vonná, šedivá, pastelová, jiskřivá, kovová, středně tmavá, tekutá, skořicová, něžná, nadýchaná, harmonická, odvážná, třpytivější, vyrovnanější, kouzelná, třpytivější, rozpálenější, něžnější, vřelá, smyslnější, svůdná, tajemná, vřelá, sladká, rozkošná, opálenější, voňavá, výraznější, krásnější, šťavnatější, nevinná, hladší, vášnivější, jemnější, vzdušnější, osvěžující, energická, harmonická, třpytivější, rozpálenější, nevinnější, vášnivější, jemnější, vzdušnější, osvěžující, energická, harmonická, Neohrožený, drsný, vyzývavý, ostře řezaný, krutý, beznadějný, neoblomný, surový, žhavý, bezbřehý, dravý, prudký, provokativní, nezlomný, vzpurný, nepoddajný, houževnatý, zkažený, bitý, rozervaný, tvrdý, kovový, vražedný, zuřivý, zběsilý, neúprosný, nemilosrdný, zjitřený, zuřící, sťatý, nemilosrdný, vyříznutý, rozsekávaný, neústupný, vražedný, temný, neodbytný, brutalizovaný, zhnusený, odporný, nekompromisní, vražedný, vyháněný, neosahávaný, odpudivý, zhoubný, odporující, surový, zkažený, nepoddajný, hrubý, nekrotický, neústupný, vražedný, bezohledný, vyčerpávaný, vyhořelý, žhavý, neoblomný, nekompromisní, odpudivý, surový, nemilosrdný, vyjedený, narušený, temný, krvelačný, zuřivý, vražedný, bezcitný, zhoubný, zkažený, krvavý, dravý, vyprahnutý, surový, neoblomný, nezdolný, vykořeněný, vyhořelý, zběsilý, nezastavitelný, neodbytný, surový, vytrvalý, vyhořelý, bitý, odpudivý, vykořeněný, odpudivý, zhoubný, temný, brutalizovaný, dravý, neústupný, vražedný, neoblomný, surový, nekompromisní, temný, neoblomný, vyčerpávaný, brutalizovaný, surový, vražedný, zhoubný, neodbytný, nekompromisní";
        public List<Slovo> pisnicka { get; private set; } = new List<Slovo>();

        public static Producent Instance { get { return rasistaProducent; } }



        private Producent(string jmeno, string mesto)
        {
            this.mesto = mesto;
            this.jmeno = jmeno;
        }

        public void generujSlova()
        {
            string[] arraySlova = nahodnaSlova.Split(',');
            generujPisnicku(arraySlova);
        }
        void generujPisnicku(string[] slova) { 
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(0, slova.Length); i++) {
                pisnicka.Add(new Slovo(slova[rnd.Next(0, slova.Length)]));    
            }
            KorekcePisnicky();

        }
        void KorekcePisnicky() { 
            List<Slovo> tmpList = new List<Slovo>();
            foreach (Slovo slovo in pisnicka)
            {
                if(slovo.vaha > 0)
                {
                    tmpList.Add(slovo);
                }
                //dodělat nahrazení podle tvrdosti

            }
        }
        public void InfoPisnicka()
        {
            Console.WriteLine("Lásku ti vyznávám, jsi má: ");
            foreach (Slovo slovo in pisnicka)
            {
                Console.Write(slovo.slovo);
            }
        }
        public void Clear() {
            pisnicka.Clear();
        }
    }
}
