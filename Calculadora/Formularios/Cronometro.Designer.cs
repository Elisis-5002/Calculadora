namespace Calculadora.Formularios
{
    partial class frmCronometro
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
            lblCrono = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnIniciar = new Button();
            btnDetener = new Button();
            btnReiniciar = new Button();
            SuspendLayout();
            // 
            // lblCrono
            // 
            lblCrono.AutoSize = true;
            lblCrono.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrono.Location = new Point(211, 132);
            lblCrono.Name = "lblCrono";
            lblCrono.Size = new Size(346, 74);
            lblCrono.TabIndex = 0;
            lblCrono.Text = "00:00:00 x.x";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(125, 290);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(115, 46);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetener.Location = new Point(310, 290);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(115, 46);
            btnDetener.TabIndex = 2;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = SystemColors.ButtonHighlight;
            btnReiniciar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReiniciar.Location = new Point(501, 290);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(143, 46);
            btnReiniciar.TabIndex = 3;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // frmCronometro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReiniciar);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Controls.Add(lblCrono);
            Name = "frmCronometro";
            Text = "Cronometro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCrono;
        private System.Windows.Forms.Timer timer1;
        private Button btnIniciar;
        private Button btnDetener;
        private Button btnReiniciar;
    }
}