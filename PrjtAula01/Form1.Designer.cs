namespace PrjtAula01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CaixaLogin = new TextBox();
            CaixaSenha = new TextBox();
            BotaoEntrar = new Button();
            Login = new Label();
            Senha = new Label();
            Mensagem = new Label();
            SuspendLayout();
            // 
            // CaixaLogin
            // 
            CaixaLogin.BackColor = Color.Gainsboro;
            CaixaLogin.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            CaixaLogin.ForeColor = Color.Black;
            CaixaLogin.Location = new Point(301, 117);
            CaixaLogin.MaxLength = 11;
            CaixaLogin.Name = "CaixaLogin";
            CaixaLogin.Size = new Size(195, 36);
            CaixaLogin.TabIndex = 0;
            // 
            // CaixaSenha
            // 
            CaixaSenha.BackColor = Color.Gainsboro;
            CaixaSenha.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            CaixaSenha.Location = new Point(301, 176);
            CaixaSenha.MaxLength = 6;
            CaixaSenha.Name = "CaixaSenha";
            CaixaSenha.Size = new Size(195, 36);
            CaixaSenha.TabIndex = 1;
            CaixaSenha.UseSystemPasswordChar = true;
            // 
            // BotaoEntrar
            // 
            BotaoEntrar.BackColor = Color.Black;
            BotaoEntrar.Cursor = Cursors.Hand;
            BotaoEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BotaoEntrar.ForeColor = Color.Yellow;
            BotaoEntrar.Location = new Point(400, 234);
            BotaoEntrar.Name = "BotaoEntrar";
            BotaoEntrar.Size = new Size(96, 34);
            BotaoEntrar.TabIndex = 2;
            BotaoEntrar.Text = "Entrar";
            BotaoEntrar.UseVisualStyleBackColor = false;
            BotaoEntrar.Click += BotaoEntrar_Click;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Login.ForeColor = Color.Yellow;
            Login.Location = new Point(207, 120);
            Login.Name = "Login";
            Login.Size = new Size(70, 30);
            Login.TabIndex = 3;
            Login.Text = "Login";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.FlatStyle = FlatStyle.Flat;
            Senha.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Senha.ForeColor = Color.Yellow;
            Senha.Location = new Point(207, 182);
            Senha.Name = "Senha";
            Senha.Size = new Size(75, 30);
            Senha.TabIndex = 4;
            Senha.Text = "Senha";
            // 
            // Mensagem
            // 
            Mensagem.AutoSize = true;
            Mensagem.FlatStyle = FlatStyle.Flat;
            Mensagem.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Mensagem.ForeColor = Color.Yellow;
            Mensagem.Location = new Point(301, 47);
            Mensagem.Name = "Mensagem";
            Mensagem.Size = new Size(127, 30);
            Mensagem.TabIndex = 5;
            Mensagem.Text = "Mensagem";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(790, 389);
            Controls.Add(Mensagem);
            Controls.Add(Senha);
            Controls.Add(Login);
            Controls.Add(BotaoEntrar);
            Controls.Add(CaixaSenha);
            Controls.Add(CaixaLogin);
            Name = "Form1";
            Text = "BanJucas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CaixaLogin;
        private TextBox CaixaSenha;
        private Button BotaoEntrar;
        private Label Login;
        private Label Senha;
        private Label Mensagem;
    }
}