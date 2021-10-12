using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppListaSimple
{
    class Lista
    {
        private Nodo head;

        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }

        public Lista()
        {
            head = null;
        }
        public void Agregar(Nodo n)
        {
            //Lista vacia
            if (head == null)
            {
                head = n;
                return;
            }
            // No esta vacia
            if (n.Numero < head.Numero)
            {
                //Al inicio
                n.Siguiente = head;
                head = n;
                return;
            }
            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (n.Numero < h.Siguiente.Numero)
                {
                    break;
                }
                h = h.Siguiente;
            }
            n.Siguiente = h.Siguiente;
            h.Siguiente = n;
        }

        public void Eliminar(int d)
        {
            //revisar que la lista no este vacia
            if (head == null)
            {
                return;
            }
            //si el nodo a elimnar primero es (head)
            if (head.Numero == d)
            {
                head = head.Siguiente;
                return;
            }
            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Numero == d)
                {
                    break;
                }
                h = h.Siguiente;
            }
            if (h.Siguiente != null)
            { h.Siguiente = h.Siguiente.Siguiente; }
        }
        public bool Buscar(int d, ref Nodo b)
        {
            //revisar que el nodo este vacio
            if (head == null)
            { return false; }
            //Si el nodo a eliminar es el primer (head)
            if (head.Numero == d)
            {
                head = head.Siguiente;
                b = head;
                return true;
            }
            Nodo h = head;
            while (h.Siguiente.Numero == d)
            {
                if (h.Siguiente.Numero == d)
                {
                    b = h.Siguiente; return true; 
                }
                h = h.Siguiente;
            }
            return false;
        }
        public void Modificar(int d, string n, string t)
        {
            //revisar que el nodo este vacio
            if (head == null)
            { return; }
            //Si el nodo a eliminar es el primer (head)
            if (head.Numero == d)
            {
                head.Nombre = n;
                head.Telefono = t;
                return;
            }
            Nodo h = head;
            while(h.Siguiente != null)
            {
                if (h.Siguiente != null)
                {
                    h.Siguiente.Nombre = n;
                    h.Siguiente.Telefono = t;
                    return;
                }
                h= h.Siguiente;
            }
            return;
        }
        public void Mostrar(ListBox lista)
        {
            Nodo h = head;
            lista.Items.Clear();
            while (h != null)
            {
                lista.Items.Add(h.ToString());
                h = h.Siguiente;
            }

        }
        public override string ToString()
        {
            string listaenTexto = "";
            Nodo h = head;
            while(h != null)
            {
                listaenTexto += h.ToString() + "";
                h = h.Siguiente;
            }
            return listaenTexto;
        }

    }
}
