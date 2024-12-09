using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leitura dos dados da primeira peça
            Console.Write("Digite o código da peça 1: ");
            int codigoPeca1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de peças 1: ");
            int numeroPeca1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor unitário da peça 1: ");
            float valorUnitarioPeca1 = float.Parse(Console.ReadLine());

            // Leitura dos dados da segunda peça
            Console.Write("Digite o código da peça 2: ");
            int codigoPeca2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de peças 2: ");
            int numeroPeca2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor unitário da peça 2: ");
            float valorUnitarioPeca2 = float.Parse(Console.ReadLine());

            // Cálculo do valor total
            float valorTotalPeca1 = numeroPeca1 * valorUnitarioPeca1;
            float valorTotalPeca2 = numeroPeca2 * valorUnitarioPeca2;
            float valorTotal = valorTotalPeca1 + valorTotalPeca2;

            // Exibição do valor total a ser pago
            Console.WriteLine($"Valor total a ser pago: R$ {valorTotal:F2}");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
