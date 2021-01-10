using System;
using System.Collections.Generic;
using System.Text;

namespace GCB.Modules.Manager
{
    abstract class  Account
    {
        private int numéroCompte;
        public string nomPror;
        private double sold;
        
        public double solde
        {
            get { return sold; }
            set { sold = value; }
        }
        
        public int numcompte
        {
            get { return numéroCompte; }
        }

        public Account()
        {

        }

        public Account(int numeroCompte, string Nom, double sold)
        {
            this.numéroCompte = numeroCompte;
            this.nomPror = Nom;
            this.sold = sold;
        }

        public virtual void Credit(double sumAjouter)
        {
    
        }

        public virtual void Debit(double sumDebiter)
        {
            
        }
    }
}
