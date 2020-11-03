namespace WindowsFormsApp3
{
    partial class ConfigCategoria3
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
            this.txtDigo = new System.Windows.Forms.TextBox();
            this.chkList = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDigo
            // 
            this.txtDigo.Location = new System.Drawing.Point(12, 100);
            this.txtDigo.Name = "txtDigo";
            this.txtDigo.Size = new System.Drawing.Size(326, 20);
            this.txtDigo.TabIndex = 18;
            // 
            // chkList
            // 
            this.chkList.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.chkList.CausesValidation = false;
            this.chkList.FormattingEnabled = true;
            this.chkList.Items.AddRange(new object[] {
            "Pictograma Categoria",
            "Pictograma 1",
            "Pictograma 2",
            "Pictograma 3",
            "Pictograma 4",
            "Pictograma 5",
            "Pictograma 6",
            "Pictograma 7",
            "Pictograma 8",
            "Pictograma 9",
            "Pictograma 10"});
            this.chkList.Location = new System.Drawing.Point(515, 40);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(210, 169);
            this.chkList.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(344, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(344, 100);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(82, 20);
            this.btnExaminar.TabIndex = 14;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(12, 126);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(326, 20);
            this.txtRuta.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.Espacios_Con_nombre;
            this.pictureBox1.Location = new System.Drawing.Point(15, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ConfigCategoria3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDigo);
            this.Controls.Add(this.chkList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ConfigCategoria3";
            this.Text = "ConfigCategoria3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDigo;
        private System.Windows.Forms.CheckedListBox chkList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}