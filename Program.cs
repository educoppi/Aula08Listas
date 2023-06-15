using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08ListasERepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            nomes.Add("Conrado");
            nomes.Add("Eduardo");
            nomes.Add("Leonardo");
            Console.WriteLine("A primeira posição é " + nomes[0]);
            Console.WriteLine("A segunda posição é " + nomes[1]);
            Console.WriteLine("A Terceira posição é " + nomes[2]);

            nomes.RemoveAt(1);

            int quantidade = nomes.Count;
            Console.WriteLine($"Existem {quantidade} itens dentro da lista");


            Console.ReadKey();
        }

        void Array()
        {
            string[] nomes = new string[3];
            int[] idades = { 19, 20, 18, 25 };

            nomes[0] = "Conrado";
            nomes[1] = "Victor";
            nomes[2] = "Eduardo";

            Console.WriteLine("O nome da primeira posição é " + nomes[0]);
            Console.WriteLine("O nome da segundaa posição é " + nomes[1]);
            Console.WriteLine("O nome da terceira posição é " + nomes[2]);

            Console.ReadKey();
        }
    }
}
