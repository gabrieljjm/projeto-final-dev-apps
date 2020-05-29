namespace ProjetoFinalDevApps
{
    partial class GestaoFornecimentos
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
            this.components = new System.ComponentModel.Container();
            this.dgvFornecimentos = new System.Windows.Forms.DataGridView();
            this.MateriaisID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFornecimentos = new System.Windows.Forms.BindingSource(this.components);
            this.btApagar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btCriar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFornecimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFornecimentos
            // 
            this.dgvFornecimentos.AllowUserToAddRows = false;
            this.dgvFornecimentos.AllowUserToDeleteRows = false;
            this.dgvFornecimentos.AllowUserToResizeRows = false;
            this.dgvFornecimentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFornecimentos.AutoGenerateColumns = false;
            this.dgvFornecimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MateriaisID,
            this.preco,
            this.prazo});
            this.dgvFornecimentos.DataSource = this.bsFornecimentos;
            this.dgvFornecimentos.Location = new System.Drawing.Point(8, 41);
            this.dgvFornecimentos.MultiSelect = false;
            this.dgvFornecimentos.Name = "dgvFornecimentos";
            this.dgvFornecimentos.ReadOnly = true;
            this.dgvFornecimentos.RowHeadersVisible = false;
            this.dgvFornecimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecimentos.Size = new System.Drawing.Size(303, 307);
            this.dgvFornecimentos.TabIndex = 0;
            // 
            // MateriaisID
            // 
            this.MateriaisID.DataPropertyName = "StockMateriaisId";
            this.MateriaisID.HeaderText = "ID Material";
            this.MateriaisID.Name = "MateriaisID";
            this.MateriaisID.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "Preco";
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // prazo
            // 
            this.prazo.DataPropertyName = "PrazoEntrega";
            this.prazo.HeaderText = "Prazo Entrega";
            this.prazo.Name = "prazo";
            this.prazo.ReadOnly = true;
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(170, 12);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(75, 23);
            this.btApagar.TabIndex = 41;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(89, 12);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 40;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btCriar
            // 
            this.btCriar.Location = new System.Drawing.Point(8, 12);
            this.btCriar.Name = "btCriar";
            this.btCriar.Size = new System.Drawing.Size(75, 23);
            this.btCriar.TabIndex = 39;
            this.btCriar.Text = "Criar";
            this.btCriar.UseVisualStyleBackColor = true;
            this.btCriar.Click += new System.EventHandler(this.btCriar_Click);
            // 
            // GestaoFornecimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 360);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btCriar);
            this.Controls.Add(this.dgvFornecimentos);
            this.Name = "GestaoFornecimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Fornecimentos";
            this.Activated += new System.EventHandler(this.GestaoFornecimentos_Activated);
            this.Load += new System.EventHandler(this.GestaoFornecimentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFornecimentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsFornecimentos;
        private System.Windows.Forms.DataGridView dgvFornecimentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaisID;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn prazo;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btCriar;
    }
}