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
    public partial class formConsultarAnimal : Form
    {
        public formConsultarAnimal()
        {
            InitializeComponent();
        }

        void LimpaCampos()
        {
            txtNome.Clear();
            txtCategoria.Clear();
            txtEspecie.Clear();
            txtSexo.Clear();
            txtIdade.Clear();
            txtSituacao.Clear();
            txtLocalResgate.Clear();
            txtDataResgate.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvResultados.DataSource = null;
            LimpaCampos();

            if (string.IsNullOrWhiteSpace(txtBuscaNome.Text))
            {
                MessageBox.Show("Digite o nome do animal.");
                return;
            }

            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = con.consultaAnimalPorNome(txtBuscaNome.Text.Trim());
            if (tabelaDados == null)
            {
                MessageBox.Show(con.mensagem);
                return;
            }

            dgvResultados.DataSource = tabelaDados;
            dgvResultados.Columns["id"].HeaderText = "ID";
            dgvResultados.Columns["nome"].HeaderText = "Nome";
            dgvResultados.Columns["especie"].HeaderText = "Espécie";
            dgvResultados.Columns["situacao"].HeaderText = "Situação";
            dgvResultados.Columns["id_categoria"].Visible = false;
            dgvResultados.Columns["categoria"].Visible = false;
            dgvResultados.Columns["sexo"].Visible = false;
            dgvResultados.Columns["idade"].Visible = false;
            dgvResultados.Columns["local_resgate"].Visible = false;
            dgvResultados.Columns["data_resgate"].Visible = false;
            dgvResultados.ClearSelection();

            if (tabelaDados.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum animal encontrado.");
            }
        }

        private void dgvResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int linha = e.RowIndex;
            txtNome.Text = dgvResultados.Rows[linha].Cells["nome"].Value.ToString();
            txtCategoria.Text = dgvResultados.Rows[linha].Cells["categoria"].Value.ToString();
            txtEspecie.Text = dgvResultados.Rows[linha].Cells["especie"].Value.ToString();
            txtSexo.Text = dgvResultados.Rows[linha].Cells["sexo"].Value.ToString();
            txtIdade.Text = dgvResultados.Rows[linha].Cells["idade"].Value.ToString();
            txtSituacao.Text = dgvResultados.Rows[linha].Cells["situacao"].Value.ToString();
            txtLocalResgate.Text = dgvResultados.Rows[linha].Cells["local_resgate"].Value.ToString();

            if (dgvResultados.Rows[linha].Cells["idade"].Value == DBNull.Value)
            {
                txtIdade.Text = "Não informada";
            }

            if (dgvResultados.Rows[linha].Cells["data_resgate"].Value == DBNull.Value)
            {
                txtDataResgate.Text = "Não informada";
            }
            else
            {
                txtDataResgate.Text = Convert.ToDateTime(dgvResultados.Rows[linha].Cells["data_resgate"].Value).ToString("dd/MM/yyyy HH:mm");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formConsultarAnimal_Load(object sender, EventArgs e)
        {

        }
    }
}
