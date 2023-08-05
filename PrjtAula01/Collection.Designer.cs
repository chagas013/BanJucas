namespace PrjtAula01
{
    partial class Collection
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
            txtID = new TextBox();
            txtNome = new TextBox();
            btnAdd = new Button();
            btnListar = new Button();
            listListar = new ListBox();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(33, 27);
            txtID.Name = "txtID";
            txtID.Size = new Size(89, 32);
            txtID.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(33, 88);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(416, 29);
            txtNome.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(93, 152);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 33);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnListar
            // 
            btnListar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnListar.Location = new Point(265, 152);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(125, 33);
            btnListar.TabIndex = 3;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // listListar
            // 
            listListar.FormattingEnabled = true;
            listListar.ItemHeight = 15;
            listListar.Location = new Point(33, 226);
            listListar.Name = "listListar";
            listListar.Size = new Size(416, 184);
            listListar.TabIndex = 4;
            // 
            // Collection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 450);
            Controls.Add(listListar);
            Controls.Add(btnListar);
            Controls.Add(btnAdd);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Name = "Collection";
            Text = "Collection";
            Load += Collection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtNome;
        private Button btnAdd;
        private Button btnListar;
        private ListBox listListar;
    }
}