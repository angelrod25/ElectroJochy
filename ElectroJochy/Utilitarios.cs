using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectroJochy
{
    public class Utilitarios
    {

        public static int ToInt(string texto)
        {
            int valor = 0;

            int.TryParse(texto, out valor);

            return valor;
        }

        public static bool ValidarTextBoxVacio(TextBox TextoValidar, ErrorProvider ErrProvider, string MensajedeError)
        {
            bool valido = true;

            if (TextoValidar.Text.Trim().Length == 0)
            {
                ErrProvider.SetError(TextoValidar, MensajedeError);
                TextoValidar.Focus();
                valido = false;
            }

            return valido;
        }

        public static void soloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        public static void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }

                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

    }//end clase


  



}
