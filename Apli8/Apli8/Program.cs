using System;


class Ejercicionegativosposivos

{
    static void Main()
    {
        Console.WriteLine("Contador de Números Positivos y Negativos y Ceros");
        int Negativos = 0;
        int Positivos = 0;
        int Ceros = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Introduce el número {i}: ");
            int numumero = Convert.ToInt32(Console.ReadLine());
            if (numumero < 0)
            {
                Negativos = Negativos + 1;
            }
            else if (numumero > 0)
            {
                Positivos = Positivos + 1;
            }
            else
            {
                Ceros = Ceros + 1;
            }

        }
        Console.WriteLine($"\n hay {Negativos} números negativos");
        Console.WriteLine($"\n hay {Positivos} números positivos");
        Console.WriteLine($"\n hay {Ceros} números ceros");
    }
}
