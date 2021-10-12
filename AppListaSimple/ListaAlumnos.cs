using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace AppListaSimple
{
    class ListaAlumnos
    {
        private NodoAlumnos head;

        public NodoAlumnos Head
        {
            get { return head; }
            set { head = value; }
        }

        public ListaAlumnos()
        {
            head = null;
        }
        public void Agregar(NodoAlumnos n)
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
            NodoAlumnos h = head;
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
        public void AgregarMateria (NodoMateria n, int num)
        {
            //revisar que el nodo este vacio
            if (head == null)
            { return; }
            //Si el nodo a eliminar es el primer (head)
            if (head.Numero == num)
            {
                head.ListaMateria.Agregar(n);
                return;
            }
            NodoAlumnos h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Numero == num)
                { h.Siguiente.ListaMateria.Agregar(n); return; }
                h = h.Siguiente;
            }
            return;
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
            NodoAlumnos h = head;
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
        public bool Buscar(int d, ref NodoAlumnos b)
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
            NodoAlumnos h = head;
            while (h.Siguiente.Numero == d)
            {
                if (h.Siguiente.Numero == d)
                { b = h.Siguiente; return true; }
                h = h.Siguiente;
            }
            return false;
        }
        public void Modificar(int num, string n, string m, string am, string ap, ListaMateria lm)
        {
            if (head == null)
            {
                return;
            }
            if (head.Numero == num)
            {
                head.Nombre = n;
                head.ApellidoMaterno = am;
                head.ApellidoPaterno = ap;
                head.ListaMateria = lm; 
                return;
            }
            NodoAlumnos h = head;
            while (h.Siguiente.Numero == num)
            {
                if (h.Siguiente != null)
                {
                    h.Siguiente.Nombre = n;
                    h.Siguiente.ApellidoMaterno = am;
                    h.Siguiente.ApellidoPaterno = am;
                    h.Siguiente.ListaMateria = lm;
                    return;
                }
                h = h.Siguiente;
            }
        }
        public void MostrarMaterias(ListBox lista, int numeroAlumno)
        {
            NodoAlumnos h = head;
            lista.Items.Clear();
            while (h != null)
            {
                if(h.Numero == numeroAlumno)
                {
                    h.ListaMateria.Mostrar(lista);
                }
                h = h.Siguiente;
            }

        }
        public void Mostrar(ListView lista)
        {
            NodoAlumnos h = head;
            lista.Items.Clear();
            while (h != null)
            {
                ListViewItem renglon = new ListViewItem(h.Numero.ToString());
                renglon.SubItems.Add(h.Matricula);
                renglon.SubItems.Add(h.Nombre + "" + h.ApellidoPaterno + "" + h.ApellidoMaterno);
                lista.Items.Add(renglon);
                h = h.Siguiente;
            }

        }
        public override string ToString()
        {
            string listaEnTexto = "";
            NodoAlumnos h = head;
            while (h != null)
            {
                listaEnTexto += h.ToString() + "";
                h = h.Siguiente;
            }
            return listaEnTexto;
        }
    }
}
