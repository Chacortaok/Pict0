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
        void _Recognition_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            try
            {
              foreach (RecognizedWordUnit word in e.Result.Words)
                {
                    listBox1.Items.Add(word.Text);
                }
            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("ERROR, la Computadora ya esta escuchando");
            }
            
        }
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
           Escuchando.SetInputToDefaultAudioDevice();
           Escuchando.LoadGrammar(new DictationGrammar());
           Escuchando.SpeechRecognized += _Recognition_SpeechRecognized;
           Escuchando.RecognizeAsync(RecognizeMode.Multiple);
        }
    }
}
