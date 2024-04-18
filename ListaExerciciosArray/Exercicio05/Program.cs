namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Crie uma matriz 4x4 de números inteiros aleatórios e encontre o maior valor presente nela.
            */

            var rand = new Random();

            int[,] matriz = new int[4,4];

            for (int i = 0; i < 4; i++) { 
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = rand.Next(1, 100);
                }
            }

            int valorMaior = matriz[0,0];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matriz[i,j] > valorMaior)
                    {
                        valorMaior = matriz[i, j];
                    }
                }
            }

            Console.WriteLine($"O maior valor é {valorMaior}");
        }
    }
}
