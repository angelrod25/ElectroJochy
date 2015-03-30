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
    public partial class cPagos : Form
    {
        public cPagos()
        {
            InitializeComponent();
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            Pagos Pago = new Pagos();
            DataTable dt = new DataTable();
            string filtro = "1=1";
            int Cantidad;

            if (BuscarPorComboBox.SelectedIndex == 0)// IdPago
            {

                filtro = "IdPago =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 1)// Concepto
            {

                filtro = "Concepto like '%" + FiltroTextBox.Text + "%'";
            }

            else if (BuscarPorComboBox.SelectedIndex == 2)// Monto
            {

                filtro = "Monto =" + FiltroTextBox.Text;
            }
            dt = Pago.Listar("IdPago, Concepto, Monto, Fecha", filtro);
            PagosDataGrid.DataSource = dt;
            Cantidad = Convert.ToInt16(PagosDataGrid.RowCount.ToString());
            CantidadTextBox.Text = Cantidad.ToString();
        }
    }
}
