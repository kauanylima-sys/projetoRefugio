namespace refugio
{
    partial class formAtualizarAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAtualizarAnimal));
            pnlCabecalho = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            lblPagina = new Label();
            lblInstrucao = new Label();
            lblIdBusca = new Label();
            numIdBusca = new NumericUpDown();
            btnBuscar = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            lblEspecie = new Label();
            txtEspecie = new TextBox();
            lblSexo = new Label();
            cmbSexo = new ComboBox();
            lblIdade = new Label();
            numIdade = new NumericUpDown();
            chkIdadeNaoInformada = new CheckBox();
            lblSituacao = new Label();
            cmbSituacao = new ComboBox();
            lblLocalResgate = new Label();
            txtLocalResgate = new TextBox();
            lblDataResgate = new Label();
            dtpDataResgate = new DateTimePicker();
            btnCancelar = new Button();
            btnSalvar = new Button();
            label1 = new Label();
            pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdBusca).BeginInit();
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
            pictureBox2.Location = new Point(82, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 19.8F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(208, 30);
            label2.Name = "label2";
            label2.Size = new Size(168, 38);
            label2.TabIndex = 3;
            label2.Text = "REFÚGIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 11.2F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(208, 78);
            label3.Name = "label3";
            label3.Size = new Size(447, 23);
            label3.TabIndex = 4;
            label3.Text = "Sistema de Gerenciamento de Animais Resgatados";
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Font = new Font("Arial", 16F);
            lblPagina.ForeColor = Color.DarkSeaGreen;
            lblPagina.Location = new Point(101, 160);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(206, 32);
            lblPagina.TabIndex = 1;
            lblPagina.Text = "Atualizar animal";
            // 
            // lblInstrucao
            // 
            lblInstrucao.AutoSize = true;
            lblInstrucao.Font = new Font("Arial", 12F);
            lblInstrucao.ForeColor = Color.DarkSeaGreen;
            lblInstrucao.Location = new Point(101, 200);
            lblInstrucao.Name = "lblInstrucao";
            lblInstrucao.Size = new Size(497, 23);
            lblInstrucao.TabIndex = 2;
            lblInstrucao.Text = "Busque um cadastro pelo ID antes de alterar os dados:";
            // 
            // lblIdBusca
            // 
            lblIdBusca.AutoSize = true;
            lblIdBusca.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdBusca.ForeColor = Color.DarkSeaGreen;
            lblIdBusca.Location = new Point(101, 264);
            lblIdBusca.Name = "lblIdBusca";
            lblIdBusca.Size = new Size(125, 21);
            lblIdBusca.TabIndex = 35;
            lblIdBusca.Text = "ID do animal:";
            // 
            // numIdBusca
            // 
            numIdBusca.BackColor = Color.White;
            numIdBusca.BorderStyle = BorderStyle.None;
            numIdBusca.Font = new Font("Arial", 13F);
            numIdBusca.Location = new Point(101, 293);
            numIdBusca.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numIdBusca.Name = "numIdBusca";
            numIdBusca.Size = new Size(129, 28);
            numIdBusca.TabIndex = 7;
            numIdBusca.ValueChanged += numIdBusca_ValueChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkSeaGreen;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(247, 293);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(129, 30);
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
            lblNome.Location = new Point(91, 362);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(59, 23);
            lblNome.TabIndex = 34;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Arial", 12F);
            txtNome.ForeColor = Color.Black;
            txtNome.Location = new Point(91, 389);
            txtNome.MaxLength = 50;
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(350, 28);
            txtNome.TabIndex = 10;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblCategoria.ForeColor = Color.DarkSeaGreen;
            lblCategoria.Location = new Point(91, 445);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(88, 23);
            lblCategoria.TabIndex = 33;
            lblCategoria.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.White;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FlatStyle = FlatStyle.Flat;
            cmbCategoria.Font = new Font("Arial", 12F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(91, 472);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(350, 31);
            cmbCategoria.TabIndex = 12;
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblEspecie.ForeColor = Color.DarkSeaGreen;
            lblEspecie.Location = new Point(91, 528);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(75, 23);
            lblEspecie.TabIndex = 32;
            lblEspecie.Text = "Espécie:";
            // 
            // txtEspecie
            // 
            txtEspecie.BackColor = Color.White;
            txtEspecie.BorderStyle = BorderStyle.None;
            txtEspecie.Cursor = Cursors.IBeam;
            txtEspecie.Font = new Font("Arial", 12F);
            txtEspecie.ForeColor = Color.Black;
            txtEspecie.Location = new Point(91, 555);
            txtEspecie.MaxLength = 100;
            txtEspecie.Multiline = true;
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(350, 28);
            txtEspecie.TabIndex = 14;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblSexo.ForeColor = Color.DarkSeaGreen;
            lblSexo.Location = new Point(91, 611);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(53, 23);
            lblSexo.TabIndex = 31;
            lblSexo.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            cmbSexo.BackColor = Color.White;
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.FlatStyle = FlatStyle.Flat;
            cmbSexo.Font = new Font("Arial", 12F);
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(91, 638);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(350, 31);
            cmbSexo.TabIndex = 16;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblIdade.ForeColor = Color.DarkSeaGreen;
            lblIdade.Location = new Point(548, 362);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(130, 23);
            lblIdade.TabIndex = 30;
            lblIdade.Text = "Idade estimada:";
            // 
            // numIdade
            // 
            numIdade.BackColor = Color.White;
            numIdade.BorderStyle = BorderStyle.None;
            numIdade.Font = new Font("Arial", 12F);
            numIdade.Location = new Point(548, 389);
            numIdade.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numIdade.Name = "numIdade";
            numIdade.Size = new Size(350, 26);
            numIdade.TabIndex = 18;
            // 
            // chkIdadeNaoInformada
            // 
            chkIdadeNaoInformada.AutoSize = true;
            chkIdadeNaoInformada.Font = new Font("Arial", 9F);
            chkIdadeNaoInformada.ForeColor = Color.DarkSeaGreen;
            chkIdadeNaoInformada.Location = new Point(548, 419);
            chkIdadeNaoInformada.Name = "chkIdadeNaoInformada";
            chkIdadeNaoInformada.Size = new Size(162, 21);
            chkIdadeNaoInformada.TabIndex = 30;
            chkIdadeNaoInformada.Text = "Idade não informada";
            chkIdadeNaoInformada.Visible = false;
            chkIdadeNaoInformada.CheckedChanged += chkIdadeNaoInformada_CheckedChanged;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblSituacao.ForeColor = Color.DarkSeaGreen;
            lblSituacao.Location = new Point(548, 445);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(81, 23);
            lblSituacao.TabIndex = 29;
            lblSituacao.Text = "Situação:";
            // 
            // cmbSituacao
            // 
            cmbSituacao.BackColor = Color.White;
            cmbSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSituacao.FlatStyle = FlatStyle.Flat;
            cmbSituacao.Font = new Font("Arial", 12F);
            cmbSituacao.FormattingEnabled = true;
            cmbSituacao.Location = new Point(548, 472);
            cmbSituacao.Name = "cmbSituacao";
            cmbSituacao.Size = new Size(350, 31);
            cmbSituacao.TabIndex = 20;
            // 
            // lblLocalResgate
            // 
            lblLocalResgate.AutoSize = true;
            lblLocalResgate.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblLocalResgate.ForeColor = Color.DarkSeaGreen;
            lblLocalResgate.Location = new Point(548, 528);
            lblLocalResgate.Name = "lblLocalResgate";
            lblLocalResgate.Size = new Size(142, 23);
            lblLocalResgate.TabIndex = 28;
            lblLocalResgate.Text = "Local do resgate:";
            // 
            // txtLocalResgate
            // 
            txtLocalResgate.BackColor = Color.White;
            txtLocalResgate.BorderStyle = BorderStyle.None;
            txtLocalResgate.Cursor = Cursors.IBeam;
            txtLocalResgate.Font = new Font("Arial", 12F);
            txtLocalResgate.ForeColor = Color.Black;
            txtLocalResgate.Location = new Point(548, 555);
            txtLocalResgate.MaxLength = 100;
            txtLocalResgate.Multiline = true;
            txtLocalResgate.Name = "txtLocalResgate";
            txtLocalResgate.Size = new Size(350, 28);
            txtLocalResgate.TabIndex = 22;
            // 
            // lblDataResgate
            // 
            lblDataResgate.AutoSize = true;
            lblDataResgate.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblDataResgate.ForeColor = Color.DarkSeaGreen;
            lblDataResgate.Location = new Point(548, 611);
            lblDataResgate.Name = "lblDataResgate";
            lblDataResgate.Size = new Size(134, 23);
            lblDataResgate.TabIndex = 27;
            lblDataResgate.Text = "Data do resgate:";
            // 
            // dtpDataResgate
            // 
            dtpDataResgate.CalendarForeColor = Color.DarkSeaGreen;
            dtpDataResgate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDataResgate.Font = new Font("Arial", 12F);
            dtpDataResgate.Format = DateTimePickerFormat.Short;
            dtpDataResgate.Location = new Point(548, 638);
            dtpDataResgate.Name = "dtpDataResgate";
            dtpDataResgate.Size = new Size(350, 30);
            dtpDataResgate.TabIndex = 24;
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
            btnCancelar.Location = new Point(324, 735);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(165, 40);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Fechar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DarkSeaGreen;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Enabled = false;
            btnSalvar.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnSalvar.FlatAppearance.BorderSize = 2;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(504, 735);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(165, 40);
            btnSalvar.TabIndex = 26;
            btnSalvar.Text = "Salvar alterações";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(388, 804);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 91;
            label1.Text = "Refúgio • Projeto Acadêmico";
            // 
            // formAtualizarAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.SeaShell;
            ClientSize = new Size(982, 853);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(dtpDataResgate);
            Controls.Add(lblDataResgate);
            Controls.Add(txtLocalResgate);
            Controls.Add(lblLocalResgate);
            Controls.Add(cmbSituacao);
            Controls.Add(lblSituacao);
            Controls.Add(chkIdadeNaoInformada);
            Controls.Add(numIdade);
            Controls.Add(lblIdade);
            Controls.Add(cmbSexo);
            Controls.Add(lblSexo);
            Controls.Add(txtEspecie);
            Controls.Add(lblEspecie);
            Controls.Add(cmbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnBuscar);
            Controls.Add(numIdBusca);
            Controls.Add(lblIdBusca);
            Controls.Add(lblInstrucao);
            Controls.Add(lblPagina);
            Controls.Add(pnlCabecalho);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(1000, 900);
            Name = "formAtualizarAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Refúgio - Atualizar Animal";
            Load += formAtualizarAnimal_Load;
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdBusca).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCabecalho;
        private Label lblPagina;
        private Label lblInstrucao;
        private Label lblIdBusca;
        private NumericUpDown numIdBusca;
        private Button btnBuscar;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Label lblEspecie;
        private TextBox txtEspecie;
        private Label lblSexo;
        private ComboBox cmbSexo;
        private Label lblIdade;
        private NumericUpDown numIdade;
        private CheckBox chkIdadeNaoInformada;
        private Label lblSituacao;
        private ComboBox cmbSituacao;
        private Label lblLocalResgate;
        private TextBox txtLocalResgate;
        private Label lblDataResgate;
        private DateTimePicker dtpDataResgate;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
    }
}
