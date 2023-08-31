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
            logarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
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
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Dock = DockStyle.Left;
            menu.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, extratoToolStripMenuItem, pagamentosToolStripMenuItem, operaçõesToolStripMenuItem, agendamentosToolStripMenuItem, configuraçõesToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(56, 554);
            menu.TabIndex = 1;
            menu.Text = "menuStrip1";
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
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alterarDadosToolStripMenuItem, alterarSenhaToolStripMenuItem });
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(113, 19);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            configuraçõesToolStripMenuItem.Visible = false;
            // 
            // alterarDadosToolStripMenuItem
            // 
            alterarDadosToolStripMenuItem.Name = "alterarDadosToolStripMenuItem";
            alterarDadosToolStripMenuItem.Size = new Size(145, 22);
            alterarDadosToolStripMenuItem.Text = "Alterar Dados";
            // 
            // alterarSenhaToolStripMenuItem
            // 
            alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            alterarSenhaToolStripMenuItem.Size = new Size(145, 22);
            alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 554);
            Controls.Add(menu);
            IsMdiContainer = true;
            MainMenuStrip = menu;
            Name = "TelaLogin";
            Text = "TelaLogin";
            Load += TelaLogin_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
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
        private ToolStripMenuItem logarToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem extratoToolStripMenuItem;
    }
}