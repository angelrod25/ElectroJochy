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
    public partial class rFacturas : Form
    {
        public rFacturas()
        {
            InitializeComponent();
        }

        private void rFacturas_Load(object sender, EventArgs e)
        {
            Articulos Articulo = new Articulos();

            ArticuloComboBox.DataSource = Articulo.Listar("IdArticulo,Descripcion", "1=1");
            ArticuloComboBox.ValueMember = "IdArticulo";
            ArticuloComboBox.DisplayMember = "Descripcion";

            TipoComboBox.SelectedIndex = 0;

            Clientes Cliente = new Clientes();

            ClienteComboBox.DataSource = Cliente.Listar("IdCliente,Nombre", "1=1");
            ClienteComboBox.ValueMember = "IdCliente";
            ClienteComboBox.DisplayMember = "Nombre";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Articulos Articulo = new Articulos();

            ErrorProvider EP1 = new ErrorProvider();
            if (!Utilitarios.ValidarTextBoxVacio(CantidadTextBox, EP1, "No dejar este campo vacío."))
            return;

                FacturaDataGrid.Rows.Add();

                FacturaDataGrid.Rows[FacturaDataGrid.Rows.Count - 1].Cells[0].Value = CantidadTextBox.Text; // Columna "Cantidad"

                FacturaDataGrid.Rows[FacturaDataGrid.Rows.Count - 1].Cells[1].Value = ArticuloComboBox.Text; // Columna "Descripcion"

                Articulo.Buscar((int)ArticuloComboBox.SelectedValue); // el metodo que pone los datos del articulo en el dataGrid

                FacturaDataGrid.Rows[FacturaDataGrid.Rows.Count - 1].Cells[2].Value = Articulo.Precio; // Columna "Precio"

                float mult = Convert.ToSingle(FacturaDataGrid.Rows[FacturaDataGrid.Rows.Count - 1].Cells[0].Value) * Convert.ToSingle(FacturaDataGrid.Rows[FacturaDataGrid.Rows.Count - 1].Cells[2].Value); //formula que multiplica cant * p.unitario

                FacturaDataGrid.Rows[FacturaDataGrid.Rows.Count - 1].Cells[3].Value = mult;      // Columna "Importe" 

                float SumaSubTotal = 0.0f;
                for (int i = 0; i < FacturaDataGrid.Rows.Count; ++i)
                {
                    SumaSubTotal += Convert.ToSingle(FacturaDataGrid.Rows[i].Cells[3].Value);
                }

                float subtotal = SumaSubTotal / 1.18f; // formula calcula subTotal

                float itbis = subtotal * 0.18f;

                float Totalpagar = subtotal + itbis;

                SubTotalTextBox.Text = subtotal.ToString("n2");
                ItbisTextBox.Text = itbis.ToString("n2");
                TotalRenglonesTextBox.Text = FacturaDataGrid.RowCount.ToString(); // Celda que calcula "Total de Renglones"
                TotalPagarTextBox.Text = Totalpagar.ToString("n2");
              
        }



        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.soloNumeros(e);
        }

        private void CantidadTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FacturaDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
