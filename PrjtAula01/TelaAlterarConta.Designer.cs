namespace PrjtAula01
{
    partial class TelaAlterarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAlterarConta));
            lblAlterarConta = new Label();
            cbAlterarConta = new ComboBox();
            lblContas = new Label();
            lblConfirmarSenhaContas = new Label();
            txtConfirmarSenhaContas = new TextBox();
            pictureBox1 = new PictureBox();
            btnTrocarConta = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAlterarConta
            // 
            lblAlterarConta.AutoSize = true;
            lblAlterarConta.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlterarConta.ForeColor = Color.White;
            lblAlterarConta.Location = new Point(252, 21);
            lblAlterarConta.Name = "lblAlterarConta";
            lblAlterarConta.Size = new Size(234, 47);
            lblAlterarConta.TabIndex = 62;
            lblAlterarConta.Text = "Alterar Conta:";
            // 
            // cbAlterarConta
            // 
            cbAlterarConta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbAlterarConta.FormattingEnabled = true;
            cbAlterarConta.Location = new Point(362, 77);
            cbAlterarConta.Name = "cbAlterarConta";
            cbAlterarConta.Size = new Size(97, 29);
            cbAlterarConta.TabIndex = 0;
            cbAlterarConta.SelectedIndexChanged += cbAlterarConta_SelectedIndexChanged;
            // 
            // lblContas
            // 
            lblContas.AutoSize = true;
            lblContas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblContas.Location = new Point(273, 81);
            lblContas.Name = "lblContas";
            lblContas.Size = new Size(78, 25);
            lblContas.TabIndex = 63;
            lblContas.Text = "Contas:";
            // 
            // lblConfirmarSenhaContas
            // 
            lblConfirmarSenhaContas.AutoSize = true;
            lblConfirmarSenhaContas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirmarSenhaContas.Location = new Point(235, 264);
            lblConfirmarSenhaContas.Name = "lblConfirmarSenhaContas";
            lblConfirmarSenhaContas.Size = new Size(273, 25);
            lblConfirmarSenhaContas.TabIndex = 64;
            lblConfirmarSenhaContas.Text = "Confirme sua senha da conta:";
            // 
            // txtConfirmarSenhaContas
            // 
            txtConfirmarSenhaContas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmarSenhaContas.Location = new Point(283, 307);
            txtConfirmarSenhaContas.Name = "txtConfirmarSenhaContas";
            txtConfirmarSenhaContas.Size = new Size(176, 33);
            txtConfirmarSenhaContas.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(309, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 124);
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // btnTrocarConta
            // 
            btnTrocarConta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrocarConta.Location = new Point(311, 356);
            btnTrocarConta.Name = "btnTrocarConta";
            btnTrocarConta.Size = new Size(121, 38);
            btnTrocarConta.TabIndex = 67;
            btnTrocarConta.Text = "Confirmar";
            btnTrocarConta.UseVisualStyleBackColor = true;
            btnTrocarConta.Click += button1_Click;
            // 
            // TelaAlterarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 143, 235);
            ClientSize = new Size(761, 450);
            Controls.Add(btnTrocarConta);
            Controls.Add(pictureBox1);
            Controls.Add(txtConfirmarSenhaContas);
            Controls.Add(lblConfirmarSenhaContas);
            Controls.Add(lblContas);
            Controls.Add(cbAlterarConta);
            Controls.Add(lblAlterarConta);
            Name = "TelaAlterarConta";
            Text = "TelaAlterarConta";
            Load += TelaAlterarConta_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAlterarConta;
        private ComboBox cbAlterarConta;
        private Label lblContas;
        private Label lblConfirmarSenhaContas;
        private TextBox txtConfirmarSenhaContas;
        private PictureBox pictureBox1;
        private Button btnTrocarConta;
    }
}