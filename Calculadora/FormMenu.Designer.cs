namespace Calculadora
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            calculadoraSImpleToolStripMenuItem = new ToolStripMenuItem();
            burbujaToolStripMenuItem = new ToolStripMenuItem();
            burbujaToolStripMenuItem1 = new ToolStripMenuItem();
            registroToolStripMenuItem = new ToolStripMenuItem();
            temporizadoresToolStripMenuItem = new ToolStripMenuItem();
            relojToolStripMenuItem = new ToolStripMenuItem();
            editorToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, aplicacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(270, 34);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraSImpleToolStripMenuItem, burbujaToolStripMenuItem, registroToolStripMenuItem, temporizadoresToolStripMenuItem, editorToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(126, 29);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // calculadoraSImpleToolStripMenuItem
            // 
            calculadoraSImpleToolStripMenuItem.Name = "calculadoraSImpleToolStripMenuItem";
            calculadoraSImpleToolStripMenuItem.Size = new Size(270, 34);
            calculadoraSImpleToolStripMenuItem.Text = "Calculadora SImple";
            calculadoraSImpleToolStripMenuItem.Click += calculadoraSImpleToolStripMenuItem_Click;
            // 
            // burbujaToolStripMenuItem
            // 
            burbujaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { burbujaToolStripMenuItem1 });
            burbujaToolStripMenuItem.Name = "burbujaToolStripMenuItem";
            burbujaToolStripMenuItem.Size = new Size(270, 34);
            burbujaToolStripMenuItem.Text = "Ordenamientos";
            // 
            // burbujaToolStripMenuItem1
            // 
            burbujaToolStripMenuItem1.Name = "burbujaToolStripMenuItem1";
            burbujaToolStripMenuItem1.Size = new Size(174, 34);
            burbujaToolStripMenuItem1.Text = "Burbuja";
            burbujaToolStripMenuItem1.Click += burbujaToolStripMenuItem1_Click;
            // 
            // registroToolStripMenuItem
            // 
            registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            registroToolStripMenuItem.Size = new Size(270, 34);
            registroToolStripMenuItem.Text = "Registro";
            registroToolStripMenuItem.Click += registroToolStripMenuItem_Click;
            // 
            // temporizadoresToolStripMenuItem
            // 
            temporizadoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relojToolStripMenuItem });
            temporizadoresToolStripMenuItem.Name = "temporizadoresToolStripMenuItem";
            temporizadoresToolStripMenuItem.Size = new Size(270, 34);
            temporizadoresToolStripMenuItem.Text = "Temporizadores";
            temporizadoresToolStripMenuItem.Click += temporizadoresToolStripMenuItem_Click;
            // 
            // relojToolStripMenuItem
            // 
            relojToolStripMenuItem.Name = "relojToolStripMenuItem";
            relojToolStripMenuItem.Size = new Size(152, 34);
            relojToolStripMenuItem.Text = "Reloj";
            relojToolStripMenuItem.Click += relojToolStripMenuItem_Click;
            // 
            // editorToolStripMenuItem
            // 
            editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            editorToolStripMenuItem.Size = new Size(270, 34);
            editorToolStripMenuItem.Text = "Editor";
            editorToolStripMenuItem.Click += editorToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "FormMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem calculadoraSImpleToolStripMenuItem;
        private ToolStripMenuItem burbujaToolStripMenuItem;
        private ToolStripMenuItem burbujaToolStripMenuItem1;
        private ToolStripMenuItem registroToolStripMenuItem;
        private ToolStripMenuItem temporizadoresToolStripMenuItem;
        private ToolStripMenuItem relojToolStripMenuItem;
        private ToolStripMenuItem editorToolStripMenuItem;
    }
}
