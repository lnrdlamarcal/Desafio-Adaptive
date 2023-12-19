namespace Desafio
{
    partial class validaAcesso
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
            textValida = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 121);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(530, 20);
            label1.TabIndex = 0;
            label1.Text = "Digite a palavra-chave \"Adaptive2023\", no campo abaixo, conforme esperado:";
            // 
            // textValida
            // 
            textValida.Location = new Point(118, 164);
            textValida.Margin = new Padding(5, 4, 5, 4);
            textValida.MaxLength = 12;
            textValida.Name = "textValida";
            textValida.Size = new Size(303, 27);
            textValida.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(442, 299);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(101, 36);
            button1.TabIndex = 2;
            button1.Text = "Validar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // validaAcesso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 352);
            Controls.Add(button1);
            Controls.Add(textValida);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "validaAcesso";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adaptive Business";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textValida;
        private Button button1;
    }
}