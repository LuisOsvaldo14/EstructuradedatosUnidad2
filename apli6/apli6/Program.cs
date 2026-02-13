using System;

class EjercicioPrimos
{
    static void Main()
    {
        Console.WriteLine("Contador de Números Primos");

        Console.Write("¿Cuántos números vas a ingresar? ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        int contadorPrimos = 0;


        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write($"Introduce el número {i}: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 2)
            {

                continue;
            }

            bool esPrimo = true;


            for (int j = 2; j < num; j++)
            {
                if (num % j == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            if (esPrimo)
            {
                contadorPrimos++;
            }
        }


        Console.WriteLine($"Se encontraron {contadorPrimos} números primos en la lista.");
    }
}

