using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Globalization;

namespace Picto
{
    public partial class textoopictograma : Form
    {
        
        SpeechRecognitionEngine Escuchando = new SpeechRecognitionEngine();
        
        public textoopictograma()
        {
            InitializeComponent();
        }

        private void textoopictograma_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //label picto lleva a la home
            // Lo hizo Dante 
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }
        private void _Recognition_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            textBox1.Text = e.Result.Text;
            }

        private void btnHablar_Click(object sender, EventArgs e)
        {
            // Abre el puerto de audio establecido como deafault, Carga el diccionario de gramatico ya preestablecido y utiliza el reconizespeech.Multiple 
            // Lo hizo Tomas 
            Escuchando.SetInputToDefaultAudioDevice();
            Escuchando.LoadGrammar(new DictationGrammar());
            Escuchando.SpeechRecognized += _Recognition_SpeechRecognized;
            Escuchando.RecognizeAsync(RecognizeMode.Multiple);
            
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //para de reconozer palabras y vacia el espacio de escritura
            // Lo hizo tomas 
            Escuchando.RecognizeAsyncStop();
            textBox1.Text = "";
        }
    }
    
    

}
