using System;

class BuscarPosicion
{
    static void Main()
    {

        string[] frutas = { "Manzana", "Pera", "Uva", "Sandía", "Mango" };

        Console.WriteLine("--- Buscador de Posiciones (Índices) ---");
        Console.WriteLine("Lista: " + string.Join(", ", frutas));

        Console.Write("\nEscribe el nombre de la fruta para saber su posición: ");
        string buscar = Console.ReadLine();

        int posicionEncontrada = -1; 

        for (int i = 0; i <= frutas.Length; i++)
        {
            
            if (frutas[i].Equals(buscar, StringComparison.OrdinalIgnoreCase))
            {
                posicionEncontrada = i;
                break; 
            }
        }

        if (posicionEncontrada != -1)
        {
            Console.WriteLine($"\nLa fruta '{buscar}' está en la posición de índice: {posicionEncontrada}");
        }
        else
        {
            Console.WriteLine("\nEse elemento no existe en la lista.");
        }
    }
}
