using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsSetsDictionary.Entities;
using System.Globalization;

namespace GenericsSetsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("TV")); // vendo se tem algo dentro do HashSet, se tiver ele retorna True, caso contrário False

            foreach (String p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}
