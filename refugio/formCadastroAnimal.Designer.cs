namespace refugio
{
    partial class formCadastroAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastroAnimal));
            pnlCabecalho = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            lblPagina = new Label();
            lblInstrucao = new Label();
            lblRodape = new Label();
            lblNome = new Label();
            lblCategoria = new Label();
            lblEspecie = new Label();
            lblSexo = new Label();
            lblIdade = new Label();
            lblSituacao = new Label();
            lblLocalResgate = new Label();
            lblDataResgate = new Label();
            txtNome = new TextBox();
            cmbCategoria = new ComboBox();
            txtEspecie = new TextBox();
            cmbSexo = new ComboBox();
            numIdade = new NumericUpDown();
            cmbSituacao = new ComboBox();
            txtLocalResgate = new TextBox();
            dtpDataResgate = new DateTimePicker();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnAddCategoria = new Button();
            pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdade).BeginInit();
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(85, 0);
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
            label2.Location = new Point(211, 30);
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
            label3.Location = new Point(211, 78);
            label3.Name = "label3";
            label3.Size = new Size(447, 23);
            label3.TabIndex = 92;
            label3.Text = "Sistema de Gerenciamento de Animais Resgatados";
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Font = new Font("Arial", 16F);
            lblPagina.ForeColor = Color.DarkSeaGreen;
            lblPagina.Location = new Point(82, 160);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(221, 32);
            lblPagina.TabIndex = 1;
            lblPagina.Text = "Cadastrar animal";
            // 
            // lblInstrucao
            // 
            lblInstrucao.AutoSize = true;
            lblInstrucao.Font = new Font("Arial", 12F);
            lblInstrucao.ForeColor = Color.DarkSeaGreen;
            lblInstrucao.Location = new Point(85, 200);
            lblInstrucao.Name = "lblInstrucao";
            lblInstrucao.Size = new Size(424, 23);
            lblInstrucao.TabIndex = 2;
            lblInstrucao.Text = "Preencha as informações do animal resgatado:";
            // 
            // lblRodape
            // 
            lblRodape.AutoSize = true;
            lblRodape.Font = new Font("Segoe UI", 9F);
            lblRodape.ForeColor = Color.Gray;
            lblRodape.Location = new Point(396, 717);
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(202, 20);
            lblRodape.TabIndex = 90;
            lblRodape.Text = "Refúgio • Projeto Acadêmico";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblNome.ForeColor = Color.DarkSeaGreen;
            lblNome.Location = new Point(82, 258);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(59, 23);
            lblNome.TabIndex = 31;
            lblNome.Text = "Nome:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblCategoria.ForeColor = Color.DarkSeaGreen;
            lblCategoria.Location = new Point(82, 342);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(88, 23);
            lblCategoria.TabIndex = 30;
            lblCategoria.Text = "Categoria:";
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblEspecie.ForeColor = Color.DarkSeaGreen;
            lblEspecie.Location = new Point(82, 426);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(75, 23);
            lblEspecie.TabIndex = 29;
            lblEspecie.Text = "Espécie:";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblSexo.ForeColor = Color.DarkSeaGreen;
            lblSexo.Location = new Point(82, 510);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(53, 23);
            lblSexo.TabIndex = 28;
            lblSexo.Text = "Sexo:";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblIdade.ForeColor = Color.DarkSeaGreen;
            lblIdade.Location = new Point(539, 258);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(130, 23);
            lblIdade.TabIndex = 27;
            lblIdade.Text = "Idade estimada:";
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblSituacao.ForeColor = Color.DarkSeaGreen;
            lblSituacao.Location = new Point(539, 342);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(81, 23);
            lblSituacao.TabIndex = 26;
            lblSituacao.Text = "Situação:";
            // 
            // lblLocalResgate
            // 
            lblLocalResgate.AutoSize = true;
            lblLocalResgate.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblLocalResgate.ForeColor = Color.DarkSeaGreen;
            lblLocalResgate.Location = new Point(539, 426);
            lblLocalResgate.Name = "lblLocalResgate";
            lblLocalResgate.Size = new Size(142, 23);
            lblLocalResgate.TabIndex = 25;
            lblLocalResgate.Text = "Local do resgate:";
            // 
            // lblDataResgate
            // 
            lblDataResgate.AutoSize = true;
            lblDataResgate.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblDataResgate.ForeColor = Color.DarkSeaGreen;
            lblDataResgate.Location = new Point(539, 510);
            lblDataResgate.Name = "lblDataResgate";
            lblDataResgate.Size = new Size(134, 23);
            lblDataResgate.TabIndex = 24;
            lblDataResgate.Text = "Data do resgate:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Arial", 12F);
            txtNome.ForeColor = Color.Black;
            txtNome.Location = new Point(82, 286);
            txtNome.MaxLength = 50;
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(350, 28);
            txtNome.TabIndex = 14;
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.White;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FlatStyle = FlatStyle.Flat;
            cmbCategoria.Font = new Font("Arial", 12F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(82, 370);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(350, 31);
            cmbCategoria.TabIndex = 15;
            // 
            // txtEspecie
            // 
            txtEspecie.BackColor = Color.White;
            txtEspecie.BorderStyle = BorderStyle.None;
            txtEspecie.Font = new Font("Arial", 12F);
            txtEspecie.ForeColor = Color.Black;
            txtEspecie.Location = new Point(82, 454);
            txtEspecie.MaxLength = 100;
            txtEspecie.Multiline = true;
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(350, 28);
            txtEspecie.TabIndex = 16;
            // 
            // cmbSexo
            // 
            cmbSexo.BackColor = Color.White;
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.FlatStyle = FlatStyle.Flat;
            cmbSexo.Font = new Font("Arial", 13F);
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(82, 538);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(350, 33);
            cmbSexo.TabIndex = 17;
            // 
            // numIdade
            // 
            numIdade.BackColor = Color.White;
            numIdade.BorderStyle = BorderStyle.None;
            numIdade.Font = new Font("Arial", 13F);
            numIdade.Location = new Point(539, 286);
            numIdade.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numIdade.Name = "numIdade";
            numIdade.Size = new Size(350, 28);
            numIdade.TabIndex = 18;
            // 
            // cmbSituacao
            // 
            cmbSituacao.BackColor = Color.White;
            cmbSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSituacao.FlatStyle = FlatStyle.Flat;
            cmbSituacao.Font = new Font("Arial", 12F);
            cmbSituacao.FormattingEnabled = true;
            cmbSituacao.Location = new Point(539, 370);
            cmbSituacao.Name = "cmbSituacao";
            cmbSituacao.Size = new Size(350, 31);
            cmbSituacao.TabIndex = 19;
            // 
            // txtLocalResgate
            // 
            txtLocalResgate.BackColor = Color.White;
            txtLocalResgate.BorderStyle = BorderStyle.None;
            txtLocalResgate.Font = new Font("Arial", 12F);
            txtLocalResgate.ForeColor = Color.Black;
            txtLocalResgate.Location = new Point(539, 454);
            txtLocalResgate.MaxLength = 100;
            txtLocalResgate.Multiline = true;
            txtLocalResgate.Name = "txtLocalResgate";
            txtLocalResgate.Size = new Size(350, 28);
            txtLocalResgate.TabIndex = 20;
            // 
            // dtpDataResgate
            // 
            dtpDataResgate.CalendarFont = new Font("Arial", 13F);
            dtpDataResgate.CalendarForeColor = Color.DarkSeaGreen;
            dtpDataResgate.CalendarTitleForeColor = SystemColors.ButtonShadow;
            dtpDataResgate.CustomFormat = "dd/MM/yyyy";
            dtpDataResgate.Font = new Font("Arial", 13F);
            dtpDataResgate.Format = DateTimePickerFormat.Short;
            dtpDataResgate.Location = new Point(539, 538);
            dtpDataResgate.Name = "dtpDataResgate";
            dtpDataResgate.Size = new Size(350, 32);
            dtpDataResgate.TabIndex = 21;
            dtpDataResgate.Value = new DateTime(2026, 11, 21, 0, 0, 0, 0);
            dtpDataResgate.ValueChanged += dtpDataResgate_ValueChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.SeaShell;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnCancelar.FlatAppearance.BorderSize = 2;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.DarkSeaGreen;
            btnCancelar.Location = new Point(323, 627);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(165, 40);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DarkSeaGreen;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnSalvar.FlatAppearance.BorderSize = 2;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(503, 627);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(165, 40);
            btnSalvar.TabIndex = 23;
            btnSalvar.Text = "Cadastrar animal";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAddCategoria
            // 
            btnAddCategoria.BackColor = Color.DarkSeaGreen;
            btnAddCategoria.Cursor = Cursors.Hand;
            btnAddCategoria.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnAddCategoria.FlatAppearance.BorderSize = 2;
            btnAddCategoria.FlatStyle = FlatStyle.Flat;
            btnAddCategoria.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnAddCategoria.ForeColor = Color.White;
            btnAddCategoria.Location = new Point(440, 370);
            btnAddCategoria.Name = "btnAddCategoria";
            btnAddCategoria.Size = new Size(40, 31);
            btnAddCategoria.TabIndex = 24;
            btnAddCategoria.Text = "+";
            btnAddCategoria.UseVisualStyleBackColor = false;
            btnAddCategoria.Click += btnAddCategoria_Click;
            // 
            // formCadastroAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(982, 753);
            Controls.Add(btnAddCategoria);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(dtpDataResgate);
            Controls.Add(txtLocalResgate);
            Controls.Add(cmbSituacao);
            Controls.Add(numIdade);
            Controls.Add(cmbSexo);
            Controls.Add(txtEspecie);
            Controls.Add(cmbCategoria);
            Controls.Add(txtNome);
            Controls.Add(lblDataResgate);
            Controls.Add(lblLocalResgate);
            Controls.Add(lblSituacao);
            Controls.Add(lblIdade);
            Controls.Add(lblSexo);
            Controls.Add(lblEspecie);
            Controls.Add(lblCategoria);
            Controls.Add(lblNome);
            Controls.Add(lblRodape);
            Controls.Add(lblInstrucao);
            Controls.Add(lblPagina);
            Controls.Add(pnlCabecalho);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(1000, 794);
            Name = "formCadastroAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Refúgio - Cadastro de Animais";
            Load += formCadastroAnimal_Load;
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCabecalho;
        private Label lblPagina;
        private Label lblInstrucao;
        private Label lblRodape;
        private Label lblNome;
        private Label lblCategoria;
        private Label lblEspecie;
        private Label lblSexo;
        private Label lblIdade;
        private Label lblSituacao;
        private Label lblLocalResgate;
        private Label lblDataResgate;
        private TextBox txtNome;
        private ComboBox cmbCategoria;
        private TextBox txtEspecie;
        private ComboBox cmbSexo;
        private NumericUpDown numIdade;
        private ComboBox cmbSituacao;
        private TextBox txtLocalResgate;
        private DateTimePicker dtpDataResgate;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnAddCategoria;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
    }
}
