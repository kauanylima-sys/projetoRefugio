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
    public partial class formAtualizarAnimal : Form
    {
        private int idAnimalSelecionado = 0;
        private bool localResgateNaoInformado = false;

        public formAtualizarAnimal()
        {
            InitializeComponent();
        }

        private void formAtualizarAnimal_Load(object sender, EventArgs e)
        {
            listaCBOpcoes();
            listaCBCategorias();
            LimpaCampos();
        }

        void listaCBOpcoes()
        {
            cmbSexo.Items.Add("F");
            cmbSexo.Items.Add("M");
            cmbSituacao.Items.Add("Triagem");
            cmbSituacao.Items.Add("quarentena");
            cmbSituacao.Items.Add("tratamento veterinário");
            cmbSituacao.Items.Add("Reabilitação Comportamental");
            cmbSituacao.Items.Add("Aclimatação / Soltura branda");
            cmbSituacao.Items.Add("Berçário / Amamentação");
            cmbSituacao.Items.Add("Apto para Soltura ");
            cmbSituacao.Items.Add("Inápto para soltura ");
            cmbSituacao.Items.Add("Transferido ");
            cmbSituacao.Items.Add("Reintegrado");
            cmbSituacao.Items.Add("Óbito");
        }

        public void listaCBCategorias()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = con.listaCategorias();
            if (tabelaDados == null)
            {
                MessageBox.Show(con.mensagem);
                return;
            }
            cmbCategoria.DataSource = tabelaDados;
            cmbCategoria.DisplayMember = "categoria";
            cmbCategoria.ValueMember = "id";
            cmbCategoria.SelectedIndex = -1;
        }

        void LimpaCampos()
        {
            txtNome.Clear();
            cmbCategoria.SelectedIndex = -1;
            txtEspecie.Clear();
            cmbSexo.SelectedIndex = -1;
            numIdade.Value = 0;
            cmbSituacao.SelectedIndex = -1;
            txtLocalResgate.Clear();
            dtpDataResgate.Value = DateTime.Today;
            chkIdadeNaoInformada.Checked = false;
            chkIdadeNaoInformada.Visible = false;
            dtpDataResgate.ShowCheckBox = false;
            dtpDataResgate.Checked = true;
            idAnimalSelecionado = 0;
            localResgateNaoInformado = false;
            btnSalvar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LimpaCampos();

            if (numIdBusca.Value == 0)
            {
                MessageBox.Show("Informe o ID do animal.");
                return;
            }

            if (cmbCategoria.DataSource == null)
            {
                listaCBCategorias();
                if (cmbCategoria.DataSource == null)
                {
                    return;
                }
            }

            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = con.consultaAnimalPorId(Convert.ToInt32(numIdBusca.Value));
            if (tabelaDados == null)
            {
                MessageBox.Show(con.mensagem);
                return;
            }

            if (tabelaDados.Rows.Count == 0)
            {
                MessageBox.Show("Animal não encontrado.");
                return;
            }

            idAnimalSelecionado = Convert.ToInt32(tabelaDados.Rows[0]["id"]);
            txtNome.Text = tabelaDados.Rows[0]["nome"].ToString();
            if (tabelaDados.Rows[0]["id_categoria"] != DBNull.Value)
            {
                cmbCategoria.SelectedValue = Convert.ToInt32(tabelaDados.Rows[0]["id_categoria"]);
            }
            txtEspecie.Text = tabelaDados.Rows[0]["especie"].ToString();

            string sexo = tabelaDados.Rows[0]["sexo"].ToString();
            if (!cmbSexo.Items.Contains(sexo) && sexo != "")
            {
                cmbSexo.Items.Add(sexo);
            }
            cmbSexo.SelectedItem = sexo;

            if (tabelaDados.Rows[0]["idade"] == DBNull.Value)
            {
                chkIdadeNaoInformada.Visible = true;
                chkIdadeNaoInformada.Checked = true;
            }
            else
            {
                int idade = Convert.ToInt32(tabelaDados.Rows[0]["idade"]);
                if (idade < numIdade.Minimum || idade > numIdade.Maximum)
                {
                    MessageBox.Show("A idade cadastrada está fora do intervalo aceito pelo formulário.");
                    LimpaCampos();
                    return;
                }
                numIdade.Value = idade;
            }

            string situacao = tabelaDados.Rows[0]["situacao"].ToString();
            if (!cmbSituacao.Items.Contains(situacao) && situacao != "")
            {
                cmbSituacao.Items.Add(situacao);
            }
            cmbSituacao.SelectedItem = situacao;
            localResgateNaoInformado = tabelaDados.Rows[0]["local_resgate"] == DBNull.Value;
            txtLocalResgate.Text = tabelaDados.Rows[0]["local_resgate"].ToString();

            if (tabelaDados.Rows[0]["data_resgate"] == DBNull.Value)
            {
                dtpDataResgate.ShowCheckBox = true;
                dtpDataResgate.Checked = false;
            }
            else
            {
                DateTime data = Convert.ToDateTime(tabelaDados.Rows[0]["data_resgate"]);
                if (data < dtpDataResgate.MinDate || data > dtpDataResgate.MaxDate)
                {
                    MessageBox.Show("A data cadastrada está fora do intervalo aceito pelo formulário.");
                    LimpaCampos();
                    return;
                }
                dtpDataResgate.Value = data;
            }
            btnSalvar.Enabled = true;
        }

        private void numIdBusca_ValueChanged(object sender, EventArgs e)
        {
            if (idAnimalSelecionado != 0 && numIdBusca.Value != idAnimalSelecionado)
            {
                LimpaCampos();
            }
        }

        private void chkIdadeNaoInformada_CheckedChanged(object sender, EventArgs e)
        {
            numIdade.Enabled = !chkIdadeNaoInformada.Checked;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (idAnimalSelecionado == 0 || numIdBusca.Value != idAnimalSelecionado)
            {
                MessageBox.Show("Busque um animal antes de alterar os dados.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtEspecie.Text))
            {
                MessageBox.Show("Preencha o nome e a espécie do animal.");
                return;
            }

            if (cmbCategoria.SelectedValue == null || cmbSexo.SelectedIndex == -1 || cmbSituacao.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria, um sexo e uma situação válidos.");
                return;
            }

            ConectaBanco con = new ConectaBanco();
            AnimalResgatado animal = new AnimalResgatado();
            animal.Id = idAnimalSelecionado;
            animal.Nome = txtNome.Text.Trim();
            animal.IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            animal.Especie = txtEspecie.Text.Trim();
            animal.Sexo = cmbSexo.SelectedItem.ToString();
            animal.Idade = Convert.ToInt32(numIdade.Value);
            animal.Situacao = cmbSituacao.SelectedItem.ToString();
            animal.LocalResgate = txtLocalResgate.Text.Trim();
            animal.DataResgate = dtpDataResgate.Value.Date;

            if (localResgateNaoInformado && animal.LocalResgate == "")
            {
                animal.LocalResgate = null;
            }
            if (chkIdadeNaoInformada.Checked)
            {
                animal.Idade = null;
            }
            if (dtpDataResgate.ShowCheckBox && !dtpDataResgate.Checked)
            {
                animal.DataResgate = null;
            }

            bool retorno = con.alteraAnimal(animal);
            if (retorno)
            {
                MessageBox.Show("Animal alterado com sucesso!");
                LimpaCampos();
                numIdBusca.Value = 0;
                numIdBusca.Focus();
            }
            else
            {
                MessageBox.Show(con.mensagem);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
