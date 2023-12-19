using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio
{
    public partial class cadastroUsuario : Form
    {
        public cadastroUsuario()
        {
            InitializeComponent();
        }

        private void textBoxSenha_Enter(object sender, EventArgs e)
        {
            textBoxSenha.BackColor = Color.LightYellow;
        }
        private void textBoxSenha_Leave(object sender, EventArgs e)
        {
            textBoxSenha.BackColor = Color.White;
        }

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            textBoxLogin.BackColor = Color.LightYellow;
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            textBoxLogin.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conn conn = new Conn();

                conn.Conecta();
                conn.RodaQuery($"INSERT INTO usuarios(login,senha) VALUES ('{textBoxLogin.Text}',UPPER(MD5('{textBoxSenha.Text}')))"); //Insere as credenciais na tabela e a senha criptografada em MD5
                conn.Fecha();

                MessageBox.Show("Usuário cadastrado com sucesso.", "Adaptive Business", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                for (int i = Application.OpenForms.Count - 1; i >= 0; i--) //Loop para fechar as telas que não sejam as credenciadas ou a inicial
                {
                    if (Application.OpenForms[i].Name != "Form1" && Application.OpenForms[i].Name != "telaCadastro")
                        Application.OpenForms[i].Close();
                }
            }
            catch (PostgresException ex)
            {
                string err = ex.MessageText;
                MessageBox.Show(err,"Adaptive Business", MessageBoxButtons.OK,MessageBoxIcon.Error); //Captura possível erro no algoritmo
            }
        }
    }
}
