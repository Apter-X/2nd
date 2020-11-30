using System;

namespace CSharp_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            boucle1();
            // boucle2();
            // boucle3();
            // boucle4();
            // boucle5();
            // boucle6();
        }

        static void boucle6()
        {
            double i = 200;

            while (i >= 0)
            {
                Console.WriteLine("Enfin !!!");
                i -=12;
            }
        }

        static void boucle5()
        {
            double i = 1;

            while (i <= 100)
            {
                Console.WriteLine("On tient le bon bout...");
                i += 15;
            }
        }

        static void boucle4()
        {
            double i = 20;

            while (i >= 0)
            {
                Console.WriteLine("C'est presque bon...");
                i--;
            }
        }

        static void boucle3()
        {
            double i = 1;

            while (i <= 15)
            {
                Console.WriteLine("On y arrive presque...");
                i++;
            }
        }

        static void boucle2()
        {
            double i = 1;

            while (i <= 10)
            {
                Console.WriteLine(i);
                i += i / 2;
            }
        }

        static void boucle1()
        {
            int i = 1;
            int n = 10;

            while (i <= 30)
            {
                int result = i * n;
                Console.WriteLine(result);
                i++;
            }
        }
    }
}
