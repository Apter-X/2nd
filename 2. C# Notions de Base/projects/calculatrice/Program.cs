using System;

namespace CSharp_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){ calcul(); }
        }

        static void calcul()
        {
            Console.WriteLine("Veuillez entrer le premier nombre :");
            string n1 = Console.ReadLine();
            Console.WriteLine("Veuillez entrer l'operateur :");
            string op = Console.ReadLine();
            Console.WriteLine("Veuillez entrer le deuxième nombre :");
            string n2 = Console.ReadLine();

            Calculatrice calcul = new Calculatrice(n1, n2);

            switch(op)
            {
                case "+":
                    Console.WriteLine("\nLe resultat est de : " + calcul.addNumber());
                    break;
                case "-":
                    Console.WriteLine("\nLe resultat est de : " + calcul.subNumber());
                    break;
                case "*":
                    Console.WriteLine("\nLe resultat est de : " + calcul.multyNumber());
                    break;
                case "/":
                    Console.WriteLine("\nLe resultat est de : " + calcul.divNumber());
                    break;
                case "%":
                    Console.WriteLine("\nLe resultat est de : " + calcul.divNumber());
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
