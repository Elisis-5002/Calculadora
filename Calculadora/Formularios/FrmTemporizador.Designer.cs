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
            menuStrip1 = new MenuStrip();
            establecerToolStripMenuItem = new ToolStripMenuItem();
            mIalarma1 = new ToolStripMenuItem();
            cronometroToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { establecerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // establecerToolStripMenuItem
            // 
            establecerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mIalarma1, cronometroToolStripMenuItem });
            establecerToolStripMenuItem.Name = "establecerToolStripMenuItem";
            establecerToolStripMenuItem.Size = new Size(107, 29);
            establecerToolStripMenuItem.Text = "Establecer";
            // 
            // mIalarma1
            // 
            mIalarma1.Name = "mIalarma1";
            mIalarma1.Size = new Size(270, 34);
            mIalarma1.Text = "Alarma 1";
            mIalarma1.Click += mIalarma1_Click;
            // 
            // cronometroToolStripMenuItem
            // 
            cronometroToolStripMenuItem.Name = "cronometroToolStripMenuItem";
            cronometroToolStripMenuItem.Size = new Size(270, 34);
            cronometroToolStripMenuItem.Text = "Cronometro";
            cronometroToolStripMenuItem.Click += cronometroToolStripMenuItem_Click;
            // 
            // FrmTemporizador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelHora);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmTemporizador";
            Text = "Reloj";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHora;
        private System.Windows.Forms.Timer tmrHora;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem establecerToolStripMenuItem;
        private ToolStripMenuItem mIalarma1;
        private ToolStripMenuItem cronometroToolStripMenuItem;
    }
}