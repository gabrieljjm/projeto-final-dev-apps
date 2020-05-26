namespace ProjetoFinalDevApps
{
    partial class GestaoTrabalhos
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
            this.btEditarTrabalho = new System.Windows.Forms.Button();
            this.btNovoPedidoTabelado = new System.Windows.Forms.Button();
            this.dgvTrabalhos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Levantado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datalev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTrabalhos = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabalhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrabalhos)).BeginInit();
            this.SuspendLayout();
            // 
            // btEditarTrabalho
            // 
            this.btEditarTrabalho.Location = new System.Drawing.Point(185, 21);
            this.btEditarTrabalho.Name = "btEditarTrabalho";
            this.btEditarTrabalho.Size = new System.Drawing.Size(157, 23);
            this.btEditarTrabalho.TabIndex = 8;
            this.btEditarTrabalho.Text = "Editar trabalho";
            this.btEditarTrabalho.UseVisualStyleBackColor = true;
            this.btEditarTrabalho.Click += new System.EventHandler(this.btVerPedidoTabelado_Click);
            // 
            // btNovoPedidoTabelado
            // 
            this.btNovoPedidoTabelado.Location = new System.Drawing.Point(22, 21);
            this.btNovoPedidoTabelado.Name = "btNovoPedidoTabelado";
            this.btNovoPedidoTabelado.Size = new System.Drawing.Size(157, 23);
            this.btNovoPedidoTabelado.TabIndex = 7;
            this.btNovoPedidoTabelado.Text = "Novo trabalho";
            this.btNovoPedidoTabelado.UseVisualStyleBackColor = true;
            this.btNovoPedidoTabelado.Click += new System.EventHandler(this.btNovoPedidoTabelado_Click);
            // 
            // dgvTrabalhos
            // 
            this.dgvTrabalhos.AllowUserToAddRows = false;
            this.dgvTrabalhos.AllowUserToDeleteRows = false;
            this.dgvTrabalhos.AutoGenerateColumns = false;
            this.dgvTrabalhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabalhos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idPedido,
            this.descricao,
            this.cor,
            this.pago,
            this.Levantado,
            this.valor,
            this.datalev,
            this.observacoes});
            this.dgvTrabalhos.DataSource = this.bsTrabalhos;
            this.dgvTrabalhos.Location = new System.Drawing.Point(22, 67);
            this.dgvTrabalhos.MultiSelect = false;
            this.dgvTrabalhos.Name = "dgvTrabalhos";
            this.dgvTrabalhos.ReadOnly = true;
            this.dgvTrabalhos.RowHeadersVisible = false;
            this.dgvTrabalhos.Size = new System.Drawing.Size(730, 339);
            this.dgvTrabalhos.TabIndex = 9;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "ID Trabalho";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // idPedido
            // 
            this.idPedido.DataPropertyName = "PedidoTabeladoId";
            this.idPedido.HeaderText = "ID Pedido";
            this.idPedido.Name = "idPedido";
            this.idPedido.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "DescricaoPeca";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // cor
            // 
            this.cor.DataPropertyName = "CorPeca";
            this.cor.HeaderText = "Cor";
            this.cor.Name = "cor";
            this.cor.ReadOnly = true;
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
            // Levantado
            // 
            this.Levantado.DataPropertyName = "Levantado";
            this.Levantado.HeaderText = "Levantado";
            this.Levantado.Name = "Levantado";
            this.Levantado.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "ValorPago";
            this.valor.HeaderText = "Valor pago";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // datalev
            // 
            this.datalev.DataPropertyName = "DataLevantamento";
            this.datalev.HeaderText = "Data levantamento";
            this.datalev.Name = "datalev";
            this.datalev.ReadOnly = true;
            // 
            // observacoes
            // 
            this.observacoes.DataPropertyName = "Observacoes";
            this.observacoes.HeaderText = "Observações";
            this.observacoes.Name = "observacoes";
            this.observacoes.ReadOnly = true;
            // 
            // GestaoTrabalhos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTrabalhos);
            this.Controls.Add(this.btEditarTrabalho);
            this.Controls.Add(this.btNovoPedidoTabelado);
            this.Name = "GestaoTrabalhos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestaoTrabalhos";
            this.Activated += new System.EventHandler(this.GestaoTrabalhos_Activated);
            this.Load += new System.EventHandler(this.GestaoTrabalhos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabalhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrabalhos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEditarTrabalho;
        private System.Windows.Forms.Button btNovoPedidoTabelado;
        private System.Windows.Forms.DataGridView dgvTrabalhos;
        private System.Windows.Forms.BindingSource bsTrabalhos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Levantado;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn datalev;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoes;
    }
}