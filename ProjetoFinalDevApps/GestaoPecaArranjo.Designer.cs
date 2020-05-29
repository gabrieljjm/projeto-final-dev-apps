namespace ProjetoFinalDevApps
{
    partial class GestaoPecaArranjo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPeca = new System.Windows.Forms.TextBox();
            this.tbArranjo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPeca = new System.Windows.Forms.ComboBox();
            this.cbArranjo = new System.Windows.Forms.ComboBox();
            this.btAdicionarPeca = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPreco = new System.Windows.Forms.NumericUpDown();
            this.btAdicionarArranjo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPeca = new System.Windows.Forms.DataGridView();
            this.idPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPeca = new System.Windows.Forms.BindingSource(this.components);
            this.dgvArranjo = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoArranjo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsArranjo = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btApagar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btConsumos = new System.Windows.Forms.Button();
            this.btApagarArranjo = new System.Windows.Forms.Button();
            this.btApagarPeca = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCombinacoes = new System.Windows.Forms.DataGridView();
            this.pecaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pecas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArranjo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arranjo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPecaArranjo = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArranjo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsArranjo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombinacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPecaArranjo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de peça:";
            // 
            // tbPeca
            // 
            this.tbPeca.Location = new System.Drawing.Point(113, 21);
            this.tbPeca.Name = "tbPeca";
            this.tbPeca.Size = new System.Drawing.Size(185, 20);
            this.tbPeca.TabIndex = 0;
            // 
            // tbArranjo
            // 
            this.tbArranjo.Location = new System.Drawing.Point(113, 57);
            this.tbArranjo.Name = "tbArranjo";
            this.tbArranjo.Size = new System.Drawing.Size(185, 20);
            this.tbArranjo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de arranjo:";
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(179, 100);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(148, 23);
            this.btAdicionar.TabIndex = 3;
            this.btAdicionar.Text = "Adicionar combinação";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peça com arranjo:";
            // 
            // cbPeca
            // 
            this.cbPeca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeca.FormattingEnabled = true;
            this.cbPeca.Location = new System.Drawing.Point(140, 28);
            this.cbPeca.Name = "cbPeca";
            this.cbPeca.Size = new System.Drawing.Size(158, 21);
            this.cbPeca.TabIndex = 0;
            // 
            // cbArranjo
            // 
            this.cbArranjo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArranjo.FormattingEnabled = true;
            this.cbArranjo.Location = new System.Drawing.Point(309, 28);
            this.cbArranjo.Name = "cbArranjo";
            this.cbArranjo.Size = new System.Drawing.Size(158, 21);
            this.cbArranjo.TabIndex = 1;
            // 
            // btAdicionarPeca
            // 
            this.btAdicionarPeca.Location = new System.Drawing.Point(318, 19);
            this.btAdicionarPeca.Name = "btAdicionarPeca";
            this.btAdicionarPeca.Size = new System.Drawing.Size(149, 23);
            this.btAdicionarPeca.TabIndex = 1;
            this.btAdicionarPeca.Text = "Adicionar peça";
            this.btAdicionarPeca.UseVisualStyleBackColor = true;
            this.btAdicionarPeca.Click += new System.EventHandler(this.btAdicionarPecaArranjo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preço:";
            // 
            // nudPreco
            // 
            this.nudPreco.DecimalPlaces = 2;
            this.nudPreco.Location = new System.Drawing.Point(140, 64);
            this.nudPreco.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPreco.Name = "nudPreco";
            this.nudPreco.Size = new System.Drawing.Size(120, 20);
            this.nudPreco.TabIndex = 2;
            // 
            // btAdicionarArranjo
            // 
            this.btAdicionarArranjo.Location = new System.Drawing.Point(318, 55);
            this.btAdicionarArranjo.Name = "btAdicionarArranjo";
            this.btAdicionarArranjo.Size = new System.Drawing.Size(149, 23);
            this.btAdicionarArranjo.TabIndex = 3;
            this.btAdicionarArranjo.Text = "Adicionar arranjo";
            this.btAdicionarArranjo.UseVisualStyleBackColor = true;
            this.btAdicionarArranjo.Click += new System.EventHandler(this.btAdicionarArranjo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPeca);
            this.groupBox1.Controls.Add(this.btAdicionarArranjo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbArranjo);
            this.groupBox1.Controls.Add(this.btAdicionarPeca);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPeca);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btAdicionar);
            this.groupBox2.Controls.Add(this.nudPreco);
            this.groupBox2.Controls.Add(this.cbArranjo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criar combinação";
            // 
            // dgvPeca
            // 
            this.dgvPeca.AllowUserToAddRows = false;
            this.dgvPeca.AllowUserToDeleteRows = false;
            this.dgvPeca.AllowUserToResizeColumns = false;
            this.dgvPeca.AllowUserToResizeRows = false;
            this.dgvPeca.AutoGenerateColumns = false;
            this.dgvPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPeca,
            this.peca});
            this.dgvPeca.DataSource = this.bsPeca;
            this.dgvPeca.Location = new System.Drawing.Point(29, 44);
            this.dgvPeca.MultiSelect = false;
            this.dgvPeca.Name = "dgvPeca";
            this.dgvPeca.ReadOnly = true;
            this.dgvPeca.RowHeadersVisible = false;
            this.dgvPeca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeca.Size = new System.Drawing.Size(204, 156);
            this.dgvPeca.TabIndex = 0;
            // 
            // idPeca
            // 
            this.idPeca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idPeca.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.idPeca.DefaultCellStyle = dataGridViewCellStyle1;
            this.idPeca.HeaderText = "ID";
            this.idPeca.Name = "idPeca";
            this.idPeca.ReadOnly = true;
            this.idPeca.Width = 43;
            // 
            // peca
            // 
            this.peca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.peca.DataPropertyName = "TipoPeca";
            this.peca.HeaderText = "Peça";
            this.peca.Name = "peca";
            this.peca.ReadOnly = true;
            // 
            // dgvArranjo
            // 
            this.dgvArranjo.AllowUserToAddRows = false;
            this.dgvArranjo.AllowUserToDeleteRows = false;
            this.dgvArranjo.AllowUserToResizeColumns = false;
            this.dgvArranjo.AllowUserToResizeRows = false;
            this.dgvArranjo.AutoGenerateColumns = false;
            this.dgvArranjo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArranjo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tipoArranjo});
            this.dgvArranjo.DataSource = this.bsArranjo;
            this.dgvArranjo.Location = new System.Drawing.Point(264, 44);
            this.dgvArranjo.MultiSelect = false;
            this.dgvArranjo.Name = "dgvArranjo";
            this.dgvArranjo.ReadOnly = true;
            this.dgvArranjo.RowHeadersVisible = false;
            this.dgvArranjo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArranjo.Size = new System.Drawing.Size(203, 156);
            this.dgvArranjo.TabIndex = 2;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 43;
            // 
            // tipoArranjo
            // 
            this.tipoArranjo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoArranjo.DataPropertyName = "TipoArranjo";
            this.tipoArranjo.HeaderText = "Arranjo";
            this.tipoArranjo.Name = "tipoArranjo";
            this.tipoArranjo.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Peça";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Arranjo";
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(152, 474);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(122, 23);
            this.btApagar.TabIndex = 1;
            this.btApagar.Text = "Apagar Combinação";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btConsumos);
            this.groupBox3.Controls.Add(this.btApagarArranjo);
            this.groupBox3.Controls.Add(this.btApagarPeca);
            this.groupBox3.Controls.Add(this.dgvPeca);
            this.groupBox3.Controls.Add(this.dgvArranjo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 245);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btConsumos
            // 
            this.btConsumos.Location = new System.Drawing.Point(401, 206);
            this.btConsumos.Name = "btConsumos";
            this.btConsumos.Size = new System.Drawing.Size(66, 23);
            this.btConsumos.TabIndex = 4;
            this.btConsumos.Text = "Consumos";
            this.btConsumos.UseVisualStyleBackColor = true;
            this.btConsumos.Click += new System.EventHandler(this.btConsumos_Click);
            // 
            // btApagarArranjo
            // 
            this.btApagarArranjo.Location = new System.Drawing.Point(264, 206);
            this.btApagarArranjo.Name = "btApagarArranjo";
            this.btApagarArranjo.Size = new System.Drawing.Size(95, 23);
            this.btApagarArranjo.TabIndex = 3;
            this.btApagarArranjo.Text = "Apagar Arranjo";
            this.btApagarArranjo.UseVisualStyleBackColor = true;
            this.btApagarArranjo.Click += new System.EventHandler(this.btApagarArranjo_Click);
            // 
            // btApagarPeca
            // 
            this.btApagarPeca.Location = new System.Drawing.Point(29, 206);
            this.btApagarPeca.Name = "btApagarPeca";
            this.btApagarPeca.Size = new System.Drawing.Size(87, 23);
            this.btApagarPeca.TabIndex = 1;
            this.btApagarPeca.Text = "Apagar Peça";
            this.btApagarPeca.UseVisualStyleBackColor = true;
            this.btApagarPeca.Click += new System.EventHandler(this.btApagarPeca_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCombinacoes);
            this.groupBox4.Controls.Add(this.btApagar);
            this.groupBox4.Location = new System.Drawing.Point(514, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(428, 514);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista de combinações";
            // 
            // dgvCombinacoes
            // 
            this.dgvCombinacoes.AllowUserToAddRows = false;
            this.dgvCombinacoes.AllowUserToDeleteRows = false;
            this.dgvCombinacoes.AllowUserToResizeColumns = false;
            this.dgvCombinacoes.AllowUserToResizeRows = false;
            this.dgvCombinacoes.AutoGenerateColumns = false;
            this.dgvCombinacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCombinacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pecaid,
            this.Pecas,
            this.idArranjo,
            this.Arranjo,
            this.preco});
            this.dgvCombinacoes.DataSource = this.bsPecaArranjo;
            this.dgvCombinacoes.Location = new System.Drawing.Point(15, 23);
            this.dgvCombinacoes.MultiSelect = false;
            this.dgvCombinacoes.Name = "dgvCombinacoes";
            this.dgvCombinacoes.ReadOnly = true;
            this.dgvCombinacoes.RowHeadersVisible = false;
            this.dgvCombinacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCombinacoes.Size = new System.Drawing.Size(396, 445);
            this.dgvCombinacoes.TabIndex = 0;
            this.dgvCombinacoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCombinacoes_CellContentClick);
            // 
            // pecaid
            // 
            this.pecaid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pecaid.DataPropertyName = "PecaId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.pecaid.DefaultCellStyle = dataGridViewCellStyle3;
            this.pecaid.HeaderText = "ID";
            this.pecaid.Name = "pecaid";
            this.pecaid.ReadOnly = true;
            this.pecaid.Width = 43;
            // 
            // Pecas
            // 
            this.Pecas.DataPropertyName = "Peca";
            this.Pecas.HeaderText = "Peça";
            this.Pecas.Name = "Pecas";
            this.Pecas.ReadOnly = true;
            // 
            // idArranjo
            // 
            this.idArranjo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idArranjo.DataPropertyName = "ArranjoId";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.idArranjo.DefaultCellStyle = dataGridViewCellStyle4;
            this.idArranjo.HeaderText = "ID";
            this.idArranjo.Name = "idArranjo";
            this.idArranjo.ReadOnly = true;
            this.idArranjo.Width = 43;
            // 
            // Arranjo
            // 
            this.Arranjo.DataPropertyName = "Arranjo";
            this.Arranjo.HeaderText = "Arranjo";
            this.Arranjo.Name = "Arranjo";
            this.Arranjo.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.preco.DataPropertyName = "Preco";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "€";
            this.preco.DefaultCellStyle = dataGridViewCellStyle5;
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            this.preco.Width = 60;
            // 
            // GestaoPecaArranjo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 539);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestaoPecaArranjo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peças e Arranjos";
            this.Activated += new System.EventHandler(this.GestaoPecaArranjo_Activated);
            this.Load += new System.EventHandler(this.GestaoPecaArranjo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArranjo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsArranjo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombinacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPecaArranjo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPeca;
        private System.Windows.Forms.TextBox tbArranjo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPeca;
        private System.Windows.Forms.ComboBox cbArranjo;
        private System.Windows.Forms.Button btAdicionarPeca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPreco;
        private System.Windows.Forms.Button btAdicionarArranjo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPeca;
        private System.Windows.Forms.BindingSource bsPeca;
        private System.Windows.Forms.DataGridView dgvArranjo;
        private System.Windows.Forms.BindingSource bsArranjo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btApagarArranjo;
        private System.Windows.Forms.Button btApagarPeca;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvCombinacoes;
        private System.Windows.Forms.BindingSource bsPecaArranjo;
        private System.Windows.Forms.Button btConsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn pecaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArranjo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arranjo;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn peca;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoArranjo;
    }
}