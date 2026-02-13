using System;

class BuscarEnLista
{
    static void Main()
    {

        int[] numeros = { 14, 25, 8, 42, 33, 10, 5, 77 };

        Console.WriteLine("--- Buscador de Valores en Lista ---");
        Console.WriteLine("Lista disponible: " + string.Join(", ", numeros));

        Console.Write("\n¿Qué número deseas buscar? ");
        int valorBuscado = Convert.ToInt32(Console.ReadLine());

        bool encontrado = false;
        int posicion = -1;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == valorBuscado)
            {
                encontrado = true;
                posicion = i; 
                break; 
            }
        }

        if (encontrado)
        {
            Console.WriteLine($"\n¡Éxito! El número {valorBuscado} está presente en la posición {posicion}.");
        }
        else
        {
            Console.WriteLine($"\nEl número {valorBuscado} NO se encuentra en la lista.");
        }
    }
}
