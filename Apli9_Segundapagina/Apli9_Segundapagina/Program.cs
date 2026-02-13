using System;
using System.Collections.Generic;

class EliminarDuplicados
{
    static void Main()
    {
        int[] original = { 5, 2, 8, 2, 10, 5, 3, 8 };

        List<int> listaSinDuplicados = new List<int>();

        Console.WriteLine("--- Eliminación de Duplicados ---");
        Console.WriteLine("Original: " + string.Join(", ", original));

        for (int i = 0; i < original.Length; i++)
        {
            bool yaExiste = false;

            foreach (int n in listaSinDuplicados)
            {
                if (n == original[i])
                {
                    yaExiste = true;
                    break;
                }
            }

            if (!yaExiste)
            {
                listaSinDuplicados.Add(original[i]);
            }
        }

        Console.WriteLine("Sin duplicados: " + string.Join(", ", listaSinDuplicados));
    }
}
