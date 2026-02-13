using System;

class RotacionArreglos
{
    static void Main()
    {

        int[] arreglo = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Arreglo Original: " + string.Join(", ", arreglo));

        Console.Write("¿Cuántas posiciones desea rotar?: ");
        int posiciones = int.Parse(Console.ReadLine());

        Console.Write("Dirección (derecha/izquierda): ");
        string direccion = Console.ReadLine().ToLower();

        int n = arreglo.Length;
        int[] resultado = new int[n];

        for (int i = 0; i < n; i++)
        {
            if (direccion == "derecha")
            {

                int nuevaPosicion = (i + posiciones) % n;
                resultado[nuevaPosicion] = arreglo[i];
            }
            else 
            {

                int nuevaPosicion = (i - posiciones % n + n) % n;
                resultado[nuevaPosicion] = arreglo[i];
            }
        }

        Console.WriteLine($"Arreglo Rotado ({direccion}): " + string.Join(", ", resultado));
    }
}
