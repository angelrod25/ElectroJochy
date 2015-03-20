using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;

namespace ElectroJochy.Formularios
{
    public partial class LoginUsuarios : Form
    {
        Usuarios Usuario = new Usuarios();
  
        public LoginUsuarios()
        {
            InitializeComponent();
        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {

            if (UsuarioTextBox.Text == "" || UsuarioTextBox.Text == "")
            {
                MessageBox.Show("Favor Ingresar Usuario y Contraseña.");
                return;
            }    
               

            Usuario.BuscarUsuario(UsuarioTextBox.Text, ContrasenaTextBox.Text);  

            //if(UsuarioTextBox.Text == Usuario.Contrasena && ContrasenaTextBox.Text == Usuario.Contrasena)
         //   {
                FormularioPrincipal Main = new FormularioPrincipal();
                Main.Show();
                this.Hide();

           // }

          //  else
            //{           
              //  MessageBox.Show("Nombre de Usuario o Contraseña Incorrecta. ", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
       
        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            UsuarioTextBox.Clear();
            ContrasenaTextBox.Clear();
        }
    }
}
