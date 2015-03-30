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
    public partial class rCategorias : Form
    {
        Categorias Categoria = new Categorias();

        public rCategorias()
        {
            InitializeComponent();
        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdCategoriaTextBox.Clear();
            NombreTextBox.Clear();
        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            ErrorProvider EP1 = new ErrorProvider();
            if (!Utilitarios.ValidarTextBoxVacio(NombreTextBox, EP1, "Favor no dejar este campo Vacio"))
                return;

            Categoria.Nombre = NombreTextBox.Text;
            Categoria.IdCategoria = Utilitarios.ToInt(IdCategoriaTextBox.Text);
            
            
             if (Categoria.IdCategoria > 0)
            {
                //editando
                paso = Categoria.Modificar();
            }
            else
            {
                //Insertando
                paso = Categoria.Insertar();

            }

            if(paso)
            {
                MessageBox.Show("Categoria Guardada");
            }
            else
            {
                MessageBox.Show("Error. Intente de Nuevo y Revise los datos ingresados.");
            }
        
           }

        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            ErrorProvider EP = new ErrorProvider();
            Utilitarios.ValidarTextBoxVacio(IdCategoriaTextBox, EP, "Por favor asigne un ID a eliminar.");
            if (!string.IsNullOrWhiteSpace(IdCategoriaTextBox.Text) && Utilitarios.ToInt(IdCategoriaTextBox.Text) > 0)
            {
                Categoria.Eliminar(Utilitarios.ToInt(IdCategoriaTextBox.Text));
                MessageBox.Show("Categoria Eliminada Con Exito");
            }
        }

        private void IdCategoriaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.soloNumeros(e);
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.soloLetras(e);
        }

        }
    }

