using System;

class Nodo
{
    public int Valor;
    public Nodo Siguiente;
    public Nodo(int v) { Valor = v; Siguiente = null; }
}

class ListaInvertible
{
    private Nodo cabeza;

    public void Agregar(int v)
    {
        Nodo nuevo = new Nodo(v);
        if (cabeza == null) { cabeza = nuevo; return; }
        Nodo temp = cabeza;
        while (temp.Siguiente != null) temp = temp.Siguiente;
        temp.Siguiente = nuevo;
    }

    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = cabeza;
        Nodo siguiente = null;

        while (actual != null)
        {
            siguiente = actual.Siguiente;
            actual.Siguiente = anterior;
            anterior = actual; 
            actual = siguiente; 
        }
        cabeza = anterior; 
    }

    public void Mostrar()
    {
        Nodo temp = cabeza;
        while (temp != null)
        {
            Console.Write(temp.Valor + " -> ");
            temp = temp.Siguiente;
        }
        Console.WriteLine("null");
    }

    static void Main()
    {
        ListaInvertible lista = new ListaInvertible();
        lista.Agregar(1); lista.Agregar(2); lista.Agregar(3); lista.Agregar(4);

        Console.WriteLine("Lista Original:");
        lista.Mostrar();

        Console.WriteLine("\nInvirtiendo lista...");
        lista.Invertir();

        Console.WriteLine("Lista Invertida:");
        lista.Mostrar();
    }
}