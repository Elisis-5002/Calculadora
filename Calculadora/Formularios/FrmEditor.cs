using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Calculadora.Formularios
{
    public partial class FrmEditor : Form
    {
        bool saved = false;
        string path = ""; 
        public FrmEditor()
        {
            InitializeComponent();
        }

        private void FrmEditor_Load(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            path= "";
            saved  = false;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            
            
            if (ofdEditor.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofdEditor.FileName))
                {
                    rtbEditor.Text = File.ReadAllText(ofdEditor.FileName);

                }
            }
        }

        private void guardarComoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void guardar()
        {
            if (sfdEditor.ShowDialog() == DialogResult.OK)
            {
                path = sfdEditor.FileName;
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);

                }
            }

        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saved == false)
            {
                guardar();
                saved = true;

            } else
            {
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }
    }
}
