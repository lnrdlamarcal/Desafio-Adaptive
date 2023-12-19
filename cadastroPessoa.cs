using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Npgsql;
using System.Data.Common;

namespace Desafio
{
    public partial class cadastroPessoa : Form
    {
        public cadastroPessoa()
        {
            InitializeComponent();
        }

        private void textBoxNome_Enter(object sender, EventArgs e)
        {
            textBoxNome.BackColor = Color.LightYellow;
        }

        private void textBoxNome_Leave(object sender, EventArgs e)
        {
            textBoxNome.BackColor = Color.White;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightYellow;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void buttonCancelar_Click(object sender, EventArgs e) //Limpa os dados nas Checkboxes
        {
            textBox1.Text = string.Empty;
            textBoxNome.Text = string.Empty;
            radioButton3.Checked = false;
            radioButton2.Checked = false;
            radioButton1.Checked = false;
        }

        private void cadastroPessoa_Load(object sender, EventArgs e)
        {
            textBox1.Text.ToLower();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //Não permite que teclas além de números sejam pressionados
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsDigit(e.KeyChar) && tecla != 08 && tecla != 14 && tecla != 15) 
            {
                e.Handled = true;

                MessageBox.Show("Digite apenas números.",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e) //Não permite que teclas além de letras sejam pressionados 
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsLetter(e.KeyChar) && tecla != 08 && tecla != 32 && tecla != 14 && tecla != 15) 
            {
                e.Handled = true;

                MessageBox.Show("Digite apenas letras.",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }
        public async void buttonSalvar_Click(object sender, EventArgs e)        //Função de UPDATE atrelada ao botão Salvar
        {
            try
            {
                if (textBox1 != null && textBoxNome != null && (radioButton3.Checked == true || radioButton2.Checked == true || radioButton1.Checked == true))
                {
                    Conn conn = new Conn();
                    string Vnome = textBoxNome.Text;
                    string Vcodigo = textBox1.Text;
                    int Vtipo = 0;
                    DateTime horaCadastro = DateTime.Now;

                    if (radioButton3.Checked == true)
                    {
                        Vtipo = 3;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        Vtipo = 2;
                    }
                    else
                    {
                        Vtipo = 1;
                    }

                    conn.Conecta();                    
                    conn.RodaQuery($"INSERT INTO pessoas(nome,id_tipo_pessoa,data_cadastro,codigo) VALUES ('{Vnome}', {Vtipo},'{horaCadastro}','{Vcodigo}')"); //Bloco de conexão no banco de dados
                    conn.Fecha();

                    MessageBox.Show("Pessoa cadastrada com sucesso.", //Exibe mensagem de sucesso
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    for (int i = Application.OpenForms.Count - 1; i >= 0; i--) //Loop para fechar janelas após sucesso
                    {
                        if (Application.OpenForms[i].Name != "Form1" && Application.OpenForms[i].Name != "telaCadastro")
                            Application.OpenForms[i].Close();
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos."); //Caso tenha campos em branco, não é possível gravar
                }
            }
            catch (PostgresException ex)
            {
                var err = ex.MessageText;

                MessageBox.Show(err, "Adaptive Business", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Captura mensagens de erro
            }


        }
    }
}
