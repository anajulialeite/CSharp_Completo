using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir o valor de pi
            double pi = 3.14159;

            // Leitura do valor do raio
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            // Cálculo da área
            double area = pi * raio * raio;

            // Exibição da área com 4 casas decimais
            Console.WriteLine($"A área do círculo é: {area:F4}");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
