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
    public partial class rCobros : Form
    {
        Cobros Cobro = new Cobros();

        public rCobros()
        {
            InitializeComponent();
        }

        private void rCobros_Load(object sender, EventArgs e)
        {
            Clientes Cliente = new Clientes();

            ClienteComboBox.DataSource = Cliente.Listar("IdCliente,Nombre", "1=1");
            ClienteComboBox.ValueMember = "IdCliente";
            ClienteComboBox.DisplayMember = "Nombre";
            ClienteComboBox.SelectedIndex = 0;
        }

        private void informaciónDelRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para realizar un nuevo cobro, Dejar el ID COBRO en blanco, esto quiere decir que va a realizar Un Nuevo cobro, si ingresa el id de cobro significa que va a modificar un cobro ya existente.\n Ojo: Si no esta seguro del id del cobro que modificará, favor dirigise a la consulta de cobros y consultar el ID y luego regresar aquí.");
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.soloNumeros(e);
        }

        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            ErrorProvider EP = new ErrorProvider();
            Utilitarios.ValidarTextBoxVacio(IdCobroTextBox, EP, "Por favor asigne un ID a eliminar.");
            if (!string.IsNullOrWhiteSpace(IdCobroTextBox.Text) && Utilitarios.ToInt(IdCobroTextBox.Text) > 0)
            {
                Cobro.Eliminar(Utilitarios.ToInt(IdCobroTextBox.Text));
                MessageBox.Show("Cobro Eliminado Con Exito");
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

            Cobro.IdCobro = Utilitarios.ToInt(IdCobroTextBox.Text);
            Cobro.Concepto = ConceptoTextBox.Text;
            Cobro.Monto = Utilitarios.ToInt(MontoTextBox.Text);
            Cobro.IdCliente = Utilitarios.ToInt(ClienteComboBox.SelectedValue.ToString());

            if (Cobro.IdCobro > 0)
            {
                paso = Cobro.Modificar();   //editando
            }

            else
            {
                paso = Cobro.Insertar(); // insertando
            }


            if (paso)
            {
                MessageBox.Show("Cobro Guardado");
                IdCobroTextBox.Clear();
                ConceptoTextBox.Clear();
                MontoTextBox.Clear();
            }

            else
                MessageBox.Show("Por Favor Complete los Campos Correctamente");
        }
    }
}
