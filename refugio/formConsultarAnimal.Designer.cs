namespace refugio
{
    partial class formConsultarAnimal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlCabecalho = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblPagina = new Label();
            lblInstrucao = new Label();
            lblRodape = new Label();
            lblBuscaNome = new Label();
            txtBuscaNome = new TextBox();
            btnBuscar = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            lblEspecie = new Label();
            txtEspecie = new TextBox();
            lblSexo = new Label();
            txtSexo = new TextBox();
            lblSituacao = new Label();
            txtSituacao = new TextBox();
            lblCategoria = new Label();
            txtCategoria = new TextBox();
            lblIdade = new Label();
            txtIdade = new TextBox();
            lblLocalResgate = new Label();
            txtLocalResgate = new TextBox();
            lblDataResgate = new Label();
            txtDataResgate = new TextBox();
            btnFechar = new Button();
            dgvResultados = new DataGridView();
            lblResultados = new Label();
            lblDetalhes = new Label();
            pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.DarkSeaGreen;
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Controls.Add(lblSubtitulo);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(982, 132);
            pnlCabecalho.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Georgia", 19.8F, FontStyle.Italic);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(160, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(168, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REFÚGIO";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Georgia", 11.2F, FontStyle.Italic);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(160, 78);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(447, 23);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Sistema de Gerenciamento de Animais Resgatados";
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Font = new Font("Arial", 17F);
            lblPagina.ForeColor = Color.DarkSeaGreen;
            lblPagina.Location = new Point(82, 160);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(250, 33);
            lblPagina.TabIndex = 1;
            lblPagina.Text = "Consultar animais";
            // 
            // lblInstrucao
            // 
            lblInstrucao.AutoSize = true;
            lblInstrucao.Font = new Font("Arial", 11F);
            lblInstrucao.ForeColor = Color.DarkSeaGreen;
            lblInstrucao.Location = new Point(82, 200);
            lblInstrucao.Name = "lblInstrucao";
            lblInstrucao.Size = new Size(428, 22);
            lblInstrucao.TabIndex = 2;
            lblInstrucao.Text = "Digite o nome do animal para localizar o cadastro:";
            // 
            // lblRodape
            // 
            lblRodape.AutoSize = true;
            lblRodape.Font = new Font("Segoe UI", 9F);
            lblRodape.ForeColor = Color.Gray;
            lblRodape.Location = new Point(366, 912);
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(202, 20);
            lblRodape.TabIndex = 90;
            lblRodape.Text = "Refúgio • Projeto Acadêmico";
            // 
            // lblBuscaNome
            // 
            lblBuscaNome.AutoSize = true;
            lblBuscaNome.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblBuscaNome.ForeColor = Color.DarkSeaGreen;
            lblBuscaNome.Location = new Point(82, 252);
            lblBuscaNome.Name = "lblBuscaNome";
            lblBuscaNome.Size = new Size(137, 23);
            lblBuscaNome.TabIndex = 34;
            lblBuscaNome.Text = "Nome do animal:";
            // 
            // txtBuscaNome
            // 
            txtBuscaNome.BackColor = Color.White;
            txtBuscaNome.BorderStyle = BorderStyle.FixedSingle;
            txtBuscaNome.Font = new Font("Arial", 12F);
            txtBuscaNome.Location = new Point(82, 284);
            txtBuscaNome.MaxLength = 50;
            txtBuscaNome.Name = "txtBuscaNome";
            txtBuscaNome.Size = new Size(350, 30);
            txtBuscaNome.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkSeaGreen;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(448, 283);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(145, 32);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblNome.ForeColor = Color.DarkSeaGreen;
            lblNome.Location = new Point(82, 560);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(59, 23);
            lblNome.TabIndex = 33;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Arial", 12F);
            txtNome.ForeColor = Color.Black;
            txtNome.Location = new Point(82, 584);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(350, 23);
            txtNome.TabIndex = 10;
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblEspecie.ForeColor = Color.DarkSeaGreen;
            lblEspecie.Location = new Point(82, 630);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(75, 23);
            lblEspecie.TabIndex = 32;
            lblEspecie.Text = "Espécie:";
            // 
            // txtEspecie
            // 
            txtEspecie.BackColor = Color.White;
            txtEspecie.BorderStyle = BorderStyle.None;
            txtEspecie.Font = new Font("Arial", 12F);
            txtEspecie.ForeColor = Color.Black;
            txtEspecie.Location = new Point(82, 654);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.ReadOnly = true;
            txtEspecie.Size = new Size(350, 23);
            txtEspecie.TabIndex = 12;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblSexo.ForeColor = Color.DarkSeaGreen;
            lblSexo.Location = new Point(82, 700);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(53, 23);
            lblSexo.TabIndex = 31;
            lblSexo.Text = "Sexo:";
            // 
            // txtSexo
            // 
            txtSexo.BackColor = Color.White;
            txtSexo.BorderStyle = BorderStyle.None;
            txtSexo.Font = new Font("Arial", 12F);
            txtSexo.ForeColor = Color.Black;
            txtSexo.Location = new Point(82, 724);
            txtSexo.Name = "txtSexo";
            txtSexo.ReadOnly = true;
            txtSexo.Size = new Size(350, 23);
            txtSexo.TabIndex = 14;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblSituacao.ForeColor = Color.DarkSeaGreen;
            lblSituacao.Location = new Point(82, 770);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(81, 23);
            lblSituacao.TabIndex = 30;
            lblSituacao.Text = "Situação:";
            // 
            // txtSituacao
            // 
            txtSituacao.BackColor = Color.White;
            txtSituacao.BorderStyle = BorderStyle.None;
            txtSituacao.Font = new Font("Arial", 12F);
            txtSituacao.ForeColor = Color.Black;
            txtSituacao.Location = new Point(82, 794);
            txtSituacao.Name = "txtSituacao";
            txtSituacao.ReadOnly = true;
            txtSituacao.Size = new Size(350, 23);
            txtSituacao.TabIndex = 16;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblCategoria.ForeColor = Color.DarkSeaGreen;
            lblCategoria.Location = new Point(539, 560);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(88, 23);
            lblCategoria.TabIndex = 29;
            lblCategoria.Text = "Categoria:";
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = Color.White;
            txtCategoria.BorderStyle = BorderStyle.None;
            txtCategoria.Font = new Font("Arial", 12F);
            txtCategoria.ForeColor = Color.Black;
            txtCategoria.Location = new Point(539, 584);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.ReadOnly = true;
            txtCategoria.Size = new Size(350, 23);
            txtCategoria.TabIndex = 18;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblIdade.ForeColor = Color.DarkSeaGreen;
            lblIdade.Location = new Point(539, 630);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(130, 23);
            lblIdade.TabIndex = 28;
            lblIdade.Text = "Idade estimada:";
            // 
            // txtIdade
            // 
            txtIdade.BackColor = Color.White;
            txtIdade.BorderStyle = BorderStyle.None;
            txtIdade.Font = new Font("Arial", 12F);
            txtIdade.ForeColor = Color.Black;
            txtIdade.Location = new Point(539, 654);
            txtIdade.Name = "txtIdade";
            txtIdade.ReadOnly = true;
            txtIdade.Size = new Size(350, 23);
            txtIdade.TabIndex = 20;
            // 
            // lblLocalResgate
            // 
            lblLocalResgate.AutoSize = true;
            lblLocalResgate.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblLocalResgate.ForeColor = Color.DarkSeaGreen;
            lblLocalResgate.Location = new Point(539, 700);
            lblLocalResgate.Name = "lblLocalResgate";
            lblLocalResgate.Size = new Size(142, 23);
            lblLocalResgate.TabIndex = 27;
            lblLocalResgate.Text = "Local do resgate:";
            // 
            // txtLocalResgate
            // 
            txtLocalResgate.BackColor = Color.White;
            txtLocalResgate.BorderStyle = BorderStyle.None;
            txtLocalResgate.Font = new Font("Arial", 12F);
            txtLocalResgate.ForeColor = Color.Black;
            txtLocalResgate.Location = new Point(539, 724);
            txtLocalResgate.Name = "txtLocalResgate";
            txtLocalResgate.ReadOnly = true;
            txtLocalResgate.Size = new Size(350, 23);
            txtLocalResgate.TabIndex = 22;
            // 
            // lblDataResgate
            // 
            lblDataResgate.AutoSize = true;
            lblDataResgate.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblDataResgate.ForeColor = Color.DarkSeaGreen;
            lblDataResgate.Location = new Point(539, 770);
            lblDataResgate.Name = "lblDataResgate";
            lblDataResgate.Size = new Size(134, 23);
            lblDataResgate.TabIndex = 26;
            lblDataResgate.Text = "Data do resgate:";
            // 
            // txtDataResgate
            // 
            txtDataResgate.BackColor = Color.White;
            txtDataResgate.BorderStyle = BorderStyle.None;
            txtDataResgate.Font = new Font("Arial", 12F);
            txtDataResgate.ForeColor = Color.Black;
            txtDataResgate.Location = new Point(539, 794);
            txtDataResgate.Name = "txtDataResgate";
            txtDataResgate.ReadOnly = true;
            txtDataResgate.Size = new Size(350, 23);
            txtDataResgate.TabIndex = 24;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.SeaShell;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnFechar.FlatAppearance.BorderSize = 2;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnFechar.ForeColor = Color.DarkSeaGreen;
            btnFechar.Location = new Point(384, 856);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(165, 40);
            btnFechar.TabIndex = 25;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.AllowUserToDeleteRows = false;
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.BackgroundColor = Color.White;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(82, 362);
            dgvResultados.MultiSelect = false;
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersVisible = false;
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultados.Size = new Size(807, 145);
            dgvResultados.TabIndex = 9;
            dgvResultados.CellClick += dgvResultados_CellClick;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblResultados.ForeColor = Color.DarkSeaGreen;
            lblResultados.Location = new Point(82, 335);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(198, 23);
            lblResultados.TabIndex = 27;
            lblResultados.Text = "Resultados da pesquisa:";
            // 
            // lblDetalhes
            // 
            lblDetalhes.AutoSize = true;
            lblDetalhes.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblDetalhes.ForeColor = Color.DarkSeaGreen;
            lblDetalhes.Location = new Point(82, 527);
            lblDetalhes.Name = "lblDetalhes";
            lblDetalhes.Size = new Size(308, 24);
            lblDetalhes.TabIndex = 26;
            lblDetalhes.Text = "Detalhes do animal selecionado";
            // 
            // formConsultarAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.SeaShell;
            ClientSize = new Size(982, 945);
            Controls.Add(btnFechar);
            Controls.Add(lblDetalhes);
            Controls.Add(lblResultados);
            Controls.Add(dgvResultados);
            Controls.Add(txtDataResgate);
            Controls.Add(lblDataResgate);
            Controls.Add(txtLocalResgate);
            Controls.Add(lblLocalResgate);
            Controls.Add(txtIdade);
            Controls.Add(lblIdade);
            Controls.Add(txtCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtSituacao);
            Controls.Add(lblSituacao);
            Controls.Add(txtSexo);
            Controls.Add(lblSexo);
            Controls.Add(txtEspecie);
            Controls.Add(lblEspecie);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscaNome);
            Controls.Add(lblBuscaNome);
            Controls.Add(lblRodape);
            Controls.Add(lblInstrucao);
            Controls.Add(lblPagina);
            Controls.Add(pnlCabecalho);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(1000, 800);
            Name = "formConsultarAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Refúgio - Consultar Animal";
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCabecalho;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblPagina;
        private Label lblInstrucao;
        private Label lblRodape;
        private Label lblBuscaNome;
        private TextBox txtBuscaNome;
        private DataGridView dgvResultados;
        private Label lblResultados;
        private Label lblDetalhes;
        private Button btnBuscar;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblEspecie;
        private TextBox txtEspecie;
        private Label lblSexo;
        private TextBox txtSexo;
        private Label lblSituacao;
        private TextBox txtSituacao;
        private Label lblCategoria;
        private TextBox txtCategoria;
        private Label lblIdade;
        private TextBox txtIdade;
        private Label lblLocalResgate;
        private TextBox txtLocalResgate;
        private Label lblDataResgate;
        private TextBox txtDataResgate;
        private Button btnFechar;
    }
}
