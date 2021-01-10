using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GCB.Modules.Manager
{
    class Bank
    {
        public List<object> Comptes;

        public Bank()
        {
            this.Comptes = new List<object>();
        }

        public bool Find(int id)
        {
            int index = this.Comptes.IndexOf(id);

            if (index >= 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public int Search(int id)
        {
            return this.Comptes.IndexOf(id);
        }

        public void Add(object compte)
        {
            if (!Find(0))
            {
                this.Comptes.Add(compte);
                Console.WriteLine("Compte ajouté avec seccès.");
            }
            else
            {
                Console.WriteLine("Numero de compte déja existant");
            }
        }

        public void Delete(int id)
        {
            this.Comptes.RemoveAt(Search(id));
        }

        public void Select(int id)
        {
            Console.WriteLine(this.Comptes[Search(id)]);
        }

    }
}
