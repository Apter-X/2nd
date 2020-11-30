using System;

namespace CSharp_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            tva();
        }

        static void tva()
        {
            Console.WriteLine("Veuillez saisir le nom de votre produit :");
            string productName = Console.ReadLine();
            Console.WriteLine("Veuillez entrer le prix HT :");
            string priceString = Console.ReadLine();

            int price = Int32.Parse(priceString);
            double result = price * 1.19;

            Console.WriteLine("Votre produit " + productName + " coûte " + result + " DH TTC.");
        }
    }
}
