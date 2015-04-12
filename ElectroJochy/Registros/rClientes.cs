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


namespace ElectroJochy.Registros
{
    public partial class rClientes : Form
    {
        Clientes Cliente = new Clientes();

        public rClientes()
        {
            InitializeComponent();
        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdClienteTextBox.Clear();
            NombreTextBox.Clear();
            CedulaTextBox.Clear();
            TelefonoTextBox.Clear();
            DireccionTextBox.Clear();
        }

        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            ErrorProvider EP = new ErrorProvider();
            Utilitarios.ValidarTextBoxVacio(IdClienteTextBox, EP, "Por favor asigne un ID a eliminar.");
            if (!string.IsNullOrWhiteSpace(IdClienteTextBox.Text) && Utilitarios.ToInt(IdClienteTextBox.Text) > 0)
            {
                Cliente.Eliminar(Utilitarios.ToInt(IdClienteTextBox.Text));
                MessageBox.Show("Cliente Eliminado Con Exito");
            }
        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            ErrorProvider EP1 = new ErrorProvider();
            if (!Utilitarios.ValidarTextBoxVacio(NombreTextBox, EP1, "Favor no dejar este campo Vacio"))
                return;

            ErrorProvider EP2 = new ErrorProvider();
            if (!Utilitarios.ValidarMaskedBoxVacio(CedulaTextBox, EP2, "Favor no dejar este campo Vacio"))
                return;

            ErrorProvider EP3 = new ErrorProvider();
            if (!Utilitarios.ValidarMaskedBoxVacio(TelefonoTextBox, EP3, "Favor no dejar este campo Vacio"))
                return;

            ErrorProvider EP4 = new ErrorProvider();
            if (!Utilitarios.ValidarTextBoxVacio(DireccionTextBox, EP4, "Favor no dejar este campo Vacio"))
                return;

            Cliente.IdCliente = Utilitarios.ToInt(IdClienteTextBox.Text);
            Cliente.Nombre = NombreTextBox.Text;
            Cliente.Cedula = CedulaTextBox.Text;
            Cliente.Telefono = TelefonoTextBox.Text;
            Cliente.Direccion = DireccionTextBox.Text;

            if (Cliente.IdCliente > 0)
            {
                //editando
                paso = Cliente.Modificar();
                IdClienteTextBox.Clear();
                NombreTextBox.Clear();
                CedulaTextBox.Clear();
                TelefonoTextBox.Clear();
                DireccionTextBox.Clear();
            }
            else
            {
                //Insertando
                paso = Cliente.Insertar();
                IdClienteTextBox.Clear();
                NombreTextBox.Clear();
                CedulaTextBox.Clear();
                TelefonoTextBox.Clear();
                DireccionTextBox.Clear();

            }

            if (paso)
                MessageBox.Show("Cliente Guardado");
            else
                MessageBox.Show("Por Favor Complete los Campos Correctamente");
        }

        private void IdClienteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.soloNumeros(e);
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.soloLetras(e);
        }

        private void IdClienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
