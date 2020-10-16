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

namespace Picto
{
    public partial class Home : Form
    {
        public void ReadMyData(string connectionString)
        {
            string queryString = "SELECT * FROM Table1";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader.GetInt32(0) + ", " + reader.GetString(1));
                }
                // always call Close when done reading.
                reader.Close();
            }
        }


        // Creacion de la Conexion 
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0 Data Source =BaseDataPicto.accdb");
        // Conexion llamada cn; 

        //
        public void InsertRow(string connectionString, string insertSQL)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // The insertSQL string contains a SQL statement that
                // inserts a new row in the source table.
                OleDbCommand command = new OleDbCommand(insertSQL);

                // Set the Connection to the new OleDbConnection.
                command.Connection = connection;

                // Open the connection and execute the insert command.
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // The connection is automatically closed when the
                // code exits the using block.
            }
        }
            //


            public Home()
        {
            InitializeComponent();
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
        private void btnConfi_Click (object sender, EventArgs e)
        {
            var C = new Configuracion();
            C.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // hora de Actual utiliza el DataTime de la PC. 
            // Lo hizo Tomas 
            hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    
    }
}
// Variable Global 
// Tomas Caula 
public static class MyGlobals
{
    public static string Texto;
}
// fin MyGlobals 






