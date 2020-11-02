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
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = BaseDataPicto.accdb"); 
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

            if (chkList.GetItemChecked(1))
            {   
               
                con.Open();
                OleDbCommand command = new OleDbCommand("INSERT into FormEx_AA WHERE Id = 1 (Ruta_img, Descripcion ) values ('" + txtRuta.Text + "', '" + txtDigo.Text + "') ");
                command.ExecuteNonQuery();
                MessageBox.Show("Guardado Exitoso!!!");
            }
            if (chkList.GetItemChecked(2))
            {
                con.Open();
                OleDbCommand command = new OleDbCommand("INSERT into FormEx_AA WHERE Id = 2 (Ruta_img, Descripcion ) values ('" + txtRuta.Text + "', '" + txtDigo.Text + "') ");
                command.ExecuteNonQuery();
                MessageBox.Show("Guardado Exitoso!!!");
            }
             if (chkList.GetItemChecked(3))
            {
                con.Open();
                OleDbCommand command = new OleDbCommand("INSERT into FormEx_AA WHERE Id = 3 (Ruta_img, Descripcion ) values ('" + txtRuta.Text + "', '" + txtDigo.Text + "') ");
                command.ExecuteNonQuery();
                MessageBox.Show("Guardado Exitoso!!!");
            }
             if (chkList.GetItemChecked(4))
            {
                con.Open();
                OleDbCommand command = new OleDbCommand("INSERT into FormEx_AA WHERE Id = 4 (Ruta_img, Descripcion ) values ('" + txtRuta.Text + "', '" + txtDigo.Text + "') ");
                command.ExecuteNonQuery();
                MessageBox.Show("Guardado Exitoso!!!");
            }
             if (chkList.GetItemChecked(5))
            {
                con.Open();
                OleDbCommand command = new OleDbCommand("INSERT into FormEx_AA WHERE Id = 5 (Ruta_img, Descripcion ) values ('" + txtRuta.Text + "', '" + txtDigo.Text + "') ");
                command.ExecuteNonQuery();
                MessageBox.Show("Guardado Exitoso!!!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
