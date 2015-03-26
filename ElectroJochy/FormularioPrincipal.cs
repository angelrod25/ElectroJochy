using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace ElectroJochy
{
    public partial class FormularioPrincipal : Form
    {
   
        
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e) // Como borrar esto?
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)  // Como borrar esto?
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.LoginUsuarios Login = new Formularios.LoginUsuarios();
            Login.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rUsuarios RegU = new Registros.rUsuarios();
            RegU.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.cUsuarios cUsuario = new Consultas.cUsuarios();
            cUsuario.Show();
        }

        private void usuariosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
                Reportes.ReporteUsuarios Reporte = new Reportes.ReporteUsuarios();
                Reporte.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creado por Angel J. Rodríguez para Programación Aplicada I.\n Universidad Católica Nordestana.\n \n Email: Angelrguez25@Gmailcom. \n \n Creditos para el Profesor Enel Almonte por su acesoría.", "Información del Sistema");
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rArticulos rArticulos = new Registros.rArticulos();
            rArticulos.Show();
        }
    }
}
