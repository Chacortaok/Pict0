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
using System.Data.OleDb;
using WindowsFormsApp3.Properties;

namespace WindowsFormsApp3
{
    public partial class FormularioNumeros : Form
    {

        SpeechSynthesizer speak = new SpeechSynthesizer();
        public FormularioNumeros()
        {
            InitializeComponent();
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Fondo FROM FormEx_AA WHERE Id = 1", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string fondo = rd.GetString(0);




            if (fondo == "Fondo Blanco")
            {
                BackgroundImage = Resources.Artboard_1;



            }

            else
            {
                BackgroundImage = Resources.Artboard_1__1_;



            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var newForm = new Home();
            newForm.Show();
            this.Hide();
            MyGlobals.Texto = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + "Dos";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
        }

        private void pictureBoxColores_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = "Uno";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = " Cuatro";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = " Tres";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = "";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = " Cinco";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = " Seis";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = " Siete";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = " Ocho";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = "Nueve";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = "Diez";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
        }

        private void FormularioNumeros_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            var newForm = new vozopictograma();
            newForm.Show();
            this.Hide();
            MyGlobals.Texto = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
        }
    }
    }

