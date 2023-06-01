using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra
{
    internal class Postac
    {
        public static int[][] Bochater()
        {
            // 0 - broń  1 - statystyka
            int[][] ret = new int[2][];
            // 0 - miecz  1 - łuk  2 - magia
            int[] wojownik = new int[] { 20, 10, 1 };
            int[] czarodziej = new int[] { 10, 1, 20 };
            int[] elf = new int[] { 1, 20, 10 };
            
            Console.WriteLine("wybierz postać");
            Console.WriteLine(" 1 - Wojownik");
            Console.WriteLine(" 2 - Czarodzeij");
            Console.WriteLine(" 3 - Elf");
            
            int wb = int.Parse(Console.ReadLine());
            switch (wb)
            {
                case 1:
                    ret[0] = wojownik;
                    break;
                case 2:
                    ret[0] = czarodziej;
                    break;
                case 3:
                    ret[0] = elf;
                    break;
            }
            //0 - max hp  1 - hp 2 - ochrona  3 - kasa  4 - broń
            ret[1] = new int[] { 500, 500, 10, 0, 1 };
            return ret;
        }
        public static int[][] Przeciwnik(int nr_misji, int nr_rn)
        {
            // 0 - syrena  1 - wampir  2 - smok
            int[][] przeciwnicy = new int[][]
            {// 0 - hp  1 - atak
                new int[] { 100*nr_rn, 50*nr_rn },
                new int[] {150 * nr_rn, 60 * nr_rn },
                new int[] {200 * nr_rn, 70 * nr_rn }
            };
            int[][] przeciwnicy_wr = new int[][]
            {// 0 - miecz  1 - łuk  2 - magia
                new int[] {1, 2, 3},
                new int[] {3, 1, 2},
                new int[] {2, 3, 1},
            };

            int[][] rtn = new int[2][];
            rtn[1] = przeciwnicy[nr_misji];
            rtn[0] = przeciwnicy_wr[nr_misji];
            return rtn;
        }
        public static string[] Przeciwnik_str(int nr_misji)
        {
            string[] rtn = new string[2];
            string[][] przeciwnicy = new string[][]
            {
                new string[] { "syrena", "brzeg morza" },
                new string[] { "wampir", "opuszczony zamek" },
                new string[] { "smok", "jaskińia smoka" }
            };
            rtn = przeciwnicy[nr_misji];

            return rtn;
        }
        
    }
}
