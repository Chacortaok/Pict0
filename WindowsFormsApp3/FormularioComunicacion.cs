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
    public partial class FormularioComunicacion : Form
    {
        public FormularioComunicacion()
        {
            InitializeComponent();
        }
        SpeechSynthesizer speak = new SpeechSynthesizer();
        int contador = 0; 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MyGlobals.Texto = MyGlobals.Texto + "Adios ";
                textBox1.Text = MyGlobals.Texto;
                speak.Speak(textBox1.Text);
                contador++;
            }
            if (contador == 1)
            {
                MyGlobals.Texto = "";
                var newForm = new Home();
                newForm.Show();
                this.Hide();
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MyGlobals.Texto = MyGlobals.Texto + "Gracias ";
                textBox1.Text = MyGlobals.Texto;
                speak.Speak(textBox1.Text);
                contador++;
            }
            if (contador == 1)
            {
                MyGlobals.Texto = "";
                var newForm = new Home();
                newForm.Show();
                this.Hide();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MyGlobals.Texto = MyGlobals.Texto + "Hola ";
                textBox1.Text = MyGlobals.Texto;
                speak.Speak(textBox1.Text);
                contador++;
            }
            if (contador == 1)
            {
                MyGlobals.Texto = "";
                var newForm = new Home();
                newForm.Show();
                this.Hide();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MyGlobals.Texto = MyGlobals.Texto + "No ";
                textBox1.Text = MyGlobals.Texto;
                speak.Speak(textBox1.Text);
                contador++;
            }
            if (contador == 1)
            {
                MyGlobals.Texto = "";
                var newForm = new Home();
                newForm.Show();
                this.Hide();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MyGlobals.Texto = MyGlobals.Texto + "Si ";
                textBox1.Text = MyGlobals.Texto;
                speak.Speak(textBox1.Text);
                contador++;
            }
            if (contador == 1)
            {
                MyGlobals.Texto = "";
                var newForm = new Home();
                newForm.Show();
                this.Hide();
            }
        }
    }
}
