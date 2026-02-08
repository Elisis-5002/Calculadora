using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class FrmTemporizador : Form
    {
        public FrmTemporizador()
        {
            InitializeComponent();
        }
       

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
