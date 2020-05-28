namespace ProjetoFinalDevApps
{
    partial class Menu
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
            this.btFormClientes = new System.Windows.Forms.Button();
            this.btFormPedidos = new System.Windows.Forms.Button();
            this.btFormFornecedores = new System.Windows.Forms.Button();
            this.btFormMateriais = new System.Windows.Forms.Button();
            this.btPecaArranjo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btFormClientes
            // 
            this.btFormClientes.Location = new System.Drawing.Point(12, 12);
            this.btFormClientes.Name = "btFormClientes";
            this.btFormClientes.Size = new System.Drawing.Size(75, 23);
            this.btFormClientes.TabIndex = 0;
            this.btFormClientes.Text = "Clientes";
            this.btFormClientes.UseVisualStyleBackColor = true;
            this.btFormClientes.Click += new System.EventHandler(this.btFormClientes_Click);
            // 
            // btFormPedidos
            // 
            this.btFormPedidos.Location = new System.Drawing.Point(103, 12);
            this.btFormPedidos.Name = "btFormPedidos";
            this.btFormPedidos.Size = new System.Drawing.Size(75, 23);
            this.btFormPedidos.TabIndex = 1;
            this.btFormPedidos.Text = "Pedidos";
            this.btFormPedidos.UseVisualStyleBackColor = true;
            this.btFormPedidos.Click += new System.EventHandler(this.btFormPedidos_Click);
            // 
            // btFormFornecedores
            // 
            this.btFormFornecedores.Location = new System.Drawing.Point(195, 12);
            this.btFormFornecedores.Name = "btFormFornecedores";
            this.btFormFornecedores.Size = new System.Drawing.Size(83, 23);
            this.btFormFornecedores.TabIndex = 2;
            this.btFormFornecedores.Text = "Fornecedores";
            this.btFormFornecedores.UseVisualStyleBackColor = true;
            this.btFormFornecedores.Click += new System.EventHandler(this.btFormFornecedores_Click);
            // 
            // btPecaArranjo
            // 
            this.btPecaArranjo.Location = new System.Drawing.Point(76, 41);
            this.btPecaArranjo.Name = "btPecaArranjo";
            this.btPecaArranjo.Size = new System.Drawing.Size(128, 23);
            this.btPecaArranjo.TabIndex = 3;
            this.btPecaArranjo.Text = "Peças e Arranjos";
            this.btPecaArranjo.UseVisualStyleBackColor = true;
            this.btPecaArranjo.Click += new System.EventHandler(this.btPecaArranjo_Click);
            // 
            // btFormMateriais
            // 
            this.btFormMateriais.Location = new System.Drawing.Point(295, 12);
            this.btFormMateriais.Name = "btFormMateriais";
            this.btFormMateriais.Size = new System.Drawing.Size(75, 23);
            this.btFormMateriais.TabIndex = 3;
            this.btFormMateriais.Text = "Materiais";
            this.btFormMateriais.UseVisualStyleBackColor = true;
            this.btFormMateriais.Click += new System.EventHandler(this.btFormMateriais_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btFormMateriais);
            this.Controls.Add(this.btFormFornecedores);
            this.Controls.Add(this.btPecaArranjo);
            this.Controls.Add(this.btFormPedidos);
            this.Controls.Add(this.btFormClientes);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFormClientes;
        private System.Windows.Forms.Button btFormPedidos;
        private System.Windows.Forms.Button btPecaArranjo;
        private System.Windows.Forms.Button btFormFornecedores;
        private System.Windows.Forms.Button btFormMateriais;
    }
}

