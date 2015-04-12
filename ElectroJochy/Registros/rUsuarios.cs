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
    public partial class rUsuarios : Form
    {
        Usuarios Usuario = new Usuarios();

        public rUsuarios()
        {
            InitializeComponent();
        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdUsuarioTextBox.Clear();
            NombreCompletoTextBox.Clear();
            UsuarioTextBox.Clear();
            ContrasenaTextBox.Clear();
            EmailTextBox.Clear();
            NivelAccesoTextBox.Clear();

        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            ErrorProvider EP1 = new ErrorProvider();
            if (!Utilitarios.ValidarTextBoxVacio(NombreCompletoTextBox, EP1, "Favor no dejar este campo Vacio"))
                return;

            ErrorProvider EP2 = new ErrorProvider();
            if (!Utilitarios.ValidarTextBoxVacio(UsuarioTextBox, EP2, "Favor no dejar este campo Vacio"))
                return;

            ErrorProvider EP3 = new ErrorProvider();
            if (!Utilitarios.ValidarTextBoxVacio(ContrasenaTextBox, EP3, "Favor no dejar este campo Vacio"))
                return;

            ErrorProvider EP4 = new ErrorProvider();
            if (!Utilitarios.ValidarTextBoxVacio(EmailTextBox, EP4, "Favor no dejar este campo Vacio"))
                return;

            ErrorProvider EP5 = new ErrorProvider();
            if (!Utilitarios.ValidarTextBoxVacio(NivelAccesoTextBox, EP5, "Favor no dejar este campo Vacio"))
                return;


            Usuario.IdUsuario = Utilitarios.ToInt(IdUsuarioTextBox.Text);
            Usuario.Nombre = NombreCompletoTextBox.Text;
            Usuario.Usuario = UsuarioTextBox.Text;
            Usuario.Contrasena = ContrasenaTextBox.Text;
            Usuario.Email = EmailTextBox.Text;
            Usuario.Nivel = Utilitarios.ToInt(NivelAccesoTextBox.Text);


            if (Usuario.IdUsuario > 0)
            {
                paso = Usuario.Modificar();   //editando
            }

            else
            {
                paso = Usuario.Insertar(); // insertando
            }

             if (paso)
             {
                 MessageBox.Show("Usuario Guardado");
                 IdUsuarioTextBox.Clear();
                 NombreCompletoTextBox.Clear();
                 UsuarioTextBox.Clear();
                 ContrasenaTextBox.Clear();
                 EmailTextBox.Clear();
                 NivelAccesoTextBox.Clear();
             }
             else
                 MessageBox.Show("Por Favor Complete los Campos Correctamente");
        
        }

        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            ErrorProvider EP = new ErrorProvider();
            Utilitarios.ValidarTextBoxVacio(IdUsuarioTextBox, EP, "Por favor asigne un ID a eliminar.");
            if (!string.IsNullOrWhiteSpace(IdUsuarioTextBox.Text) && Utilitarios.ToInt(IdUsuarioTextBox.Text) > 0)
            {
                Usuario.Eliminar(Utilitarios.ToInt(IdUsuarioTextBox.Text));
                MessageBox.Show("Usuario Eliminado Con Exito");
            }
        }

        private void IdUsuarioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.soloNumeros(e);
        }

        private void NombreCompletoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.soloLetras(e);
        }

        private void NivelAccesoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.soloNumeros(e);
        }
    }
}
