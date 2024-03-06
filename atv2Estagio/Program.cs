using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (VerificarNumero(numero))
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool VerificarNumero(int numero)
    {
        int a = 0;
        int b = 1;

        while (a <= numero)
        {
            if (a == numero)
            {
                return true;
            }

            int temp = a + b;
            a = b;
            b = temp;
        }

        return false;
    }
}
