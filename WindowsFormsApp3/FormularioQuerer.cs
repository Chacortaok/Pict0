﻿using System;
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
    public partial class FormularioQuerer : Form
    {
        public FormularioQuerer()
        {
            InitializeComponent();
        }
        SpeechSynthesizer speak = new SpeechSynthesizer();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + "jugar ";
            textBox1.Text = MyGlobals.Texto;
            var newformjugar = new FormularioJugar();
            newformjugar.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            
            MyGlobals.Texto = MyGlobals.Texto + "ponerme ";
            textBox1.Text = MyGlobals.Texto;
            var newformropa = new FormularioRopa();
            newformropa.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + "atarme los cordones ";
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto +  "bañarme ";
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBoxColores_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto +  "usar la bici ";
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + "lavarme los dientes ";
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + "Comer ";
            var newformcomidas = new FormularioComidas();
            newformcomidas.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + "dormir ";
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
            MyGlobals.Texto = MyGlobals.Texto + "ir ";
            var newformlugares = new FormularioLugares();
            newformlugares.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto +  "hacer pis ";
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + "ver la television ";
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            speak.Speak(textBox1.Text);
    }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + "hacer caca ";
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Home();
            newForm.Show();
            this.Hide();

        }
    }
}
