namespace refugio
{
    partial class formListarAnimais
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
            lblFiltro = new Label();
            txtFiltro = new TextBox();
            btnBuscar = new Button();
            btnAtualizarLista = new Button();
            dgvAnimais = new DataGridView();
            btnFechar = new Button();
            btnExcluir = new Button();
            pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimais).BeginInit();
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
            lblPagina.Location = new Point(81, 157);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(272, 33);
            lblPagina.TabIndex = 1;
            lblPagina.Text = "Animais resgatados";
            // 
            // lblInstrucao
            // 
            lblInstrucao.AutoSize = true;
            lblInstrucao.Font = new Font("Arial", 11F);
            lblInstrucao.ForeColor = Color.DarkSeaGreen;
            lblInstrucao.Location = new Point(81, 205);
            lblInstrucao.Name = "lblInstrucao";
            lblInstrucao.Size = new Size(391, 22);
            lblInstrucao.TabIndex = 2;
            lblInstrucao.Text = "Consulte os animais cadastrados no sistema:";
            // 
            // lblRodape
            // 
            lblRodape.AutoSize = true;
            lblRodape.Font = new Font("Segoe UI", 9F);
            lblRodape.ForeColor = Color.Gray;
            lblRodape.Location = new Point(81, 715);
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(202, 20);
            lblRodape.TabIndex = 90;
            lblRodape.Text = "Refúgio • Projeto Acadêmico";
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblFiltro.ForeColor = Color.DarkSeaGreen;
            lblFiltro.Location = new Point(81, 257);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(233, 23);
            lblFiltro.TabIndex = 12;
            lblFiltro.Text = "Buscar por nome ou espécie:";
            // 
            // txtFiltro
            // 
            txtFiltro.BackColor = Color.White;
            txtFiltro.BorderStyle = BorderStyle.None;
            txtFiltro.Font = new Font("Arial", 12F);
            txtFiltro.ForeColor = Color.Black;
            txtFiltro.Location = new Point(81, 286);
            txtFiltro.MaxLength = 100;
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(480, 23);
            txtFiltro.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkSeaGreen;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnBuscar.FlatAppearance.BorderSize = 2;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(575, 279);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 46);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAtualizarLista
            // 
            btnAtualizarLista.BackColor = Color.SeaShell;
            btnAtualizarLista.Cursor = Cursors.Hand;
            btnAtualizarLista.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnAtualizarLista.FlatAppearance.BorderSize = 2;
            btnAtualizarLista.FlatStyle = FlatStyle.Flat;
            btnAtualizarLista.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnAtualizarLista.ForeColor = Color.DarkSeaGreen;
            btnAtualizarLista.Location = new Point(715, 279);
            btnAtualizarLista.Name = "btnAtualizarLista";
            btnAtualizarLista.Size = new Size(172, 46);
            btnAtualizarLista.TabIndex = 9;
            btnAtualizarLista.Text = "Atualizar lista";
            btnAtualizarLista.UseVisualStyleBackColor = false;
            btnAtualizarLista.Click += btnAtualizarLista_Click;
            // 
            // dgvAnimais
            // 
            dgvAnimais.AllowUserToAddRows = false;
            dgvAnimais.AllowUserToDeleteRows = false;
            dgvAnimais.AllowUserToResizeRows = false;
            dgvAnimais.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAnimais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvAnimais.BackgroundColor = Color.White;
            dgvAnimais.BorderStyle = BorderStyle.None;
            dgvAnimais.ColumnHeadersHeight = 29;
            dgvAnimais.Location = new Point(81, 347);
            dgvAnimais.MultiSelect = false;
            dgvAnimais.Name = "dgvAnimais";
            dgvAnimais.ReadOnly = true;
            dgvAnimais.RowHeadersVisible = false;
            dgvAnimais.RowHeadersWidth = 51;
            dgvAnimais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimais.Size = new Size(806, 306);
            dgvAnimais.TabIndex = 10;
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
            btnFechar.Location = new Point(719, 672);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(168, 48);
            btnFechar.TabIndex = 11;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.SeaShell;
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnExcluir.FlatAppearance.BorderSize = 2;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.DarkSeaGreen;
            btnExcluir.Location = new Point(535, 672);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(168, 48);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir animal";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // formListarAnimais
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(982, 755);
            Controls.Add(btnExcluir);
            Controls.Add(btnFechar);
            Controls.Add(dgvAnimais);
            Controls.Add(btnAtualizarLista);
            Controls.Add(btnBuscar);
            Controls.Add(txtFiltro);
            Controls.Add(lblFiltro);
            Controls.Add(lblRodape);
            Controls.Add(lblInstrucao);
            Controls.Add(lblPagina);
            Controls.Add(pnlCabecalho);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(1000, 794);
            Name = "formListarAnimais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Refúgio - Lista de Animais";
            Load += formListarAnimais_Load;
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimais).EndInit();
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
        private Label lblFiltro;
        private TextBox txtFiltro;
        private Button btnBuscar;
        private Button btnAtualizarLista;
        private DataGridView dgvAnimais;
        private Button btnFechar;
        private Button btnExcluir;
    }
}
