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
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0 Data Source =BaseDataPicto.accdb");
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

       
        
        // btn test if the connection is OK
        private void btnTest_Click(object sender, EventArgs e)
        {
            if (cn != null)
            {
                MessageBox.Show("Conexion Correcta PAPUUU");
            }
            {
              //  using (())
                {
                    OleDbCommand and = new OleDbCommand();
                    cn.Open();
                    and.Connection = cn;
                    and.CommandText = "SELECT Image FROM Table1 WHERE IDhere= 1 ";
                    OleDbDataReader read = and.ExecuteReader();
                    while (read.Read())
                    {
                        var bytes = (byte[])read[4];
                        using (MemoryStream ms = new MemoryStream(bytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }

                    cn.Close();
                }
            }
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






