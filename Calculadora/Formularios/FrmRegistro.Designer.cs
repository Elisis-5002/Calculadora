namespace Calculadora.Formularios
{
    partial class FrmRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            Registro = new TabPage();
            btnRegistrar = new Button();
            dtpFecha = new Label();
            dtpFechaNac = new DateTimePicker();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbMostrar = new TabPage();
            dgvPersonas = new DataGridView();
            tabControl1.SuspendLayout();
            Registro.SuspendLayout();
            tbMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Registro);
            tabControl1.Controls.Add(tbMostrar);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(788, 440);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // Registro
            // 
            Registro.Controls.Add(btnRegistrar);
            Registro.Controls.Add(dtpFecha);
            Registro.Controls.Add(dtpFechaNac);
            Registro.Controls.Add(txtApellido);
            Registro.Controls.Add(txtNombre);
            Registro.Controls.Add(label2);
            Registro.Controls.Add(label1);
            Registro.Location = new Point(4, 34);
            Registro.Name = "Registro";
            Registro.Padding = new Padding(3);
            Registro.Size = new Size(780, 402);
            Registro.TabIndex = 0;
            Registro.Tag = "Registros";
            Registro.Text = "Registros";
            Registro.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(638, 343);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.AutoSize = true;
            dtpFecha.Location = new Point(63, 278);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(177, 25);
            dtpFecha.TabIndex = 6;
            dtpFecha.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(63, 306);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(369, 31);
            dtpFechaNac.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(63, 208);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(322, 31);
            txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(63, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(322, 31);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 167);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 47);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // tbMostrar
            // 
            tbMostrar.BackColor = SystemColors.Control;
            tbMostrar.Controls.Add(dgvPersonas);
            tbMostrar.Location = new Point(4, 34);
            tbMostrar.Name = "tbMostrar";
            tbMostrar.Padding = new Padding(3);
            tbMostrar.Size = new Size(780, 402);
            tbMostrar.TabIndex = 1;
            tbMostrar.Tag = "Mostrar";
            tbMostrar.Text = "Mostrar";
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(3, 0);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersWidth = 62;
            dgvPersonas.Size = new Size(769, 406);
            dgvPersonas.TabIndex = 0;
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FrmRegistro";
            Text = "Registro Alumnos";
            tabControl1.ResumeLayout(false);
            Registro.ResumeLayout(false);
            Registro.PerformLayout();
            tbMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Registro;
        private TabPage tbMostrar;
        private Label dtpFecha;
        private DateTimePicker dtpFechaNac;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private Button btnRegistrar;
        private DataGridView dgvPersonas;
    }
}