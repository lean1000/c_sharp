namespace Sitema2
{
    partial class Gerenciamento_Clientes
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.button_pesquisarCliente = new System.Windows.Forms.Button();
            this.button_removerCliente = new System.Windows.Forms.Button();
            this.button_fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(43, 101);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(529, 316);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // button_pesquisarCliente
            // 
            this.button_pesquisarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisarCliente.Location = new System.Drawing.Point(696, 101);
            this.button_pesquisarCliente.Name = "button_pesquisarCliente";
            this.button_pesquisarCliente.Size = new System.Drawing.Size(227, 57);
            this.button_pesquisarCliente.TabIndex = 1;
            this.button_pesquisarCliente.Text = "Pesquisar";
            this.button_pesquisarCliente.UseVisualStyleBackColor = true;
            this.button_pesquisarCliente.Click += new System.EventHandler(this.button_pesquisarCliente_Click);
            // 
            // button_removerCliente
            // 
            this.button_removerCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_removerCliente.Location = new System.Drawing.Point(696, 182);
            this.button_removerCliente.Name = "button_removerCliente";
            this.button_removerCliente.Size = new System.Drawing.Size(227, 57);
            this.button_removerCliente.TabIndex = 2;
            this.button_removerCliente.Text = "Remover";
            this.button_removerCliente.UseVisualStyleBackColor = true;
            this.button_removerCliente.Click += new System.EventHandler(this.button_removerCliente_Click);
            // 
            // button_fechar
            // 
            this.button_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fechar.Location = new System.Drawing.Point(696, 360);
            this.button_fechar.Name = "button_fechar";
            this.button_fechar.Size = new System.Drawing.Size(227, 57);
            this.button_fechar.TabIndex = 3;
            this.button_fechar.Text = "Fechar";
            this.button_fechar.UseVisualStyleBackColor = true;
            this.button_fechar.Click += new System.EventHandler(this.button_fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gerenciamento de Cliente";
            // 
            // Gerenciamento_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_fechar);
            this.Controls.Add(this.button_removerCliente);
            this.Controls.Add(this.button_pesquisarCliente);
            this.Controls.Add(this.dgvCliente);
            this.Name = "Gerenciamento_Clientes";
            this.Text = "Gerenciamento_Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button button_pesquisarCliente;
        private System.Windows.Forms.Button button_removerCliente;
        private System.Windows.Forms.Button button_fechar;
        private System.Windows.Forms.Label label1;
    }
}