using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppListaSimple
{
    public partial class Form1 : Form
    {
        Lista milista;
        Graphics graficos;

        public Form1()
        {
            InitializeComponent();
            milista = new  Lista();
            this.WindowState = FormWindowState.Maximized;
            graficos = this.CreateGraphics();
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            Nodo n = new Nodo(numero, nombre, telefono);
            milista.Agregar(n);
            txtNumero.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            milista.Mostrar(LstDatos);

            /*for (int i = 0; i < LstDatos.Items.Count; i++)
            {
                DibujarRectangulo(i);
            }*/
        }

        /*
        public void DibujarRectangulo(int x)
        {
            Pen pluma = new Pen(Color.Black, 3);
            Rectangle rectangulo = new Rectangle(10+(x*120), 400, 100, 50);
            graficos.DrawRectangle(pluma, rectangulo);
            graficos.DrawLine(pluma, 80 + (x * 120), 400, 80 + (x * 120), 450);
            graficos.DrawLine(pluma, 80 + (x * 120), 425, 130 + (x * 120), 425);

        }
        */
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int d = int.Parse(txtNumero.Text);
            milista.Eliminar(d);
            txtNumero.Clear();
            txtTelefono.Clear();
            txtNombre.Clear();
            txtNumero.Focus();
            milista.Mostrar(LstDatos);
            //MessageBox.Show(milista + "");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            Nodo b = new Nodo();
            if (milista.Buscar(numero,ref b))
            {
                txtNombre.Text = b.Nombre;
                txtTelefono.Text = b.Nombre;

            }
            else
            {
                MessageBox.Show("No existe");
            }
            txtNumero.Focus();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            milista.Mostrar(LstDatos);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            Nodo n = new Nodo(numero, nombre, telefono);
            milista.Agregar(n);
            txtNumero.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            milista.Mostrar(LstDatos);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            Nodo n = new Nodo(numero, nombre, telefono);
            milista.Agregar(n);
            txtNumero.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            milista.Mostrar(LstDatos);
        }
    }
}
