using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Training
{
    class Calculatrice
    {
        public double nbr1, nbr2;

        public Calculatrice(string n1, string n2)
        {
            this.nbr1 = Double.Parse(n1);
            this.nbr2 = Double.Parse(n2);
        }

        public double addNumber()
        {
            return this.nbr1 + this.nbr2;
        }

        public double subNumber()
        {
            return this.nbr1 - this.nbr2;
        }

        public double multyNumber()
        {
            return this.nbr1 * this.nbr2;
        }

        public double divNumber()
        {
            return this.nbr1 / this.nbr2;
        }

        public double modNumber()
        {
            return this.nbr1 % this.nbr2;
        }
    }
}
