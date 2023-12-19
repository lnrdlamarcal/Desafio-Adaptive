using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio
{
    public partial class telaCadastro : Form
    {
        public telaCadastro()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarPessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cadastro_pessoa = new cadastroPessoa();
            cadastro_pessoa.MdiParent = this;
            cadastro_pessoa.Show();
        }

        private void telaCadastro_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.White;
                    break;
                }
            }
        }

        private void consultarPessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consulta_pessoa = new consultaPessoa();
            consulta_pessoa.MdiParent = this;
            consulta_pessoa.Show();
        }
    }
}
