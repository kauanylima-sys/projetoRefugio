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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formListarAnimais));
            pnlCabecalho = new Panel();
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
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimais).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.DarkSeaGreen;
            pnlCabecalho.Controls.Add(pictureBox2);
            pnlCabecalho.Controls.Add(label2);
            pnlCabecalho.Controls.Add(label3);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(982, 132);
            pnlCabecalho.TabIndex = 0;
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
            lblRodape.Location = new Point(392, 808);
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
            lblFiltro.Location = new Point(81, 253);
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
            txtFiltro.Location = new Point(81, 282);
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
            btnBuscar.Size = new Size(125, 30);
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
            btnAtualizarLista.Size = new Size(172, 30);
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
            dgvAnimais.Location = new Point(81, 333);
            dgvAnimais.MultiSelect = false;
            dgvAnimais.Name = "dgvAnimais";
            dgvAnimais.ReadOnly = true;
            dgvAnimais.RowHeadersVisible = false;
            dgvAnimais.RowHeadersWidth = 51;
            dgvAnimais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimais.Size = new Size(806, 358);
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
            btnFechar.Location = new Point(504, 741);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(168, 48);
            btnFechar.TabIndex = 11;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.SeaShell;
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnExcluir.FlatAppearance.BorderSize = 2;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.DarkSeaGreen;
            btnExcluir.Location = new Point(320, 741);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(168, 48);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir animal";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(81, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 19.8F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(210, 30);
            label2.Name = "label2";
            label2.Size = new Size(168, 38);
            label2.TabIndex = 6;
            label2.Text = "REFÚGIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 11.2F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(210, 78);
            label3.Name = "label3";
            label3.Size = new Size(447, 23);
            label3.TabIndex = 7;
            label3.Text = "Sistema de Gerenciamento de Animais Resgatados";
            // 
            // formListarAnimais
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(982, 853);
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
            MinimumSize = new Size(1000, 800);
            Name = "formListarAnimais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Refúgio - Lista de Animais";
            Load += formListarAnimais_Load;
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimais).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCabecalho;
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
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
    }
}
