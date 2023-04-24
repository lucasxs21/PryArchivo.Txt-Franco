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
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void frm2_Load(object sender, EventArgs e)
        {
            string archivo = @"C:\Users\Lucas Franco\Documents\nota.txt";
            StreamReader leerArchivo = new StreamReader(archivo);

            while(leerArchivo.EndOfStream == false)
            {
                string auxiliar = leerArchivo.ReadLine();

                if (auxiliar.Contains(txtDatoABuscar.Text))
                {
                    lblDatos.Text = "ENCONTRADO";
                    break;
                }
                else
                {
                    lblDatos.Text = "NO SE ENCONTRO";
                }
            }

            leerArchivo.Close();
           
        }   
            
    }
}
