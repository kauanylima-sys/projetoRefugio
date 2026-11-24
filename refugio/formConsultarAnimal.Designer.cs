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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConsultarAnimal));
            pnlCabecalho = new Panel();
            lblPagina = new Label();
            lblInstrucao = new Label();
            lblRodape = new Label();
            lblBuscaNome = new Label();
            txtBuscaNome = new TextBox();
            btnBuscar = new Button();
            lblSexo = new Label();
            txtSexo = new TextBox();
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
            lblNome = new Label();
            txtNome = new TextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
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
            lblRodape.Location = new Point(390, 822);
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
            txtBuscaNome.BorderStyle = BorderStyle.None;
            txtBuscaNome.Cursor = Cursors.IBeam;
            txtBuscaNome.Font = new Font("Arial", 12F);
            txtBuscaNome.Location = new Point(82, 284);
            txtBuscaNome.MaxLength = 50;
            txtBuscaNome.Name = "txtBuscaNome";
            txtBuscaNome.Size = new Size(350, 23);
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
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblSexo.ForeColor = Color.DarkSeaGreen;
            lblSexo.Location = new Point(82, 616);
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
            txtSexo.Location = new Point(82, 640);
            txtSexo.Name = "txtSexo";
            txtSexo.ReadOnly = true;
            txtSexo.Size = new Size(350, 23);
            txtSexo.TabIndex = 14;
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
            lblIdade.Location = new Point(82, 676);
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
            txtIdade.Location = new Point(82, 700);
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
            lblLocalResgate.Location = new Point(539, 616);
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
            txtLocalResgate.Location = new Point(539, 640);
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
            lblDataResgate.Location = new Point(539, 676);
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
            txtDataResgate.Location = new Point(539, 700);
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
            btnFechar.Location = new Point(408, 766);
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
            dgvResultados.BorderStyle = BorderStyle.None;
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(92, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 93;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 19.8F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(218, 30);
            label2.Name = "label2";
            label2.Size = new Size(168, 38);
            label2.TabIndex = 91;
            label2.Text = "REFÚGIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 11.2F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(218, 78);
            label3.Name = "label3";
            label3.Size = new Size(447, 23);
            label3.TabIndex = 92;
            label3.Text = "Sistema de Gerenciamento de Animais Resgatados";
            // 
            // formConsultarAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.SeaShell;
            ClientSize = new Size(982, 853);
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
            Controls.Add(txtSexo);
            Controls.Add(lblSexo);
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
            MinimumSize = new Size(1000, 900);
            Name = "formConsultarAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Refúgio - Consultar Animal";
            Load += formConsultarAnimal_Load;
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCabecalho;
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
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
    }
}
