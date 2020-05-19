namespace ProjetoFinalDevApps
{
    partial class GestaoPedidos
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
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btNovoPedido = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btPago = new System.Windows.Forms.Button();
            this.btLevantado = new System.Windows.Forms.Button();
            this.btNovoTrabalho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(12, 41);
            this.dgvPedido.MultiSelect = false;
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(776, 361);
            this.dgvPedido.TabIndex = 6;
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellContentClick);
            // 
            // btNovoPedido
            // 
            this.btNovoPedido.Location = new System.Drawing.Point(12, 12);
            this.btNovoPedido.Name = "btNovoPedido";
            this.btNovoPedido.Size = new System.Drawing.Size(138, 23);
            this.btNovoPedido.TabIndex = 7;
            this.btNovoPedido.Text = "Novo pedido";
            this.btNovoPedido.UseVisualStyleBackColor = true;
            this.btNovoPedido.Click += new System.EventHandler(this.button1_Click);
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(300, 12);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(138, 23);
            this.btApagar.TabIndex = 8;
            this.btApagar.Text = "Apagar pedido";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(156, 12);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(138, 23);
            this.btEditar.TabIndex = 9;
            this.btEditar.Text = "Editar pedido";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btPago
            // 
            this.btPago.Enabled = false;
            this.btPago.Location = new System.Drawing.Point(606, 408);
            this.btPago.Name = "btPago";
            this.btPago.Size = new System.Drawing.Size(88, 23);
            this.btPago.TabIndex = 10;
            this.btPago.Text = "Pago";
            this.btPago.UseVisualStyleBackColor = true;
            this.btPago.Click += new System.EventHandler(this.btPago_Click);
            // 
            // btLevantado
            // 
            this.btLevantado.Enabled = false;
            this.btLevantado.Location = new System.Drawing.Point(700, 408);
            this.btLevantado.Name = "btLevantado";
            this.btLevantado.Size = new System.Drawing.Size(88, 23);
            this.btLevantado.TabIndex = 11;
            this.btLevantado.Text = "Levantado";
            this.btLevantado.UseVisualStyleBackColor = true;
            this.btLevantado.Click += new System.EventHandler(this.btLevantado_Click);
            // 
            // btNovoTrabalho
            // 
            this.btNovoTrabalho.Location = new System.Drawing.Point(13, 407);
            this.btNovoTrabalho.Name = "btNovoTrabalho";
            this.btNovoTrabalho.Size = new System.Drawing.Size(156, 23);
            this.btNovoTrabalho.TabIndex = 12;
            this.btNovoTrabalho.Text = "Novo trabalho";
            this.btNovoTrabalho.UseVisualStyleBackColor = true;
            this.btNovoTrabalho.Click += new System.EventHandler(this.btNovoTrabalho_Click);
            // 
            // GestaoPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.btNovoTrabalho);
            this.Controls.Add(this.btLevantado);
            this.Controls.Add(this.btPago);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btNovoPedido);
            this.Controls.Add(this.dgvPedido);
            this.Name = "GestaoPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Activated += new System.EventHandler(this.GestaoPedidos_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestaoPedidos_FormClosed);
            this.Load += new System.EventHandler(this.GestaoPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btNovoPedido;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btPago;
        private System.Windows.Forms.Button btLevantado;
        private System.Windows.Forms.Button btNovoTrabalho;
    }
}