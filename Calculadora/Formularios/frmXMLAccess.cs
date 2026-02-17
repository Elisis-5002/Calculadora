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
            for (int i = 0; i < dgvPersonas.RowCount-1; i++)
            {
                xml.Add(
                    new XElement("Persona" , new XAttribute("ID", dgvPersonas.Rows[i].Cells[0].Value),
                    new XElement("Nombre", dgvPersonas.Rows[i].Cells[1].Value),
                    new XElement("Telefono", dgvPersonas.Rows[i].Cells[2].Value))); 
            }
            try
            {
                // Explorador de solciones - abrir en explorador de archivos - bin- debug- windows
                xml.Save("Archivo.xml");
                MessageBox.Show("Guardado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
