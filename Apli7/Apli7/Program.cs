using System;

class Multiplos
{
    static void Main()
    {
        Console.WriteLine("--- Múltiplos de 5 entre dos números ---");
        Console.Write("Introduce el primer número: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int inicio = Math.Min(n1, n2);
        int fin = Math.Max(n1, n2);
        Console.WriteLine($"\nMúltiplos de 5 entre {inicio} y {fin}:");
        bool encontroAlguno = false;

        
        for (int i = inicio; i <= fin; i++)
        {
            
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
                encontroAlguno = true;
            }
        }

        if (!encontroAlguno)
        {
            Console.WriteLine("No se encontraron múltiplos de 5 en este rango.");
        }
    }
}
