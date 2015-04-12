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
                FacturaDataGrid.Rows[FacturaDataGrid.Rows.Count - 1].Cells[0].Value = CantidadTextBox.Text;
                FacturaDataGrid.Rows[FacturaDataGrid.Rows.Count - 1].Cells[1].Value = ArticuloComboBox.Text;
                Articulo.Buscar((int)ArticuloComboBox.SelectedValue);

                FacturaDataGrid.Rows[FacturaDataGrid.Rows.Count - 1].Cells[2].Value = Articulo.Precio ;
                // precio total: FacturaDataGrid.Rows[FacturaDataGrid.Rows.Count - 1].Cells[3].Value = ArticuloComboBox.Text;

                TotalRenglonesTextBox.Text = FacturaDataGrid.RowCount.ToString();
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
    }
}
