using System;

class Mayor
{
    static void Main()
    {
        Console.WriteLine("Programa para encontrar el número mayor" );

       
        int mayor = int.MinValue;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Introduce el número {i}: ");
            int numeroActual = Convert.ToInt32(Console.ReadLine());

            
            if (numeroActual > mayor)
            {
                mayor = numeroActual;
            }
        }

        
        Console.WriteLine($"El número mayor de los 10 ingresados es: {mayor}");
    }
}
