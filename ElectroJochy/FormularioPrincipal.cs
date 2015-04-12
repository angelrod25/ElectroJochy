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
            MessageBox.Show("Creado por Angel J. Rodríguez para Programación Aplicada I.\nUniversidad Católica Nordestana.\n \nEmail: Angelrguez25@Gmail.com. \n \nCreditos para el Profesor Enel Almonte por su acesoría.", "Información del Sistema");
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rArticulos rArticulos = new Registros.rArticulos();
            rArticulos.Show();
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.cArticulos cArticulos = new Consultas.cArticulos();
            cArticulos.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rCategorias rCategorias = new Registros.rCategorias();
            rCategorias.Show();
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.cCategorias cCategorias = new Consultas.cCategorias();
            cCategorias.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rClientes rClientes = new Registros.rClientes();
            rClientes.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.cClientes cClientes = new Consultas.cClientes();
            cClientes.Show();
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rSuplidores rSuplidores = new Registros.rSuplidores();
            rSuplidores.Show();
        }

        private void suplidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.cSuplidores cSuplidores = new Consultas.cSuplidores();
            cSuplidores.Show();
        }

        private void articulosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Reportes.ReporteArticulos rArticulos = new Reportes.ReporteArticulos();
            rArticulos.Show();
        }

        private void categoriasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Reportes.ReporteCategorias rC = new Reportes.ReporteCategorias();
            rC.Show();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Reportes.ReporteClientes rClientes = new Reportes.ReporteClientes();
            rClientes.Show();
        }

        private void suplidoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Reportes.ReporteSuplidores repSup = new Reportes.ReporteSuplidores();
            repSup.Show();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rPagos rPago = new Registros.rPagos();
            rPago.Show();
        }

        private void pagosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.cPagos cPago = new Consultas.cPagos();
            cPago.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rFacturas rFact = new Registros.rFacturas();
            rFact.Show();
        }

        private void pagosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Reportes.ReportePagos repPagos = new Reportes.ReportePagos();
            repPagos.Show();
        }

        private void cobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rCobros regCobros = new Registros.rCobros();
            regCobros.Show();
        }

        private void cobrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.cCobros conCobros = new Consultas.cCobros();
            conCobros.Show();
        }

        private void cobrosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Reportes.ReporteCobros repCobros = new Reportes.ReporteCobros();
            repCobros.Show();
        }
    }
}
