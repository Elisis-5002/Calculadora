using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq; 

namespace Calculadora.Formularios
{
    public partial class frmXMLAccess : Form
    {
        public frmXMLAccess()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XElement xml = new XElement("Directorio");
            for (int i = 0; i < dgvPersonas.RowCount; i++)
            {
                xml.Add(
                    new XElement("Personas"),
                    new XAttribute("ID", dgvPersonas.Rows[i].Cells[0].Value),
                    new XElement("Nombre", dgvPersonas.Rows[i].Cells[1].Value),
                    new XElement("Telefono", dgvPersonas.Rows[i].Cells[2].Value)); 
            }
            xml.Save("Archivo.xml"); 


        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
