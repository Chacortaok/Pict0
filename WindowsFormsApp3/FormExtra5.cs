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


namespace WindowsFormsApp3
{
    public partial class FormExtra5 : Form
    {
        SpeechSynthesizer speak = new SpeechSynthesizer();
        public FormExtra5()

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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var newForm = new Home();
            newForm.Show();
            this.Hide();
            MyGlobals.Texto = "";
        }

        private void FormExtra5_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxColores_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_5  WHERE Id = 1", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_5  WHERE Id = 2", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_5  WHERE Id = 3", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_5  WHERE Id = 4", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_5  WHERE Id = 5", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_5  WHERE Id = 6", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_5  WHERE Id = 7", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_5  WHERE Id = 8", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_5  WHERE Id = 9", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Descripcion FROM FormEx_5  WHERE Id = 10", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string des = rd.GetString(0);
            MyGlobals.Texto = MyGlobals.Texto + des;
            textBox1.Text = MyGlobals.Texto;
            speak.Speak(textBox1.Text);
            MyGlobals.Texto = "";
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void imagen1()
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_5  WHERE Id = 1", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut1 = rd.GetString(0);


            pictureBoxColores.Image = Image.FromFile(rut1);

        }
        private void imagen2()
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_5  WHERE Id = 2", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut2 = rd.GetString(0);


            pictureBox2.Image = Image.FromFile(rut2);

        }
        private void imagen3()
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_5  WHERE Id = 3", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut3 = rd.GetString(0);


            pictureBox3.Image = Image.FromFile(rut3);

        }
        private void imagen4()
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_5  WHERE Id = 4", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut4 = rd.GetString(0);


            pictureBox4.Image = Image.FromFile(rut4);

        }
        private void imagen5()
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_5  WHERE Id = 5", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut5 = rd.GetString(0);


            pictureBox5.Image = Image.FromFile(rut5);

        }
        private void imagen6()
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_5  WHERE Id = 6", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut6 = rd.GetString(0);
            pictureBox6.Image = Image.FromFile(rut6);
        }
        private void imagen7()
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_5 WHERE Id = 7", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut7 = rd.GetString(0);


            pictureBox7.Image = Image.FromFile(rut7);

        }
        private void imagen8()
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_5  WHERE Id = 8", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut8 = rd.GetString(0);


            pictureBox8.Image = Image.FromFile(rut8);

        }
        private void imagen9()
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_5  WHERE Id = 9", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut9 = rd.GetString(0);


            pictureBox9.Image = Image.FromFile(rut9);

        }
        private void imagen10()
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Ruta FROM FormEx_5  WHERE Id = 10", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();

            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string rut10 = rd.GetString(0);


            pictureBox10.Image = Image.FromFile(rut10);

        }
    }
}
