using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra
{
    internal class Zadania
    {
        public static bool Walka(int nr_misji, int[][] bochater, int nr_rn)
        {
            int[][] przciwnik = Postac.Przeciwnik(nr_misji, nr_rn);
            Console.WriteLine($"Walczysz z {Postac.Przeciwnik_str(nr_misji)[0]}.");
            while (przciwnik[1][0] > 0 & bochater[1][1] > 0)
            {
                Console.WriteLine("--------------");
                Console.WriteLine($"twój przzeciwnik ma {przciwnik[1][0]} hp");
                Console.WriteLine("Jaki atak chcesz zastosować?");
                Console.WriteLine(" 1 - miecz");
                Console.WriteLine(" 2 - łuk");
                Console.WriteLine(" 3 - magia");
                int wb = int.Parse(Console.ReadLine())-1;
                int at = bochater[0][wb]*bochater[1][4];
                przciwnik[1][0] -= at*przciwnik[0][wb];
                bochater[1][1] -= przciwnik[1][1] - bochater[1][2];  
                
            }
            if (bochater[1][1] > 0)
            {
                Console.WriteLine($"POKONAŁEŚ {Postac.Przeciwnik_str(nr_misji)[0]}!!!");
                Console.WriteLine($"zostało ci {bochater[1][1]} hp");
                Console.WriteLine("--------------");
                return true;
            }
            else
            {
                Console.WriteLine($"zostałeś pokonany przez {Postac.Przeciwnik_str(nr_misji)[0]} :((");
                return false;
            }
            
        }
        public static void Misja( int nr_misji, int[][] bochater, int nr_rn )
        {
            int nagroda = nr_misji+1;
            nagroda = nagroda * 50 * nr_rn;
            bool wykonane = false;
            Console.WriteLine($"udaj się do {Postac.Przeciwnik_str(nr_misji)[1]} aby pokonać {Postac.Przeciwnik_str(nr_misji)[0]}");
            Console.WriteLine($"W zamian dostaniesz {nagroda} monet");
            if ( !wykonane )
            {
                wykonane = Walka(nr_misji, bochater, nr_rn);
            }
            if (wykonane)
            {
                bochater[1][3] += nagroda;
                Console.WriteLine($"GRSTULACJE!!! Wykonałeś zadanie. Masz teraz {bochater[1][3]} monet.");                
            }
        }
        
    }
}
