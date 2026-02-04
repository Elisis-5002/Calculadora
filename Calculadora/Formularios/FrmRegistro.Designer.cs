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
            tabPage2 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dtpFecha = new Label();
            tabControl1.SuspendLayout();
            Registro.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Registro);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(788, 440);
            tabControl1.TabIndex = 0;
            // 
            // Registro
            // 
            Registro.Controls.Add(dtpFecha);
            Registro.Controls.Add(dateTimePicker1);
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
            Registro.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(780, 402);
            tabPage2.TabIndex = 1;
            tabPage2.Tag = "Mostrar";
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 167);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(63, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(322, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(63, 208);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(322, 31);
            txtApellido.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(63, 306);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(369, 31);
            dateTimePicker1.TabIndex = 4;
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
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Registro;
        private TabPage tabPage2;
        private Label dtpFecha;
        private DateTimePicker dateTimePicker1;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
    }
}