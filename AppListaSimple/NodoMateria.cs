using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaSimple
{
    class NodoMateria
    {
        private int numero;
        private string asicnatura;
        private double calificacion;
        private NodoMateria siguiente;
            
        public NodoMateria Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Asicnatura
        {
            get { return asicnatura; }
            set { asicnatura = value; }
        }
        public double Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }
        public NodoMateria ( )
        {
            numero = 0;
            asicnatura = "";
            calificacion = 0;
            siguiente = null;
        }
        public override string ToString()
        {
            return Asicnatura + "-" + Calificacion;
        }

    }
}
