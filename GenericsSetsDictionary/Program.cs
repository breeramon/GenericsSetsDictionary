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
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            PrintCollection(a);

            // union = Conjunto
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b); // ele vai inserir todos os números diferentes que tem entre 'a' e 'b' no c
            PrintCollection(c);

            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //difference = diferença de conjuntos
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b); // método que ver os números diferentes que tem entre cada coleções
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
