using System;


class Nodo
{
    public int Valor;
    public Nodo Siguiente;

    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}


class ListaEnlazada
{
    private Nodo cabeza; 

    
    public void AgregarAlFinal(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
            return;
        }

        Nodo actual = cabeza;
        while (actual.Siguiente != null)
        {
            actual = actual.Siguiente;
        }
        actual.Siguiente = nuevoNodo;
    }

    public void Eliminar(int valor)
    {
        if (cabeza == null) return;

        if (cabeza.Valor == valor)
        {
            cabeza = cabeza.Siguiente;
            return;
        }

        Nodo actual = cabeza;
        while (actual.Siguiente != null && actual.Siguiente.Valor != valor)
        {
            actual = actual.Siguiente;
        }

        if (actual.Siguiente != null)
        {
            actual.Siguiente = actual.Siguiente.Siguiente;
        }
    }

    public bool Buscar(int valor)
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            if (actual.Valor == valor) return true;
            actual = actual.Siguiente;
        }
        return false;
    }

    public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Valor + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main()
    {
        ListaEnlazada miLista = new ListaEnlazada();

        Console.WriteLine("--- Implementación de Lista Enlazada Simple ---");

        miLista.AgregarAlFinal(10);
        miLista.AgregarAlFinal(20);
        miLista.AgregarAlFinal(30);
        miLista.Mostrar(); 

        Console.WriteLine("\n¿Está el 20 presente?: " + miLista.Buscar(20));

        Console.WriteLine("\nEliminando el 20...");
        miLista.Eliminar(20);
        miLista.Mostrar();
    }
}
