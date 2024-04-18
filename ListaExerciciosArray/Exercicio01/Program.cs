namespace Exercicio01;
using Utils;

internal class Program
{
    static void Main(string[] args)
    {
        /*
        - Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, exiba esses elementos na tela.
         */

        int[] ints = { Utils.RecebeValor(), Utils.RecebeValor(), Utils.RecebeValor(), Utils.RecebeValor(), Utils.RecebeValor() };

        Console.Clear();
        Console.Write("Valores Informados: ");

        foreach (int i in ints)
        {
            Console.Write($"{i} ");
        }
    }
}
