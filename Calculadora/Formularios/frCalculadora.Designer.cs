namespace Calculadora
{
    partial class frCalculadora
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
            label1 = new Label();
            label2 = new Label();
            txVarA = new TextBox();
            txVarB = new TextBox();
            butCalcular = new Button();
            butReset = new Button();
            gbOperaciones = new GroupBox();
            rdbSuma = new RadioButton();
            rdbResta = new RadioButton();
            rdbMultiplicacion = new RadioButton();
            rdbDivision = new RadioButton();
            gbOperaciones.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 44);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Variable :A";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 205);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 1;
            label2.Text = "Variable B:";
            label2.Click += label2_Click;
            // 
            // txVarA
            // 
            txVarA.Location = new Point(47, 89);
            txVarA.Name = "txVarA";
            txVarA.Size = new Size(150, 31);
            txVarA.TabIndex = 2;
            // 
            // txVarB
            // 
            txVarB.Location = new Point(49, 253);
            txVarB.Name = "txVarB";
            txVarB.Size = new Size(150, 31);
            txVarB.TabIndex = 3;
            // 
            // butCalcular
            // 
            butCalcular.Location = new Point(514, 106);
            butCalcular.Name = "butCalcular";
            butCalcular.Size = new Size(112, 34);
            butCalcular.TabIndex = 4;
            butCalcular.Text = "Calcular";
            butCalcular.UseVisualStyleBackColor = true;
            butCalcular.Click += butCalcular_Click;
            // 
            // butReset
            // 
            butReset.Location = new Point(514, 238);
            butReset.Name = "butReset";
            butReset.Size = new Size(112, 34);
            butReset.TabIndex = 5;
            butReset.Text = "Reset";
            butReset.UseVisualStyleBackColor = true;
            butReset.Click += butReset_Click;
            // 
            // gbOperaciones
            // 
            gbOperaciones.Controls.Add(rdbDivision);
            gbOperaciones.Controls.Add(rdbMultiplicacion);
            gbOperaciones.Controls.Add(rdbResta);
            gbOperaciones.Controls.Add(rdbSuma);
            gbOperaciones.Location = new Point(246, 89);
            gbOperaciones.Name = "gbOperaciones";
            gbOperaciones.Size = new Size(219, 183);
            gbOperaciones.TabIndex = 6;
            gbOperaciones.TabStop = false;
            gbOperaciones.Text = "Operaciones";
            gbOperaciones.Enter += groupBox1_Enter;
            // 
            // rdbSuma
            // 
            rdbSuma.AutoSize = true;
            rdbSuma.Location = new Point(52, 35);
            rdbSuma.Name = "rdbSuma";
            rdbSuma.Size = new Size(82, 29);
            rdbSuma.TabIndex = 0;
            rdbSuma.TabStop = true;
            rdbSuma.Text = "Suma";
            rdbSuma.UseVisualStyleBackColor = true;
            // 
            // rdbResta
            // 
            rdbResta.AutoSize = true;
            rdbResta.Location = new Point(52, 62);
            rdbResta.Name = "rdbResta";
            rdbResta.Size = new Size(79, 29);
            rdbResta.TabIndex = 1;
            rdbResta.TabStop = true;
            rdbResta.Text = "Resta";
            rdbResta.UseVisualStyleBackColor = true;
            rdbResta.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdbMultiplicacion
            // 
            rdbMultiplicacion.AutoSize = true;
            rdbMultiplicacion.Location = new Point(52, 97);
            rdbMultiplicacion.Name = "rdbMultiplicacion";
            rdbMultiplicacion.Size = new Size(146, 29);
            rdbMultiplicacion.TabIndex = 2;
            rdbMultiplicacion.TabStop = true;
            rdbMultiplicacion.Text = "Multiplicación";
            rdbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdbDivision
            // 
            rdbDivision.AutoSize = true;
            rdbDivision.Location = new Point(52, 132);
            rdbDivision.Name = "rdbDivision";
            rdbDivision.Size = new Size(100, 29);
            rdbDivision.TabIndex = 3;
            rdbDivision.TabStop = true;
            rdbDivision.Text = "División";
            rdbDivision.UseVisualStyleBackColor = true;
            rdbDivision.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // frCalculadora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbOperaciones);
            Controls.Add(butReset);
            Controls.Add(butCalcular);
            Controls.Add(txVarB);
            Controls.Add(txVarA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frCalculadora";
            Text = "frCalculadora";
            gbOperaciones.ResumeLayout(false);
            gbOperaciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txVarA;
        private TextBox txVarB;
        private Button butCalcular;
        private Button butReset;
        private GroupBox gbOperaciones;
        private RadioButton rdbDivision;
        private RadioButton rdbMultiplicacion;
        private RadioButton rdbResta;
        private RadioButton rdbSuma;
    }
}