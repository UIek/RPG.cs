using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace gra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] bohater = Postac.Bochater();
            int nr_misji = 0;
            int nr_rn = 1;
            
            while (bohater[1][1] > 0)
            {
                Console.WriteLine("Co robisz?");
                Console.WriteLine(" 1 - idź do sklepu");
                Console.WriteLine(" 2 - idź walczyć");
                int co = int.Parse(Console.ReadLine());
                switch (co)
                {
                    case 1:
                        Shop.Sklep(bohater);
                        break;
                    case 2:
                        Zadania.Misja(nr_misji, bohater, nr_rn);
                        nr_misji++;
                        if (nr_misji == 3)
                        {
                            nr_misji -= 3;
                            nr_rn++;
                        }
                        break;
                }

            }
            

            
            





            Console.ReadKey();
        }
    }
}
