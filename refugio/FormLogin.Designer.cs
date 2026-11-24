namespace refugio
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pnlCabecalho = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblNomeLogin = new Label();
            txtSenhaLogin = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            btnSair = new Button();
            txtUserLogin = new TextBox();
            lblRodape = new Label();
            label5 = new Label();
            lblPagina = new Label();
            label4 = new Label();
            pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.DarkSeaGreen;
            pnlCabecalho.Controls.Add(pictureBox2);
            pnlCabecalho.Controls.Add(label1);
            pnlCabecalho.Controls.Add(label2);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(882, 132);
            pnlCabecalho.TabIndex = 4;
            pnlCabecalho.Paint += pnlCabecalho_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(56, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 19.8F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(182, 30);
            label1.Name = "label1";
            label1.Size = new Size(168, 38);
            label1.TabIndex = 0;
            label1.Text = "REFÚGIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 11.2F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(182, 78);
            label2.Name = "label2";
            label2.Size = new Size(447, 23);
            label2.TabIndex = 1;
            label2.Text = "Sistema de Gerenciamento de Animais Resgatados";
            // 
            // lblNomeLogin
            // 
            lblNomeLogin.AutoSize = true;
            lblNomeLogin.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            lblNomeLogin.ForeColor = Color.DarkSeaGreen;
            lblNomeLogin.Location = new Point(256, 309);
            lblNomeLogin.Name = "lblNomeLogin";
            lblNomeLogin.Size = new Size(222, 23);
            lblNomeLogin.TabIndex = 34;
            lblNomeLogin.Text = "Digite seu nome de usuário:";
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.BackColor = Color.White;
            txtSenhaLogin.BorderStyle = BorderStyle.None;
            txtSenhaLogin.Font = new Font("Arial", 12F);
            txtSenhaLogin.ForeColor = Color.Black;
            txtSenhaLogin.Location = new Point(256, 411);
            txtSenhaLogin.MaxLength = 50;
            txtSenhaLogin.Multiline = true;
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(350, 28);
            txtSenhaLogin.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            label3.ForeColor = Color.DarkSeaGreen;
            label3.Location = new Point(256, 383);
            label3.Name = "label3";
            label3.Size = new Size(141, 23);
            label3.TabIndex = 36;
            label3.Text = "Digite sua senha:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkSeaGreen;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnLogin.FlatAppearance.BorderSize = 2;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(441, 513);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(165, 40);
            btnLogin.TabIndex = 38;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.SeaShell;
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnSair.FlatAppearance.BorderSize = 2;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnSair.ForeColor = Color.DarkSeaGreen;
            btnSair.Location = new Point(261, 513);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(165, 40);
            btnSair.TabIndex = 37;
            btnSair.Text = "Cancelar";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // txtUserLogin
            // 
            txtUserLogin.BackColor = Color.White;
            txtUserLogin.BorderStyle = BorderStyle.None;
            txtUserLogin.Font = new Font("Arial", 12F);
            txtUserLogin.ForeColor = Color.Black;
            txtUserLogin.Location = new Point(256, 347);
            txtUserLogin.MaxLength = 50;
            txtUserLogin.Multiline = true;
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.Size = new Size(350, 28);
            txtUserLogin.TabIndex = 39;
            // 
            // lblRodape
            // 
            lblRodape.AutoSize = true;
            lblRodape.Font = new Font("Segoe UI", 9F);
            lblRodape.ForeColor = Color.Gray;
            lblRodape.Location = new Point(400, 700);
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(202, 20);
            lblRodape.TabIndex = 40;
            lblRodape.Text = "Refúgio • Projeto Acadêmico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.ForeColor = Color.DarkSeaGreen;
            label5.Location = new Point(56, 202);
            label5.Name = "label5";
            label5.Size = new Size(444, 23);
            label5.TabIndex = 44;
            label5.Text = "Entre com as suas credênciais únicas de acesso:";
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Font = new Font("Arial", 16F);
            lblPagina.ForeColor = Color.DarkSeaGreen;
            lblPagina.Location = new Point(56, 157);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(277, 32);
            lblPagina.TabIndex = 43;
            lblPagina.Text = "Bem vindo ao refúgio!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(351, 599);
            label4.Name = "label4";
            label4.Size = new Size(202, 20);
            label4.TabIndex = 91;
            label4.Text = "Refúgio • Projeto Acadêmico";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(882, 653);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lblPagina);
            Controls.Add(lblRodape);
            Controls.Add(txtUserLogin);
            Controls.Add(btnLogin);
            Controls.Add(btnSair);
            Controls.Add(txtSenhaLogin);
            Controls.Add(label3);
            Controls.Add(lblNomeLogin);
            Controls.Add(pnlCabecalho);
            Name = "FormLogin";
            Text = "Refúgio - Login";
            Load += FormLogin_Load;
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCabecalho;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private Label lblNomeLogin;
        private TextBox txtSenhaLogin;
        private Label label3;
        private Button btnLogin;
        private Button btnSair;
        private PictureBox pictureBox1;
        private TextBox txtUserLogin;
        private PictureBox pictureBox2;
        private Label lblRodape;
        private Label label5;
        private Label lblPagina;
        private Label label4;
    }
}