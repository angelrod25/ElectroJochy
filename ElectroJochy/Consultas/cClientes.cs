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

namespace ElectroJochy.Consultas
{
    public partial class cClientes : Form
    {
        public cClientes()
        {
            InitializeComponent();
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            Clientes Cliente = new Clientes();
            DataTable dt = new DataTable();
            string filtro = "1=1";

            /*
IdCliente
Nombre
Cedula
Telefono
Direccion
Balance
             */

            if (BuscarPorComboBox.SelectedIndex == 0)// IdCliente
            {
                //todo: validar que sea un numero

                filtro = "IdCliente =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 1)// Nombre
            {

                filtro = "Nombre like '%" + FiltroTextBox.Text + "%'";
            }

            else if (BuscarPorComboBox.SelectedIndex == 2)// Cedula
            {

                filtro = "Cedula =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 3)// Telefono
            {

                filtro = "Telefono =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 4) // Direccion
            {

                filtro = "Direccion like '%" + FiltroTextBox.Text + "%'";
            }

            else if (BuscarPorComboBox.SelectedIndex == 5) // Balance
            {

                filtro = "Balance =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 6) // fecha
            {

                filtro = "Fecha =" + FiltroTextBox.Text;
            }

            dt = Cliente.Listar("IdCliente, Nombre, Cedula, Telefono, Direccion, Balance, Fecha", filtro);
            ClientesDataGrid.DataSource = dt;
            CantidadTextBox.Text = ClientesDataGrid.RowCount.ToString();
        }
    }
}
