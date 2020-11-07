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
    public partial class FormularioComidas : Form
    {
        public FormularioComidas()
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
        
        SpeechSynthesizer speak = new SpeechSynthesizer();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBoxNumeros_Click(object sender, EventArgs e)
        {
            
                MyGlobals.Texto = MyGlobals.Texto + "agua ";
                textBox1.Text = MyGlobals.Texto;
                MyGlobals.Texto = "Yo quiero/no quiero comer ";
            }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
                MyGlobals.Texto = MyGlobals.Texto + "caramelos ";
                textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "Yo quiero/no quiero comer ";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
                MyGlobals.Texto = MyGlobals.Texto + "la cena ";
                textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "Yo quiero/no quiero comer ";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
                MyGlobals.Texto = MyGlobals.Texto + "el desayuno ";
                textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "Yo quiero/no quiero comer ";

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
                MyGlobals.Texto = MyGlobals.Texto + "la merienda ";
                textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "Yo quiero/no quiero comer ";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
                MyGlobals.Texto = MyGlobals.Texto + "helado ";
                textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "Yo quiero/no quiero comer ";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
                MyGlobals.Texto = MyGlobals.Texto + "chocolate ";
                textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "Yo quiero/no quiero comer ";
        }

        private void FormularioComidas_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            var newForm = new FormularioQuerer();
            newForm.Show();
            this.Hide();
            MyGlobals.Texto = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            speak.Speak(textBox1.Text);
            
        }
    }
}
