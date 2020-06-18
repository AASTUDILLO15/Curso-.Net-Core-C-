using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Library
{
    public class NumBoxEvent
    {
        public void numKeyPress(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))//datos de tipo numero
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
            else if (char.IsSeparator(e.KeyChar))//no permite espaciar (space)
            {
                e.Handled = true;
            }
            else//si no es ninguno de los anteriores no lo permite
            {
                e.Handled = true;
            }
        }
    }
}
