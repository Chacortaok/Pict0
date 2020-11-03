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
    public partial class FormularioSentimientos : Form
    {
        public FormularioSentimientos()
        {
            InitializeComponent();
        }
        int contador = 0;
        SpeechSynthesizer speak = new SpeechSynthesizer();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MyGlobals.Texto = MyGlobals.Texto + "aburrido ";
                textBox1.Text = MyGlobals.Texto;
                speak.Speak(textBox1.Text);
                contador++;
            }
            if (contador == 1)
            {
                MyGlobals.Texto = "";
                var newForm = new Picto.vozopictograma();
                newForm.Show();
                this.Hide();
            }

            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MyGlobals.Texto = MyGlobals.Texto + "enojado ";
                textBox1.Text = MyGlobals.Texto;
                speak.Speak(textBox1.Text);
                contador++;
            }
            if (contador == 1)
            {
                MyGlobals.Texto = "";
                var newForm = new Picto.vozopictograma();
                newForm.Show();
                this.Hide();
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MyGlobals.Texto = MyGlobals.Texto + "Enfermo ";
                textBox1.Text = MyGlobals.Texto;
                speak.Speak(textBox1.Text);
                contador++;
            }
            if (contador == 1)
            {
                MyGlobals.Texto = "";
                var newForm = new Picto.vozopictograma();
                newForm.Show();
                this.Hide();
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MyGlobals.Texto = MyGlobals.Texto + "alegre ";
                textBox1.Text = MyGlobals.Texto;
                speak.Speak(textBox1.Text);
                contador++;
            }
            if (contador == 1)
            {
                MyGlobals.Texto = "";
                var newForm = new Picto.vozopictograma();
                newForm.Show();
                this.Hide();
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MyGlobals.Texto = MyGlobals.Texto + "asustado ";
                textBox1.Text = MyGlobals.Texto;
                speak.Speak(textBox1.Text);
                contador++;
            }
            if (contador == 1)
            {
                MyGlobals.Texto = "";
                var newForm = new Picto.vozopictograma();
                newForm.Show();
                this.Hide();
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MyGlobals.Texto = MyGlobals.Texto + "triste ";
                textBox1.Text = MyGlobals.Texto;
                speak.Speak(textBox1.Text);
                contador++;
            }
            if (contador == 1)
            {
                MyGlobals.Texto = "";
                var newForm = new Picto.vozopictograma();
                newForm.Show();
                this.Hide();
            }

        }

        private void FormularioSentimientos_Load(object sender, EventArgs e)
        {

        }
    }
}
