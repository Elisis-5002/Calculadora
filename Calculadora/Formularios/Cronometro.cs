using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class frmCronometro : Form
    {
        int segundos = 0;
        int minutos = 0;
        public frmCronometro()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCrono.Text = segundos.ToString("00:00:00"); 
            segundos++;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
           
            timer1.Enabled=true;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            lblCrono.Text = "00:00:00";
            minutos = 0;
            segundos = 0;


        }
    }
}
