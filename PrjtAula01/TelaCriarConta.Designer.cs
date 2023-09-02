namespace PrjtAula01
{
    partial class TelaCriarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCriarConta));
            lblValorMin = new Label();
            lblDepInicial = new Label();
            txtValDepConta = new TextBox();
            pictureBox1 = new PictureBox();
            btCriarConta = new Button();
            txtConfSenhaCriar = new TextBox();
            txtSenhaCriar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblValorMin
            // 
            lblValorMin.AutoSize = true;
            lblValorMin.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorMin.ForeColor = Color.White;
            lblValorMin.Location = new Point(319, 48);
            lblValorMin.Name = "lblValorMin";
            lblValorMin.Size = new Size(161, 28);
            lblValorMin.TabIndex = 25;
            lblValorMin.Text = "(mínimo R$ 1,00)";
            // 
            // lblDepInicial
            // 
            lblDepInicial.AutoSize = true;
            lblDepInicial.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepInicial.ForeColor = Color.White;
            lblDepInicial.Location = new Point(248, 20);
            lblDepInicial.Name = "lblDepInicial";
            lblDepInicial.Size = new Size(295, 28);
            lblDepInicial.TabIndex = 23;
            lblDepInicial.Text = "Insira o valor do seu 1º depósito";
            // 
            // txtValDepConta
            // 
            txtValDepConta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValDepConta.Location = new Point(247, 95);
            txtValDepConta.Name = "txtValDepConta";
            txtValDepConta.PlaceholderText = "R$ 0,00";
            txtValDepConta.Size = new Size(300, 29);
            txtValDepConta.TabIndex = 0;
            txtValDepConta.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(330, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 124);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // btCriarConta
            // 
            btCriarConta.BackColor = Color.White;
            btCriarConta.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btCriarConta.Location = new Point(301, 374);
            btCriarConta.Name = "btCriarConta";
            btCriarConta.Size = new Size(203, 54);
            btCriarConta.TabIndex = 3;
            btCriarConta.Text = "Criar Conta";
            btCriarConta.UseVisualStyleBackColor = false;
            btCriarConta.Click += btCriarConta_Click;
            // 
            // txtConfSenhaCriar
            // 
            txtConfSenhaCriar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfSenhaCriar.Location = new Point(247, 324);
            txtConfSenhaCriar.Name = "txtConfSenhaCriar";
            txtConfSenhaCriar.PlaceholderText = "Confirme sua senha";
            txtConfSenhaCriar.Size = new Size(300, 29);
            txtConfSenhaCriar.TabIndex = 2;
            txtConfSenhaCriar.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSenhaCriar
            // 
            txtSenhaCriar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaCriar.Location = new Point(247, 273);
            txtSenhaCriar.Name = "txtSenhaCriar";
            txtSenhaCriar.PlaceholderText = "Criar senha";
            txtSenhaCriar.Size = new Size(300, 29);
            txtSenhaCriar.TabIndex = 1;
            txtSenhaCriar.TextAlign = HorizontalAlignment.Center;
            // 
            // TelaCriarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(800, 450);
            Controls.Add(lblValorMin);
            Controls.Add(lblDepInicial);
            Controls.Add(txtValDepConta);
            Controls.Add(pictureBox1);
            Controls.Add(btCriarConta);
            Controls.Add(txtConfSenhaCriar);
            Controls.Add(txtSenhaCriar);
            Name = "TelaCriarConta";
            Text = "TelaCriarConta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValorMin;
        private Label lblDepInicial;
        private TextBox txtValDepConta;
        private PictureBox pictureBox1;
        private Button btCriarConta;
        private TextBox txtConfSenhaCriar;
        private TextBox txtSenhaCriar;
    }
}