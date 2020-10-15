namespace WindowsFormsApp3
{
    partial class Configuracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.baseDataPictoDataSet1 = new WindowsFormsApp3.BaseDataPictoDataSet();
            this.tabla1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tabla1TableAdapter1 = new WindowsFormsApp3.BaseDataPictoDataSetTableAdapters.Tabla1TableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp3.BaseDataPictoDataSetTableAdapters.TableAdapterManager();
            this.tabla1DataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla1BindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tabla1BindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataPictoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1BindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1BindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // baseDataPictoDataSet1
            // 
            this.baseDataPictoDataSet1.DataSetName = "BaseDataPictoDataSet";
            this.baseDataPictoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabla1BindingSource3
            // 
            this.tabla1BindingSource3.DataMember = "Tabla1";
            this.tabla1BindingSource3.DataSource = this.baseDataPictoDataSet1;
            // 
            // tabla1TableAdapter1
            // 
            this.tabla1TableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Tabla1TableAdapter = this.tabla1TableAdapter1;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp3.BaseDataPictoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabla1DataGridView1
            // 
            this.tabla1DataGridView1.AutoGenerateColumns = false;
            this.tabla1DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla1DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tabla1DataGridView1.DataSource = this.tabla1BindingSource3;
            this.tabla1DataGridView1.Location = new System.Drawing.Point(568, 12);
            this.tabla1DataGridView1.Name = "tabla1DataGridView1";
            this.tabla1DataGridView1.Size = new System.Drawing.Size(342, 519);
            this.tabla1DataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Campo1";
            this.dataGridViewTextBoxColumn5.HeaderText = "Campo1";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tabla1BindingSource4
            // 
            this.tabla1BindingSource4.DataMember = "Tabla1";
            this.tabla1BindingSource4.DataSource = this.baseDataPictoDataSet1;
            // 
            // tabla1BindingSource5
            // 
            this.tabla1BindingSource5.DataMember = "Tabla1";
            this.tabla1BindingSource5.DataSource = this.baseDataPictoDataSet1;
            // 
            // Configuracion
            // 
            this.ClientSize = new System.Drawing.Size(922, 543);
            this.Controls.Add(this.tabla1DataGridView1);
            this.Name = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataPictoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1BindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1BindingSource5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.PictureBox Pictograma;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private BaseDataPictoDataSet baseDataPictoDataSet;
        private System.Windows.Forms.BindingSource tabla1BindingSource;
        private BaseDataPictoDataSetTableAdapters.Tabla1TableAdapter tabla1TableAdapter;
        private BaseDataPictoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tabla1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource tabla1BindingSource1;
        private System.Windows.Forms.ListBox tabla1ListBox;
        private System.Windows.Forms.BindingSource tabla1BindingSource2;
        private System.Windows.Forms.ComboBox tabla1ComboBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox imagenPicTextBox;
        private System.Windows.Forms.Label lblHome;
        private BaseDataPictoDataSet baseDataPictoDataSet1;
        private System.Windows.Forms.BindingSource tabla1BindingSource3;
        private BaseDataPictoDataSetTableAdapters.Tabla1TableAdapter tabla1TableAdapter1;
        private BaseDataPictoDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView tabla1DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource tabla1BindingSource4;
        private System.Windows.Forms.BindingSource tabla1BindingSource5;
    }
}