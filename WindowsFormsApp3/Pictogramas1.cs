using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;
using WindowsFormsApp3;
using System.Data.OleDb;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Picto
{
    public partial class vozopictograma : Form
    {
        
        public vozopictograma()
        {
            InitializeComponent();
            imagen1();
            imagen2();
            imagen3();
            imagen4();
            imagen5();



        }


        //declar cada funcion
        
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
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_AA  WHERE Id = 1", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = des;

            var newformextra1 = new FormExtra1();
            newformextra1.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_AA  WHERE Id = 2", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = des;
            var newformextra2 = new FormExtra2();
            newformextra2.Show();
            this.Hide();
            
            
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_AA  WHERE Id = 3", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = des;
            var newformextra3 = new FormExtra3();
            newformextra3.Show();
            this.Hide();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_AA  WHERE Id = 4", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = des;
            var newformextra4 = new FormExtra4();
            newformextra4.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_AA  WHERE Id = 5", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = des;
            var newformextra5 = new FormExtra5();
            newformextra5.Show();
            this.Hide();
        }

        
        
        
        private void imagen1()
        {

            try { 
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_AA  WHERE Id = 1", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut1 = rd.GetString(0);


            pictureBox7.Image = Image.FromFile(rut1);
            }
            catch
            {
                pictureBox7.Visible = false;
            }

        }
        private void imagen2()
        {
            try { 
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_AA  WHERE Id = 2", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut2 = rd.GetString(0);


            pictureBox5.Image = Image.FromFile(rut2);
            }
            catch
            {
                pictureBox5.Visible = false;
            }

        }
        private void imagen3()
        {
            try { 
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_AA  WHERE Id = 3", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut3 = rd.GetString(0);


            pictureBox4.Image = Image.FromFile(rut3);
            }
            catch
            {
                pictureBox4.Visible = false;
            }
        }
        private void imagen4()
        {
            try { 
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_AA  WHERE Id = 4", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut4 = rd.GetString(0);


            pictureBox8.Image = Image.FromFile(rut4);
            }
            catch
            {
                pictureBox8.Visible = false;
            }

        }
        private void imagen5()
        {
            try { 

            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_AA  WHERE Id = 5", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut5 = rd.GetString(0);
             pictureBox6.Image = Image.FromFile(rut5);



            }
            catch
            {
                pictureBox6.Visible = false;
            }


            

            }

        

    }
}
