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
    public partial class rArticulos : Form
    {
        Articulos Articulo = new Articulos();
        public rArticulos()
        {
            InitializeComponent();
        }

        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            ErrorProvider EP = new ErrorProvider();
            Utilitarios.ValidarTextBoxVacio(IdArticuloTextBox, EP, "Por favor asigne un ID a eliminar.");
            if (!string.IsNullOrWhiteSpace(IdArticuloTextBox.Text) && Utilitarios.ToInt(IdArticuloTextBox.Text) > 0)
            {
                Articulo.Eliminar(Utilitarios.ToInt(IdArticuloTextBox.Text));
                MessageBox.Show("Articulo Eliminado Con Exito");
            }
        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            Articulo.IdArticulo = Utilitarios.ToInt(IdArticuloTextBox.Text);
            Articulo.Costo = Utilitarios.ToInt(CostoTextBox.Text);
            Articulo.Existencia = Utilitarios.ToInt(ExistenciaTextBox.Text);
            Articulo.Precio = Utilitarios.ToInt(PrecioTextBox.Text);
            Articulo.IdSuplidor = Utilitarios.ToInt(IdSuplidorTextBox.Text);
            Articulo.Descripcion = DescripcionTextBox.Text;
            Articulo.IdCategoria = Utilitarios.ToInt(IdCategoriaTextBox.Text);

            if (Articulo.IdArticulo > 0)
            {
                //editando
                paso = Articulo.Modificar();
            }
            else
            {
                //Insertando
                paso = Articulo.Insertar();

            }
        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdArticuloTextBox.Clear();
            CostoTextBox.Clear();
            ExistenciaTextBox.Clear();
            PrecioTextBox.Clear();
            IdSuplidorTextBox.Clear();
            DescripcionTextBox.Clear();
            
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
           
        }



    }
}
