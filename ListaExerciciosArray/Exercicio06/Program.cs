using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices.Marshalling;

namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
              Busca de Dados em uma Matriz de Animais
              Suponha que você tenha uma matriz que representa uma lista de animais, onde cada linha contém as seguintes propriedades de um animal:
                Nome
                Espécie
                Idade
                Peso
              Escreva um programa em C# que permita ao usuário buscar animais por uma determinada propriedade (nome, espécie, idade ou peso) e exibir os animais que correspondem à busca.
              // Matriz de animais [Nome, Espécie, Idade, Peso]
                    string[,] animais = {
                        { "Fido", "Cachorro", "5", "10kg" },
                        { "Whiskers", "Gato", "5", "5kg" },
                        { "Buddy", "Cachorro", "3", "8kg" },
                        { "Fluffy", "Gato", "2", "4kg" },
                        { "Spot", "Cachorro", "4", "12kg" }
                    };
            */

            string[,] animais = {
                        { "Fido", "Cachorro", "5", "10" },
                        { "Fido", "Gato", "5", "5" },
                        { "Buddy", "Cachorro", "3", "8" },
                        { "Fluffy", "Gato", "2", "4" },
                        { "Spot", "Cachorro", "4", "12" } };

            List<Animal> list = new List<Animal>();

            for (int i = 0; i < animais.GetLength(0); i++)
            {
                list.Add(new Animal
                {
                    Nome = animais[i, 0],
                    Especie = animais[i, 1],
                    Idade = int.Parse(animais[i, 2]),
                    Peso = decimal.Parse(animais[i, 3])
                });
            }

            int opcao = Menu();
            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Informe o Nome do Pet");
                    string nome = Console.ReadLine();
                    foreach (var animal in list)
                    {
                        if (animal.Nome == nome)
                        {
                            Console.Write($"{animal}\n\n");
                        }
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Informe a Especie do Pet");
                    string especie = Console.ReadLine();
                    foreach (var animal in list)
                    {
                        if (animal.Especie == especie)
                        {
                            Console.Write($"{animal}\n\n");
                        }
                    }                   
                  
                    break;
                case 3:
                    Console.WriteLine("Informe a idade do Pet");
                    int idade = int.Parse(Console.ReadLine()); 
                    foreach (var animal in list)
                    {
                        if (animal.Idade == idade)
                        {
                            Console.Write($"{animal}\n\n");
                        }
                    }
                    break;
                
                case 4:
                    Console.WriteLine("Informe a idade do Pet");
                    decimal peso = int.Parse(Console.ReadLine());                    
                    foreach (var animal in list)
                    {
                        if (animal.Idade == peso)
                        {
                            Console.Write($"{animal}\n\n");
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Opção não encontrado");
                    break;
            }

        }

        internal static int Menu()
        {
            int exit = 0;
            while (exit == 0 || exit > 4)
            {
                Console.Clear();
                Console.WriteLine("Informe o metodo de pesquisa");
                Console.WriteLine("1 - Nome\n" +
                    "2 - Especie\n" +
                    "3 - Idade\n" +
                    "4 - Peso\n");
                if (int.TryParse(Console.ReadLine(), out int resposta))
                {
                    exit = resposta;
                }
            }
            return exit;
        }
    }

    public class Animal
    {
        public string? Nome { get; set; }
        public string? Especie { get; set; }
        public int Idade { get; set; }
        public decimal Peso { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} \n" +
                $"Especie: {Especie} \n" +
                $"Idade: {Idade} \n" +
                $"Peso: {Peso}";
        }
    }
}
