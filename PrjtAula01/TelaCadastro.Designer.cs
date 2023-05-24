namespace PrjtAula01
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            nome = new TextBox();
            cpf = new TextBox();
            rg = new TextBox();
            celular = new TextBox();
            email = new TextBox();
            dataNascimento = new TextBox();
            renda = new TextBox();
            logradouro = new TextBox();
            genero = new TextBox();
            confirmarSenha = new TextBox();
            criarSenha = new TextBox();
            pictureBox1 = new PictureBox();
            criarAcesso = new Button();
            voltarLoginCadastro = new Button();
            lblinserirCadastro = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nome
            // 
            nome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nome.Location = new Point(133, 107);
            nome.Name = "nome";
            nome.PlaceholderText = "Nome Completo";
            nome.Size = new Size(300, 29);
            nome.TabIndex = 0;
            nome.TextAlign = HorizontalAlignment.Center;
            // 
            // cpf
            // 
            cpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cpf.Location = new Point(133, 159);
            cpf.Name = "cpf";
            cpf.PlaceholderText = "000.000.000-00";
            cpf.Size = new Size(300, 29);
            cpf.TabIndex = 1;
            cpf.TextAlign = HorizontalAlignment.Center;
            // 
            // rg
            // 
            rg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rg.Location = new Point(133, 212);
            rg.Name = "rg";
            rg.PlaceholderText = "00.000.000-0";
            rg.Size = new Size(300, 29);
            rg.TabIndex = 2;
            rg.TextAlign = HorizontalAlignment.Center;
            // 
            // celular
            // 
            celular.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            celular.Location = new Point(133, 265);
            celular.Name = "celular";
            celular.PlaceholderText = "Celular";
            celular.Size = new Size(300, 29);
            celular.TabIndex = 3;
            celular.TextAlign = HorizontalAlignment.Center;
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(133, 316);
            email.Name = "email";
            email.PlaceholderText = "email@email.com";
            email.Size = new Size(300, 29);
            email.TabIndex = 4;
            email.TextAlign = HorizontalAlignment.Center;
            // 
            // dataNascimento
            // 
            dataNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataNascimento.Location = new Point(133, 367);
            dataNascimento.Name = "dataNascimento";
            dataNascimento.PlaceholderText = "Data de Nascimento";
            dataNascimento.Size = new Size(300, 29);
            dataNascimento.TabIndex = 5;
            dataNascimento.TextAlign = HorizontalAlignment.Center;
            // 
            // renda
            // 
            renda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            renda.Location = new Point(133, 520);
            renda.Name = "renda";
            renda.PlaceholderText = "Renda Mensal";
            renda.Size = new Size(300, 29);
            renda.TabIndex = 8;
            renda.TextAlign = HorizontalAlignment.Center;
            // 
            // logradouro
            // 
            logradouro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logradouro.Location = new Point(133, 469);
            logradouro.Name = "logradouro";
            logradouro.PlaceholderText = "Endereço Completo";
            logradouro.Size = new Size(300, 29);
            logradouro.TabIndex = 7;
            logradouro.TextAlign = HorizontalAlignment.Center;
            // 
            // genero
            // 
            genero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            genero.Location = new Point(133, 418);
            genero.Name = "genero";
            genero.PlaceholderText = "Gênero";
            genero.Size = new Size(300, 29);
            genero.TabIndex = 6;
            genero.TextAlign = HorizontalAlignment.Center;
            // 
            // confirmarSenha
            // 
            confirmarSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmarSenha.Location = new Point(794, 158);
            confirmarSenha.Name = "confirmarSenha";
            confirmarSenha.PlaceholderText = "Confirme sua senha";
            confirmarSenha.Size = new Size(300, 29);
            confirmarSenha.TabIndex = 10;
            confirmarSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // criarSenha
            // 
            criarSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            criarSenha.Location = new Point(794, 107);
            criarSenha.Name = "criarSenha";
            criarSenha.PlaceholderText = "Crie sua senha";
            criarSenha.Size = new Size(300, 29);
            criarSenha.TabIndex = 9;
            criarSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(82, 143, 235);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(687, 212);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 178);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // criarAcesso
            // 
            criarAcesso.BackColor = Color.White;
            criarAcesso.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            criarAcesso.Location = new Point(855, 418);
            criarAcesso.Name = "criarAcesso";
            criarAcesso.Size = new Size(203, 54);
            criarAcesso.TabIndex = 11;
            criarAcesso.Text = "Criar Acesso";
            criarAcesso.UseVisualStyleBackColor = false;
            // 
            // voltarLoginCadastro
            // 
            voltarLoginCadastro.BackColor = Color.White;
            voltarLoginCadastro.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            voltarLoginCadastro.Location = new Point(855, 495);
            voltarLoginCadastro.Name = "voltarLoginCadastro";
            voltarLoginCadastro.Size = new Size(203, 54);
            voltarLoginCadastro.TabIndex = 12;
            voltarLoginCadastro.Text = "Voltar";
            voltarLoginCadastro.UseVisualStyleBackColor = false;
            // 
            // lblinserirCadastro
            // 
            lblinserirCadastro.AutoSize = true;
            lblinserirCadastro.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblinserirCadastro.ForeColor = Color.White;
            lblinserirCadastro.Location = new Point(179, 37);
            lblinserirCadastro.Name = "lblinserirCadastro";
            lblinserirCadastro.Size = new Size(218, 37);
            lblinserirCadastro.TabIndex = 15;
            lblinserirCadastro.Text = "Insira seus dados";
            lblinserirCadastro.Click += lblCriarCadastro_Click;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(1218, 636);
            Controls.Add(lblinserirCadastro);
            Controls.Add(voltarLoginCadastro);
            Controls.Add(criarAcesso);
            Controls.Add(pictureBox1);
            Controls.Add(confirmarSenha);
            Controls.Add(criarSenha);
            Controls.Add(renda);
            Controls.Add(logradouro);
            Controls.Add(genero);
            Controls.Add(dataNascimento);
            Controls.Add(email);
            Controls.Add(celular);
            Controls.Add(rg);
            Controls.Add(cpf);
            Controls.Add(nome);
            Name = "TelaCadastro";
            Text = "Tela Cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nome;
        private TextBox cpf;
        private TextBox rg;
        private TextBox celular;
        private TextBox email;
        private TextBox dataNascimento;
        private TextBox renda;
        private TextBox logradouro;
        private TextBox genero;
        private TextBox confirmarSenha;
        private TextBox criarSenha;
        private PictureBox pictureBox1;
        private Button criarAcesso;
        private Button voltarLoginCadastro;
        private Label lblinserirCadastro;
    }
}