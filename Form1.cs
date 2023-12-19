using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e) //Valida conexão do usuário
        {
            Conn conn = new Conn();
            conn.Conecta();
            string usuarioLogin = $"SELECT login FROM usuarios WHERE login = '{textBoxUsuario.Text}'";
            string senhaLogin = $"SELECT senha FROM usuarios WHERE login = '{textBoxUsuario.Text}'";
            string hashSenha = $"SELECT UPPER(MD5('{textBoxSenha.Text}'))"; //Converte input do usuário para MD5

            string usuario = conn.RodaConsulta(usuarioLogin);
            string senha = conn.RodaConsulta(senhaLogin);
            string hash = conn.RodaConsulta(hashSenha);

            try
            {
                if (textBoxUsuario.Text.Equals(usuario) && senha == hash)
                {
                    Form validaAcesso = new validaAcesso(); //Acessa a área restrita
                    validaAcesso.ShowDialog();
                    validaAcesso.Focus();
                    conn.Fecha();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.", //Exibe erro nas credenciais
                                    "Adaptive Business",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    textBoxUsuario.Focus();
                    textBoxSenha.Text = "";
                    conn.Fecha();
                }
            }
            catch (Exception ex)
            {
                conn.Fecha();
            }
        }

        private void textBoxUsuario_Enter(object sender, EventArgs e)
        {
            textBoxUsuario.BackColor = Color.LightYellow;
        }

        private void textBoxUsuario_Leave(object sender, EventArgs e)
        {
            textBoxUsuario.BackColor = Color.White;
        }

        private void textBoxSenha_Enter(object sender, EventArgs e)
        {
            textBoxSenha.BackColor = Color.LightYellow;
        }

        private void textBoxSenha_Leave(object sender, EventArgs e)
        {
            textBoxSenha.BackColor = Color.White;
        }

        private void textBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsLetter(e.KeyChar) && tecla != 08 && tecla != 32 && tecla != 14 && tecla != 15) //Não permite que números sejam digitados
            {
                e.Handled = true;

                MessageBox.Show("Digite apenas letras.",
                                    "",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                textBoxUsuario.SelectionStart = 0;
                textBoxUsuario.SelectionLength = textBoxUsuario.Text.Length;

                textBoxUsuario.Focus();
            }
        }

        private void buttonCadastro_Click(object sender, EventArgs e) //Abre tela para cadastro de usuário
        {
            Form cadastroUsuario = new cadastroUsuario();
            cadastroUsuario.ShowDialog();
            cadastroUsuario.Focus();
        }
    }
}
