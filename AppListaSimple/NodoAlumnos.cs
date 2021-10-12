using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaSimple
{
    class NodoAlumnos
    {
        private int numero;
        private string matricula;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private int calificacion;
        private NodoAlumnos siguiente;
        private ListaMateria listaMateria;

        public ListaMateria ListaMateria
        {
            get { return listaMateria; }
            set { listaMateria = value; }
        }

        public NodoAlumnos Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string ApellidoMaterno
        {
            get { return apellidoMaterno; }
            set { apellidoMaterno = value; }
        }

        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }
        }

        public int Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }

        public NodoAlumnos()
        {
            numero = 0;
            nombre = "";
            matricula = "";
            apellidoPaterno = "";
            apellidoMaterno = "";
            listaMateria = new ListaMateria();
            siguiente = null;
        }

        public NodoAlumnos(int num, string nomb, string ap, string m, string am, int cal)
        {
            numero = num;
            nombre = nomb;
            matricula = m;
            apellidoMaterno = ap;
            apellidoPaterno = am;
            listaMateria = new ListaMateria();
            calificacion = cal;
            siguiente = null;
        }

        public override string ToString()
        {
            if(listaMateria == null)
            {
                return numero + "-" + matricula + "-" + nombre + "" + apellidoMaterno + "" + apellidoPaterno + "" + siguiente + listaMateria + "" + calificacion.ToString();
            }
            return numero + "-" + matricula + "-" + nombre + "" + apellidoMaterno + "" + apellidoPaterno + "" + siguiente + listaMateria + "" + calificacion.ToString();
        }
    }
}
