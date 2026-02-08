namespace Calculadora.Formularios
{
    partial class FrmTemporizador
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
            components = new System.ComponentModel.Container();
            labelHora = new Label();
            tmrHora = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHora.Location = new Point(121, 150);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(543, 128);
            labelHora.TabIndex = 0;
            labelHora.Text = "00:00:00 x.x";
            // 
            // tmrHora
            // 
            tmrHora.Enabled = true;
            tmrHora.Interval = 1000;
            tmrHora.Tick += tmrHora_Tick;
            // 
            // FrmTemporizador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelHora);
            Name = "FrmTemporizador";
            Text = "Reloj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHora;
        private System.Windows.Forms.Timer tmrHora;
    }
}