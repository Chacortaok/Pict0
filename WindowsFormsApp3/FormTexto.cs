using Picto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Properties;

namespace WindowsFormsApp3
{
    public partial class FormTexto : Form
    {
        public FormTexto()
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
        private void FormTexto_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            speak.Speak(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        int a = 0;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (a > 0)
                {
                    textBox1.SelectionBackColor = Color.White;
                    a--;
                    textBox2.Text = textBox1.Text;
                    textBox2.CharacterCasing = CharacterCasing.Lower;
                    string[] palabras = textBox2.Text.Split(' ');
                    string palabra = palabras[a];
                    var imageToShow = Properties.Resources.ResourceManager.GetObject(palabra);
                    pictureBox2.BackgroundImage = (Image)imageToShow;
                    textBox2.Text = "";
                    textBox1.Find(palabra);
                    textBox1.SelectionBackColor = Color.Gray;
                }
            }
            catch
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {



                textBox2.Text = textBox1.Text;
                textBox2.CharacterCasing = CharacterCasing.Lower;
                string[] palabras = textBox2.Text.Split(' ');
                string palabra = palabras[a];
                if (a < palabras.Length)
                {
                    var imageToShow = Properties.Resources.ResourceManager.GetObject(palabra);
                    pictureBox2.BackgroundImage = (Image)imageToShow;
                    textBox1.SelectionBackColor = Color.White;
                    a++;
                    textBox2.Text = "";
                    textBox1.Find(palabra);
                    textBox1.SelectionBackColor = Color.Gray;
                    
                }
            }
            catch
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
