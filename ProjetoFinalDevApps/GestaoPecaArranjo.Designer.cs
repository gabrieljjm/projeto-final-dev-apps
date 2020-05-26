﻿namespace ProjetoFinalDevApps
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
            this.dgvArranjo = new System.Windows.Forms.DataGridView();
            this.bsPeca = new System.Windows.Forms.BindingSource(this.components);
            this.bsArranjo = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoArranjo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btApagar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btApagarPeca = new System.Windows.Forms.Button();
            this.btApagarArranjo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCombinacoes = new System.Windows.Forms.DataGridView();
            this.bsPecaArranjo = new System.Windows.Forms.BindingSource(this.components);
            this.pecaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArranjo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArranjo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPeca)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de peça";
            // 
            // tbPeca
            // 
            this.tbPeca.Location = new System.Drawing.Point(113, 21);
            this.tbPeca.Name = "tbPeca";
            this.tbPeca.Size = new System.Drawing.Size(185, 20);
            this.tbPeca.TabIndex = 1;
            // 
            // tbArranjo
            // 
            this.tbArranjo.Location = new System.Drawing.Point(113, 57);
            this.tbArranjo.Name = "tbArranjo";
            this.tbArranjo.Size = new System.Drawing.Size(185, 20);
            this.tbArranjo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de arranjo";
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(179, 100);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(148, 23);
            this.btAdicionar.TabIndex = 4;
            this.btAdicionar.Text = "Adicionar combinação";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peça com arranjo";
            // 
            // cbPeca
            // 
            this.cbPeca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeca.FormattingEnabled = true;
            this.cbPeca.Location = new System.Drawing.Point(140, 28);
            this.cbPeca.Name = "cbPeca";
            this.cbPeca.Size = new System.Drawing.Size(158, 21);
            this.cbPeca.TabIndex = 6;
            this.cbPeca.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbPeca_DrawItem);
            // 
            // cbArranjo
            // 
            this.cbArranjo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArranjo.FormattingEnabled = true;
            this.cbArranjo.Location = new System.Drawing.Point(309, 28);
            this.cbArranjo.Name = "cbArranjo";
            this.cbArranjo.Size = new System.Drawing.Size(158, 21);
            this.cbArranjo.TabIndex = 7;
            // 
            // btAdicionarPeca
            // 
            this.btAdicionarPeca.Location = new System.Drawing.Point(318, 19);
            this.btAdicionarPeca.Name = "btAdicionarPeca";
            this.btAdicionarPeca.Size = new System.Drawing.Size(149, 23);
            this.btAdicionarPeca.TabIndex = 8;
            this.btAdicionarPeca.Text = "Adicionar peça";
            this.btAdicionarPeca.UseVisualStyleBackColor = true;
            this.btAdicionarPeca.Click += new System.EventHandler(this.btAdicionarPecaArranjo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preço";
            // 
            // nudPreco
            // 
            this.nudPreco.Location = new System.Drawing.Point(140, 64);
            this.nudPreco.Name = "nudPreco";
            this.nudPreco.Size = new System.Drawing.Size(120, 20);
            this.nudPreco.TabIndex = 10;
            // 
            // btAdicionarArranjo
            // 
            this.btAdicionarArranjo.Location = new System.Drawing.Point(318, 55);
            this.btAdicionarArranjo.Name = "btAdicionarArranjo";
            this.btAdicionarArranjo.Size = new System.Drawing.Size(149, 23);
            this.btAdicionarArranjo.TabIndex = 11;
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
            this.groupBox1.TabIndex = 12;
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
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criar combinação";
            // 
            // dgvPeca
            // 
            this.dgvPeca.AllowUserToAddRows = false;
            this.dgvPeca.AllowUserToDeleteRows = false;
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
            this.dgvPeca.TabIndex = 14;
            // 
            // dgvArranjo
            // 
            this.dgvArranjo.AllowUserToAddRows = false;
            this.dgvArranjo.AllowUserToDeleteRows = false;
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
            this.dgvArranjo.TabIndex = 15;
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
            // idPeca
            // 
            this.idPeca.DataPropertyName = "Id";
            this.idPeca.HeaderText = "ID";
            this.idPeca.Name = "idPeca";
            this.idPeca.ReadOnly = true;
            // 
            // peca
            // 
            this.peca.DataPropertyName = "TipoPeca";
            this.peca.HeaderText = "Tipo de peça";
            this.peca.Name = "peca";
            this.peca.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // tipoArranjo
            // 
            this.tipoArranjo.DataPropertyName = "TipoArranjo";
            this.tipoArranjo.HeaderText = "Tipo de arranjo";
            this.tipoArranjo.Name = "tipoArranjo";
            this.tipoArranjo.ReadOnly = true;
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(105, 475);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(122, 23);
            this.btApagar.TabIndex = 18;
            this.btApagar.Text = "Apagar combinação";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btApagarArranjo);
            this.groupBox3.Controls.Add(this.btApagarPeca);
            this.groupBox3.Controls.Add(this.dgvPeca);
            this.groupBox3.Controls.Add(this.dgvArranjo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 245);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // btApagarPeca
            // 
            this.btApagarPeca.Location = new System.Drawing.Point(67, 206);
            this.btApagarPeca.Name = "btApagarPeca";
            this.btApagarPeca.Size = new System.Drawing.Size(129, 23);
            this.btApagarPeca.TabIndex = 18;
            this.btApagarPeca.Text = "Apagar peça";
            this.btApagarPeca.UseVisualStyleBackColor = true;
            this.btApagarPeca.Click += new System.EventHandler(this.btApagarPeca_Click);
            // 
            // btApagarArranjo
            // 
            this.btApagarArranjo.Location = new System.Drawing.Point(301, 206);
            this.btApagarArranjo.Name = "btApagarArranjo";
            this.btApagarArranjo.Size = new System.Drawing.Size(129, 23);
            this.btApagarArranjo.TabIndex = 19;
            this.btApagarArranjo.Text = "Apagar arranjo";
            this.btApagarArranjo.UseVisualStyleBackColor = true;
            this.btApagarArranjo.Click += new System.EventHandler(this.btApagarArranjo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCombinacoes);
            this.groupBox4.Controls.Add(this.btApagar);
            this.groupBox4.Location = new System.Drawing.Point(514, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 514);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista de combinações";
            // 
            // dgvCombinacoes
            // 
            this.dgvCombinacoes.AllowUserToAddRows = false;
            this.dgvCombinacoes.AllowUserToDeleteRows = false;
            this.dgvCombinacoes.AutoGenerateColumns = false;
            this.dgvCombinacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCombinacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pecaid,
            this.idArranjo,
            this.preco});
            this.dgvCombinacoes.DataSource = this.bsPecaArranjo;
            this.dgvCombinacoes.Location = new System.Drawing.Point(15, 23);
            this.dgvCombinacoes.MultiSelect = false;
            this.dgvCombinacoes.Name = "dgvCombinacoes";
            this.dgvCombinacoes.ReadOnly = true;
            this.dgvCombinacoes.RowHeadersVisible = false;
            this.dgvCombinacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCombinacoes.Size = new System.Drawing.Size(303, 445);
            this.dgvCombinacoes.TabIndex = 0;
            this.dgvCombinacoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCombinacoes_CellContentClick);
            // 
            // pecaid
            // 
            this.pecaid.DataPropertyName = "PecaId";
            this.pecaid.HeaderText = "ID Peca";
            this.pecaid.Name = "pecaid";
            this.pecaid.ReadOnly = true;
            // 
            // idArranjo
            // 
            this.idArranjo.DataPropertyName = "ArranjoId";
            this.idArranjo.HeaderText = "ID Arranjo";
            this.idArranjo.Name = "idArranjo";
            this.idArranjo.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "Preco";
            this.preco.HeaderText = "Preco";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // GestaoPecaArranjo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 539);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestaoPecaArranjo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestaoPecaArranjo";
            this.Activated += new System.EventHandler(this.GestaoPecaArranjo_Activated);
            this.Load += new System.EventHandler(this.GestaoPecaArranjo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArranjo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPeca)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn peca;
        private System.Windows.Forms.BindingSource bsPeca;
        private System.Windows.Forms.DataGridView dgvArranjo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoArranjo;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn pecaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArranjo;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
    }
}