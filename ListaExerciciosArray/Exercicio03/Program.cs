namespace Exercicio03;
using Utils;

internal class Program
{
    static void Main(string[] args)
    {
        /*
        - Crie um programa que preencha uma matriz 3x3 com valores inteiros informados pelo usuário e depois exiba essa matriz na tela.
        */

        int[,] ints = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                ints[i, j] = Utils.RecebeValor();
            }
        }

        Console.Clear();

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{ints[i, j]}  ");
            }
        }
    }
}
