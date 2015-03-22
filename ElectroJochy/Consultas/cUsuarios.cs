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
    public partial class cUsuarios : Form
    {

        public cUsuarios()
        {
            InitializeComponent();
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            Usuarios Usuario = new Usuarios();
            DataTable dt = new DataTable();
            string filtro = "1=1";

            if (BuscarPorComboBox.SelectedIndex == 0)// IdUsuario
            {
                //todo: validar que sea un numero

                filtro = "IdUsuario=" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 1)// Nombre
            {

                filtro = "Nombre =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 2)// Usuario
            {

                filtro = "Usuario =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 3)// Email
            {

                filtro = "Email like '%" + FiltroTextBox.Text + "%'";
            }

            else if (BuscarPorComboBox.SelectedIndex == 4)// Nivel
            {

                filtro = "Nivel =" + FiltroTextBox.Text;
            }

            dt = Usuario.Listar("IdUsuario, Nombre, Usuario, Email, Nivel", filtro);
            UsuariosDataGrid.DataSource = dt;
            CantidadTextBox.Text = UsuariosDataGrid.RowCount.ToString();
        }

    }
}
