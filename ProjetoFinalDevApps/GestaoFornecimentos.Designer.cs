namespace ProjetoFinalDevApps
{
    partial class GestaoFornecimentos
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
            this.dgvFornecimentos = new System.Windows.Forms.DataGridView();
            this.MateriaisID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFornecimentos = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cbMateriais = new System.Windows.Forms.ComboBox();
            this.dtpPrazo = new System.Windows.Forms.DateTimePicker();
            this.nudPreco = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btApagar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btCriar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFornecimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFornecimentos
            // 
            this.dgvFornecimentos.AllowUserToAddRows = false;
            this.dgvFornecimentos.AllowUserToDeleteRows = false;
            this.dgvFornecimentos.AllowUserToResizeRows = false;
            this.dgvFornecimentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFornecimentos.AutoGenerateColumns = false;
            this.dgvFornecimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MateriaisID,
            this.preco,
            this.prazo});
            this.dgvFornecimentos.DataSource = this.bsFornecimentos;
            this.dgvFornecimentos.Location = new System.Drawing.Point(12, 121);
            this.dgvFornecimentos.MultiSelect = false;
            this.dgvFornecimentos.Name = "dgvFornecimentos";
            this.dgvFornecimentos.ReadOnly = true;
            this.dgvFornecimentos.RowHeadersVisible = false;
            this.dgvFornecimentos.Size = new System.Drawing.Size(500, 268);
            this.dgvFornecimentos.TabIndex = 0;
            // 
            // MateriaisID
            // 
            this.MateriaisID.DataPropertyName = "StockMateriaisId";
            this.MateriaisID.HeaderText = "ID Material";
            this.MateriaisID.Name = "MateriaisID";
            this.MateriaisID.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "Preco";
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // prazo
            // 
            this.prazo.DataPropertyName = "PrazoEntrega";
            this.prazo.HeaderText = "Prazo Entrega";
            this.prazo.Name = "prazo";
            this.prazo.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Material:";
            // 
            // cbMateriais
            // 
            this.cbMateriais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriais.FormattingEnabled = true;
            this.cbMateriais.Location = new System.Drawing.Point(107, 64);
            this.cbMateriais.Name = "cbMateriais";
            this.cbMateriais.Size = new System.Drawing.Size(200, 21);
            this.cbMateriais.TabIndex = 10;
            // 
            // dtpPrazo
            // 
            this.dtpPrazo.Location = new System.Drawing.Point(107, 38);
            this.dtpPrazo.Name = "dtpPrazo";
            this.dtpPrazo.Size = new System.Drawing.Size(200, 20);
            this.dtpPrazo.TabIndex = 9;
            // 
            // nudPreco
            // 
            this.nudPreco.Location = new System.Drawing.Point(107, 12);
            this.nudPreco.Name = "nudPreco";
            this.nudPreco.Size = new System.Drawing.Size(120, 20);
            this.nudPreco.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prazo de Entrega:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Preço:";
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(174, 92);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(75, 23);
            this.btApagar.TabIndex = 41;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(93, 92);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 40;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btCriar
            // 
            this.btCriar.Location = new System.Drawing.Point(12, 92);
            this.btCriar.Name = "btCriar";
            this.btCriar.Size = new System.Drawing.Size(75, 23);
            this.btCriar.TabIndex = 39;
            this.btCriar.Text = "Criar";
            this.btCriar.UseVisualStyleBackColor = true;
            this.btCriar.Click += new System.EventHandler(this.btCriar_Click);
            // 
            // GestaoFornecimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 401);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btCriar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMateriais);
            this.Controls.Add(this.dtpPrazo);
            this.Controls.Add(this.nudPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFornecimentos);
            this.Name = "GestaoFornecimentos";
            this.Text = "GestaoFornecimentos";
            this.Activated += new System.EventHandler(this.GestaoFornecimentos_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFornecimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsFornecimentos;
        private System.Windows.Forms.DataGridView dgvFornecimentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaisID;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn prazo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMateriais;
        private System.Windows.Forms.DateTimePicker dtpPrazo;
        private System.Windows.Forms.NumericUpDown nudPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btCriar;
    }
}