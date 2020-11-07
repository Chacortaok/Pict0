using Picto;
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
using WindowsFormsApp3.Properties;

namespace WindowsFormsApp3
{
    public partial class Configuracion_Picto : Form
    {
        public Configuracion_Picto()
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
                BackColor = Color.White;



            }

            else
            {
                BackgroundImage = Resources.FONDOO_1;



            }
        }
        
     
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Configuracion_Picto_Load(object sender, EventArgs e)
        {

        }

        private void txtDigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newformconfig1 = new ConfigCategoria1();
            newformconfig1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newformconfig2 = new ConfigCategoria2();
            newformconfig2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newformconfig3 = new ConfigCategoria3();
            newformconfig3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newformconfig4 = new ConfigCategoria4();
            newformconfig4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var newformconfig5 = new ConfigCategoria5();
            newformconfig5.Show();
            this.Hide();
        }

        
        private void chkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Fondo Blanco")
            {

                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


                con.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE FormEx_AA SET Fondo = '" + comboBox1.Text + "' WHERE Id = 1", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Guardado Exitoso!!!");
                Application.Restart();
            }
            else
            {
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");


                con.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE FormEx_AA SET Fondo = '" + comboBox1.Text + "' WHERE Id = 1", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Guardado Exitoso!!!");
                Application.Restart();
            }
        }
    }
}
