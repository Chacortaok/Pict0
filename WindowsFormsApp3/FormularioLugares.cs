using System;
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
    public partial class FormularioLugares : Form
    {
        public FormularioLugares()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }
    }
}
