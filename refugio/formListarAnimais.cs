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
    public partial class formListarAnimais : Form
    {
        public formListarAnimais()
        {
            InitializeComponent();
        }

        void lista_gridAnimais()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = con.listaAnimais();
            if (tabelaDados == null)
            {
                dgvAnimais.DataSource = null;
                MessageBox.Show(con.mensagem);
                return;
            }

            dgvAnimais.DataSource = tabelaDados;
            dgvAnimais.Columns["id"].HeaderText = "ID";
            dgvAnimais.Columns["nome"].HeaderText = "Nome";
            dgvAnimais.Columns["id_categoria"].Visible = false;
            dgvAnimais.Columns["categoria"].HeaderText = "Categoria";
            dgvAnimais.Columns["especie"].HeaderText = "Espécie";
            dgvAnimais.Columns["sexo"].HeaderText = "Sexo";
            dgvAnimais.Columns["idade"].HeaderText = "Idade";
            dgvAnimais.Columns["situacao"].HeaderText = "Situação";
            dgvAnimais.Columns["local_resgate"].HeaderText = "Local do resgate";
            dgvAnimais.Columns["data_resgate"].HeaderText = "Data do resgate";
            dgvAnimais.Columns["data_resgate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvAnimais.ClearSelection();
        }

        private void formListarAnimais_Load(object sender, EventArgs e)
        {
            lista_gridAnimais();
        }

        void filtraAnimais()
        {
            if (dgvAnimais.DataSource == null)
            {
                return;
            }

            string busca = txtFiltro.Text.Trim();
            string filtro = "";
            for (int i = 0; i < busca.Length; i++)
            {
                if (busca[i] == '\'')
                {
                    filtro += "''";
                }
                else if (busca[i] == '[' || busca[i] == ']' || busca[i] == '%' || busca[i] == '*')
                {
                    filtro += "[" + busca[i] + "]";
                }
                else
                {
                    filtro += busca[i];
                }
            }

            if (filtro == "")
            {
                (dgvAnimais.DataSource as DataTable).DefaultView.RowFilter = "";
            }
            else
            {
                (dgvAnimais.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("nome like '%{0}%' or especie like '%{0}%'", filtro);
            }
            dgvAnimais.ClearSelection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtraAnimais();
            if (dgvAnimais.DataSource != null && dgvAnimais.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum animal encontrado.");
            }
        }

        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            lista_gridAnimais();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvAnimais.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um animal para excluir.");
                return;
            }

            int linha = dgvAnimais.SelectedRows[0].Index;
            int id = Convert.ToInt32(dgvAnimais.Rows[linha].Cells["id"].Value);
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?",
                "Remover Animal", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaAnimal(id);
                if (retorno == true)
                {
                    MessageBox.Show("Animal excluído com sucesso!");
                    lista_gridAnimais();
                    filtraAnimais();
                }
                else
                {
                    MessageBox.Show(con.mensagem);
                }
            }
            else
            {
                MessageBox.Show("Exclusão cancelada");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
