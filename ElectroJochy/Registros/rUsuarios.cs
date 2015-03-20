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
            Usuario.IdUsuario = Utilitarios.ToInt(IdUsuarioTextBox.Text);
            Usuario.Nombre = NombreCompletoTextBox.Text;
            Usuario.Usuario = IdUsuarioTextBox.Text;
            Usuario.Contrasena = ContrasenaTextBox.Text;
            Usuario.Email = EmailTextBox.Text;
            Usuario.Nivel = Utilitarios.ToInt(NivelAccesoTextBox.Text);

            Usuario.Insertar();
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
    }
}
