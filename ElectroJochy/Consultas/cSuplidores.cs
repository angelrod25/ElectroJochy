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
    public partial class cSuplidores : Form
    {
        public cSuplidores()
        {
            InitializeComponent();
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            Suplidores Suplidor = new Suplidores();
            DataTable dt = new DataTable();
            string filtro = "1=1";

            if (BuscarPorComboBox.SelectedIndex == 0)// IdSuplidor
            {
                //todo: validar que sea un numero

                filtro = "IdSuplidor =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 1)// Nombre
            {

                filtro = "Nombre like '%" + FiltroTextBox.Text + "%'";
            }

            else if (BuscarPorComboBox.SelectedIndex == 2)// Telefono
            {

                filtro = "Telefono =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 3)// RNC
            {

                filtro = "Telefono =" + FiltroTextBox.Text;
            }


            dt = Suplidor.Listar("IdSuplidor, Nombre, Telefono, RNC", filtro);
            SuplidoresDataGrid.DataSource = dt;
            CantidadTextBox.Text = SuplidoresDataGrid.RowCount.ToString();
        }
    }
}
