namespace ProjetoFinalDevApps
{
    partial class GestaoOrcamento
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
            this.btNovoOrcamento = new System.Windows.Forms.Button();
            this.btVerOrcamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(27, 53);
            this.dgvPedido.MultiSelect = false;
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(639, 295);
            this.dgvPedido.TabIndex = 0;
            // 
            // btNovoOrcamento
            // 
            this.btNovoOrcamento.Location = new System.Drawing.Point(27, 24);
            this.btNovoOrcamento.Name = "btNovoOrcamento";
            this.btNovoOrcamento.Size = new System.Drawing.Size(157, 23);
            this.btNovoOrcamento.TabIndex = 1;
            this.btNovoOrcamento.Text = "Novo orçamento";
            this.btNovoOrcamento.UseVisualStyleBackColor = true;
            this.btNovoOrcamento.Click += new System.EventHandler(this.btNovoOrcamento_Click);
            // 
            // btVerOrcamento
            // 
            this.btVerOrcamento.Location = new System.Drawing.Point(190, 24);
            this.btVerOrcamento.Name = "btVerOrcamento";
            this.btVerOrcamento.Size = new System.Drawing.Size(157, 23);
            this.btVerOrcamento.TabIndex = 2;
            this.btVerOrcamento.Text = "Ver orçamento";
            this.btVerOrcamento.UseVisualStyleBackColor = true;
            this.btVerOrcamento.Click += new System.EventHandler(this.btVerOrcamento_Click);
            // 
            // GestaoOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 369);
            this.Controls.Add(this.btVerOrcamento);
            this.Controls.Add(this.btNovoOrcamento);
            this.Controls.Add(this.dgvPedido);
            this.Name = "GestaoOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestaoOrcamento";
            this.Load += new System.EventHandler(this.GestaoOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btNovoOrcamento;
        private System.Windows.Forms.Button btVerOrcamento;
    }
}