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
    public partial class formCadastroAnimal : Form
    {
        public formCadastroAnimal()
        {
            InitializeComponent();
        }

        private void formCadastroAnimal_Load(object sender, EventArgs e)
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
            txtNome.Focus();
        }

        private string PedirNovaCategoria()
        {
            using (Form prompt = new Form())
            {
                prompt.Width = 340;
                prompt.Height = 160;
                prompt.Text = "Nova Categoria";
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.StartPosition = FormStartPosition.CenterParent;
                prompt.MaximizeBox = false;
                prompt.MinimizeBox = false;

                Label lbl = new Label() { Left = 15, Top = 15, Width = 300, Text = "Digite o nome da nova categoria:" };
                TextBox txt = new TextBox() { Left = 15, Top = 40, Width = 295, MaxLength = 45 };
                Button btnOk = new Button() { Text = "OK", Left = 230, Top = 70, Width = 80, DialogResult = DialogResult.OK };

                prompt.Controls.Add(lbl);
                prompt.Controls.Add(txt);
                prompt.Controls.Add(btnOk);
                prompt.AcceptButton = btnOk;

                return prompt.ShowDialog(this) == DialogResult.OK ? txt.Text.Trim() : string.Empty;
            }
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            string novaCategoria = PedirNovaCategoria();

            if (string.IsNullOrWhiteSpace(novaCategoria))
            {
                return;
            }

            ConectaBanco con = new ConectaBanco();
            bool retorno = con.insereCategoria(novaCategoria);

            if (retorno)
            {
                MessageBox.Show("Categoria adicionada com sucesso!");
                listaCBCategorias();
                int indice = cmbCategoria.FindStringExact(novaCategoria);
                if (indice >= 0)
                {
                    cmbCategoria.SelectedIndex = indice;
                }
            }
            else
            {
                MessageBox.Show(con.mensagem);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
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

            animal.Nome = txtNome.Text.Trim();
            animal.IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            animal.Especie = txtEspecie.Text.Trim();
            animal.Sexo = cmbSexo.SelectedItem.ToString();
            animal.Idade = Convert.ToInt32(numIdade.Value);
            animal.Situacao = cmbSituacao.SelectedItem.ToString();
            animal.LocalResgate = txtLocalResgate.Text.Trim();
            animal.DataResgate = dtpDataResgate.Value.Date;

            bool retorno = con.insereAnimal(animal);
            if (retorno == false)
            {
                MessageBox.Show(con.mensagem);
            }
            else
            {
                MessageBox.Show("Animal cadastrado com sucesso!");
                LimpaCampos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpDataResgate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
