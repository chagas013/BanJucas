namespace PrjtAula01
{
    partial class TelaLogin
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
            menu = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            cadastrarConta = new ToolStripMenuItem();
            extratoToolStripMenuItem = new ToolStripMenuItem();
            pagamentosToolStripMenuItem = new ToolStripMenuItem();
            operaçõesToolStripMenuItem = new ToolStripMenuItem();
            depósitoToolStripMenuItem = new ToolStripMenuItem();
            saqueToolStripMenuItem = new ToolStripMenuItem();
            transferênciaToolStripMenuItem = new ToolStripMenuItem();
            agendamentosToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            alterarDadosToolStripMenuItem = new ToolStripMenuItem();
            alterarSenhaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            alterarContaToolStripMenuItem = new ToolStripMenuItem();
            abrirContaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            menu.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Dock = DockStyle.Left;
            menu.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, cadastrarConta, extratoToolStripMenuItem, pagamentosToolStripMenuItem, operaçõesToolStripMenuItem, agendamentosToolStripMenuItem, configuraçõesToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(126, 527);
            menu.TabIndex = 1;
            menu.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(113, 19);
            loginToolStripMenuItem.Text = "Logar";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // cadastrarConta
            // 
            cadastrarConta.Name = "cadastrarConta";
            cadastrarConta.Size = new Size(113, 19);
            cadastrarConta.Text = "Cadastrar Conta";
            cadastrarConta.Click += cadastrarContaToolStripMenuItem_Click;
            // 
            // extratoToolStripMenuItem
            // 
            extratoToolStripMenuItem.Name = "extratoToolStripMenuItem";
            extratoToolStripMenuItem.Size = new Size(113, 19);
            extratoToolStripMenuItem.Text = "Extrato";
            extratoToolStripMenuItem.Visible = false;
            // 
            // pagamentosToolStripMenuItem
            // 
            pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            pagamentosToolStripMenuItem.Size = new Size(113, 19);
            pagamentosToolStripMenuItem.Text = "Pagamentos";
            pagamentosToolStripMenuItem.Visible = false;
            // 
            // operaçõesToolStripMenuItem
            // 
            operaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { depósitoToolStripMenuItem, saqueToolStripMenuItem, transferênciaToolStripMenuItem });
            operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            operaçõesToolStripMenuItem.Size = new Size(113, 19);
            operaçõesToolStripMenuItem.Text = "Operações";
            operaçõesToolStripMenuItem.Visible = false;
            // 
            // depósitoToolStripMenuItem
            // 
            depósitoToolStripMenuItem.Name = "depósitoToolStripMenuItem";
            depósitoToolStripMenuItem.Size = new Size(143, 22);
            depósitoToolStripMenuItem.Text = "Depósito";
            depósitoToolStripMenuItem.Click += depósitoToolStripMenuItem_Click;
            // 
            // saqueToolStripMenuItem
            // 
            saqueToolStripMenuItem.Name = "saqueToolStripMenuItem";
            saqueToolStripMenuItem.Size = new Size(143, 22);
            saqueToolStripMenuItem.Text = "Saque";
            saqueToolStripMenuItem.Click += saqueToolStripMenuItem_Click;
            // 
            // transferênciaToolStripMenuItem
            // 
            transferênciaToolStripMenuItem.Name = "transferênciaToolStripMenuItem";
            transferênciaToolStripMenuItem.Size = new Size(143, 22);
            transferênciaToolStripMenuItem.Text = "Transferência";
            transferênciaToolStripMenuItem.Click += transferênciaToolStripMenuItem_Click;
            // 
            // agendamentosToolStripMenuItem
            // 
            agendamentosToolStripMenuItem.Name = "agendamentosToolStripMenuItem";
            agendamentosToolStripMenuItem.Size = new Size(113, 19);
            agendamentosToolStripMenuItem.Text = "Agendamentos";
            agendamentosToolStripMenuItem.Visible = false;
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alterarDadosToolStripMenuItem, alterarSenhaToolStripMenuItem, toolStripSeparator1, alterarContaToolStripMenuItem, abrirContaToolStripMenuItem });
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(113, 19);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            configuraçõesToolStripMenuItem.Visible = false;
            // 
            // alterarDadosToolStripMenuItem
            // 
            alterarDadosToolStripMenuItem.Name = "alterarDadosToolStripMenuItem";
            alterarDadosToolStripMenuItem.Size = new Size(180, 22);
            alterarDadosToolStripMenuItem.Text = "Alterar Dados";
            alterarDadosToolStripMenuItem.Click += alterarDadosToolStripMenuItem_Click;
            // 
            // alterarSenhaToolStripMenuItem
            // 
            alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            alterarSenhaToolStripMenuItem.Size = new Size(180, 22);
            alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            alterarSenhaToolStripMenuItem.Click += alterarSenhaToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // alterarContaToolStripMenuItem
            // 
            alterarContaToolStripMenuItem.Name = "alterarContaToolStripMenuItem";
            alterarContaToolStripMenuItem.Size = new Size(180, 22);
            alterarContaToolStripMenuItem.Text = "Alterar Conta";
            alterarContaToolStripMenuItem.Click += alterarContaToolStripMenuItem_Click;
            // 
            // abrirContaToolStripMenuItem
            // 
            abrirContaToolStripMenuItem.Name = "abrirContaToolStripMenuItem";
            abrirContaToolStripMenuItem.Size = new Size(180, 22);
            abrirContaToolStripMenuItem.Text = "Abrir Conta";
            abrirContaToolStripMenuItem.Click += abrirContaToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripTextBox2 });
            menuStrip1.Location = new Point(0, 527);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1098, 27);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 23);
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 554);
            Controls.Add(menu);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menu;
            Name = "TelaLogin";
            Text = "TelaLogin";
            Load += TelaLogin_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem operaçõesToolStripMenuItem;
        private ToolStripMenuItem depósitoToolStripMenuItem;
        private ToolStripMenuItem saqueToolStripMenuItem;
        private ToolStripMenuItem transferênciaToolStripMenuItem;
        private ToolStripMenuItem pagamentosToolStripMenuItem;
        private ToolStripMenuItem agendamentosToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem alterarDadosToolStripMenuItem;
        private ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private ToolStripMenuItem extratoToolStripMenuItem;
        private ToolStripMenuItem cadastrarConta;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem alterarContaToolStripMenuItem;
        private ToolStripMenuItem abrirContaToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
    }
}