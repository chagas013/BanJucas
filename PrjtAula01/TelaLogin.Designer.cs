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
            menuStrip1 = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            logarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            operaçõesToolStripMenuItem = new ToolStripMenuItem();
            depósitoToolStripMenuItem = new ToolStripMenuItem();
            saqueToolStripMenuItem = new ToolStripMenuItem();
            transferênciaToolStripMenuItem = new ToolStripMenuItem();
            pagamentosToolStripMenuItem = new ToolStripMenuItem();
            agendamentosToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            alterarDadosToolStripMenuItem = new ToolStripMenuItem();
            alterarSenhaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, operaçõesToolStripMenuItem, pagamentosToolStripMenuItem, agendamentosToolStripMenuItem, configuraçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(126, 554);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logarToolStripMenuItem, cadastrarToolStripMenuItem });
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(113, 19);
            loginToolStripMenuItem.Text = "Entrar";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // logarToolStripMenuItem
            // 
            logarToolStripMenuItem.Name = "logarToolStripMenuItem";
            logarToolStripMenuItem.Size = new Size(180, 22);
            logarToolStripMenuItem.Text = "Logar";
            logarToolStripMenuItem.Click += logarToolStripMenuItem_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(180, 22);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // operaçõesToolStripMenuItem
            // 
            operaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { depósitoToolStripMenuItem, saqueToolStripMenuItem, transferênciaToolStripMenuItem });
            operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            operaçõesToolStripMenuItem.Size = new Size(113, 19);
            operaçõesToolStripMenuItem.Text = "Operações";
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
            // pagamentosToolStripMenuItem
            // 
            pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            pagamentosToolStripMenuItem.Size = new Size(113, 19);
            pagamentosToolStripMenuItem.Text = "Pagamentos";
            // 
            // agendamentosToolStripMenuItem
            // 
            agendamentosToolStripMenuItem.Name = "agendamentosToolStripMenuItem";
            agendamentosToolStripMenuItem.Size = new Size(113, 19);
            agendamentosToolStripMenuItem.Text = "Agendamentos";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alterarDadosToolStripMenuItem, alterarSenhaToolStripMenuItem });
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(113, 19);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // alterarDadosToolStripMenuItem
            // 
            alterarDadosToolStripMenuItem.Name = "alterarDadosToolStripMenuItem";
            alterarDadosToolStripMenuItem.Size = new Size(180, 22);
            alterarDadosToolStripMenuItem.Text = "Alterar Dados";
            // 
            // alterarSenhaToolStripMenuItem
            // 
            alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            alterarSenhaToolStripMenuItem.Size = new Size(180, 22);
            alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 554);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "TelaLogin";
            Text = "TelaLogin";
            Load += TelaLogin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
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
        private ToolStripMenuItem logarToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
    }
}