namespace PrjtAula01
{
    partial class TelaAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAlterarSenha));
            pictureBox1 = new PictureBox();
            btSalvarSenha = new Button();
            txtConfAlterarSenha = new TextBox();
            txtAlterarSenha = new TextBox();
            lblAlterarSenha = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(505, 280);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 124);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // btSalvarSenha
            // 
            btSalvarSenha.BackColor = Color.White;
            btSalvarSenha.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btSalvarSenha.Location = new Point(474, 461);
            btSalvarSenha.Name = "btSalvarSenha";
            btSalvarSenha.Size = new Size(203, 54);
            btSalvarSenha.TabIndex = 2;
            btSalvarSenha.Text = "Salvar Senha";
            btSalvarSenha.UseVisualStyleBackColor = false;
            btSalvarSenha.Click += btSalvarSenha_Click;
            // 
            // txtConfAlterarSenha
            // 
            txtConfAlterarSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfAlterarSenha.Location = new Point(426, 201);
            txtConfAlterarSenha.Name = "txtConfAlterarSenha";
            txtConfAlterarSenha.PlaceholderText = "Confirme Sua Nova Senha";
            txtConfAlterarSenha.Size = new Size(300, 29);
            txtConfAlterarSenha.TabIndex = 1;
            txtConfAlterarSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAlterarSenha
            // 
            txtAlterarSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlterarSenha.Location = new Point(426, 150);
            txtAlterarSenha.Name = "txtAlterarSenha";
            txtAlterarSenha.PlaceholderText = "Nova Senha";
            txtAlterarSenha.Size = new Size(300, 29);
            txtAlterarSenha.TabIndex = 0;
            txtAlterarSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // lblAlterarSenha
            // 
            lblAlterarSenha.AutoSize = true;
            lblAlterarSenha.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlterarSenha.ForeColor = Color.White;
            lblAlterarSenha.Location = new Point(453, 55);
            lblAlterarSenha.Name = "lblAlterarSenha";
            lblAlterarSenha.Size = new Size(228, 47);
            lblAlterarSenha.TabIndex = 62;
            lblAlterarSenha.Text = "Alterar Senha";
            // 
            // TelaAlterarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(1149, 634);
            Controls.Add(lblAlterarSenha);
            Controls.Add(pictureBox1);
            Controls.Add(btSalvarSenha);
            Controls.Add(txtConfAlterarSenha);
            Controls.Add(txtAlterarSenha);
            Name = "TelaAlterarSenha";
            Text = "TelaAlterarSenha";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btSalvarSenha;
        private TextBox txtConfAlterarSenha;
        private TextBox txtAlterarSenha;
        private Label lblAlterarSenha;
    }
}