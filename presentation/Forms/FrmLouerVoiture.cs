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
    public partial class FrmLouerVoiture : Form
    {
        public FrmLouerVoiture()
        {
            InitializeComponent();
        }

        private void btn_louer_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
