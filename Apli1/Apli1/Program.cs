using System;

class contarpares
{
    static void Main()
    {
        Console.WriteLine("Este es un programa que cuenta los numeros pares entre 1 y el numero que introduzcas");

        Console.Write("Introduce tu numero: ");
        int Numero = Convert.ToInt32(Console.ReadLine());
        int suma = 0;
        
        for (int i = 0; i < Numero; i++)
        {
            if (i % 2  == 0)
            {
                suma = suma + 1;
            }
        }
        Console.WriteLine($"Los numeros pares que hay entre 1 y {Numero} son {suma}");
    }
}
