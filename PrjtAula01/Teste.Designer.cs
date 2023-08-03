namespace PrjtAula01
{
    partial class Teste
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
            btnDepositar = new Button();
            txtVlrDpst = new TextBox();
            lblTotalSaldo = new Label();
            btnSaque = new Button();
            btnVerSaldo = new Button();
            btnEsconderSaldo = new Button();
            SuspendLayout();
            // 
            // btnDepositar
            // 
            btnDepositar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepositar.Location = new Point(155, 191);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(185, 42);
            btnDepositar.TabIndex = 0;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // txtVlrDpst
            // 
            txtVlrDpst.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtVlrDpst.Location = new Point(287, 102);
            txtVlrDpst.Name = "txtVlrDpst";
            txtVlrDpst.PlaceholderText = "0,00";
            txtVlrDpst.Size = new Size(185, 43);
            txtVlrDpst.TabIndex = 1;
            txtVlrDpst.TextChanged += txtVlrDpst_TextChanged;
            // 
            // lblTotalSaldo
            // 
            lblTotalSaldo.AutoSize = true;
            lblTotalSaldo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalSaldo.Location = new Point(340, 284);
            lblTotalSaldo.Name = "lblTotalSaldo";
            lblTotalSaldo.Size = new Size(0, 25);
            lblTotalSaldo.TabIndex = 2;
            // 
            // btnSaque
            // 
            btnSaque.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaque.Location = new Point(417, 191);
            btnSaque.Name = "btnSaque";
            btnSaque.Size = new Size(185, 42);
            btnSaque.TabIndex = 5;
            btnSaque.Text = "Sacar";
            btnSaque.UseVisualStyleBackColor = true;
            btnSaque.Click += btnSaque_Click;
            // 
            // btnVerSaldo
            // 
            btnVerSaldo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerSaldo.Location = new Point(188, 24);
            btnVerSaldo.Name = "btnVerSaldo";
            btnVerSaldo.Size = new Size(152, 38);
            btnVerSaldo.TabIndex = 6;
            btnVerSaldo.Text = "Verificar Saldo";
            btnVerSaldo.UseVisualStyleBackColor = true;
            btnVerSaldo.Click += btnVerSaldo_Click;
            // 
            // btnEsconderSaldo
            // 
            btnEsconderSaldo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnEsconderSaldo.Location = new Point(417, 24);
            btnEsconderSaldo.Name = "btnEsconderSaldo";
            btnEsconderSaldo.Size = new Size(161, 38);
            btnEsconderSaldo.TabIndex = 7;
            btnEsconderSaldo.Text = "Esconder Saldo";
            btnEsconderSaldo.UseVisualStyleBackColor = true;
            btnEsconderSaldo.Click += btnEsconderSaldo_Click;
            // 
            // Teste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEsconderSaldo);
            Controls.Add(btnVerSaldo);
            Controls.Add(btnSaque);
            Controls.Add(lblTotalSaldo);
            Controls.Add(txtVlrDpst);
            Controls.Add(btnDepositar);
            Name = "Teste";
            Tag = "";
            Text = "Teste";
            Load += Teste_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDepositar;
        private TextBox txtVlrDpst;
        private Label lblTotalSaldo;
        private Button btnSaque;
        private Button btnVerSaldo;
        private Button btnEsconderSaldo;
    }
}