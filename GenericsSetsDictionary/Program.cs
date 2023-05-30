using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace GenericsSetsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();
            
            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Student Enrollment {0}: ", i);
                int codigo = int.Parse(Console.ReadLine());
                courseA.Add(codigo);
            }
            Console.WriteLine();

            Console.Write("How many students for a course B? ");
            int n1 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n1; i++)
            {
                Console.Write("Student Enrollment {0}: ", i);
                int codigo = int.Parse(Console.ReadLine());
                courseB.Add(codigo);
            }
            Console.WriteLine();

            Console.Write("How many students for a course C? ");
            int n2 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n2; i++)
            {
                Console.Write("Student Enrollment {0}: ", i);
                int codigo = int.Parse(Console.ReadLine());
                courseC.Add(codigo);
            }
            Console.WriteLine();

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);

            Console.WriteLine("Total students: " + all.Count);
        }   
    }
}
