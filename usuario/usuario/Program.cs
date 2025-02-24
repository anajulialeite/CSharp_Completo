using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ana Júlia de Lima Aguiar Leite";
            int quarto = 3;
            double preco = 500.50;
            string lastName = "Leite";
            int idade = 32;
            double altura = 1.61;

            Console.WriteLine(name);
            Console.WriteLine(quarto);
            Console.WriteLine(preco);
            Console.WriteLine($"{lastName} {idade} {altura}");
        }
    }
}
