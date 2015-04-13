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
    public partial class cArticulos : Form
    {
        public cArticulos()
        {
            InitializeComponent();
        }
        /*IdArticulo
        Descripcion
        Costo
        Precio
        Existencia
        IdSuplidor
        IdCategoria */

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            Suplidores Suplidor = new Suplidores();
            Articulos Articulo = new Articulos();
            DataTable dt = new DataTable();
            string filtro = "1=1";

            if (BuscarPorComboBox.SelectedIndex == 0)// IdArticulo
            {
                //todo: validar que sea un numero

                filtro = "IdArticulo =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 1)// Descripcion
            {

                filtro = "Descripcion like '%" + FiltroTextBox.Text + "%'";
            }

            else if (BuscarPorComboBox.SelectedIndex == 2)// Costo
            {

                filtro = "Costo =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 3)// Precio
            {

                filtro = "Precio =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 4) // Existencia
            {

                filtro = "Existencia =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 5) // IdSuplidor
            {

                filtro = "IdSuplidor =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 6) // IdCategoria
            {

                filtro = "IdCategoria =" + FiltroTextBox.Text;
            }

            dt = Articulo.Listar("IdArticulo, Descripcion, Costo, Precio, Existencia, IdSuplidor, IdCategoria", filtro);
            ArticulosDataGrid.DataSource = dt;
            CantidadTextBox.Text = ArticulosDataGrid.RowCount.ToString();
        }

        private void BuscarPorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FiltroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
