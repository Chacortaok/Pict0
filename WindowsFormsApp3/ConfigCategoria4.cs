﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp3
{
    public partial class ConfigCategoria4 : Form
    {
        public ConfigCategoria4()
        {
            InitializeComponent();
        }
        

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            

        }

        private void chkList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = openFileDialog1.FileName;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            if (chkList.GetItemChecked(0))
            {
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "UPDATE FormEx_AA SET Descripcion = '" + txtDigo.Text + "', Ruta = '" + txtRuta.Text + "' WHERE Id = 4";
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
                string query = "UPDATE FormEx_4 SET Descripcion = '" + txtDigo.Text + "',  Ruta = '" + txtRuta.Text + "' WHERE Id = 1 ";
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
                string query = "UPDATE FormEx_4 SET Descripcion = '" + txtDigo.Text + "',  Ruta = '" + txtRuta.Text + "' WHERE Id = 2 ";
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
                string query = "UPDATE FormEx_4 SET Descripcion = '" + txtDigo.Text + "',  Ruta = '" + txtRuta.Text + "' WHERE Id = 3 ";
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
                string query = "UPDATE FormEx_4 SET Descripcion = '" + txtDigo.Text + "',  Ruta = '" + txtRuta.Text + "' WHERE Id = 4 ";
                command.CommandText = query;
                command.ExecuteNonQuery();
                txtDigo.Text = "";
                txtRuta.Text = "";
                MessageBox.Show("Guardado Exitoso!!!");
            }

            if (chkList.GetItemChecked(5))
            {
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "UPDATE FormEx_4 SET Descripcion = '" + txtDigo.Text + "', Ruta = '" + txtRuta.Text + "' WHERE Id = 5";
                command.CommandText = query;
                command.ExecuteNonQuery();
                txtDigo.Text = "";
                txtRuta.Text = "";
                MessageBox.Show("Guardado Exitoso!!!");

            }
            if (chkList.GetItemChecked(6))
            {

                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "UPDATE FormEx_4 SET Descripcion = '" + txtDigo.Text + "',  Ruta = '" + txtRuta.Text + "' WHERE Id = 6 ";
                command.CommandText = query;
                command.ExecuteNonQuery();
                txtDigo.Text = "";
                txtRuta.Text = "";
                MessageBox.Show("Guardado Exitoso!!!");
            }
            if (chkList.GetItemChecked(7))
            {

                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "UPDATE FormEx_4 SET Descripcion = '" + txtDigo.Text + "',  Ruta = '" + txtRuta.Text + "' WHERE Id = 7 ";
                command.CommandText = query;
                command.ExecuteNonQuery();
                txtDigo.Text = "";
                txtRuta.Text = "";
                MessageBox.Show("Guardado Exitoso!!!");
            }
            if (chkList.GetItemChecked(8))
            {

                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "UPDATE FormEx_4 SET Descripcion = '" + txtDigo.Text + "',  Ruta = '" + txtRuta.Text + "' WHERE Id = 8 ";
                command.CommandText = query;
                command.ExecuteNonQuery();
                txtDigo.Text = "";
                txtRuta.Text = "";
                MessageBox.Show("Guardado Exitoso!!!");
            }
            if (chkList.GetItemChecked(9))
            {

                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "UPDATE FormEx_4 SET Descripcion = '" + txtDigo.Text + "',  Ruta = '" + txtRuta.Text + "' WHERE Id = 9 ";
                command.CommandText = query;
                command.ExecuteNonQuery();
                txtDigo.Text = "";
                txtRuta.Text = "";
                MessageBox.Show("Guardado Exitoso!!!");
            }
            if (chkList.GetItemChecked(9))
            {

                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "UPDATE FormEx_4 SET Descripcion = '" + txtDigo.Text + "',  Ruta = '" + txtRuta.Text + "' WHERE Id = 10 ";
                command.CommandText = query;
                command.ExecuteNonQuery();
                txtDigo.Text = "";
                txtRuta.Text = "";
                MessageBox.Show("Guardado Exitoso!!!");
            }
            if (chkList.GetItemChecked(9))
            {

                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseDataPicto.accdb");
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "UPDATE FormEx_4 SET Descripcion = '" + txtDigo.Text + "',  Ruta = '" + txtRuta.Text + "' WHERE Id = 11 ";
                command.CommandText = query;
                command.ExecuteNonQuery();
                txtDigo.Text = "";
                txtRuta.Text = "";
                MessageBox.Show("Guardado Exitoso!!!");
            }

        }
        
        

        

          private void button1_Click_1(object sender, EventArgs e)
        {
            var newformconfig1 = new ConfigCategoria1();
            newformconfig1.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            var newformconfig2 = new ConfigCategoria2();
            newformconfig2.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var newformconfig3 = new ConfigCategoria3();
            newformconfig3.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var newformconfig4 = new ConfigCategoria4();
            newformconfig4.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var newformconfig5 = new ConfigCategoria5();
            newformconfig5.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
