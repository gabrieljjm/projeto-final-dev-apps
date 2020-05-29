namespace ProjetoFinalDevApps
{
    partial class GestaoOrcamentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.bsOrcamento = new System.Windows.Forms.BindingSource(this.components);
            this.btNovoOrcamento = new System.Windows.Forms.Button();
            this.btVerOrcamento = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aceite = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.levantado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrcamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.AllowUserToResizeColumns = false;
            this.dgvPedido.AllowUserToResizeRows = false;
            this.dgvPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedido.AutoGenerateColumns = false;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.idCliente,
            this.dataPedido,
            this.aceite,
            this.pago,
            this.levantado,
            this.observacoes,
            this.descricao,
            this.valor});
            this.dgvPedido.DataSource = this.bsOrcamento;
            this.dgvPedido.Location = new System.Drawing.Point(12, 41);
            this.dgvPedido.MultiSelect = false;
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.RowHeadersVisible = false;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(662, 316);
            this.dgvPedido.TabIndex = 0;
            // 
            // btNovoOrcamento
            // 
            this.btNovoOrcamento.Location = new System.Drawing.Point(12, 12);
            this.btNovoOrcamento.Name = "btNovoOrcamento";
            this.btNovoOrcamento.Size = new System.Drawing.Size(84, 23);
            this.btNovoOrcamento.TabIndex = 1;
            this.btNovoOrcamento.Text = "Novo";
            this.btNovoOrcamento.UseVisualStyleBackColor = true;
            this.btNovoOrcamento.Click += new System.EventHandler(this.btNovoOrcamento_Click);
            // 
            // btVerOrcamento
            // 
            this.btVerOrcamento.Location = new System.Drawing.Point(102, 12);
            this.btVerOrcamento.Name = "btVerOrcamento";
            this.btVerOrcamento.Size = new System.Drawing.Size(85, 23);
            this.btVerOrcamento.TabIndex = 2;
            this.btVerOrcamento.Text = "Editar";
            this.btVerOrcamento.UseVisualStyleBackColor = true;
            this.btVerOrcamento.Click += new System.EventHandler(this.btVerOrcamento_Click);
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(193, 12);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(75, 23);
            this.btApagar.TabIndex = 3;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // idCliente
            // 
            this.idCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idCliente.DataPropertyName = "Cliente";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.idCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.idCliente.HeaderText = "ID - Cliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Width = 84;
            // 
            // dataPedido
            // 
            this.dataPedido.DataPropertyName = "DataPedido";
            this.dataPedido.HeaderText = "Data Pedido";
            this.dataPedido.Name = "dataPedido";
            this.dataPedido.ReadOnly = true;
            // 
            // aceite
            // 
            this.aceite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aceite.DataPropertyName = "Aceite";
            this.aceite.HeaderText = "Aceite";
            this.aceite.Name = "aceite";
            this.aceite.ReadOnly = true;
            this.aceite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aceite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.aceite.Width = 62;
            // 
            // pago
            // 
            this.pago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pago.DataPropertyName = "Pago";
            this.pago.HeaderText = "Pago";
            this.pago.Name = "pago";
            this.pago.ReadOnly = true;
            this.pago.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pago.Width = 57;
            // 
            // levantado
            // 
            this.levantado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.levantado.DataPropertyName = "Levantado";
            this.levantado.HeaderText = "Levantado";
            this.levantado.Name = "levantado";
            this.levantado.ReadOnly = true;
            this.levantado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.levantado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.levantado.Width = 83;
            // 
            // observacoes
            // 
            this.observacoes.DataPropertyName = "Observacoes";
            this.observacoes.HeaderText = "Observações";
            this.observacoes.Name = "observacoes";
            this.observacoes.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "Descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "Valor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "€";
            this.valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // GestaoOrcamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 369);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btVerOrcamento);
            this.Controls.Add(this.btNovoOrcamento);
            this.Controls.Add(this.dgvPedido);
            this.Name = "GestaoOrcamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orçamento";
            this.Activated += new System.EventHandler(this.GestaoOrcamento_Activated);
            this.Load += new System.EventHandler(this.GestaoOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrcamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btNovoOrcamento;
        private System.Windows.Forms.Button btVerOrcamento;
        private System.Windows.Forms.BindingSource bsOrcamento;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPedido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aceite;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn levantado;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}