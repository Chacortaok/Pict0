﻿namespace WindowsFormsApp3
{
    partial class ConfigCategoria5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigCategoria5));
            this.txtDigo = new System.Windows.Forms.TextBox();
            this.chkList = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDigo
            // 
            this.txtDigo.Location = new System.Drawing.Point(12, 100);
            this.txtDigo.Name = "txtDigo";
            this.txtDigo.Size = new System.Drawing.Size(326, 20);
            this.txtDigo.TabIndex = 18;
            this.txtDigo.Text = "Nombre";
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
            this.chkList.Location = new System.Drawing.Point(447, 57);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(210, 169);
            this.chkList.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(344, 151);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(344, 100);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(82, 20);
            this.btnExaminar.TabIndex = 14;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(71, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "Categoria 2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(282, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Categoria 5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(141, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Categoria 3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Categoria 4";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Categoria 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ruta de Archivo:";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(12, 154);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(326, 20);
            this.txtRuta.TabIndex = 28;
            this.txtRuta.WordWrap = false;
            // 
            // ConfigCategoria5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDigo);
            this.Controls.Add(this.chkList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExaminar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigCategoria5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Picto";
            this.Load += new System.EventHandler(this.ConfigCategoria5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDigo;
        private System.Windows.Forms.CheckedListBox chkList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuta;
    }
}