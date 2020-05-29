namespace ProjetoFinalDevApps
{
    partial class RegistarDevolucao
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
            this.bsTrabalhos = new System.Windows.Forms.BindingSource(this.components);
            this.bsSelecionados = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTrabalhos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Levantado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datalev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSelecionado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRem = new System.Windows.Forms.Button();
            this.btDevolverTodos = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btRegistar = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrabalhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelecionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabalhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecionado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrabalhos
            // 
            this.dgvTrabalhos.AllowUserToAddRows = false;
            this.dgvTrabalhos.AllowUserToDeleteRows = false;
            this.dgvTrabalhos.AllowUserToResizeColumns = false;
            this.dgvTrabalhos.AllowUserToResizeRows = false;
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
            this.dgvTrabalhos.Size = new System.Drawing.Size(420, 380);
            this.dgvTrabalhos.TabIndex = 10;
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
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "€";
            this.valor.DefaultCellStyle = dataGridViewCellStyle1;
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
            // dgvSelecionado
            // 
            this.dgvSelecionado.AllowUserToAddRows = false;
            this.dgvSelecionado.AllowUserToDeleteRows = false;
            this.dgvSelecionado.AllowUserToResizeColumns = false;
            this.dgvSelecionado.AllowUserToResizeRows = false;
            this.dgvSelecionado.AutoGenerateColumns = false;
            this.dgvSelecionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelecionado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvSelecionado.DataSource = this.bsSelecionados;
            this.dgvSelecionado.Location = new System.Drawing.Point(544, 41);
            this.dgvSelecionado.MultiSelect = false;
            this.dgvSelecionado.Name = "dgvSelecionado";
            this.dgvSelecionado.ReadOnly = true;
            this.dgvSelecionado.RowHeadersVisible = false;
            this.dgvSelecionado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelecionado.Size = new System.Drawing.Size(420, 380);
            this.dgvSelecionado.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DescricaoPeca";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CorPeca";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Pago";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Pago";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Levantado";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Levantado";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ValorPago";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "€";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor pago";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DataLevantamento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data levantamento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Observacoes";
            this.dataGridViewTextBoxColumn7.HeaderText = "Observações";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(438, 163);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 23);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRem
            // 
            this.btRem.Location = new System.Drawing.Point(438, 192);
            this.btRem.Name = "btRem";
            this.btRem.Size = new System.Drawing.Size(100, 23);
            this.btRem.TabIndex = 13;
            this.btRem.Text = "Remover";
            this.btRem.UseVisualStyleBackColor = true;
            this.btRem.Click += new System.EventHandler(this.btRem_Click);
            // 
            // btDevolverTodos
            // 
            this.btDevolverTodos.Location = new System.Drawing.Point(152, 12);
            this.btDevolverTodos.Name = "btDevolverTodos";
            this.btDevolverTodos.Size = new System.Drawing.Size(141, 23);
            this.btDevolverTodos.TabIndex = 14;
            this.btDevolverTodos.Text = "Devolver Todos";
            this.btDevolverTodos.UseVisualStyleBackColor = true;
            this.btDevolverTodos.Click += new System.EventHandler(this.btDevolverTodos_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(717, 12);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 15;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btRegistar
            // 
            this.btRegistar.Location = new System.Drawing.Point(889, 476);
            this.btRegistar.Name = "btRegistar";
            this.btRegistar.Size = new System.Drawing.Size(75, 23);
            this.btRegistar.TabIndex = 16;
            this.btRegistar.Text = "Registar";
            this.btRegistar.UseVisualStyleBackColor = true;
            this.btRegistar.Click += new System.EventHandler(this.btRegistar_Click);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(104, 427);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Data devolução:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descrição:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(104, 453);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(328, 46);
            this.tbDescricao.TabIndex = 22;
            // 
            // RegistarDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 511);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRegistar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btDevolverTodos);
            this.Controls.Add(this.btRem);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dgvSelecionado);
            this.Controls.Add(this.dgvTrabalhos);
            this.Name = "RegistarDevolucao";
            this.Text = "Registar Devolução";
            this.Load += new System.EventHandler(this.RegistarDevolucao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTrabalhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelecionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabalhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecionado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsTrabalhos;
        private System.Windows.Forms.BindingSource bsSelecionados;
        private System.Windows.Forms.DataGridView dgvTrabalhos;
        private System.Windows.Forms.DataGridView dgvSelecionado;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRem;
        private System.Windows.Forms.Button btDevolverTodos;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btRegistar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Levantado;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn datalev;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}