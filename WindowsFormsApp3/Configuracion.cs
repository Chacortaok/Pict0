using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Configuracion : Form
    {
        Categoria img = new Categoria();
        public Configuracion()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            // Usa Try Para captar si hay un error. 
            // usa el openFileDialog.ShowDialog() 
            //Lo cargar(.Load) en la picturebox 
            try
            {
                this.openFileDialog.ShowDialog();
                if (this.openFileDialog.FileName.Equals("") == false)
                {
                    pictureBox1.Load(this.openFileDialog.FileName);
                }
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la imagen");
            }

            ///
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
         }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Table' Puede moverla o quitarla según sea necesario.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy(this.database1DataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
