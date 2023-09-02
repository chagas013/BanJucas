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
            txtNomeCad = new TextBox();
            txtCpfCad = new TextBox();
            txtRgCad = new TextBox();
            txtTelCad = new TextBox();
            txtEmailCad = new TextBox();
            txtRendaCad = new TextBox();
            txtCidade = new TextBox();
            btAcessoCad = new Button();
            btVoltarCad = new Button();
            lblinserirCadastro = new Label();
            pictureBox1 = new PictureBox();
            txtCEP = new TextBox();
            txtLogradouro = new TextBox();
            txtNumeroLogradouro = new TextBox();
            cbEstado = new ComboBox();
            dataNasc = new DateTimePicker();
            txtCelCad = new TextBox();
            cbGenero = new ComboBox();
            txtConfSenhaCad = new TextBox();
            txtSenhaCad = new TextBox();
            lblNome = new Label();
            lblCpf = new Label();
            lblRg = new Label();
            lblDataNasc = new Label();
            lblCelular = new Label();
            lblTelefone = new Label();
            lblLogradouro = new Label();
            lblNumero = new Label();
            lblCep = new Label();
            lblEmail = new Label();
            lblCidade = new Label();
            lblEstado = new Label();
            lblGenero = new Label();
            lblRenda = new Label();
            lblSenha = new Label();
            lblConfSena = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNomeCad
            // 
            txtNomeCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCad.Location = new Point(120, 122);
            txtNomeCad.Name = "txtNomeCad";
            txtNomeCad.PlaceholderText = "Nome Completo";
            txtNomeCad.Size = new Size(300, 29);
            txtNomeCad.TabIndex = 0;
            txtNomeCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCpfCad
            // 
            txtCpfCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpfCad.Location = new Point(435, 122);
            txtCpfCad.MaxLength = 11;
            txtCpfCad.Name = "txtCpfCad";
            txtCpfCad.PlaceholderText = "000.000.000-00";
            txtCpfCad.Size = new Size(300, 29);
            txtCpfCad.TabIndex = 1;
            txtCpfCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRgCad
            // 
            txtRgCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRgCad.Location = new Point(750, 122);
            txtRgCad.MaxLength = 9;
            txtRgCad.Name = "txtRgCad";
            txtRgCad.PlaceholderText = "00.000.000-0";
            txtRgCad.Size = new Size(300, 29);
            txtRgCad.TabIndex = 2;
            txtRgCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTelCad
            // 
            txtTelCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelCad.Location = new Point(750, 182);
            txtTelCad.Name = "txtTelCad";
            txtTelCad.PlaceholderText = "Telefone";
            txtTelCad.Size = new Size(300, 29);
            txtTelCad.TabIndex = 5;
            txtTelCad.TabStop = false;
            txtTelCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmailCad
            // 
            txtEmailCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailCad.Location = new Point(120, 301);
            txtEmailCad.Name = "txtEmailCad";
            txtEmailCad.PlaceholderText = "email@email.com";
            txtEmailCad.Size = new Size(300, 29);
            txtEmailCad.TabIndex = 9;
            txtEmailCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRendaCad
            // 
            txtRendaCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRendaCad.Location = new Point(842, 301);
            txtRendaCad.Name = "txtRendaCad";
            txtRendaCad.PlaceholderText = "Renda Mensal";
            txtRendaCad.Size = new Size(208, 29);
            txtRendaCad.TabIndex = 13;
            txtRendaCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.Location = new Point(435, 301);
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = "Cidade";
            txtCidade.Size = new Size(243, 29);
            txtCidade.TabIndex = 10;
            txtCidade.TextAlign = HorizontalAlignment.Center;
            // 
            // btAcessoCad
            // 
            btAcessoCad.BackColor = Color.White;
            btAcessoCad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btAcessoCad.Location = new Point(816, 428);
            btAcessoCad.Name = "btAcessoCad";
            btAcessoCad.Size = new Size(203, 54);
            btAcessoCad.TabIndex = 16;
            btAcessoCad.Text = "Criar Acesso";
            btAcessoCad.UseVisualStyleBackColor = false;
            btAcessoCad.Click += btAcessoCad_Click;
            // 
            // btVoltarCad
            // 
            btVoltarCad.BackColor = Color.White;
            btVoltarCad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btVoltarCad.Location = new Point(816, 498);
            btVoltarCad.Name = "btVoltarCad";
            btVoltarCad.Size = new Size(203, 54);
            btVoltarCad.TabIndex = 17;
            btVoltarCad.Text = "Voltar";
            btVoltarCad.UseVisualStyleBackColor = false;
            // 
            // lblinserirCadastro
            // 
            lblinserirCadastro.AutoSize = true;
            lblinserirCadastro.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblinserirCadastro.ForeColor = Color.White;
            lblinserirCadastro.Location = new Point(435, 21);
            lblinserirCadastro.Name = "lblinserirCadastro";
            lblinserirCadastro.Size = new Size(286, 47);
            lblinserirCadastro.TabIndex = 15;
            lblinserirCadastro.Text = "Insira seus dados";
            lblinserirCadastro.Click += lblCriarCadastro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(537, 428);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 124);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // txtCEP
            // 
            txtCEP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCEP.Location = new Point(750, 242);
            txtCEP.MaxLength = 8;
            txtCEP.Name = "txtCEP";
            txtCEP.PlaceholderText = "CEP";
            txtCEP.Size = new Size(300, 29);
            txtCEP.TabIndex = 8;
            txtCEP.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogradouro.Location = new Point(120, 243);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.PlaceholderText = "Logradouro";
            txtLogradouro.Size = new Size(300, 29);
            txtLogradouro.TabIndex = 6;
            txtLogradouro.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumeroLogradouro
            // 
            txtNumeroLogradouro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroLogradouro.Location = new Point(435, 242);
            txtNumeroLogradouro.Name = "txtNumeroLogradouro";
            txtNumeroLogradouro.PlaceholderText = "Número";
            txtNumeroLogradouro.Size = new Size(300, 29);
            txtNumeroLogradouro.TabIndex = 7;
            txtNumeroLogradouro.TextAlign = HorizontalAlignment.Center;
            // 
            // cbEstado
            // 
            cbEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" });
            cbEstado.Location = new Point(684, 301);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(51, 29);
            cbEstado.TabIndex = 11;
            cbEstado.Text = "UF";
            // 
            // dataNasc
            // 
            dataNasc.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataNasc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataNasc.Location = new Point(120, 182);
            dataNasc.Name = "dataNasc";
            dataNasc.Size = new Size(300, 29);
            dataNasc.TabIndex = 3;
            // 
            // txtCelCad
            // 
            txtCelCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelCad.Location = new Point(435, 182);
            txtCelCad.Name = "txtCelCad";
            txtCelCad.PlaceholderText = "Celular";
            txtCelCad.Size = new Size(300, 29);
            txtCelCad.TabIndex = 4;
            txtCelCad.TextAlign = HorizontalAlignment.Center;
            // 
            // cbGenero
            // 
            cbGenero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbGenero.FormattingEnabled = true;
            cbGenero.Items.AddRange(new object[] { "F", "M" });
            cbGenero.Location = new Point(750, 301);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(82, 29);
            cbGenero.TabIndex = 12;
            cbGenero.Text = "Gênero";
            // 
            // txtConfSenhaCad
            // 
            txtConfSenhaCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfSenhaCad.Location = new Point(120, 523);
            txtConfSenhaCad.Name = "txtConfSenhaCad";
            txtConfSenhaCad.PlaceholderText = "Confirme sua senha";
            txtConfSenhaCad.Size = new Size(300, 29);
            txtConfSenhaCad.TabIndex = 15;
            txtConfSenhaCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSenhaCad
            // 
            txtSenhaCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaCad.Location = new Point(120, 428);
            txtSenhaCad.Name = "txtSenhaCad";
            txtSenhaCad.PlaceholderText = "Senha da conta";
            txtSenhaCad.Size = new Size(300, 29);
            txtSenhaCad.TabIndex = 14;
            txtSenhaCad.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(120, 99);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(51, 17);
            lblNome.TabIndex = 18;
            lblNome.Text = "Nome*";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCpf.Location = new Point(435, 99);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(37, 17);
            lblCpf.TabIndex = 19;
            lblCpf.Text = "CPF*";
            // 
            // lblRg
            // 
            lblRg.AutoSize = true;
            lblRg.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblRg.Location = new Point(750, 99);
            lblRg.Name = "lblRg";
            lblRg.Size = new Size(28, 19);
            lblRg.TabIndex = 20;
            lblRg.Text = "RG";
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataNasc.Location = new Point(120, 159);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(139, 17);
            lblDataNasc.TabIndex = 21;
            lblDataNasc.Text = "Data de Nascimento*";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCelular.Location = new Point(435, 159);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(57, 17);
            lblCelular.TabIndex = 22;
            lblCelular.Text = "Celular*";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone.Location = new Point(750, 159);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(61, 17);
            lblTelefone.TabIndex = 23;
            lblTelefone.Text = "Telefone";
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogradouro.Location = new Point(120, 220);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(70, 17);
            lblLogradouro.TabIndex = 24;
            lblLogradouro.Text = "Endereço*";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumero.Location = new Point(435, 220);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(64, 17);
            lblNumero.TabIndex = 25;
            lblNumero.Text = "Número*";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCep.Location = new Point(750, 220);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(37, 17);
            lblCep.TabIndex = 26;
            lblCep.Text = "CEP*";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(120, 278);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 17);
            lblEmail.TabIndex = 27;
            lblEmail.Text = "Email";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCidade.Location = new Point(435, 278);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(56, 17);
            lblCidade.TabIndex = 28;
            lblCidade.Text = "Cidade*";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.Location = new Point(684, 278);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(30, 17);
            lblEstado.TabIndex = 29;
            lblEstado.Text = "UF*";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenero.Location = new Point(750, 278);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(58, 17);
            lblGenero.TabIndex = 30;
            lblGenero.Text = "Gênero*";
            // 
            // lblRenda
            // 
            lblRenda.AutoSize = true;
            lblRenda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRenda.Location = new Point(842, 278);
            lblRenda.Name = "lblRenda";
            lblRenda.Size = new Size(100, 17);
            lblRenda.TabIndex = 31;
            lblRenda.Text = "Renda Mensal*";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenha.Location = new Point(120, 408);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(119, 17);
            lblSenha.TabIndex = 32;
            lblSenha.Text = "Digite Sua Senha*";
            // 
            // lblConfSena
            // 
            lblConfSena.AutoSize = true;
            lblConfSena.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfSena.Location = new Point(120, 503);
            lblConfSena.Name = "lblConfSena";
            lblConfSena.Size = new Size(138, 17);
            lblConfSena.TabIndex = 33;
            lblConfSena.Text = "Confirme Sua Senha*";
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(1218, 636);
            Controls.Add(lblConfSena);
            Controls.Add(lblSenha);
            Controls.Add(lblRenda);
            Controls.Add(lblGenero);
            Controls.Add(lblEstado);
            Controls.Add(lblCidade);
            Controls.Add(lblEmail);
            Controls.Add(lblCep);
            Controls.Add(lblNumero);
            Controls.Add(lblLogradouro);
            Controls.Add(lblTelefone);
            Controls.Add(lblCelular);
            Controls.Add(lblDataNasc);
            Controls.Add(lblRg);
            Controls.Add(lblCpf);
            Controls.Add(lblNome);
            Controls.Add(txtConfSenhaCad);
            Controls.Add(txtSenhaCad);
            Controls.Add(cbGenero);
            Controls.Add(txtCelCad);
            Controls.Add(dataNasc);
            Controls.Add(cbEstado);
            Controls.Add(txtNumeroLogradouro);
            Controls.Add(txtLogradouro);
            Controls.Add(txtCEP);
            Controls.Add(pictureBox1);
            Controls.Add(lblinserirCadastro);
            Controls.Add(btVoltarCad);
            Controls.Add(btAcessoCad);
            Controls.Add(txtRendaCad);
            Controls.Add(txtCidade);
            Controls.Add(txtEmailCad);
            Controls.Add(txtTelCad);
            Controls.Add(txtRgCad);
            Controls.Add(txtCpfCad);
            Controls.Add(txtNomeCad);
            Name = "TelaCadastro";
            Text = "Tela Cadastro";
            Load += TelaCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeCad;
        private TextBox txtCpfCad;
        private TextBox txtRgCad;
        private TextBox txtTelCad;
        private TextBox txtEmailCad;
        private TextBox txtRendaCad;
        private TextBox txtCidade;
        private Button btAcessoCad;
        private Button btVoltarCad;
        private Label lblinserirCadastro;
        private PictureBox pictureBox1;
        private TextBox txtCEP;
        private TextBox txtLogradouro;
        private TextBox txtNumeroLogradouro;
        private ComboBox cbEstado;
        private DateTimePicker dataNasc;
        private TextBox txtCelCad;
        private ComboBox cbGenero;
        private TextBox txtConfSenhaCad;
        private TextBox txtSenhaCad;
        private Label lblNome;
        private Label lblCpf;
        private Label lblRg;
        private Label lblDataNasc;
        private Label lblCelular;
        private Label lblTelefone;
        private Label lblLogradouro;
        private Label lblNumero;
        private Label lblCep;
        private Label lblEmail;
        private Label lblCidade;
        private Label lblEstado;
        private Label lblGenero;
        private Label lblRenda;
        private Label lblSenha;
        private Label lblConfSena;
    }
}