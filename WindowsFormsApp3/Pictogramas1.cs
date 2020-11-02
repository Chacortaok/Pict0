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
using System.Configuration;
using System.IO;

namespace Picto
{
    public partial class vozopictograma : Form
    {
        
        public vozopictograma()
        {
            InitializeComponent();
        }


        //declar cada funcion
        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet DataSet = new DataSet();
        MemoryStream ms = new MemoryStream();
       // OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();


        //
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
            var newformquerer = new FormularioQuerer();
            newformquerer.Show();
            this.Hide();
            MyGlobals.Texto = "Yo no quiero ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void vozopictograma_Load(object sender, EventArgs e)
        {
            


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var newformcolores = new FormularioColores();
                newformcolores.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var newformcomunicacion = new FormularioComunicacion();
            newformcomunicacion.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var newformnumeros = new FormularioNumeros();
            newformnumeros.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var newformquerer = new FormularioQuerer();
            newformquerer.Show();
            this.Hide();
            MyGlobals.Texto = "Yo quiero ";
        }

        private void pictureBoxSentimientos_Click(object sender, EventArgs e)
        {
            var newformsentimientos = new FormularioSentimientos();
            newformsentimientos.Show();
            this.Hide();
            MyGlobals.Texto = "Yo me siento "; 
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            var newformextra1 = new FormExtra1();
            newformextra1.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var newformextra2 = new FormExtra2();
            newformextra2.Show();
            this.Hide();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            var newformextra3 = new FormExtra3();
            newformextra3.Show();
            this.Hide();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            var newformextra4 = new FormExtra4();
            newformextra4.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            var newformextra5 = new FormExtra5();
            newformextra5.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0 Data Source = BaseDataPicto.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select Id, Nombre from Tabla1", con);
            OleDbDataReader rd = cmd.ExecuteReader();

            ///
            DataTable dt = new DataTable();
            dt.Load(rd);
            con.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
