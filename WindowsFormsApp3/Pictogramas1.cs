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

namespace Picto
{
    public partial class vozopictograma : Form
    {
        String texto; 
        public vozopictograma()
        {
            InitializeComponent();
        }

        

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Escribí lo que sea");
            }
            else
            {
                string toSpeak = textBox1.Text;
                SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
                speechSynthesizer.Speak(toSpeak);
                speechSynthesizer.Dispose();
            }
        }

        private void picquerer_Click(object sender, EventArgs e)
        {
            var newformnoquerer  = new FormularioNoQuerer();
            newformnoquerer.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void vozopictograma_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var newformcolores = new FormularioColores();
                newformcolores.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var newformcomunicacion = new FormularioComunicacion();
            newformcomunicacion.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var newformnumeros = new FormularioNumeros();
            newformnumeros.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var newformquerer = new FormularioQuerer();
            newformquerer.Show();
            this.Hide();
        }

        private void pictureBoxSentimientos_Click(object sender, EventArgs e)
        {
            var newformsentimientos = new FormularioSentimientos();
            newformsentimientos.Show();
            this.Hide();
        }
    }
}
