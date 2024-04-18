namespace Exercicio04;
using Utils;

internal class Program
{
    static void Main(string[] args)
    {

        /*
         * - Escreva um programa que declare dois vetores de mesmo tamanho e calcule a soma dos elementos correspondentes de ambos os vetores, 
         * armazenando o resultado em um terceiro vetor. Em seguida, exiba o vetor resultante.
        */

        int[] vetor1 = { 2, 3, 3 };
        int[] vetor2 = { 2, 3, 3 };
        int[] vetor3 = new int[3];

      /*  for (int i = 0; i < 3; i++)
        {
            vetor1[i] = Utils.RecebeValor();
        }

        for (int i = 0; i < 3; i++)
        {
            vetor2[i] = Utils.RecebeValor();
        }
      */
        Console.Write("Novo vetor: ");

        for (int i = 0; i < 3; i++)
        {
            vetor3[i] = vetor1[i] + vetor2[i];
            Console.Write($"{vetor3[i]} ");
        }
    }
}
