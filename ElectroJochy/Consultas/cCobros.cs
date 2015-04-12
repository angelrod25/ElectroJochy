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
    public partial class cCobros : Form
    {
        public cCobros()
        {
            InitializeComponent();
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            Cobros Cobro = new Cobros();
            DataTable dt = new DataTable();
            string filtro = "1=1";

            if (BuscarPorComboBox.SelectedIndex == 0)// IdCobro
            {
                //todo: validar que sea un numero

                filtro = "IdCobro =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 1)// Fecha
            {

                filtro = "Fecha like '%" + FiltroTextBox.Text + "%'";
            }

            else if (BuscarPorComboBox.SelectedIndex == 2)// Monto
            {

                filtro = "Monto =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 3)// IdCliente
            {

                filtro = "IdCliente =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 4) // Concepto
            {

                filtro = "Concepto like '%" + FiltroTextBox.Text + "%'";
            }

            dt = Cobro.Listar("IdCobro, Fecha, Monto, IdCliente, Concepto", filtro);
            CobrosDataGrid.DataSource = dt;
            CantidadTextBox.Text = CobrosDataGrid.RowCount.ToString();

        }
    }
}
