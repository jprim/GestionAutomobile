using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitaire.TextBox
{
    /// <summary>
    /// Classe Saisie
    /// </summary>
    class Saisie
    {
        //Empeche la saisie des numéros dans certains champs
        private void nb_KeyPress(object sender, EventArgs e )
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||
                 (e.KeyChar == (char)44))
                e.Handled = false;
            else
                e.Handled = true;
        }

        





    }
}
