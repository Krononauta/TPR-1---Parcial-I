using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR_1___Parcial
{
    
    public partial class Form1 : Form
    {
        
        TCola Cola = new TCola();
        
        

        public Form1()
        {
            InitializeComponent();
        }

        void Encolar(TAlumno alumno, TCola cola, ListBox lstBoxPila)
        {
            if (!cola.Llena())
            {
                cola.Enqueue(alumno);
                MostrarCola(cola, lstBoxPila);
            }
        }
        void MostrarCola(TCola cola, ListBox lstBox)
        {
            TAlumno[] elementos = new TAlumno[cola.Longitud()];
            elementos = (TAlumno[])cola.Elementos();

            lstBox.Items.Clear();
            for (int i = cola.Primero_(); i <= cola.Ultimo_(); i++)
            {
                lstBox.Items.Add(elementos[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            TAlumno alumno = new TAlumno();
            alumno.Nombre = txtNombre1.Text;
            alumno.Apellido = txtApellido1.Text;
            Encolar(alumno, Cola, listBox1);
            txtNombre1.Text = "";
            txtApellido1.Text = "";
            txtNombre1.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!Cola.Vacia())
            {
                Cola.Dequeue();
                MostrarCola(Cola, listBox1);
            }

        }
//
        private void btnTope_Click(object sender, EventArgs e)
        {
            if (!Cola.Vacia())
            {
 
                MessageBox.Show("Tope\n\n" + "Nombre: " + Cola.Peek().Nombre +"\n"
                                         + "Apellido: " + Cola.Peek().Apellido + "\n");
                 
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
