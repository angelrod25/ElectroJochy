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
    public partial class rPagos : Form
    {
        Pagos Pago = new Pagos();

        public rPagos()
        {
            InitializeComponent();
        }

        private void IdPagoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdPagoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.soloNumeros(e);
        }

        private void MontoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString().Equals(".") || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdPagoTextBox.Clear();
            ConceptoTextBox.Clear();
            MontoTextBox.Clear();
        }

        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            ErrorProvider EP = new ErrorProvider();
            Utilitarios.ValidarTextBoxVacio(IdPagoTextBox, EP, "Por favor asigne un ID a eliminar.");
            if (!string.IsNullOrWhiteSpace(IdPagoTextBox.Text) && Utilitarios.ToInt(IdPagoTextBox.Text) > 0)
            {
                Pago.Eliminar(Utilitarios.ToInt(IdPagoTextBox.Text));
                MessageBox.Show("Pago Eliminado Con Exito");
            }
        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            ErrorProvider EP1 = new ErrorProvider();
            if (!Utilitarios.ValidarTextBoxVacio(ConceptoTextBox, EP1, "Favor no dejar este campo Vacio"))
                return;

            ErrorProvider EP2 = new ErrorProvider();
            if (!Utilitarios.ValidarTextBoxVacio(MontoTextBox, EP2, "Favor no dejar este campo Vacio"))
                return;

            Pago.IdPago = Utilitarios.ToInt(IdPagoTextBox.Text);
            Pago.Concepto = ConceptoTextBox.Text;
            Pago.Monto = Utilitarios.ToInt(MontoTextBox.Text);

            paso = Pago.Insertar();

            if (paso)
                MessageBox.Show("Pago Guardado");
            else
                MessageBox.Show("Por Favor Complete los Campos Correctamente");
        }
    }
}
