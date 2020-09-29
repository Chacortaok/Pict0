using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using WindowsFormsApp3;

namespace Picto
{
    public partial class vozopictograma : Form
    {
        String texto; 
        public vozopictograma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var newForm = new Home();
            newForm.Show();
            this.Hide();
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
            MyGlobals.Texto = "Yo quiero ";
            var Picto2q = new Pictos2q();
            Picto2q.Show();
            this.Hide();

        }
    }
}
