﻿using System;
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
    public partial class FrmSupprimerPersonne : Form
    {
        public FrmSupprimerPersonne()
        {
            InitializeComponent();
        }

        private void btn_SupprPers_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
