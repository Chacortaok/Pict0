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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label imagenPicLabel;
            this.btnExaminar = new System.Windows.Forms.Button();
            this.Pictograma = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.baseDataPictoDataSet = new WindowsFormsApp3.BaseDataPictoDataSet();
            this.tabla1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabla1TableAdapter = new WindowsFormsApp3.BaseDataPictoDataSetTableAdapters.Tabla1TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.BaseDataPictoDataSetTableAdapters.TableAdapterManager();
            this.tabla1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabla1ListBox = new System.Windows.Forms.ListBox();
            this.tabla1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tabla1ComboBox = new System.Windows.Forms.ComboBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.imagenPicTextBox = new System.Windows.Forms.TextBox();
            this.lblHome = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            imagenPicLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pictograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataPictoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(61, 366);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 38);
            this.btnExaminar.TabIndex = 0;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // Pictograma
            // 
            this.Pictograma.Location = new System.Drawing.Point(27, 211);
            this.Pictograma.Name = "Pictograma";
            this.Pictograma.Size = new System.Drawing.Size(154, 149);
            this.Pictograma.TabIndex = 1;
            this.Pictograma.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // baseDataPictoDataSet
            // 
            this.baseDataPictoDataSet.DataSetName = "BaseDataPictoDataSet";
            this.baseDataPictoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabla1BindingSource
            // 
            this.tabla1BindingSource.DataMember = "Tabla1";
            this.tabla1BindingSource.DataSource = this.baseDataPictoDataSet;
            // 
            // tabla1TableAdapter
            // 
            this.tabla1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tabla1TableAdapter = this.tabla1TableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.BaseDataPictoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabla1DataGridView
            // 
            this.tabla1DataGridView.AutoGenerateColumns = false;
            this.tabla1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tabla1DataGridView.DataSource = this.tabla1BindingSource;
            this.tabla1DataGridView.Location = new System.Drawing.Point(418, 159);
            this.tabla1DataGridView.Name = "tabla1DataGridView";
            this.tabla1DataGridView.Size = new System.Drawing.Size(300, 220);
            this.tabla1DataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ImagenPic";
            this.dataGridViewTextBoxColumn2.HeaderText = "ImagenPic";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tabla1BindingSource1
            // 
            this.tabla1BindingSource1.DataMember = "Tabla1";
            this.tabla1BindingSource1.DataSource = this.baseDataPictoDataSet;
            // 
            // tabla1ListBox
            // 
            this.tabla1ListBox.DataSource = this.tabla1BindingSource1;
            this.tabla1ListBox.DisplayMember = "Nombre";
            this.tabla1ListBox.FormattingEnabled = true;
            this.tabla1ListBox.Location = new System.Drawing.Point(228, 159);
            this.tabla1ListBox.Name = "tabla1ListBox";
            this.tabla1ListBox.Size = new System.Drawing.Size(184, 121);
            this.tabla1ListBox.TabIndex = 3;
            this.tabla1ListBox.ValueMember = "Nombre";
            // 
            // tabla1BindingSource2
            // 
            this.tabla1BindingSource2.DataMember = "Tabla1";
            this.tabla1BindingSource2.DataSource = this.baseDataPictoDataSet;
            // 
            // tabla1ComboBox
            // 
            this.tabla1ComboBox.DataSource = this.tabla1BindingSource2;
            this.tabla1ComboBox.DisplayMember = "Nombre";
            this.tabla1ComboBox.FormattingEnabled = true;
            this.tabla1ComboBox.Location = new System.Drawing.Point(418, 132);
            this.tabla1ComboBox.Name = "tabla1ComboBox";
            this.tabla1ComboBox.Size = new System.Drawing.Size(300, 21);
            this.tabla1ComboBox.TabIndex = 4;
            this.tabla1ComboBox.ValueMember = "Nombre";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(225, 110);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla1BindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(294, 107);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 6;
            // 
            // imagenPicLabel
            // 
            imagenPicLabel.AutoSize = true;
            imagenPicLabel.Location = new System.Drawing.Point(225, 136);
            imagenPicLabel.Name = "imagenPicLabel";
            imagenPicLabel.Size = new System.Drawing.Size(63, 13);
            imagenPicLabel.TabIndex = 7;
            imagenPicLabel.Text = "Imagen Pic:";
            // 
            // imagenPicTextBox
            // 
            this.imagenPicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla1BindingSource, "ImagenPic", true));
            this.imagenPicTextBox.Location = new System.Drawing.Point(294, 133);
            this.imagenPicTextBox.Name = "imagenPicTextBox";
            this.imagenPicTextBox.Size = new System.Drawing.Size(100, 20);
            this.imagenPicTextBox.TabIndex = 8;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(13, 13);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(70, 13);
            this.lblHome.TabIndex = 9;
            this.lblHome.Text = "BACK HOME";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(imagenPicLabel);
            this.Controls.Add(this.imagenPicTextBox);
            this.Controls.Add(this.tabla1ComboBox);
            this.Controls.Add(this.tabla1ListBox);
            this.Controls.Add(this.tabla1DataGridView);
            this.Controls.Add(this.Pictograma);
            this.Controls.Add(this.btnExaminar);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pictograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataPictoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}