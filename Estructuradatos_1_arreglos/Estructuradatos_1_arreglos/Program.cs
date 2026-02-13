using System;

class OperacionesArreglos
{
    static int[] arreglo = new int[10];
    static int tamanoActual = 0;

    static void Main()
    {
        Insertar(10, 0);
        Insertar(20, 1);
        Insertar(30, 2);
        Insertar(40, 3);
        Insertar(50, 4);

        Console.WriteLine("Arreglo inicial:");
        MostrarArreglo();

        Console.WriteLine("\nInsertando 25 en la posición 4");
        Insertar(45, 4);
        MostrarArreglo();

        Console.WriteLine("\nEliminando elemento en la posición 4");
        Eliminar(4);
        MostrarArreglo();

        int buscado = 10;
        int indice = Buscar(buscado);
        Console.WriteLine(indice != -1 ? $"\nEl {buscado} está en el índice {indice}" : $"\n{buscado} no encontrado");
    }

    static void Insertar(int elemento, int posicion)
    {
        if (tamanoActual >= arreglo.Length) return;

        
        for (int i = tamanoActual; i > posicion; i--)
        {
            arreglo[i] = arreglo[i - 1];
        }
        arreglo[posicion] = elemento;
        tamanoActual++;
    }

    static void Eliminar(int posicion)
    {
        if (posicion < 0 || posicion >= tamanoActual) return;

        for (int i = posicion; i < tamanoActual - 1; i++)
        {
            arreglo[i] = arreglo[i + 1];
        }
        tamanoActual--;
    }

    static int Buscar(int elemento)
    {
        for (int i = 0; i < tamanoActual; i++)
        {
            if (arreglo[i] == elemento) return i;
        }
        return -1;
    }

    static void MostrarArreglo()
    {
        for (int i = 0; i < tamanoActual; i++)
        {
            Console.Write(arreglo[i] + " ");
        }
        Console.WriteLine();
    }
}
