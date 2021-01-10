using System;
using System.Collections.Generic;
using System.Text;

namespace GCB.Modules.Manager
{
    class Check : Account
    {
        private int NuméroChèque; 
        private int NuméroCarte;
        public int DateFinValiditCarte;

        public int numcheque
        {
            get { return NuméroChèque; }
        }
        public int numcarte
        {
            get { return NuméroCarte; }
        }
        

        public Check()
        {

        }
        public Check(int numeroCompte, string Nom, double sold, int NuméroChèque,int NuméroCarte, int DateFinValiditCarte):base(numeroCompte,Nom,sold)
        {
            this.NuméroChèque = NuméroChèque;
            this.NuméroCarte = NuméroCarte;
            this.DateFinValiditCarte = DateFinValiditCarte;
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
            else
            {
                throw new ArgumentNullException("solde insufisant pour cette opération");
            }

        }
        

           
    }
}
