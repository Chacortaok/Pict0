using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace Picto
{
    public partial class txt : Form
    {
        SpeechRecognitionEngine Escuchando = new SpeechRecognitionEngine();
        public txt()
        {
            InitializeComponent();
        }

        private void vozotexto_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void btnEscuchar_Click(object sender, EventArgs e)
        {

        }
    }
}
 
          
