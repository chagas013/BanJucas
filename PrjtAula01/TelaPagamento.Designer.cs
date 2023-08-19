namespace PrjtAula01
{
    partial class TelaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPagamento));
            txtIdentificacao = new TextBox();
            txtNomeDestino = new TextBox();
            txtNumConta = new TextBox();
            txtCodBarras = new TextBox();
            lblSaldoVal = new Label();
            lblSaldo = new Label();
            lblPagamento = new Label();
            lblPagamentoConfirmado = new Label();
            lblVoltarPagamento = new Button();
            btConfirmarPagamento = new Button();
            lblValorPagar = new Label();
            txtValorPagamento = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtIdentificacao
            // 
            txtIdentificacao.BackColor = Color.White;
            txtIdentificacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdentificacao.Location = new Point(45, 461);
            txtIdentificacao.Name = "txtIdentificacao";
            txtIdentificacao.PlaceholderText = "Quem está depositando?";
            txtIdentificacao.Size = new Size(379, 29);
            txtIdentificacao.TabIndex = 3;
            txtIdentificacao.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNomeDestino
            // 
            txtNomeDestino.BackColor = Color.White;
            txtNomeDestino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeDestino.Location = new Point(45, 388);
            txtNomeDestino.Name = "txtNomeDestino";
            txtNomeDestino.PlaceholderText = "Nome do beneficiário";
            txtNomeDestino.Size = new Size(379, 29);
            txtNomeDestino.TabIndex = 2;
            txtNomeDestino.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumConta
            // 
            txtNumConta.BackColor = Color.White;
            txtNumConta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumConta.Location = new Point(45, 315);
            txtNumConta.Name = "txtNumConta";
            txtNumConta.PlaceholderText = "Número da conta destino";
            txtNumConta.Size = new Size(379, 29);
            txtNumConta.TabIndex = 1;
            txtNumConta.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCodBarras
            // 
            txtCodBarras.BackColor = Color.White;
            txtCodBarras.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodBarras.Location = new Point(45, 243);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.PlaceholderText = "0000.0000.0000.0000.000000.0.000000000";
            txtCodBarras.Size = new Size(379, 29);
            txtCodBarras.TabIndex = 0;
            txtCodBarras.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSaldoVal
            // 
            lblSaldoVal.AutoSize = true;
            lblSaldoVal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoVal.ForeColor = Color.Black;
            lblSaldoVal.Location = new Point(157, 141);
            lblSaldoVal.Name = "lblSaldoVal";
            lblSaldoVal.Size = new Size(121, 37);
            lblSaldoVal.TabIndex = 21;
            lblSaldoVal.Text = "R$ 50,33";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.Black;
            lblSaldo.Location = new Point(61, 141);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(90, 37);
            lblSaldo.TabIndex = 20;
            lblSaldo.Text = "Saldo:";
            // 
            // lblPagamento
            // 
            lblPagamento.AutoSize = true;
            lblPagamento.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPagamento.ForeColor = Color.Black;
            lblPagamento.Location = new Point(61, 66);
            lblPagamento.Name = "lblPagamento";
            lblPagamento.Size = new Size(163, 37);
            lblPagamento.TabIndex = 19;
            lblPagamento.Text = "Pagamentos";
            // 
            // lblPagamentoConfirmado
            // 
            lblPagamentoConfirmado.AutoSize = true;
            lblPagamentoConfirmado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPagamentoConfirmado.ForeColor = Color.White;
            lblPagamentoConfirmado.Location = new Point(844, 427);
            lblPagamentoConfirmado.Name = "lblPagamentoConfirmado";
            lblPagamentoConfirmado.Size = new Size(276, 37);
            lblPagamentoConfirmado.TabIndex = 30;
            lblPagamentoConfirmado.Text = "Pagamento realizado!";
            // 
            // lblVoltarPagamento
            // 
            lblVoltarPagamento.BackColor = Color.White;
            lblVoltarPagamento.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblVoltarPagamento.Location = new Point(988, 527);
            lblVoltarPagamento.Name = "lblVoltarPagamento";
            lblVoltarPagamento.Size = new Size(133, 42);
            lblVoltarPagamento.TabIndex = 6;
            lblVoltarPagamento.Text = "Voltar";
            lblVoltarPagamento.UseVisualStyleBackColor = false;
            // 
            // btConfirmarPagamento
            // 
            btConfirmarPagamento.BackColor = Color.Black;
            btConfirmarPagamento.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmarPagamento.ForeColor = Color.White;
            btConfirmarPagamento.Location = new Point(828, 333);
            btConfirmarPagamento.Name = "btConfirmarPagamento";
            btConfirmarPagamento.Size = new Size(300, 48);
            btConfirmarPagamento.TabIndex = 5;
            btConfirmarPagamento.Text = "Confirmar pagamento";
            btConfirmarPagamento.UseVisualStyleBackColor = false;
            // 
            // lblValorPagar
            // 
            lblValorPagar.AutoSize = true;
            lblValorPagar.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorPagar.ForeColor = Color.Black;
            lblValorPagar.Location = new Point(796, 163);
            lblValorPagar.Name = "lblValorPagar";
            lblValorPagar.Size = new Size(356, 37);
            lblValorPagar.TabIndex = 29;
            lblValorPagar.Text = "Insira o valor de pagamento:";
            // 
            // txtValorPagamento
            // 
            txtValorPagamento.BackColor = Color.White;
            txtValorPagamento.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorPagamento.Location = new Point(828, 229);
            txtValorPagamento.Name = "txtValorPagamento";
            txtValorPagamento.PlaceholderText = "R$ 0,00";
            txtValorPagamento.Size = new Size(300, 43);
            txtValorPagamento.TabIndex = 4;
            txtValorPagamento.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(512, 226);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 177);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // TelaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(1172, 634);
            Controls.Add(lblPagamentoConfirmado);
            Controls.Add(lblVoltarPagamento);
            Controls.Add(btConfirmarPagamento);
            Controls.Add(lblValorPagar);
            Controls.Add(txtValorPagamento);
            Controls.Add(pictureBox1);
            Controls.Add(txtIdentificacao);
            Controls.Add(txtNomeDestino);
            Controls.Add(txtNumConta);
            Controls.Add(txtCodBarras);
            Controls.Add(lblSaldoVal);
            Controls.Add(lblSaldo);
            Controls.Add(lblPagamento);
            Name = "TelaPagamento";
            Text = "TelaPagamento";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdentificacao;
        private TextBox txtNomeDestino;
        private TextBox txtNumConta;
        private TextBox txtCodBarras;
        private Label lblSaldoVal;
        private Label lblSaldo;
        private Label lblPagamento;
        private Label lblPagamentoConfirmado;
        private Button lblVoltarPagamento;
        private Button btConfirmarPagamento;
        private Label lblValorPagar;
        private TextBox txtValorPagamento;
        private PictureBox pictureBox1;
    }
}