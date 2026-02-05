using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class FrmRegistro : Form
    {
        List<Persona> persona = new List<Persona>();

        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            persona.Add(new Persona() { Nombre = txtNombre.Text, Apelllido = txtApellido.Text, FechaNac = dtpFechaNac.Value });
            MessageBox.Show("Persona Registrada");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                dgvPersonas.DataSource = null;
                dgvPersonas.DataSource = persona;


            }
        }
    }
}
