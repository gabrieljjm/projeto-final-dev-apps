namespace ProjetoFinalDevApps
{
    partial class GestaoPedidosTabelados
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
            this.btVerPedidoTabelado = new System.Windows.Forms.Button();
            this.btNovoPedidoTabelado = new System.Windows.Forms.Button();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.idPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.levantado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPedidosTabelados = new System.Windows.Forms.BindingSource(this.components);
            this.btVerTrabalho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedidosTabelados)).BeginInit();
            this.SuspendLayout();
            // 
            // btVerPedidoTabelado
            // 
            this.btVerPedidoTabelado.Location = new System.Drawing.Point(175, 12);
            this.btVerPedidoTabelado.Name = "btVerPedidoTabelado";
            this.btVerPedidoTabelado.Size = new System.Drawing.Size(157, 23);
            this.btVerPedidoTabelado.TabIndex = 5;
            this.btVerPedidoTabelado.Text = "Ver pedido tabelado";
            this.btVerPedidoTabelado.UseVisualStyleBackColor = true;
            this.btVerPedidoTabelado.Click += new System.EventHandler(this.btVerPedidoTabelado_Click);
            // 
            // btNovoPedidoTabelado
            // 
            this.btNovoPedidoTabelado.Location = new System.Drawing.Point(12, 12);
            this.btNovoPedidoTabelado.Name = "btNovoPedidoTabelado";
            this.btNovoPedidoTabelado.Size = new System.Drawing.Size(157, 23);
            this.btNovoPedidoTabelado.TabIndex = 4;
            this.btNovoPedidoTabelado.Text = "Novo pedido tabelado";
            this.btNovoPedidoTabelado.UseVisualStyleBackColor = true;
            this.btNovoPedidoTabelado.Click += new System.EventHandler(this.btNovoPedidoTabelado_Click);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.AutoGenerateColumns = false;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedido,
            this.idCliente,
            this.dataPedido,
            this.pago,
            this.levantado,
            this.observacoes});
            this.dgvPedido.DataSource = this.bsPedidosTabelados;
            this.dgvPedido.Location = new System.Drawing.Point(12, 41);
            this.dgvPedido.MultiSelect = false;
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.RowHeadersVisible = false;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(639, 295);
            this.dgvPedido.TabIndex = 3;
            // 
            // idPedido
            // 
            this.idPedido.DataPropertyName = "Id";
            this.idPedido.HeaderText = "ID Pedido";
            this.idPedido.Name = "idPedido";
            this.idPedido.ReadOnly = true;
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
            // observacoes
            // 
            this.observacoes.DataPropertyName = "Observacoes";
            this.observacoes.HeaderText = "Observações";
            this.observacoes.Name = "observacoes";
            this.observacoes.ReadOnly = true;
            // 
            // btVerTrabalho
            // 
            this.btVerTrabalho.Location = new System.Drawing.Point(338, 12);
            this.btVerTrabalho.Name = "btVerTrabalho";
            this.btVerTrabalho.Size = new System.Drawing.Size(157, 23);
            this.btVerTrabalho.TabIndex = 6;
            this.btVerTrabalho.Text = "Ver trabalhos";
            this.btVerTrabalho.UseVisualStyleBackColor = true;
            this.btVerTrabalho.Click += new System.EventHandler(this.btAdicionarTrabalho_Click);
            // 
            // GestaoPedidosTabelados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 420);
            this.Controls.Add(this.btVerTrabalho);
            this.Controls.Add(this.btVerPedidoTabelado);
            this.Controls.Add(this.btNovoPedidoTabelado);
            this.Controls.Add(this.dgvPedido);
            this.Name = "GestaoPedidosTabelados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestaoPedidosTabelados";
            this.Activated += new System.EventHandler(this.GestaoPedidosTabelados_Activated);
            this.Load += new System.EventHandler(this.GestaoPedidosTabelados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedidosTabelados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btVerPedidoTabelado;
        private System.Windows.Forms.Button btNovoPedidoTabelado;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.BindingSource bsPedidosTabelados;
        private System.Windows.Forms.Button btVerTrabalho;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPedido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn levantado;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoes;
    }
}