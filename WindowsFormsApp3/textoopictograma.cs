using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Picto
{
    public partial class textoopictograma : Form
    {
        public textoopictograma()
        {
            InitializeComponent();
        }

        private void textoopictograma_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }
    }
}
