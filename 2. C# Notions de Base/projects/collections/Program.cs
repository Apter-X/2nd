using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            showElementOfList(listMonths(), 2);
            //showElements(listMonths());
            //updateListValue(listMonths(), "Aout", "Août");
            //insertValue(listMonths(), 0, "1st");
            //removeValue(listMonths(), 2);
            //findValue(listMonths(), "Avril");
            //sortList(listMounths());
            //var copy = copyList(listMounths());
        }

        static List<string> copyList(List<string> months)
        {
            List<string> copy = new List<string>(months);

            return copy;
        }

        static void sortList(List<string> months)
        {
            months.Sort();
            showElements(months);
        }

        static void findValue(List<string> months, string value)
        {
            int index = months.IndexOf(value);

            if (index >= 0)
            {
                Console.WriteLine("La position de cette element est : " + index);
            } else
            {
                Console.WriteLine("NOT FOUND !!");
            }
        }

        static void removeValue(List<string> months, int index)
        {
            months.RemoveAt(index);
            showElements(months);
        }

        static void insertValue(List<string> months, int index, string value)
        {
            months.Insert(index, value);
            showElements(months);
        }

        static void updateListValue(List<string> months, string oldValue, string newValue)
        {
            int index = months.IndexOf(oldValue);
            months[index] = newValue;
            showElements(months);
        }

        static void showElements(List<string> months)
        {
            foreach (string month in months)
            {
                Console.WriteLine(month);
            }
        }

        static void showElementOfList(List<string> months, int n)
        {
            Console.WriteLine(months[n]);
        }

        static List<string> listMonths()
        {
            return new List<string>() { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" };
        }
    }
}
