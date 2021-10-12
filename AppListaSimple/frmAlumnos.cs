using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppListaSimple
{
    public partial class frmAlumnos : Form
    {
        ListaAlumnos miLista;
        public frmAlumnos()
        {
            InitializeComponent();
            miLista = new ListaAlumnos(); 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNum.Text);
            string matricula = txtMat.Text; 
            string nombre = txtNom.Text;
            string apellidoPaterno = txtAp.Text;
            string apellidoMaterno = txtAm.Text; 
            NodoAlumnos n = new NodoAlumnos(numero, nombre, apellidoMaterno,apellidoMaterno, matricula);
            miLista.Agregar(n);
            txtNum.Clear();
            txtNom.Clear();
            txtAm.Clear();
            txtAp.Clear();
            miLista.Mostrar(lstDatos);
            txtNum.Focus();
            miLista.Mostrar(lstDatos);
        }

        private void btnAggregarMat_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumMat.Text);
            string nombre = txtNom.Text;
            double calificacion = double.Parse(txtCalificacion.Text);
            NodoMateria n = new  NodoMateria( numero, nombre, calificacion);
            miLista.AgregarMateria(n, numero);
            txtNomMat.Clear();
            txtCalificacion.Clear();
            txtNumMat.Focus();
            //miLista.Mostrar(lstDatos);
            miLista.Mostrar(lstAlumnos)
;        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstAlumnos.SelectedIndexChanged.Count==0)
            {
                return;
            }
            int numeroAlumno = int.Parse(lstAlumnos.SelectedItems[0].SubItems[0].Text;)
            miLista.MostrarMateria(lstMaterias, numeroAlumno);
        }

        
    }
}
