using Picto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace WindowsFormsApp3
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            // Usa Try Para captar si hay un error. 
            // usa el openFileDialog.ShowDialog() 
            //Lo cargar(.Load) en la picturebox 
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    Pictograma.Load(this.openFileDialog1.FileName);
                }
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la imagen");
            }
        }

        private void tabla1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabla1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataPictoDataSet);

        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'baseDataPictoDataSet.Tabla1' Puede moverla o quitarla según sea necesario.
            this.tabla1TableAdapter.Fill(this.baseDataPictoDataSet.Tabla1);

        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            var newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void tabla1BindingSource3BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabla1BindingSource3.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.baseDataPictoDataSet1);

        }

        private void Configuracion_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'baseDataPictoDataSet1.Tabla1' Puede moverla o quitarla según sea necesario.
            this.tabla1TableAdapter1.Fill(this.baseDataPictoDataSet1.Tabla1);

        }

        private void campo1PictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}

