﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using WindowsFormsApp3;
using Picto;


namespace WindowsFormsApp3
{
    public partial class FormularioNoQuerer : Form
    {
        public FormularioNoQuerer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            var newformcomidas = new FormularioComidas();
            newformcomidas.Show();
            this.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            var newformjugar = new FormularioJugar();
            newformjugar.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            var newformlugares = new FormularioLugares();
            newformlugares.Show();
            this.Hide();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            var newformropa = new FormularioRopa();
            newformropa.Show();
            this.Hide();
        }
    }
}