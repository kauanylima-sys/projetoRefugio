namespace refugio
{
    partial class formPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnCadastrar = new Button();
            lblRodape = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlCabecalho = new Panel();
            label1 = new Label();
            label2 = new Label();
            btnAtualizar = new Button();
            btnConsultar = new Button();
            btnListar = new Button();
            pnlCabecalho.SuspendLayout();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.SeaShell;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.BorderSize = 2;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.DarkSeaGreen;
            btnCadastrar.Location = new Point(81, 289);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.RightToLeft = RightToLeft.No;
            btnCadastrar.Size = new Size(383, 130);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar Animal";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblRodape
            // 
            lblRodape.AutoSize = true;
            lblRodape.Font = new Font("Segoe UI", 9F);
            lblRodape.ForeColor = Color.Gray;
            lblRodape.Location = new Point(410, 624);
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(202, 20);
            lblRodape.TabIndex = 0;
            lblRodape.Text = "Refúgio • Projeto Acadêmico";
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
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Georgia", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(160, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(172, 39);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REFÚGIO";
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.DarkSeaGreen;
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Controls.Add(lblSubtitulo);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Font = new Font("Georgia", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Margin = new Padding(0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(982, 132);
            pnlCabecalho.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSeaGreen;
            label1.Location = new Point(82, 160);
            label1.Name = "label1";
            label1.Size = new Size(284, 32);
            label1.TabIndex = 2;
            label1.Text = "Bem vindo ao refúgio!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSeaGreen;
            label2.Location = new Point(85, 200);
            label2.Name = "label2";
            label2.Size = new Size(335, 23);
            label2.TabIndex = 3;
            label2.Text = "Selecione uma opção para continuar:";
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.SeaShell;
            btnAtualizar.Cursor = Cursors.Hand;
            btnAtualizar.FlatAppearance.BorderSize = 2;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.ForeColor = Color.DarkSeaGreen;
            btnAtualizar.Location = new Point(81, 463);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.RightToLeft = RightToLeft.No;
            btnAtualizar.Size = new Size(383, 130);
            btnAtualizar.TabIndex = 10;
            btnAtualizar.Text = "Atualizar Animal";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.SeaShell;
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.FlatAppearance.BorderSize = 2;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = Color.DarkSeaGreen;
            btnConsultar.Location = new Point(521, 289);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.RightToLeft = RightToLeft.No;
            btnConsultar.Size = new Size(383, 130);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar Animal";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.SeaShell;
            btnListar.Cursor = Cursors.Hand;
            btnListar.FlatAppearance.BorderSize = 2;
            btnListar.FlatStyle = FlatStyle.Flat;
            btnListar.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListar.ForeColor = Color.DarkSeaGreen;
            btnListar.Location = new Point(521, 463);
            btnListar.Name = "btnListar";
            btnListar.RightToLeft = RightToLeft.No;
            btnListar.Size = new Size(383, 130);
            btnListar.TabIndex = 12;
            btnListar.Text = "Listar Animais";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // formPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(982, 653);
            Controls.Add(btnListar);
            Controls.Add(btnConsultar);
            Controls.Add(btnAtualizar);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblRodape);
            Controls.Add(btnCadastrar);
            Controls.Add(pnlCabecalho);
            MinimumSize = new Size(900, 600);
            Name = "formPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Refúgio - Gerenciamento de Animais";
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblRodape;

        private Button btnCadastrar;
        private Label lblSubtitulo;
        private Label lblTitulo;
        private Panel pnlCabecalho;
        private Label label1;
        private Label label2;
        private Button btnAtualizar;
        private Button btnConsultar;
        private Button btnListar;
    }
}
