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
using System.Data.OleDb;
using WindowsFormsApp3.Properties;

namespace WindowsFormsApp3
{
    public partial class FormularioRopa : Form
    {
        public FormularioRopa()
        {
            InitializeComponent();
            textBox1.Text = MyGlobals.Texto;
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
        SpeechSynthesizer speak = new SpeechSynthesizer();

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var newForm = new Home();
            newForm.Show();
            this.Hide();
            MyGlobals.Texto = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            speak.Speak(textBox1.Text);
        }

        private void pictureBoxColores_Click(object sender, EventArgs e)
        {
            
                MyGlobals.Texto = MyGlobals.Texto + "unos botines";
                textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
                MyGlobals.Texto = MyGlobals.Texto + "las zapatillas";
                textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
                MyGlobals.Texto = MyGlobals.Texto + "unas ojotas";
                textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
                MyGlobals.Texto = MyGlobals.Texto + "un vestido";
                textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();



        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
                MyGlobals.Texto = MyGlobals.Texto + "una remera ";
                textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
         
                MyGlobals.Texto = MyGlobals.Texto + "el pijama";
                textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();




        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
          
                MyGlobals.Texto = MyGlobals.Texto + "impermiable ";
                textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + "un abrigo";
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
           
                MyGlobals.Texto = MyGlobals.Texto + "un pantalon";
                textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();


        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
          
                MyGlobals.Texto = MyGlobals.Texto + "guantes ";
                textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();


        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

            MyGlobals.Texto = MyGlobals.Texto + "joyas ";
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();
        }

        private void FormularioRopa_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            var newForm = new Home();
            newForm.Show();
            this.Hide();
            MyGlobals.Texto = "";
        }
    }
    }

