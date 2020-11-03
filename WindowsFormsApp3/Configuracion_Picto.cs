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

namespace WindowsFormsApp3
{
    public partial class Configuracion_Picto : Form
    {
        public Configuracion_Picto()
        {
            InitializeComponent();
            
        }
        
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                txtRuta.Text = openFileDialog1.FileName;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int indice = chkList.SelectedIndex;

             
            
            if (chkList.GetItemChecked(0))
            {
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb"); 
                con.Open(); 
                OleDbCommand command = new OleDbCommand(); 
                command.Connection = con;
                string query = "UPDATE FormEx_AA SET Descripcion = '" +txtDigo.Text+ "', Ruta = '" + txtRuta.Text + "' WHERE Id = 1"; 
                command.CommandText = query; 
                command.ExecuteNonQuery();
                txtDigo.Text = "";
                txtRuta.Text = "";
                MessageBox.Show("Guardado Exitoso!!!");

            }
            if (chkList.GetItemChecked(1))
            {

                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "UPDATE FormEx_AA SET Descripcion = '" +txtDigo.Text+ "',  Ruta = '" + txtRuta.Text + "' WHERE Id = 2 ";
                command.CommandText = query;
                command.ExecuteNonQuery();
                txtDigo.Text = "";
                txtRuta.Text = "";
                MessageBox.Show("Guardado Exitoso!!!");
            }
            if (chkList.GetItemChecked(2))
            {

                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "UPDATE FormEx_AA SET Descripcion = '" + txtDigo.Text + "',  Ruta = '" + txtRuta.Text + "' WHERE Id = 3 ";
                command.CommandText = query;
                command.ExecuteNonQuery();
                txtDigo.Text = "";
                txtRuta.Text = "";
                MessageBox.Show("Guardado Exitoso!!!");
            }
            if (chkList.GetItemChecked(3))
            {

                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "UPDATE FormEx_AA SET Descripcion = '" + txtDigo.Text + "',  Ruta = '" + txtRuta.Text + "' WHERE Id = 4 ";
                command.CommandText = query;
                command.ExecuteNonQuery();
                txtDigo.Text = "";
                txtRuta.Text = "";
                MessageBox.Show("Guardado Exitoso!!!");
            }  
            if (chkList.GetItemChecked(4))
            {

                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "UPDATE FormEx_AA SET Descripcion = '" + txtDigo.Text + "',  Ruta = '" + txtRuta.Text + "' WHERE Id = 5 ";
                command.CommandText = query;
                command.ExecuteNonQuery();
                txtDigo.Text = "";
                txtRuta.Text = "";
                MessageBox.Show("Guardado Exitoso!!!");
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
    }
}
