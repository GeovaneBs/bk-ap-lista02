using System.Drawing;

namespace Utils;

public static class Utils
{
    public static int RecebeValor()
    {
        int valor = 0;

        while (valor == 0)
        {
            Console.Write("Informe um Valor: ");
            if (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("valor errado");
            }
        }

        return valor;
    }
}
