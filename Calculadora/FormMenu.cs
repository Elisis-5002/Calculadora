namespace Calculadora
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculadoraSImpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frCalculadora calculadoraSimple = new frCalculadora();
            calculadoraSimple.Show();
        }

        private void burbujaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBurbuja burbuja = new FrmBurbuja();
            burbuja.Show();
        }
    }
}
