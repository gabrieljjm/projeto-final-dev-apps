namespace ProjetoFinalDevApps
{
    partial class GestaoMateriais
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.nudQuant = new System.Windows.Forms.NumericUpDown();
            this.nudConsMed = new System.Windows.Forms.NumericUpDown();
            this.nudMinimo = new System.Windows.Forms.NumericUpDown();
            this.btApagar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btCriar = new System.Windows.Forms.Button();
            this.dgvMateriais = new System.Windows.Forms.DataGridView();
            this.bsMateriais = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMateriais)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade Atual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Consumo Méd. Diário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock Mínimo:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(126, 12);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(198, 60);
            this.tbDescricao.TabIndex = 4;
            // 
            // nudQuant
            // 
            this.nudQuant.Location = new System.Drawing.Point(126, 78);
            this.nudQuant.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudQuant.Name = "nudQuant";
            this.nudQuant.Size = new System.Drawing.Size(120, 20);
            this.nudQuant.TabIndex = 5;
            // 
            // nudConsMed
            // 
            this.nudConsMed.Location = new System.Drawing.Point(126, 104);
            this.nudConsMed.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudConsMed.Name = "nudConsMed";
            this.nudConsMed.Size = new System.Drawing.Size(120, 20);
            this.nudConsMed.TabIndex = 6;
            // 
            // nudMinimo
            // 
            this.nudMinimo.Location = new System.Drawing.Point(126, 130);
            this.nudMinimo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudMinimo.Name = "nudMinimo";
            this.nudMinimo.Size = new System.Drawing.Size(120, 20);
            this.nudMinimo.TabIndex = 7;
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(174, 156);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(75, 23);
            this.btApagar.TabIndex = 57;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(93, 156);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 56;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btCriar
            // 
            this.btCriar.Location = new System.Drawing.Point(12, 156);
            this.btCriar.Name = "btCriar";
            this.btCriar.Size = new System.Drawing.Size(75, 23);
            this.btCriar.TabIndex = 55;
            this.btCriar.Text = "Criar";
            this.btCriar.UseVisualStyleBackColor = true;
            this.btCriar.Click += new System.EventHandler(this.btCriar_Click);
            // 
            // dgvMateriais
            // 
            this.dgvMateriais.AllowUserToAddRows = false;
            this.dgvMateriais.AllowUserToDeleteRows = false;
            this.dgvMateriais.AutoGenerateColumns = false;
            this.dgvMateriais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descricao,
            this.QuantAtual,
            this.ConsMed,
            this.StockMin});
            this.dgvMateriais.DataSource = this.bsMateriais;
            this.dgvMateriais.Location = new System.Drawing.Point(12, 185);
            this.dgvMateriais.Name = "dgvMateriais";
            this.dgvMateriais.ReadOnly = true;
            this.dgvMateriais.RowHeadersVisible = false;
            this.dgvMateriais.Size = new System.Drawing.Size(776, 253);
            this.dgvMateriais.TabIndex = 58;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // QuantAtual
            // 
            this.QuantAtual.DataPropertyName = "QuantAtual";
            this.QuantAtual.HeaderText = "Quantidade Atual";
            this.QuantAtual.Name = "QuantAtual";
            this.QuantAtual.ReadOnly = true;
            // 
            // ConsMed
            // 
            this.ConsMed.DataPropertyName = "ConsumoMedioDiario";
            this.ConsMed.HeaderText = "Consumo Méd. Diário";
            this.ConsMed.Name = "ConsMed";
            this.ConsMed.ReadOnly = true;
            // 
            // StockMin
            // 
            this.StockMin.DataPropertyName = "StockMinimo";
            this.StockMin.HeaderText = "Stock Mínimo";
            this.StockMin.Name = "StockMin";
            this.StockMin.ReadOnly = true;
            // 
            // GestaoMateriais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMateriais);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btCriar);
            this.Controls.Add(this.nudMinimo);
            this.Controls.Add(this.nudConsMed);
            this.Controls.Add(this.nudQuant);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestaoMateriais";
            this.Text = "GestaoMateriais";
            this.Activated += new System.EventHandler(this.GestaoMateriais_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMateriais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.NumericUpDown nudQuant;
        private System.Windows.Forms.NumericUpDown nudConsMed;
        private System.Windows.Forms.NumericUpDown nudMinimo;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btCriar;
        private System.Windows.Forms.DataGridView dgvMateriais;
        private System.Windows.Forms.BindingSource bsMateriais;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMin;
    }
}