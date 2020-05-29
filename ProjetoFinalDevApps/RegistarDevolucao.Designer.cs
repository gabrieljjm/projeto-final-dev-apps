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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsTrabalhos = new System.Windows.Forms.BindingSource(this.components);
            this.bsSelecionados = new System.Windows.Forms.BindingSource(this.components);
            this.btAdd = new System.Windows.Forms.Button();
            this.btRem = new System.Windows.Forms.Button();
            this.btDevolverTodos = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btRegistar = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.dgvTrabalhos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSelecionado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrabalhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelecionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabalhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecionado)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(438, 204);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 23);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRem
            // 
            this.btRem.Location = new System.Drawing.Point(438, 236);
            this.btRem.Name = "btRem";
            this.btRem.Size = new System.Drawing.Size(100, 23);
            this.btRem.TabIndex = 4;
            this.btRem.Text = "Remover";
            this.btRem.UseVisualStyleBackColor = true;
            this.btRem.Click += new System.EventHandler(this.btRem_Click);
            // 
            // btDevolverTodos
            // 
            this.btDevolverTodos.Location = new System.Drawing.Point(152, 12);
            this.btDevolverTodos.Name = "btDevolverTodos";
            this.btDevolverTodos.Size = new System.Drawing.Size(141, 23);
            this.btDevolverTodos.TabIndex = 0;
            this.btDevolverTodos.Text = "Devolver Todos";
            this.btDevolverTodos.UseVisualStyleBackColor = true;
            this.btDevolverTodos.Click += new System.EventHandler(this.btDevolverTodos_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(717, 12);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 1;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btRegistar
            // 
            this.btRegistar.Location = new System.Drawing.Point(889, 476);
            this.btRegistar.Name = "btRegistar";
            this.btRegistar.Size = new System.Drawing.Size(75, 23);
            this.btRegistar.TabIndex = 8;
            this.btRegistar.Text = "Registar";
            this.btRegistar.UseVisualStyleBackColor = true;
            this.btRegistar.Click += new System.EventHandler(this.btRegistar_Click);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(104, 427);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 6;
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
            this.tbDescricao.TabIndex = 7;
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
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvTrabalhos.DataSource = this.bsTrabalhos;
            this.dgvTrabalhos.Location = new System.Drawing.Point(12, 41);
            this.dgvTrabalhos.MultiSelect = false;
            this.dgvTrabalhos.Name = "dgvTrabalhos";
            this.dgvTrabalhos.ReadOnly = true;
            this.dgvTrabalhos.RowHeadersVisible = false;
            this.dgvTrabalhos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrabalhos.Size = new System.Drawing.Size(420, 380);
            this.dgvTrabalhos.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 43;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DescricaoPeca";
            this.dataGridViewTextBoxColumn8.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CorPeca";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cor";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 48;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Pago";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Pago";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn3.Width = 57;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "Levantado";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Levantado";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            this.dataGridViewCheckBoxColumn4.Width = 64;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ValorPago";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = "€";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn10.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 56;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "DataLevantamento";
            this.dataGridViewTextBoxColumn11.HeaderText = "Data levantamento";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Observacoes";
            this.dataGridViewTextBoxColumn12.HeaderText = "Observações";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewCheckBoxColumn6,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.dgvSelecionado.DataSource = this.bsSelecionados;
            this.dgvSelecionado.Location = new System.Drawing.Point(544, 41);
            this.dgvSelecionado.MultiSelect = false;
            this.dgvSelecionado.Name = "dgvSelecionado";
            this.dgvSelecionado.ReadOnly = true;
            this.dgvSelecionado.RowHeadersVisible = false;
            this.dgvSelecionado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelecionado.Size = new System.Drawing.Size(420, 380);
            this.dgvSelecionado.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Id";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn13.HeaderText = "ID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 43;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "DescricaoPeca";
            this.dataGridViewTextBoxColumn14.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "CorPeca";
            this.dataGridViewTextBoxColumn15.HeaderText = "Cor";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 48;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "Pago";
            this.dataGridViewCheckBoxColumn5.HeaderText = "Pago";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.ReadOnly = true;
            this.dataGridViewCheckBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn5.Width = 57;
            // 
            // dataGridViewCheckBoxColumn6
            // 
            this.dataGridViewCheckBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn6.DataPropertyName = "Levantado";
            this.dataGridViewCheckBoxColumn6.HeaderText = "Levantado";
            this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            this.dataGridViewCheckBoxColumn6.ReadOnly = true;
            this.dataGridViewCheckBoxColumn6.Width = 64;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ValorPago";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = "€";
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn16.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 56;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "DataLevantamento";
            this.dataGridViewTextBoxColumn17.HeaderText = "Data levantamento";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Observacoes";
            this.dataGridViewTextBoxColumn18.HeaderText = "Observações";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // RegistarDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 511);
            this.Controls.Add(this.dgvSelecionado);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRegistar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btDevolverTodos);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btRem);
            this.Controls.Add(this.dgvTrabalhos);
            this.Name = "RegistarDevolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRem;
        private System.Windows.Forms.Button btDevolverTodos;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btRegistar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.DataGridView dgvTrabalhos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridView dgvSelecionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}