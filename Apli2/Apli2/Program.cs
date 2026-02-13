using System;

class Numeropercto
{
    static void Main()
    {
        Console.WriteLine("--- Este es un programa para saber si un número es perfecto ---");
        Console.Write("Ingrese un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero <= 0)
        {
            Console.WriteLine("Por favor introduzca un número entero mayor a cero");
        }
        else
        {
            int sumaDivisores = 0;
            int divisor = 1;


            while (divisor < numero)
            {
                if (numero % divisor == 0)
                {
                    sumaDivisores += divisor;
                }
                divisor++;
            }


            if (sumaDivisores == numero)
            {
                Console.WriteLine($"{numero} es un número perfecto");
            }
            else
            {
                Console.WriteLine($"{numero} no es un número perfecto");
            }


        }
    }
}

