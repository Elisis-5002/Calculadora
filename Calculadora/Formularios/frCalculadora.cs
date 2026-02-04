using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frCalculadora : Form
    {
        public frCalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0, b = 0, resultado = 0;
                a = Convert.ToInt32(txVarA.Text);
                b = int.Parse(txVarB.Text);

                if (rdbSuma.Checked){
                    resultado = a + b; 
                }
                if (rdbResta.Checked)
                {
                    resultado = a - b;
                }
                if (rdbMultiplicacion.Checked)
                {
                    resultado = a * b;
                }
                if (rdbDivision.Checked)
                {
                    resultado = a / b;
                }

                MessageBox.Show("El resultado es: " + resultado.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al insertar los datos, deben ser enteros", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void butReset_Click(object sender, EventArgs e)
        {
            reset();

        }
        private void reset()
        {
            txVarA.Text = "";
            txVarB.Clear();
            txVarA.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
