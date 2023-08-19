namespace PrjtAula01
{
    partial class TelaTransferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTransferencia));
            lblTransferencia = new Label();
            lblSaldoValTransf = new Label();
            lblSaldoTransf = new Label();
            txtValorTransf = new TextBox();
            txtDestinoTransf = new TextBox();
            lblTransfConfirmada = new Label();
            lblVoltarTransf = new Button();
            pictureBox1 = new PictureBox();
            lblValorTransf = new Label();
            btConfirmarTransf = new Button();
            lblDestinoTransf = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTransferencia
            // 
            lblTransferencia.AutoSize = true;
            lblTransferencia.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTransferencia.ForeColor = Color.Black;
            lblTransferencia.Location = new Point(109, 62);
            lblTransferencia.Name = "lblTransferencia";
            lblTransferencia.Size = new Size(171, 37);
            lblTransferencia.TabIndex = 13;
            lblTransferencia.Text = "Transferência";
            // 
            // lblSaldoValTransf
            // 
            lblSaldoValTransf.AutoSize = true;
            lblSaldoValTransf.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoValTransf.ForeColor = Color.Black;
            lblSaldoValTransf.Location = new Point(205, 119);
            lblSaldoValTransf.Name = "lblSaldoValTransf";
            lblSaldoValTransf.Size = new Size(121, 37);
            lblSaldoValTransf.TabIndex = 16;
            lblSaldoValTransf.Text = "R$ 50,33";
            // 
            // lblSaldoTransf
            // 
            lblSaldoTransf.AutoSize = true;
            lblSaldoTransf.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoTransf.ForeColor = Color.Black;
            lblSaldoTransf.Location = new Point(109, 119);
            lblSaldoTransf.Name = "lblSaldoTransf";
            lblSaldoTransf.Size = new Size(90, 37);
            lblSaldoTransf.TabIndex = 15;
            lblSaldoTransf.Text = "Saldo:";
            // 
            // txtValorTransf
            // 
            txtValorTransf.BackColor = Color.White;
            txtValorTransf.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorTransf.Location = new Point(700, 269);
            txtValorTransf.Name = "txtValorTransf";
            txtValorTransf.PlaceholderText = "0,00";
            txtValorTransf.Size = new Size(312, 35);
            txtValorTransf.TabIndex = 1;
            txtValorTransf.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDestinoTransf
            // 
            txtDestinoTransf.BackColor = Color.White;
            txtDestinoTransf.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDestinoTransf.Location = new Point(700, 133);
            txtDestinoTransf.Name = "txtDestinoTransf";
            txtDestinoTransf.PlaceholderText = "000.000.000-00";
            txtDestinoTransf.Size = new Size(315, 35);
            txtDestinoTransf.TabIndex = 0;
            txtDestinoTransf.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTransfConfirmada
            // 
            lblTransfConfirmada.AutoSize = true;
            lblTransfConfirmada.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTransfConfirmada.ForeColor = Color.White;
            lblTransfConfirmada.Location = new Point(710, 414);
            lblTransfConfirmada.Name = "lblTransfConfirmada";
            lblTransfConfirmada.Size = new Size(293, 37);
            lblTransfConfirmada.TabIndex = 25;
            lblTransfConfirmada.Text = "Transferência realizada!";
            // 
            // lblVoltarTransf
            // 
            lblVoltarTransf.BackColor = Color.White;
            lblVoltarTransf.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblVoltarTransf.Location = new Point(870, 506);
            lblVoltarTransf.Name = "lblVoltarTransf";
            lblVoltarTransf.Size = new Size(133, 42);
            lblVoltarTransf.TabIndex = 3;
            lblVoltarTransf.Text = "Voltar";
            lblVoltarTransf.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(106, 228);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 189);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // lblValorTransf
            // 
            lblValorTransf.AutoSize = true;
            lblValorTransf.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorTransf.ForeColor = Color.Black;
            lblValorTransf.Location = new Point(700, 226);
            lblValorTransf.Name = "lblValorTransf";
            lblValorTransf.Size = new Size(308, 37);
            lblValorTransf.TabIndex = 29;
            lblValorTransf.Text = "Insira o valor a transferir:";
            lblValorTransf.Click += lblValorDeposito_Click;
            // 
            // btConfirmarTransf
            // 
            btConfirmarTransf.BackColor = Color.Black;
            btConfirmarTransf.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmarTransf.ForeColor = Color.White;
            btConfirmarTransf.Location = new Point(700, 323);
            btConfirmarTransf.Name = "btConfirmarTransf";
            btConfirmarTransf.Size = new Size(315, 48);
            btConfirmarTransf.TabIndex = 2;
            btConfirmarTransf.Text = "Confirmar transferência";
            btConfirmarTransf.UseVisualStyleBackColor = false;
            // 
            // lblDestinoTransf
            // 
            lblDestinoTransf.AutoSize = true;
            lblDestinoTransf.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblDestinoTransf.ForeColor = Color.Black;
            lblDestinoTransf.Location = new Point(700, 92);
            lblDestinoTransf.Name = "lblDestinoTransf";
            lblDestinoTransf.Size = new Size(278, 37);
            lblDestinoTransf.TabIndex = 30;
            lblDestinoTransf.Text = "CPF da Conta destino:";
            // 
            // TelaTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(1125, 633);
            Controls.Add(lblDestinoTransf);
            Controls.Add(btConfirmarTransf);
            Controls.Add(lblValorTransf);
            Controls.Add(pictureBox1);
            Controls.Add(lblVoltarTransf);
            Controls.Add(lblTransfConfirmada);
            Controls.Add(txtValorTransf);
            Controls.Add(txtDestinoTransf);
            Controls.Add(lblSaldoValTransf);
            Controls.Add(lblSaldoTransf);
            Controls.Add(lblTransferencia);
            Name = "TelaTransferencia";
            Text = "TelaTransferencia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTransferencia;
        private Label lblSaldoValTransf;
        private Label lblSaldoTransf;
        private TextBox txtNomeDestino;
        private TextBox txtValorTransf;
        private TextBox txtDestinoTransf;
        private Label lblTransfConfirmada;
        private Button lblVoltarTransf;
        private PictureBox pictureBox1;
        private Label lblValorTransf;
        private Button btConfirmarTransf;
        private Label lblDestinoTransf;
    }
}