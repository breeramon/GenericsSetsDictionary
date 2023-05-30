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
        {            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> Votos = new Dictionary<string, int>();
                    
                    while (!sr.EndOfStream)
                    {
                        string[] votingRecord = sr.ReadLine().Split(',');
                        string candidato = votingRecord[0];
                        int votosQuantity = int.Parse(votingRecord[1]);

                        if (Votos.ContainsKey(candidato))
                        {
                            Votos[candidato] += votosQuantity;
                        }
                        else
                        {
                            Votos[candidato] = votosQuantity;
                        }
                    }
                    foreach (var item in Votos)
                    {
                        Console.WriteLine(item.Key + "," + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");                Console.WriteLine(e.Message);            }
        }   
    }
}
