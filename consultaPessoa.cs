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
    public partial class consultaPessoa : Form
    {
        public consultaPessoa()
        {
            InitializeComponent();
        }

        private void consultaPessoa_Load(object sender, EventArgs e) //Realiza o select e popula o Grid
        {
            string consultaSql = "SELECT p.id_pessoa,p.codigo, p.nome, tp.tipo_pessoa FROM pessoas p INNER JOIN tipo_pessoa tp ON tp.id_tipo_pessoa = p.id_tipo_pessoa";
            Conn conn = new Conn();
            string conexao = conn.connString;
            Npgsql.NpgsqlConnection conecta = new Npgsql.NpgsqlConnection(conexao);
            conecta.Open();
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(consultaSql, conecta);
            cmd.CommandType = CommandType.Text;
            Npgsql.NpgsqlDataAdapter adapter = new Npgsql.NpgsqlDataAdapter(cmd);
            DataTable pessoas = new DataTable();
            adapter.Fill(pessoas);
            dataGridView1.DataSource = pessoas;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //Caso clique na célula, dados é exibidos a direita
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox4.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox1.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e) //Realiza a edição do campo Nome
        {
            Conn conn = new Conn();

            if (textBox1 != null || textBox1.Text != "")
            {
                string novoNome = textBox1.Text;
                int id_pessoa = Int32.Parse(textBox4.Text);
                conn.Conecta();
                conn.RodaQuery($"UPDATE pessoas SET nome = '{novoNome}' where id_pessoa = {id_pessoa}");
                conn.Fecha();

                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "Form1" && Application.OpenForms[i].Name != "telaCadastro")
                        Application.OpenForms[i].Close();
                }

                MessageBox.Show("Pessoa editada com sucesso.","Adaptive Business", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Form consultaPessoa = new consultaPessoa();
                consultaPessoa.ShowDialog();
                consultaPessoa.Focus();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.",
                         "",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);


            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
