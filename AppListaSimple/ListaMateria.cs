using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppListaSimple
{
    class ListaMateria
    {
        private NodoMateria head;

        public NodoMateria Head
        {
            get { return head; }
            set { head = value; }
        }
        

        public ListaMateria()
        {
            head = null;
        }
        public void Agregar(NodoMateria n)
        {
            //Lista va cia
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
            NodoMateria h = head;
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
            NodoMateria h = head;
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
        public bool Buscar(int d, ref NodoMateria b)
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
            NodoMateria h = head;
            while (h.Siguiente.Numero == d)
            {
                if (h.Siguiente.Numero == d)
                { b = h.Siguiente; return true; }
                h = h.Siguiente;
            }
            return false;
        }
        public void Modificar(int d, string n, double c)
        {
            if (head == null)
            {
                return;
            }
            if (head.Numero == d)
            {
                head.Asicnatura = n;
                head.Calificacion = c;
                return;
            }
            NodoMateria h = head;
            while (h.Siguiente.Numero == d)
            {
                if (h.Siguiente != null)
                {
                    h.Siguiente.Asicnatura = n;
                    h.Siguiente.Calificacion = c;
                    return;
                }
                h = h.Siguiente;
            }
        }
        public void Mostrar(ListBox lista)
        {
            NodoMateria h = head;
            lista.Items.Clear();
            while (h != null)
            {
                lista.Items.Add(h.ToString());
                h = h.Siguiente;
            }
            
        }
        public void MostrarMaterias(ListView lista, int numeroAlumno)
        {
            NodoAlumnos h = head;
            lista.Items.Clear();
            while (h != null)
            {
                ListViewItem renglon = new ListViewItem(h.Numero.ToString());
                renglon.SubItems.Add(h.Nombre);
                renglon.SubItems.Add(h.Calificacion.ToString());
                lista.Items.Add(renglon);
                h = h.Siguiente;
            }
        }
        public void Guardar(string nombreArchivo)
        {
            Nodo h = head;
            if (head == null)
            {
                return;
            }
            nombreArchivo = "testlistacircular";
            string path = @"d:/" + nombreArchivo + ".txt";
            using (streawriter sw = File.CreateText(path))
            {
                do
                {
                    sw.writeline(h.Numero + "-" + "/n");
                    h = h.Siguiente;
                } while (h != head);
            }
            return;
        }
        public void Cargar(string nombreArchivo)
        {
            nombreArchivo = "testlistacircular";
            string[] lineas = File.ReadAllLines(@"d:/" + nombreArchivo + ".text");
            foreach (string linea in lineas)
            {
                if (linea.lenght == 0)
                {
                    continue;
                }
                string[] datos = linea.Split("-");
                string numero = datos[0];
                string nombre = datos[0];
                Nodo n = new Nodo(numero, nombre);
                Agregar(n);
            }
        }
        public override string ToString()
        {
            string listaEnTexto = "";
            NodoMateria h = head;
            while (h != null)
            {
                listaEnTexto += h.ToString() + "";
                h = h.Siguiente;
            }
            return listaEnTexto;
        }   


    }
}
