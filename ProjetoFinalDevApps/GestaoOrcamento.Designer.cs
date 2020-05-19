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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btNovoOrcamento = new System.Windows.Forms.Button();
            this.btVerOrcamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(90, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 295);
            this.dataGridView1.TabIndex = 0;
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
            // 
            // GestaoOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btVerOrcamento);
            this.Controls.Add(this.btNovoOrcamento);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GestaoOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestaoOrcamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btNovoOrcamento;
        private System.Windows.Forms.Button btVerOrcamento;
    }
}