using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ListLibrary
{
    public class Operace
    {
        public static void Vygenerovani(List<int> list, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; ++i)
            {
                int a = rnd.Next(-100, 100);
                list.Add(a);
            }
           
        }

        public static void Vypsani(List<int> list,ListBox l)
        {
            l.Items.Clear();

            foreach (int cislo in list)
            {
                l.Items.Add(cislo);
            }
        }

        public static int pocetJedinecnych(List<int> list)
        {
            List<int> pocetJedinec = list.Distinct().ToList();
            int pocet = pocetJedinec.Count;
            return pocet;
        }
        
    }
}
