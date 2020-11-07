using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Picto;
using System.Speech.Synthesis;
using WindowsFormsApp3.Properties;

namespace WindowsFormsApp3
{
    public partial class FormExtra2 : Form
    {
        SpeechSynthesizer speak = new SpeechSynthesizer();
        public FormExtra2()
        {
            InitializeComponent();
            imagen1();
            imagen2();
            imagen3();
            imagen4();
            imagen5();
            imagen6();
            imagen7();
            imagen8();
            imagen9();
            imagen10();
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_2  WHERE Id = 9", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_2  WHERE Id = 8", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_2  WHERE Id = 7", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_2  WHERE Id = 6", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_2  WHERE Id = 5", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_2  WHERE Id = 4", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_2  WHERE Id = 3", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_2  WHERE Id = 2", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();
        }

        private void pictureBoxColores_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_2  WHERE Id = 1", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_2  WHERE Id = 10", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Picto.vozopictograma();
            newForm.Show();
            this.Hide();
        }

        private void imagen1()
        {
            try { 
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_2  WHERE Id = 1", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut1 = rd.GetString(0);


            pictureBoxColores.Image = Image.FromFile(rut1);
            }
            catch
            {
                pictureBoxColores.Visible = false;
            }
        }
        private void imagen2()
        {
            try { 
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_2  WHERE Id = 2", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut2 = rd.GetString(0);


            pictureBox2.Image = Image.FromFile(rut2);
            }
            catch
            {
                pictureBox2.Visible = false;
            }

        }
        private void imagen3()
        {
            try { 
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_2  WHERE Id = 3", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut3 = rd.GetString(0);


            pictureBox3.Image = Image.FromFile(rut3);
            }
            catch
            {
                pictureBox3.Visible = false;
            }

        }
        private void imagen4()
        {
            try { 
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_2  WHERE Id = 4", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut4 = rd.GetString(0);


            pictureBox4.Image = Image.FromFile(rut4);
            }
            catch
            {
                pictureBox4.Visible = false;
            }



        }
        private void imagen5()
        {
            try { 
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_2  WHERE Id = 5", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut5 = rd.GetString(0);


            pictureBox5.Image = Image.FromFile(rut5);
            }
            catch
            {
                pictureBox5.Visible = false;
            }

        }
        private void imagen6()
        {
            try { 
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_2  WHERE Id = 6", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut6 = rd.GetString(0);
            pictureBox6.Image = Image.FromFile(rut6);
            }
            catch
            {
                pictureBox6.Visible = false;
            }
        }
        private void imagen7()
        {
            try { 
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_2  WHERE Id = 7", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut7 = rd.GetString(0);


            pictureBox7.Image = Image.FromFile(rut7);
            }
            catch
            {
                pictureBox7.Visible = false;
            }
        }
        private void imagen8()
        {
            try { 
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_2  WHERE Id = 8", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut8 = rd.GetString(0);


            pictureBox8.Image = Image.FromFile(rut8);
            }
            catch
            {
                pictureBox8.Visible = false;
            }

        }
        private void imagen9()
        {
            try { 
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_2  WHERE Id = 9", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut9 = rd.GetString(0);


            pictureBox9.Image = Image.FromFile(rut9);
            }
            catch
            {
                pictureBox9.Visible = false;
            }

        }
        private void imagen10()
        {
            try { 
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_2  WHERE Id = 10", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut10 = rd.GetString(0);


            pictureBox10.Image = Image.FromFile(rut10);
            }
            catch
            {
                pictureBox10.Visible = false;
            }

        }

        private void FormExtra2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            speak.Speak(textBox1.Text);
        }
    }
}
