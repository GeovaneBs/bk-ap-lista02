
namespace Exercicio02;
using Utils;

internal class Program
{
    static void Main(string[] args)
    {
        /*
         - Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, mostre o maior e menor valor.
         */

        int[] ints = { Utils.RecebeValor(), Utils.RecebeValor(), Utils.RecebeValor(), Utils.RecebeValor(), Utils.RecebeValor() };

        Console.Clear();

        Console.WriteLine($"O maior valor é: {ints.Max()}");
        Console.WriteLine($"O menor valor é: {ints.Min()}");
    }
}
