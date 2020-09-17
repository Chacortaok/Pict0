﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Speech.Recognition;

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
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }
        void _Recognition_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            foreach (RecognizedWordUnit word in e.Result.Words)
            {
                lsTexto.Items.Add(word.Text);
            }
        }

        private void btnHablar_Click(object sender, EventArgs e)
        {
            Escuchando.SetInputToDefaultAudioDevice();
            Escuchando.LoadGrammar(new DictationGrammar());
            Escuchando.SpeechRecognized += _Recognition_SpeechRecognized;
            Escuchando.RecognizeAsync(RecognizeMode.Multiple);
        }
    }
}
