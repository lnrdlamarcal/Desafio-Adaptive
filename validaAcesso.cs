using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio
{
    public partial class validaAcesso : Form
    {
        public validaAcesso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Validação da palavra-camaleão
        {
            Valida v = new Valida();
            string palavraValida = v.validaAcesso("adaptive2023");

            if (palavraValida == textValida.Text)
            {
                Form telaCadastro = new telaCadastro(); //Em caso de sucesso, abre a próxima tela
                telaCadastro.Show();
                telaCadastro.Focus();

                for (int i = Application.OpenForms.Count - 1; i >= 0; i--) //Loop para fechar janelas
                {
                    if (Application.OpenForms[i].Name != "Form1" && Application.OpenForms[i].Name != "telaCadastro")
                        Application.OpenForms[i].Close();
                }
            }
            else
            {
                MessageBox.Show("Palavra-chave incorreta.", //Exibe possível erros
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }
    }
}
