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
            Client a = new Client() { Name = "Maria", Email = "maria@gmail.com"};
            Client b = new Client() { Name = "Alex", Email = "alex@gmail.com"};

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a  == b); //ele ta comparando a referencia do ponteiro de memoria do objeto, ou seja, se eles "apontam" para o mesmo objeto, não somente se eles são iguais.
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
