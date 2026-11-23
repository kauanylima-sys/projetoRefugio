using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace refugio
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            using (formCadastroAnimal cadastro = new formCadastroAnimal())
            {
                cadastro.ShowDialog(this);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (formConsultarAnimal consulta = new formConsultarAnimal())
            {
                consulta.ShowDialog(this);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            using (formAtualizarAnimal atualizacao = new formAtualizarAnimal())
            {
                atualizacao.ShowDialog(this);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            using (formListarAnimais listagem = new formListarAnimais())
            {
                listagem.ShowDialog(this);
            }
        }
    }
}
