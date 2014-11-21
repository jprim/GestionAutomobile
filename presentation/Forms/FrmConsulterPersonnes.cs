using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation.Forms
{
    public partial class FrmConsulterPersonnes : Form
    {
        public FrmConsulterPersonnes()
        {
            InitializeComponent();
        }

        private void btn_affichePersonnes_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
