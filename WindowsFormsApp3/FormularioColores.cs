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
using WindowsFormsApp3.Properties;
using System.Data.OleDb;

namespace WindowsFormsApp3
{
    public partial class FormularioColores : Form
    {

        SpeechSynthesizer speak = new SpeechSynthesizer();
        public FormularioColores()
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


        

        private void pictureBoxColores_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + " Amarillo";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + " Azul";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + " Blanco";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + " Gris";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + " Naranja";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + " Negro";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + " Rojo";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + " Rosa";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + " Verde";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";   

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MyGlobals.Texto = MyGlobals.Texto + " Violeta";
            textBox1.Text = MyGlobals.Texto;
            MyGlobals.Texto = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormularioColores_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            var newForm = new vozopictograma();
            newForm.Show();
            this.Hide();
            MyGlobals.Texto = "";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            
        }
    }
}
