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
    public partial class rSuplidores : Form
    {
        Suplidores Suplidor = new Suplidores();

        public rSuplidores()
        {
            InitializeComponent();
        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdSuplidorTextBox.Clear();
            NombreTextBox.Clear();
            TelefonoMaskedBox.Clear();
            RNCTextBox.Clear();
        }

        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            ErrorProvider EP = new ErrorProvider();
            Utilitarios.ValidarTextBoxVacio(IdSuplidorTextBox, EP, "Por favor asigne un ID a eliminar.");
            if (!string.IsNullOrWhiteSpace(IdSuplidorTextBox.Text) && Utilitarios.ToInt(IdSuplidorTextBox.Text) > 0)
            {
                Suplidor.Eliminar(Utilitarios.ToInt(IdSuplidorTextBox.Text));
                MessageBox.Show("Suplidor Eliminado Con Exito");
            }
        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            ErrorProvider EP1 = new ErrorProvider();
            if (!Utilitarios.ValidarTextBoxVacio(NombreTextBox, EP1, "Favor no dejar este campo Vacio"))
                return;

            ErrorProvider EP2 = new ErrorProvider();
            if (!Utilitarios.ValidarTextBoxVacio(RNCTextBox, EP2, "Favor no dejar este campo Vacio"))
                return;

            ErrorProvider EP3 = new ErrorProvider();
            if (!Utilitarios.ValidarMaskedBoxVacio(TelefonoMaskedBox, EP3, "Favor no dejar este campo Vacio"))
                return;


            Suplidor.IdSuplidor = Utilitarios.ToInt(IdSuplidorTextBox.Text);
            Suplidor.Nombre = NombreTextBox.Text;
            Suplidor.RNC = RNCTextBox.Text;
            Suplidor.Telefono = TelefonoMaskedBox.Text;


            if (Suplidor.IdSuplidor > 0)
            {
                //editando
                paso = Suplidor.Modificar();
                IdSuplidorTextBox.Clear();
                NombreTextBox.Clear();
                TelefonoMaskedBox.Clear();
                RNCTextBox.Clear();
            }
            else
            {
                //Insertando
                paso = Suplidor.Insertar();
                IdSuplidorTextBox.Clear();
                NombreTextBox.Clear();
                TelefonoMaskedBox.Clear();
                RNCTextBox.Clear();

            }

            if (paso)
                MessageBox.Show("Suplidor Guardado");
            else
                MessageBox.Show("Por Favor Complete los Campos Correctamente");
        }

        private void IdSuplidorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.soloNumeros(e);
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.soloLetras(e);
        }
    }
}
