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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btEditarTrabalho = new System.Windows.Forms.Button();
            this.btNovoPedidoTabelado = new System.Windows.Forms.Button();
            this.dgvTrabalhos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Levantado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datalev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTrabalhos = new System.Windows.Forms.BindingSource(this.components);
            this.btExportar = new System.Windows.Forms.Button();
            this.btDevolucoes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabalhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrabalhos)).BeginInit();
            this.SuspendLayout();
            // 
            // btEditarTrabalho
            // 
            this.btEditarTrabalho.Location = new System.Drawing.Point(174, 12);
            this.btEditarTrabalho.Name = "btEditarTrabalho";
            this.btEditarTrabalho.Size = new System.Drawing.Size(127, 23);
            this.btEditarTrabalho.TabIndex = 8;
            this.btEditarTrabalho.Text = "Editar";
            this.btEditarTrabalho.UseVisualStyleBackColor = true;
            this.btEditarTrabalho.Click += new System.EventHandler(this.btVerPedidoTabelado_Click);
            // 
            // btNovoPedidoTabelado
            // 
            this.btNovoPedidoTabelado.Location = new System.Drawing.Point(12, 12);
            this.btNovoPedidoTabelado.Name = "btNovoPedidoTabelado";
            this.btNovoPedidoTabelado.Size = new System.Drawing.Size(127, 23);
            this.btNovoPedidoTabelado.TabIndex = 7;
            this.btNovoPedidoTabelado.Text = "Novo";
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
            this.descricao,
            this.cor,
            this.pago,
            this.Levantado,
            this.valor,
            this.datalev,
            this.observacoes});
            this.dgvTrabalhos.DataSource = this.bsTrabalhos;
            this.dgvTrabalhos.Location = new System.Drawing.Point(12, 41);
            this.dgvTrabalhos.MultiSelect = false;
            this.dgvTrabalhos.Name = "dgvTrabalhos";
            this.dgvTrabalhos.ReadOnly = true;
            this.dgvTrabalhos.RowHeadersVisible = false;
            this.dgvTrabalhos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrabalhos.Size = new System.Drawing.Size(779, 397);
            this.dgvTrabalhos.TabIndex = 9;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 43;
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
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "€";
            this.valor.DefaultCellStyle = dataGridViewCellStyle2;
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
            // btExportar
            // 
            this.btExportar.Location = new System.Drawing.Point(664, 12);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(127, 23);
            this.btExportar.TabIndex = 10;
            this.btExportar.Text = "Fatura";
            this.btExportar.UseVisualStyleBackColor = true;
            this.btExportar.Click += new System.EventHandler(this.btExportar_Click);
            // 
            // btDevolucoes
            // 
            this.btDevolucoes.Location = new System.Drawing.Point(503, 12);
            this.btDevolucoes.Name = "btDevolucoes";
            this.btDevolucoes.Size = new System.Drawing.Size(127, 23);
            this.btDevolucoes.TabIndex = 11;
            this.btDevolucoes.Text = "Devoluções";
            this.btDevolucoes.UseVisualStyleBackColor = true;
            this.btDevolucoes.Click += new System.EventHandler(this.btDevolucoes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Apagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GestaoTrabalhos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btDevolucoes);
            this.Controls.Add(this.btExportar);
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
        private System.Windows.Forms.Button btExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Levantado;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn datalev;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoes;
        private System.Windows.Forms.Button button1;
    }
}