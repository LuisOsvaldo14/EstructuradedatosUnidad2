using System;


class Nodo
{
    public int Valor;
    public Nodo Siguiente;
    public Nodo(int v) { Valor = v; Siguiente = null; }
}

class ListaCircular
{
    private Nodo cabeza = null;


    public void Agregar(int v)
    {
        Nodo nuevo = new Nodo(v);
        if (cabeza == null)
        {
            cabeza = nuevo;
            nuevo.Siguiente = cabeza; 
        }
        else
        {
            Nodo temp = cabeza;
            while (temp.Siguiente != cabeza)
            {
                temp = temp.Siguiente;
            }
            temp.Siguiente = nuevo;
            nuevo.Siguiente = cabeza;
        }
    }


    public void Eliminar(int valor)
    {
        if (cabeza == null) return;

        Nodo actual = cabeza;
        Nodo anterior = null;


        if (actual.Valor == valor)
        {

            if (actual.Siguiente == cabeza)
            {
                cabeza = null;
            }
            else
            {

                Nodo ultimo = cabeza;
                while (ultimo.Siguiente != cabeza) ultimo = ultimo.Siguiente;
                cabeza = cabeza.Siguiente;
                ultimo.Siguiente = cabeza;
            }
            return;
        }

        do
        {
            anterior = actual;
            actual = actual.Siguiente;
            if (actual.Valor == valor)
            {
                anterior.Siguiente = actual.Siguiente;
                return;
            }
        } while (actual != cabeza);
    }

    public void Mostrar()
    {
        if (cabeza == null)
        {
            Console.WriteLine("Lista vacía");
            return;
        }

        Nodo temp = cabeza;
        do
        {
            Console.Write(temp.Valor + " -> ");
            temp = temp.Siguiente;
        } while (temp != cabeza);
        Console.WriteLine("(regresa a la cabeza)");
    }
}

class Program
{
    static void Main()
    {
        ListaCircular lc = new ListaCircular();
        lc.Agregar(10);
        lc.Agregar(20);
        lc.Agregar(30);
        lc.Agregar(59);

        Console.WriteLine("--- Lista Enlazada Circular ---");
        lc.Mostrar();

        Console.WriteLine("\nEliminando el 20...");
        lc.Eliminar(20);
        lc.Mostrar();
    }
}
