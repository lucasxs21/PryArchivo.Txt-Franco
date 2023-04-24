using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryArchivo.Txt_Franco
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string texto = txtGrabar.Text;
            string archivo = @"C:\Users\Lucas Franco\Documents\nota.txt";
            using (StreamWriter sw = new StreamWriter(archivo, true))
            {
             sw.WriteLine(texto);
            }
            MessageBox.Show("Archivo guardado correctamente.");
            
           
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string archivo = @"C:\Users\Lucas Franco\Documents\nota.txt"; 
            using (StreamReader sr = new StreamReader(archivo))
            {
             string contenido = sr.ReadToEnd();
             txtTexto.Text = contenido;
            }
            MessageBox.Show("Archivo leído correctamente.");
            
             
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frm2 form2 = new frm2();
            form2.Show();
            this.Visible = false;
        }
    }
}
