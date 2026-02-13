using System;

class ListaDuplicada
{
    static void Main()
    {
        int[] listaOriginal = { 5, 12, 8, 20, 3 };
        int[] listaNueva = new int[listaOriginal.Length];

        Console.WriteLine("Multiplicar elementos por 2");
        Console.WriteLine("Lista Original: " + string.Join(", ", listaOriginal));

        for (int i = 0; i < listaOriginal.Length; i++)
        {
            listaNueva[i] = listaOriginal[i] * 2;
        }

        Console.WriteLine("Lista Nueva (x2): " + string.Join(", ", listaNueva));
    }
}
