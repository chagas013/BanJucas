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
            txtIdentificacao = new TextBox();
            txtNomeDestino = new TextBox();
            txtNumConta = new TextBox();
            txtCodBarras = new TextBox();
            lblSaldoVal = new Label();
            lblSaldo = new Label();
            lblPagamento = new Label();
            SuspendLayout();
            // 
            // txtIdentificacao
            // 
            txtIdentificacao.BackColor = Color.White;
            txtIdentificacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdentificacao.Location = new Point(90, 461);
            txtIdentificacao.Name = "txtIdentificacao";
            txtIdentificacao.PlaceholderText = "Quem está depositando?";
            txtIdentificacao.Size = new Size(379, 29);
            txtIdentificacao.TabIndex = 18;
            txtIdentificacao.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNomeDestino
            // 
            txtNomeDestino.BackColor = Color.White;
            txtNomeDestino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeDestino.Location = new Point(90, 388);
            txtNomeDestino.Name = "txtNomeDestino";
            txtNomeDestino.PlaceholderText = "Nome do beneficiário";
            txtNomeDestino.Size = new Size(379, 29);
            txtNomeDestino.TabIndex = 17;
            txtNomeDestino.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumConta
            // 
            txtNumConta.BackColor = Color.White;
            txtNumConta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumConta.Location = new Point(90, 315);
            txtNumConta.Name = "txtNumConta";
            txtNumConta.PlaceholderText = "Número da conta destino";
            txtNumConta.Size = new Size(379, 29);
            txtNumConta.TabIndex = 16;
            txtNumConta.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCodBarras
            // 
            txtCodBarras.BackColor = Color.White;
            txtCodBarras.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodBarras.Location = new Point(90, 243);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.PlaceholderText = "0000.0000.0000.0000.000000.0.000000000";
            txtCodBarras.Size = new Size(379, 29);
            txtCodBarras.TabIndex = 15;
            txtCodBarras.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSaldoVal
            // 
            lblSaldoVal.AutoSize = true;
            lblSaldoVal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoVal.ForeColor = Color.Black;
            lblSaldoVal.Location = new Point(202, 141);
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
            lblSaldo.Location = new Point(106, 141);
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
            lblPagamento.Location = new Point(106, 66);
            lblPagamento.Name = "lblPagamento";
            lblPagamento.Size = new Size(163, 37);
            lblPagamento.TabIndex = 19;
            lblPagamento.Text = "Pagamentos";
            // 
            // TelaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(1102, 634);
            Controls.Add(txtIdentificacao);
            Controls.Add(txtNomeDestino);
            Controls.Add(txtNumConta);
            Controls.Add(txtCodBarras);
            Controls.Add(lblSaldoVal);
            Controls.Add(lblSaldo);
            Controls.Add(lblPagamento);
            Name = "TelaPagamento";
            Text = "TelaPagamento";
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
    }
}