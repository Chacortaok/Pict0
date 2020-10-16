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
        //
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0 Data Source =BaseDataPicto.accdb");
        
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
