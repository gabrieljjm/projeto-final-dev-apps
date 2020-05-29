namespace ProjetoFinalDevApps
{
    partial class GestaoDevolucoes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btNovo = new System.Windows.Forms.Button();
            this.dgvDevolucoes = new System.Windows.Forms.DataGridView();
            this.bsDevolucoes = new System.Windows.Forms.BindingSource(this.components);
            this.btEditar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDevolucoes)).BeginInit();
            this.SuspendLayout();
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(12, 12);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 0;
            this.btNovo.Text = "Nova";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // dgvDevolucoes
            // 
            this.dgvDevolucoes.AllowUserToAddRows = false;
            this.dgvDevolucoes.AllowUserToDeleteRows = false;
            this.dgvDevolucoes.AllowUserToResizeRows = false;
            this.dgvDevolucoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDevolucoes.AutoGenerateColumns = false;
            this.dgvDevolucoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descricao,
            this.DataDevolucao,
            this.Valor});
            this.dgvDevolucoes.DataSource = this.bsDevolucoes;
            this.dgvDevolucoes.Location = new System.Drawing.Point(12, 41);
            this.dgvDevolucoes.MultiSelect = false;
            this.dgvDevolucoes.Name = "dgvDevolucoes";
            this.dgvDevolucoes.ReadOnly = true;
            this.dgvDevolucoes.RowHeadersVisible = false;
            this.dgvDevolucoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevolucoes.Size = new System.Drawing.Size(361, 243);
            this.dgvDevolucoes.TabIndex = 1;
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(93, 12);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 43;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // DataDevolucao
            // 
            this.DataDevolucao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DataDevolucao.DataPropertyName = "DataDevolucao";
            this.DataDevolucao.HeaderText = "Data";
            this.DataDevolucao.Name = "DataDevolucao";
            this.DataDevolucao.ReadOnly = true;
            this.DataDevolucao.Width = 55;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Valor.DataPropertyName = "ValorDevolvido";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "€";
            this.Valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 56;
            // 
            // GestaoDevolucoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 296);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.dgvDevolucoes);
            this.Controls.Add(this.btNovo);
            this.Name = "GestaoDevolucoes";
            this.Text = "GestaoDevolucoes";
            this.Activated += new System.EventHandler(this.GestaoDevolucoes_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDevolucoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.DataGridView dgvDevolucoes;
        private System.Windows.Forms.BindingSource bsDevolucoes;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}