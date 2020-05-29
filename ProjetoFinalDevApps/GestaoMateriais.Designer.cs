namespace ProjetoFinalDevApps
{
    partial class GestaoMateriais
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
            this.btApagar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.dgvMateriais = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMateriais = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMateriais)).BeginInit();
            this.SuspendLayout();
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(174, 12);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(75, 23);
            this.btApagar.TabIndex = 57;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(93, 12);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 56;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(12, 12);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 55;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // dgvMateriais
            // 
            this.dgvMateriais.AllowUserToAddRows = false;
            this.dgvMateriais.AllowUserToDeleteRows = false;
            this.dgvMateriais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMateriais.AutoGenerateColumns = false;
            this.dgvMateriais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descricao,
            this.QuantAtual,
            this.ConsMed,
            this.StockMin});
            this.dgvMateriais.DataSource = this.bsMateriais;
            this.dgvMateriais.Location = new System.Drawing.Point(12, 41);
            this.dgvMateriais.Name = "dgvMateriais";
            this.dgvMateriais.ReadOnly = true;
            this.dgvMateriais.RowHeadersVisible = false;
            this.dgvMateriais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriais.Size = new System.Drawing.Size(584, 322);
            this.dgvMateriais.TabIndex = 58;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // QuantAtual
            // 
            this.QuantAtual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QuantAtual.DataPropertyName = "QuantAtual";
            this.QuantAtual.HeaderText = "Stock Atual";
            this.QuantAtual.Name = "QuantAtual";
            this.QuantAtual.ReadOnly = true;
            this.QuantAtual.Width = 80;
            // 
            // ConsMed
            // 
            this.ConsMed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ConsMed.DataPropertyName = "ConsumoMedioDiario";
            this.ConsMed.HeaderText = "Consumo Méd. Diário";
            this.ConsMed.Name = "ConsMed";
            this.ConsMed.ReadOnly = true;
            this.ConsMed.Width = 97;
            // 
            // StockMin
            // 
            this.StockMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StockMin.DataPropertyName = "StockMinimo";
            this.StockMin.HeaderText = "Stock Mínimo";
            this.StockMin.Name = "StockMin";
            this.StockMin.ReadOnly = true;
            this.StockMin.Width = 90;
            // 
            // GestaoMateriais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 375);
            this.Controls.Add(this.dgvMateriais);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNovo);
            this.Name = "GestaoMateriais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Materiais";
            this.Activated += new System.EventHandler(this.GestaoMateriais_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMateriais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.DataGridView dgvMateriais;
        private System.Windows.Forms.BindingSource bsMateriais;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMin;
    }
}