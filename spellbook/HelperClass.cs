using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spellbook.txt
{
    internal class HelperClass
    {
        Random Generator = new Random();
        public string[] PoleZTextu(string adresaSouboru)
        {
            string obsahTxt = File.ReadAllText(adresaSouboru);
            string[] obsah = obsahTxt.Split(';');
            return obsah;
        }
        public string VygenerujSpellname(string[] poleForma, string[] poleTypy)
        {
            int index1 = Generator.Next(0, poleForma.Length - 1);
            string forma = poleForma[index1];

            int index2 = Generator.Next(0, poleForma.Length - 1);
            string typ = poleTypy[index2];
            string vysledek = forma + " " + typ;
            return vysledek;
        }
        public int VygenerujCislo(int max)
        {
            return Generator.Next(0, max);
        }
    }
}