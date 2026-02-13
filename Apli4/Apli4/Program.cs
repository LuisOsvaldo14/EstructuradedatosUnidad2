using System;

class EjercicioMCM
{
    static void Main()
    {
        Console.WriteLine("--- Calculadora de Mínimo Común Múltiplo (MCM) ---");


        Console.Write("Introduce el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int mcm;

        if (num1 > num2)
        {
            mcm = num1;
        }
        else
        {
            mcm = num2;
        }

        
        while (true)
        {
            if (mcm % num1 == 0 && mcm % num2 == 0)
            {
                
                Console.WriteLine($"El MCM de {num1} y {num2} es: {mcm}");
                break; 
            }

            mcm++;
        }
    }
}
