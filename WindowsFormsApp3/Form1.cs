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

namespace Picto
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        // Te manda a las diferentes partes de la App 
        private void btn2_Click(object sender, EventArgs e)
        {
            var newForm3 = new vozopictograma();
            newForm3.Show();
            this.Hide();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
          //var newForm4 = new txt();
          //  newForm4.Show();
          //  this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
           // var newForm2 = new textoopictograma();
           // newForm2.Show();
           // this.Hide();

        }
        // Aca termina la anterior aclaracion 
        // Dante 

        private void btnConfi_Click (object sender, EventArgs e)
        {
            var C = new Configuracion();
            C.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // hora de Actual utiliza el DataTime de la PC. 
            // Lo hizo Tomas 
            hora.Text = DateTime.Now.ToLongTimeString();
        }

    }
}
// Variable Global 
// Tomas Caula 
public static class MyGlobals
{
    public static string Texto;
}
// fin MyGlobals 
