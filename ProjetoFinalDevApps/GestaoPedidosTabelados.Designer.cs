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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btEditarPedidoTabelado = new System.Windows.Forms.Button();
            this.btNovoPedidoTabelado = new System.Windows.Forms.Button();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.bsPedidosTabelados = new System.Windows.Forms.BindingSource(this.components);
            this.btVerTrabalho = new System.Windows.Forms.Button();
            this.btDevolucoes = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.idPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.levantado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedidosTabelados)).BeginInit();
            this.SuspendLayout();
            // 
            // btEditarPedidoTabelado
            // 
            this.btEditarPedidoTabelado.Location = new System.Drawing.Point(93, 12);
            this.btEditarPedidoTabelado.Name = "btEditarPedidoTabelado";
            this.btEditarPedidoTabelado.Size = new System.Drawing.Size(75, 23);
            this.btEditarPedidoTabelado.TabIndex = 1;
            this.btEditarPedidoTabelado.Text = "Editar ";
            this.btEditarPedidoTabelado.UseVisualStyleBackColor = true;
            this.btEditarPedidoTabelado.Click += new System.EventHandler(this.btVerPedidoTabelado_Click);
            // 
            // btNovoPedidoTabelado
            // 
            this.btNovoPedidoTabelado.Location = new System.Drawing.Point(12, 12);
            this.btNovoPedidoTabelado.Name = "btNovoPedidoTabelado";
            this.btNovoPedidoTabelado.Size = new System.Drawing.Size(75, 23);
            this.btNovoPedidoTabelado.TabIndex = 0;
            this.btNovoPedidoTabelado.Text = "Novo ";
            this.btNovoPedidoTabelado.UseVisualStyleBackColor = true;
            this.btNovoPedidoTabelado.Click += new System.EventHandler(this.btNovoPedidoTabelado_Click);
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
            this.dgvPedido.Size = new System.Drawing.Size(656, 367);
            this.dgvPedido.TabIndex = 5;
            // 
            // btVerTrabalho
            // 
            this.btVerTrabalho.Location = new System.Drawing.Point(492, 12);
            this.btVerTrabalho.Name = "btVerTrabalho";
            this.btVerTrabalho.Size = new System.Drawing.Size(85, 23);
            this.btVerTrabalho.TabIndex = 3;
            this.btVerTrabalho.Text = "Trabalhos";
            this.btVerTrabalho.UseVisualStyleBackColor = true;
            this.btVerTrabalho.Click += new System.EventHandler(this.btAdicionarTrabalho_Click);
            // 
            // btDevolucoes
            // 
            this.btDevolucoes.Location = new System.Drawing.Point(583, 12);
            this.btDevolucoes.Name = "btDevolucoes";
            this.btDevolucoes.Size = new System.Drawing.Size(85, 23);
            this.btDevolucoes.TabIndex = 4;
            this.btDevolucoes.Text = "Devoluções";
            this.btDevolucoes.UseVisualStyleBackColor = true;
            this.btDevolucoes.Click += new System.EventHandler(this.btDevolucoes_Click);
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(174, 12);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(75, 23);
            this.btApagar.TabIndex = 2;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // idPedido
            // 
            this.idPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idPedido.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.idPedido.DefaultCellStyle = dataGridViewCellStyle1;
            this.idPedido.HeaderText = "ID";
            this.idPedido.Name = "idPedido";
            this.idPedido.ReadOnly = true;
            this.idPedido.Width = 43;
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
            // GestaoPedidosTabelados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 420);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btDevolucoes);
            this.Controls.Add(this.btVerTrabalho);
            this.Controls.Add(this.btEditarPedidoTabelado);
            this.Controls.Add(this.btNovoPedidoTabelado);
            this.Controls.Add(this.dgvPedido);
            this.Name = "GestaoPedidosTabelados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos Tabelados";
            this.Activated += new System.EventHandler(this.GestaoPedidosTabelados_Activated);
            this.Load += new System.EventHandler(this.GestaoPedidosTabelados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedidosTabelados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEditarPedidoTabelado;
        private System.Windows.Forms.Button btNovoPedidoTabelado;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.BindingSource bsPedidosTabelados;
        private System.Windows.Forms.Button btVerTrabalho;
        private System.Windows.Forms.Button btDevolucoes;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPedido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn levantado;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoes;
    }
}