namespace Lanches_maju
{
    partial class gerenciamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gerenciamento));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCadastrarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCadastrarProduto = new System.Windows.Forms.Button();
            this.buttonEditarProduto = new System.Windows.Forms.Button();
            this.buttonEditarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCadastrarCliente
            // 
            this.buttonCadastrarCliente.BackColor = System.Drawing.Color.Moccasin;
            this.buttonCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrarCliente.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrarCliente.Location = new System.Drawing.Point(78, 244);
            this.buttonCadastrarCliente.Name = "buttonCadastrarCliente";
            this.buttonCadastrarCliente.Size = new System.Drawing.Size(196, 62);
            this.buttonCadastrarCliente.TabIndex = 2;
            this.buttonCadastrarCliente.Text = "Cadastrar Cliente";
            this.buttonCadastrarCliente.UseVisualStyleBackColor = false;
            this.buttonCadastrarCliente.Click += new System.EventHandler(this.buttonCadastrarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(279, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "lanches da Maju";
            // 
            // buttonCadastrarProduto
            // 
            this.buttonCadastrarProduto.BackColor = System.Drawing.Color.Moccasin;
            this.buttonCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrarProduto.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrarProduto.Location = new System.Drawing.Point(523, 244);
            this.buttonCadastrarProduto.Name = "buttonCadastrarProduto";
            this.buttonCadastrarProduto.Size = new System.Drawing.Size(196, 62);
            this.buttonCadastrarProduto.TabIndex = 4;
            this.buttonCadastrarProduto.Text = "Cadastrar Produto";
            this.buttonCadastrarProduto.UseVisualStyleBackColor = false;
            this.buttonCadastrarProduto.Click += new System.EventHandler(this.buttonCadastrarProduto_Click);
            // 
            // buttonEditarProduto
            // 
            this.buttonEditarProduto.BackColor = System.Drawing.Color.Moccasin;
            this.buttonEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarProduto.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarProduto.Location = new System.Drawing.Point(523, 332);
            this.buttonEditarProduto.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEditarProduto.Name = "buttonEditarProduto";
            this.buttonEditarProduto.Size = new System.Drawing.Size(196, 62);
            this.buttonEditarProduto.TabIndex = 5;
            this.buttonEditarProduto.Text = "Editar Produto";
            this.buttonEditarProduto.UseVisualStyleBackColor = false;
            this.buttonEditarProduto.Click += new System.EventHandler(this.buttonEditarProduto_Click);
            // 
            // buttonEditarCliente
            // 
            this.buttonEditarCliente.BackColor = System.Drawing.Color.Moccasin;
            this.buttonEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarCliente.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarCliente.Location = new System.Drawing.Point(78, 332);
            this.buttonEditarCliente.Name = "buttonEditarCliente";
            this.buttonEditarCliente.Size = new System.Drawing.Size(196, 62);
            this.buttonEditarCliente.TabIndex = 6;
            this.buttonEditarCliente.Text = "Editar Cliente";
            this.buttonEditarCliente.UseVisualStyleBackColor = false;
            this.buttonEditarCliente.Click += new System.EventHandler(this.buttonEditarCliente_Click);
            // 
            // gerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEditarCliente);
            this.Controls.Add(this.buttonEditarProduto);
            this.Controls.Add(this.buttonCadastrarProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCadastrarCliente);
            this.Controls.Add(this.pictureBox1);
            this.Name = "gerenciamento";
            this.Text = "gerenciamento";
            this.Load += new System.EventHandler(this.gerenciamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCadastrarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCadastrarProduto;
        private System.Windows.Forms.Button buttonEditarProduto;
        private System.Windows.Forms.Button buttonEditarCliente;
    }
}