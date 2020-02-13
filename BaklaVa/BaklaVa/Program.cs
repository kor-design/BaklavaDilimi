using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaklaVa
{
    class Program
    {
        static void Main(string[] args)
        {
            int bosluk, yildiz, satir;
            Console.WriteLine("Kaç satır baklava dilimi yazdırmak istiyorsunuz ?");
            satir = int.Parse(Console.ReadLine());

            satir = (satir % 2 == 0) ? ++satir : satir;
            bosluk = satir / 2;
            yildiz = 1;
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < bosluk; j++)
                {
                    Console.Write(" ");
                }
                for (int z = 0; z < yildiz; z++)
                {
                    Console.Write("*");
                }
                if (i < satir/2)
                {
                    bosluk--;
                    yildiz += 2;
                }
                else
                {
                    bosluk++;
                    yildiz -= 2;
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
