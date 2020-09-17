using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Picto
{
    public partial class vozotexto : Form
    {
        public vozotexto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void vozotexto_Load(object sender, EventArgs e)
        {

        }
    }
}
