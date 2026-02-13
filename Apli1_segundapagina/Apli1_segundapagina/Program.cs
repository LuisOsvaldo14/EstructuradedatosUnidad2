using System;

class CalculadoraBasica
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine(" Calculadora Básica");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.Write("Selecciona una opción: ");

            string opcion = Console.ReadLine();

            if (opcion == "5")
            {
                continuar = false;
                Console.WriteLine("Saliendo del programa...");
                break;
            }


            Console.Write("Introduce el primer número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            switch (opcion)
            {
                case "1":
                    Console.WriteLine($"Resultado: {n1} + {n2} = {n1 + n2}");
                    break;
                case "2":
                    Console.WriteLine($"Resultado: {n1} - {n2} = {n1 - n2}");
                    break;
                case "3":
                    Console.WriteLine($"Resultado: {n1} * {n2} = {n1 * n2}");
                    break;
                case "4":
                    if (n2 != 0)
                        Console.WriteLine($"Resultado: {n1} / {n2} = {n1 / n2}");
                    else
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    break;
            }
        }
    }
}
