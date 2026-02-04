using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmBurbuja : Form
    {
        public FrmBurbuja()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e){
            int [] ordenado= new int[dgvDesordenado.RowCount-1];
            for (int i = 0; i < dgvDesordenado.RowCount-1; i++){
                ordenado[i] = Convert.ToInt32(dgvDesordenado.Rows[i].Cells[0].Value);
            }
            Ordenamientos ordenamientos= new Ordenamientos();
            ordenado = ordenamientos.Burbuja(ordenado);

            dgvOrdenado.DataSource = ordenado;
            for (int i = 0; i < ordenado.Length; i++)
            {
                dgvOrdenado.Rows[i].Cells[0].Value= ordenado[i];

            }
        }
    }
}
