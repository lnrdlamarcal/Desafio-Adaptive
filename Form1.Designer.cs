namespace Desafio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitulo = new Label();
            labelUsuario = new Label();
            labelSenha = new Label();
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            buttonLogin = new Button();
            labelCadastro = new Label();
            buttonCadastro = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(74, 101);
            labelTitulo.Margin = new Padding(4, 0, 4, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(295, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Bem vindo ao módulo de cadastro do Adaptive Forms.";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(42, 197);
            labelUsuario.Margin = new Padding(4, 0, 4, 0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(50, 15);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Usuário:";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(42, 236);
            labelSenha.Margin = new Padding(4, 0, 4, 0);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(42, 15);
            labelSenha.TabIndex = 2;
            labelSenha.Text = "Senha:";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(102, 194);
            textBoxUsuario.Margin = new Padding(4, 4, 4, 4);
            textBoxUsuario.MaxLength = 100;
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(262, 23);
            textBoxUsuario.TabIndex = 3;
            textBoxUsuario.Enter += textBoxUsuario_Enter;
            textBoxUsuario.KeyPress += textBoxUsuario_KeyPress;
            textBoxUsuario.Leave += textBoxUsuario_Leave;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(102, 232);
            textBoxSenha.Margin = new Padding(4, 4, 4, 4);
            textBoxSenha.MaxLength = 12;
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(262, 23);
            textBoxSenha.TabIndex = 4;
            textBoxSenha.UseSystemPasswordChar = true;
            textBoxSenha.Enter += textBoxSenha_Enter;
            textBoxSenha.Leave += textBoxSenha_Leave;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(175, 262);
            buttonLogin.Margin = new Padding(4, 4, 4, 4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(88, 26);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelCadastro
            // 
            labelCadastro.AutoSize = true;
            labelCadastro.Location = new Point(99, 366);
            labelCadastro.Margin = new Padding(4, 0, 4, 0);
            labelCadastro.Name = "labelCadastro";
            labelCadastro.Size = new Size(217, 15);
            labelCadastro.TabIndex = 6;
            labelCadastro.Text = "Ainda não é cadastrado ? Clique abaixo.";
            // 
            // buttonCadastro
            // 
            buttonCadastro.Location = new Point(175, 394);
            buttonCadastro.Margin = new Padding(4, 4, 4, 4);
            buttonCadastro.Name = "buttonCadastro";
            buttonCadastro.Size = new Size(88, 26);
            buttonCadastro.TabIndex = 7;
            buttonCadastro.Text = "Cadastro";
            buttonCadastro.UseVisualStyleBackColor = true;
            buttonCadastro.Click += buttonCadastro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_adaptive___vertical;
            pictureBox1.Location = new Point(357, 448);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(430, 519);
            Controls.Add(pictureBox1);
            Controls.Add(buttonCadastro);
            Controls.Add(labelCadastro);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Controls.Add(labelSenha);
            Controls.Add(labelUsuario);
            Controls.Add(labelTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adaptive Business";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelUsuario;
        private Label labelSenha;
        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Button buttonLogin;
        private Label labelCadastro;
        private Button buttonCadastro;
        private PictureBox pictureBox1;
    }
}

