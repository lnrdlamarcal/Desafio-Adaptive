namespace Desafio
{
    partial class telaCadastro
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
            menuStrip1 = new MenuStrip();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            consultarPessoasToolStripMenuItem = new ToolStripMenuItem();
            cadastrarPessoasToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { consultasToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(880, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarPessoasToolStripMenuItem, cadastrarPessoasToolStripMenuItem });
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(73, 24);
            consultasToolStripMenuItem.Text = "Pessoas";
            // 
            // consultarPessoasToolStripMenuItem
            // 
            consultarPessoasToolStripMenuItem.Name = "consultarPessoasToolStripMenuItem";
            consultarPessoasToolStripMenuItem.Size = new Size(224, 26);
            consultarPessoasToolStripMenuItem.Text = "Consultar Pessoas";
            consultarPessoasToolStripMenuItem.Click += consultarPessoasToolStripMenuItem_Click;
            // 
            // cadastrarPessoasToolStripMenuItem
            // 
            cadastrarPessoasToolStripMenuItem.Name = "cadastrarPessoasToolStripMenuItem";
            cadastrarPessoasToolStripMenuItem.Size = new Size(224, 26);
            cadastrarPessoasToolStripMenuItem.Text = "Cadastrar Pessoas";
            cadastrarPessoasToolStripMenuItem.Click += cadastrarPessoasToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(70, 24);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // telaCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 614);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "telaCadastro";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adaptive Business";
            WindowState = FormWindowState.Maximized;
            Load += telaCadastro_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem consultarPessoasToolStripMenuItem;
        private ToolStripMenuItem cadastrarPessoasToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}