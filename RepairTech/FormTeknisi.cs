﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PBO
{
    public partial class FormTeknisi : Form
    {
        public FormTeknisi()
        {
            InitializeComponent();
        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {
            FormAdmin1 formTransaksi = new FormAdmin1();
            formTransaksi.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonKomponen_Click(object sender, EventArgs e)
        {
            FormKomponen formKomponen = new FormKomponen();
            formKomponen.Show();
            this.Hide();
        }

        private void buttonJasa_Click(object sender, EventArgs e)
        {
            FormJasaServis formJasa = new FormJasaServis();
            formJasa.Show();
            this.Hide();
        }
    }
}
