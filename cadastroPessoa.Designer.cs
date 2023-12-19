namespace Desafio
{
    partial class cadastroPessoa
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
            labelNome = new Label();
            textBoxNome = new TextBox();
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            bindingSource1 = new BindingSource(components);
            labelTCadastro = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(37, 105);
            labelNome.Margin = new Padding(4, 0, 4, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(53, 20);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(67, 129);
            textBoxNome.Margin = new Padding(4, 5, 4, 5);
            textBoxNome.MaxLength = 250;
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(471, 27);
            textBoxNome.TabIndex = 3;
            textBoxNome.Enter += textBoxNome_Enter;
            textBoxNome.KeyPress += textBoxNome_KeyPress;
            textBoxNome.Leave += textBoxNome_Leave;
            // 
            // buttonCancelar
            // 
            buttonCancelar.DialogResult = DialogResult.Cancel;
            buttonCancelar.Location = new Point(565, 391);
            buttonCancelar.Margin = new Padding(4, 5, 4, 5);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(100, 35);
            buttonCancelar.TabIndex = 8;
            buttonCancelar.Text = "Limpar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(673, 391);
            buttonSalvar.Margin = new Padding(4, 5, 4, 5);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(100, 35);
            buttonSalvar.TabIndex = 9;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 10;
            label1.Text = "Código:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 69);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 27);
            textBox1.TabIndex = 11;
            textBox1.Enter += textBox1_Enter;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.Leave += textBox1_Leave;
            // 
            // labelTCadastro
            // 
            labelTCadastro.AutoSize = true;
            labelTCadastro.Location = new Point(37, 171);
            labelTCadastro.Margin = new Padding(4, 0, 4, 0);
            labelTCadastro.Name = "labelTCadastro";
            labelTCadastro.Size = new Size(126, 20);
            labelTCadastro.TabIndex = 13;
            labelTCadastro.Text = "Tipo de Cadastro:";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(67, 257);
            radioButton3.Margin = new Padding(4, 5, 4, 5);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(114, 24);
            radioButton3.TabIndex = 14;
            radioButton3.TabStop = true;
            radioButton3.Text = "Colaborador";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(67, 226);
            radioButton2.Margin = new Padding(4, 5, 4, 5);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(105, 24);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "Fornecedor";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(67, 195);
            radioButton1.Margin = new Padding(4, 5, 4, 5);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 24);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cliente";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // cadastroPessoa
            // 
            AcceptButton = buttonSalvar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton = buttonCancelar;
            ClientSize = new Size(785, 451);
            Controls.Add(radioButton1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton3);
            Controls.Add(labelTCadastro);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonCancelar);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Margin = new Padding(4, 5, 4, 5);
            MinimizeBox = false;
            Name = "cadastroPessoa";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Cadastro de Pessoa";
            TopMost = true;
            Load += cadastroPessoa_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Label label1;
        private TextBox textBox1;
        private BindingSource bindingSource1;
        private Label labelTCadastro;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}