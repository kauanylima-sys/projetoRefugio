using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace refugio
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserLogin.Text) ||
               string.IsNullOrWhiteSpace(txtSenhaLogin.Text))
            {
                MessageBox.Show("Informe o usuário e a senha.");
                return;
            }

            ConectaBanco conecta = new ConectaBanco();

            if (conecta.Verifica(
                txtUserLogin.Text.Trim(),
                txtSenhaLogin.Text))
            {
                formPrincipal principal = new formPrincipal();

                this.Hide();
                principal.ShowDialog();
                this.Close();
            }
            else
            {
                if (conecta.mensagem != "")
                {
                    MessageBox.Show(
                        "Erro ao realizar login: " + conecta.mensagem);
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!");
                }

                txtSenhaLogin.Clear();
                txtSenhaLogin.Focus();
            }
        }

        private void lblPagina_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pnlCabecalho_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
