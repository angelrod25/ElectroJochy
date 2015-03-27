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
    public partial class cCategorias : Form
    {
        public cCategorias()
        {
            InitializeComponent();
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            Categorias Categoria = new Categorias();
            DataTable dt = new DataTable();
            string filtro = "1=1";
            int Cantidad;

            if (BuscarPorComboBox.SelectedIndex == 0)// IdCategoria
            {
                //todo: validar que sea un numero

                filtro = "IdCategoria =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 1)// Nombre
            {

                filtro = "Nombre like '%" + FiltroTextBox.Text + "%'";
            }

            dt = Categoria.Listar("IdCategoria, Nombre", filtro);
            CategoriasDataGrid.DataSource = dt;
            Cantidad = Convert.ToInt16(CategoriasDataGrid.RowCount.ToString());
            CantidadTextBox.Text = Cantidad.ToString();
        }
    }
}
