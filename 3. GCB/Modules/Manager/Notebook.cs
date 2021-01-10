using System;
using System.Collections.Generic;
using System.Text;

namespace GCB.Modules.Manager
{
    class Notebook : Account
    {
        private int NuméroCanret;

        public int numcarnet
        {
            get { return NuméroCanret; }
        }

        public Notebook()
        {

        }
        public Notebook(int numeroCompte, string Nom, double sold, int NuméroCanret) :base(numeroCompte,Nom,sold)
        {
            this.NuméroCanret = NuméroCanret;
        }
        

        public override void Credit(double sumAjouter)
        {

            this.solde += sumAjouter;
        }
        public override void Debit(double sumDebiter)
        {
            if (this.solde - sumDebiter > 0)
            {
                this.solde -= sumDebiter;
            }
            else if(sumDebiter > 10000)
            {
                throw new ArgumentNullException("ne dois pas deppaser le plafond de 10000DH");
                }
            else
            {
                throw new ArgumentNullException("solde insufisant pour cette opération");
            }
        }
    }
}
