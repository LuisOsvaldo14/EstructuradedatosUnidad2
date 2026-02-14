using System;

class Producto
{
    public int Codigo;
    public string Nombre;
    public Producto Siguiente;

    public Producto(int codigo, string nombre)
    {
        Codigo = codigo;
        Nombre = nombre;
        Siguiente = null;
    }
}

class SistemaInventario
{

    private Producto[] arregloInv = new Producto[100];
    private int contadorArreglo = 0;

    public void AgregarArreglo(int cod, string nom)
    {
        if (contadorArreglo < arregloInv.Length)
        {
            arregloInv[contadorArreglo++] = new Producto(cod, nom);
            Console.WriteLine("Producto agregado.");
        }
    }

    public void EliminarArreglo(int cod)
    {
        for (int i = 0; i < contadorArreglo; i++)
        {
            if (arregloInv[i].Codigo == cod)
            {

                for (int j = i; j < contadorArreglo - 1; j++)
                {
                    arregloInv[j] = arregloInv[j + 1];
                }
                arregloInv[contadorArreglo - 1] = null;
                contadorArreglo--;
                Console.WriteLine($"Código {cod} eliminado.");
                return;
            }
        }
        Console.WriteLine(" Código no encontrado.");
    }

    private Producto cabeza;

    public void AgregarLista(int cod, string nom)
    {
        Producto nuevo = new Producto(cod, nom);
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Producto temp = cabeza;
            while (temp.Siguiente != null) temp = temp.Siguiente;
            temp.Siguiente = nuevo;
        }
        Console.WriteLine("Producto agregado.");
    }

    public void EliminarLista(int cod)
    {
        if (cabeza == null) return;

        if (cabeza.Codigo == cod)
        {
            cabeza = cabeza.Siguiente;
            Console.WriteLine($" Código {cod} eliminado.");
            return;
        }

        Producto actual = cabeza;
        while (actual.Siguiente != null && actual.Siguiente.Codigo != cod)
        {
            actual = actual.Siguiente;
        }

        if (actual.Siguiente != null)
        {
            
            actual.Siguiente = actual.Siguiente.Siguiente;
            Console.WriteLine($" Código {cod} eliminado.");
        }
        else
        {
            Console.WriteLine(" [Lista] Código no encontrado.");
        }
    }

    public void MostrarTodo()
    {
        Console.WriteLine("\n--- ESTADO ACTUAL DEL INVENTARIO (LISTA) ---");
        Producto temp = cabeza;
        while (temp != null)
        {
            Console.WriteLine($"- ID: {temp.Codigo}, Nombre: {temp.Nombre}");
            temp = temp.Siguiente;
        }
    }
}

class Program
{
    static void Main()
    {
        SistemaInventario inventario = new SistemaInventario();

        // Pruebas
        inventario.AgregarLista(101, "Laptop");
        inventario.AgregarLista(102, "Mouse");
        inventario.AgregarLista(103, "Teclado");
        


        inventario.MostrarTodo();

        // Probando eliminación
        inventario.EliminarLista(102);


        inventario.MostrarTodo();
    }
}

