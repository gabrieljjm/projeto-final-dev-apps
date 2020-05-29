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
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.bsOrcamento = new System.Windows.Forms.BindingSource(this.components);
            this.btNovoOrcamento = new System.Windows.Forms.Button();
            this.btVerOrcamento = new System.Windows.Forms.Button();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.levantado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aceite = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.dgvPedido.AutoGenerateColumns = false;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.dataPedido,
            this.pago,
            this.levantado,
            this.aceite,
            this.observacoes,
            this.descricao,
            this.valor});
            this.dgvPedido.DataSource = this.bsOrcamento;
            this.dgvPedido.Location = new System.Drawing.Point(27, 53);
            this.dgvPedido.MultiSelect = false;
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(639, 295);
            this.dgvPedido.TabIndex = 0;
            // 
            // btNovoOrcamento
            // 
            this.btNovoOrcamento.Location = new System.Drawing.Point(27, 24);
            this.btNovoOrcamento.Name = "btNovoOrcamento";
            this.btNovoOrcamento.Size = new System.Drawing.Size(157, 23);
            this.btNovoOrcamento.TabIndex = 1;
            this.btNovoOrcamento.Text = "Novo orçamento";
            this.btNovoOrcamento.UseVisualStyleBackColor = true;
            this.btNovoOrcamento.Click += new System.EventHandler(this.btNovoOrcamento_Click);
            // 
            // btVerOrcamento
            // 
            this.btVerOrcamento.Location = new System.Drawing.Point(190, 24);
            this.btVerOrcamento.Name = "btVerOrcamento";
            this.btVerOrcamento.Size = new System.Drawing.Size(157, 23);
            this.btVerOrcamento.TabIndex = 2;
            this.btVerOrcamento.Text = "Editar orçamento";
            this.btVerOrcamento.UseVisualStyleBackColor = true;
            this.btVerOrcamento.Click += new System.EventHandler(this.btVerOrcamento_Click);
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "ClienteId";
            this.idCliente.HeaderText = "ID Cliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            // 
            // dataPedido
            // 
            this.dataPedido.DataPropertyName = "DataPedido";
            this.dataPedido.HeaderText = "Data Pedido";
            this.dataPedido.Name = "dataPedido";
            this.dataPedido.ReadOnly = true;
            // 
            // pago
            // 
            this.pago.DataPropertyName = "Pago";
            this.pago.HeaderText = "Pago";
            this.pago.Name = "pago";
            this.pago.ReadOnly = true;
            this.pago.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // levantado
            // 
            this.levantado.DataPropertyName = "Levantado";
            this.levantado.HeaderText = "Levantado";
            this.levantado.Name = "levantado";
            this.levantado.ReadOnly = true;
            this.levantado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.levantado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // aceite
            // 
            this.aceite.DataPropertyName = "Aceite";
            this.aceite.HeaderText = "Aceite";
            this.aceite.Name = "aceite";
            this.aceite.ReadOnly = true;
            this.aceite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aceite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "€";
            this.valor.DefaultCellStyle = dataGridViewCellStyle1;
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // GestaoOrcamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 369);
            this.Controls.Add(this.btVerOrcamento);
            this.Controls.Add(this.btNovoOrcamento);
            this.Controls.Add(this.dgvPedido);
            this.Name = "GestaoOrcamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestaoOrcamento";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPedido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn levantado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aceite;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}