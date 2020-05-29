namespace ProjetoFinalDevApps
{
    partial class GestaoConsumos
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
            this.bsConsumos = new System.Windows.Forms.BindingSource(this.components);
            this.cbMateriais = new System.Windows.Forms.ComboBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.dgvConsumos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantMedia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQuantMed = new System.Windows.Forms.NumericUpDown();
            this.btCriar = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsConsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantMed)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMateriais
            // 
            this.cbMateriais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriais.FormattingEnabled = true;
            this.cbMateriais.Location = new System.Drawing.Point(112, 15);
            this.cbMateriais.Name = "cbMateriais";
            this.cbMateriais.Size = new System.Drawing.Size(121, 21);
            this.cbMateriais.TabIndex = 0;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // dgvConsumos
            // 
            this.dgvConsumos.AllowUserToAddRows = false;
            this.dgvConsumos.AllowUserToDeleteRows = false;
            this.dgvConsumos.AllowUserToResizeColumns = false;
            this.dgvConsumos.AllowUserToResizeRows = false;
            this.dgvConsumos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsumos.AutoGenerateColumns = false;
            this.dgvConsumos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvConsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.QuantMedia,
            this.Stock});
            this.dgvConsumos.DataSource = this.bsConsumos;
            this.dgvConsumos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsumos.Location = new System.Drawing.Point(12, 122);
            this.dgvConsumos.MultiSelect = false;
            this.dgvConsumos.Name = "dgvConsumos";
            this.dgvConsumos.ReadOnly = true;
            this.dgvConsumos.RowHeadersVisible = false;
            this.dgvConsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsumos.Size = new System.Drawing.Size(541, 247);
            this.dgvConsumos.TabIndex = 52;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Id.DataPropertyName = "Id";
            this.Id.Frozen = true;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 5;
            // 
            // QuantMedia
            // 
            this.QuantMedia.DataPropertyName = "QuantidadeMedia";
            this.QuantMedia.Frozen = true;
            this.QuantMedia.HeaderText = "Quantidade Média";
            this.QuantMedia.Name = "QuantMedia";
            this.QuantMedia.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "StockMateriais";
            this.Stock.Frozen = true;
            this.Stock.HeaderText = "Material";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Quantidade Média";
            // 
            // nudQuantMed
            // 
            this.nudQuantMed.Location = new System.Drawing.Point(112, 39);
            this.nudQuantMed.Name = "nudQuantMed";
            this.nudQuantMed.Size = new System.Drawing.Size(120, 20);
            this.nudQuantMed.TabIndex = 55;
            // 
            // btCriar
            // 
            this.btCriar.Location = new System.Drawing.Point(15, 93);
            this.btCriar.Name = "btCriar";
            this.btCriar.Size = new System.Drawing.Size(75, 23);
            this.btCriar.TabIndex = 56;
            this.btCriar.Text = "Criar";
            this.btCriar.UseVisualStyleBackColor = true;
            this.btCriar.Click += new System.EventHandler(this.btCriar_Click);
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(96, 93);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(75, 23);
            this.btApagar.TabIndex = 57;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // GestaoConsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 381);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btCriar);
            this.Controls.Add(this.nudQuantMed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsumos);
            this.Controls.Add(this.cbMateriais);
            this.Name = "GestaoConsumos";
            this.Text = "GestaoConsumos";
            this.Activated += new System.EventHandler(this.GestaoConsumos_Activated);
            this.Load += new System.EventHandler(this.GestaoConsumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsConsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantMed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsConsumos;
        private System.Windows.Forms.ComboBox cbMateriais;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.DataGridView dgvConsumos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQuantMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantMedia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.Button btCriar;
        private System.Windows.Forms.Button btApagar;
    }
}