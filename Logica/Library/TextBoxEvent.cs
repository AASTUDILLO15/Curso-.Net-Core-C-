using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace Logica.Library
{
    public class TextBoxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//datos de tipo texto
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))//no dar salto de linea cuando se oprime enter
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))//permite borrar un caracter (backspace)
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))//permite espaciar (space)
            {
                e.Handled = false;
            }
            else//si no es ninguno de los anteriores no lo permite
            {
                e.Handled = true;
            }
        }

        public void emailKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))//no dar salto de linea cuando se oprime enter
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))//permite borrar un caracter (backspace)
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))//no permite espaciar (space)
            {
                e.Handled = true;
            }
        }

        public bool emailFormat(string email)
        {
            return new EmailAddressAttribute().IsValid(email);//si es un email valid true, sino false
        }
    }
}
