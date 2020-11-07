using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;
using System.Data.OleDb;
using System.IO;
using WindowsFormsApp3.Properties;

namespace Picto
{
    public partial class Home : Form
    {
        public static void ReadData(string connectionString, string queryString)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);

                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString());
                }
                reader.Close();
            }
        }
        // Creacion de la Conexion 
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Tomas\Documents\GitHub\Pict0\WindowsFormsApp3\bin\Debug\BaseDataPicto.accdb");
        // Conexion llamada cn; 
        private void _OpenConnection()
        {
            cn.Open();
        }
        private void _CloseConnection()
        {
            cn.Close();
        }
        // Open and close connection with Base Data 
        public Home()
        {
            InitializeComponent();
            
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Fondo FROM FormEx_AA WHERE Id = 1", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            OleDbDataReader rd = cmd.ExecuteReader();

            rd.Read();
            string fondo = rd.GetString(0);




            if (fondo == "Fondo Blanco") {
                BackgroundImage = Resources.Artboard_2;
                pictureBox2.Visible = false;

            }

            else
            {
                BackgroundImage = Resources.Main_Menu_2;
                pictureBox2.Visible = true;
            }
           
        }
        // Te manda a las diferentes partes de la  App 
        private void btn2_Click(object sender, EventArgs e)
        {
            var newForm3 = new vozopictograma();
            newForm3.Show();
            this.Hide();
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

       
        
        // btn test if the connection is OK
        private void btnTest_Click(object sender, EventArgs e)
        {
            
            {
              //  using (())
                
            }
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com/");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var FormConfi = new Configuracion_Picto();
            FormConfi.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }




        // btn test if the connection is OK 
    }
}
// Variable Global 
// Tomas Caula 
public static class MyGlobals
{
    public static string Texto;
}
// fin MyGlobals 






