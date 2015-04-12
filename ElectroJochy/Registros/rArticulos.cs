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

            ErrorProvider EP1 = new ErrorProvider();
            if(!Utilitarios.ValidarTextBoxVacio(CostoTextBox, EP1, "Favor no dejar este campo Vacio"))
                return;

            ErrorProvider EP2 = new ErrorProvider();
            if (!Utilitarios.ValidarTextBoxVacio(ExistenciaTextBox, EP2, "Favor no dejar este campo Vacio"))
                return;

            ErrorProvider EP3 = new ErrorProvider();
            if (!Utilitarios.ValidarTextBoxVacio(PrecioTextBox, EP3, "Favor no dejar este campo Vacio"))
                return;

            ErrorProvider EP4 = new ErrorProvider();
            if (!Utilitarios.ValidarTextBoxVacio(IdSuplidorTextBox, EP4, "Favor no dejar este campo Vacio"))
                return;

            ErrorProvider EP5 = new ErrorProvider();
            if (!Utilitarios.ValidarTextBoxVacio(DescripcionTextBox, EP5, "Favor no dejar este campo Vacio"))
                return;

            ErrorProvider EP6 = new ErrorProvider();
            if (!Utilitarios.ValidarTextBoxVacio(IdCategoriaTextBox, EP6, "Favor no dejar este campo Vacio"))
                return;

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
                IdArticuloTextBox.Clear();
                CostoTextBox.Clear();
                ExistenciaTextBox.Clear();
                PrecioTextBox.Clear();
                IdSuplidorTextBox.Clear();
                DescripcionTextBox.Clear();
            }
            else
            {
                //Insertando
                paso = Articulo.Insertar();
                IdArticuloTextBox.Clear();
                CostoTextBox.Clear();
                ExistenciaTextBox.Clear();
                PrecioTextBox.Clear();
                IdSuplidorTextBox.Clear();
                DescripcionTextBox.Clear();

            }

            if (paso)
                MessageBox.Show("Articulo Guardado");
            else
                MessageBox.Show("Por Favor Complete los Campos Correctamente");
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

        private void DescripcionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           // Utilitarios.soloLetras(e);
        }

        private void IdArticuloTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.soloNumeros(e);
        }

        private void ExistenciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.soloNumeros(e);
        }

        private void IdSuplidorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.soloNumeros(e);
        }

        private void IdCategoriaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.soloNumeros(e);
        }
        
        private void CostoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e.KeyChar.ToString().Equals(".")
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e.KeyChar.ToString().Equals(".")

            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CostoTextBox_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
