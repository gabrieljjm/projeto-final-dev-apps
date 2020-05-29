namespace ProjetoFinalDevApps
{
    partial class GestaoClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.bsClientes = new System.Windows.Forms.BindingSource(this.components);
            this.btApagar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Morada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.NIF,
            this.Telefone,
            this.Morada,
            this.Localidade,
            this.CodigoPostal});
            this.dgvClientes.DataSource = this.bsClientes;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.Location = new System.Drawing.Point(12, 41);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(672, 313);
            this.dgvClientes.TabIndex = 3;
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(174, 12);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(75, 23);
            this.btApagar.TabIndex = 2;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(93, 12);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 1;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(12, 12);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 0;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 43;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // NIF
            // 
            this.NIF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NIF.DataPropertyName = "NIF";
            this.NIF.HeaderText = "NIF";
            this.NIF.Name = "NIF";
            this.NIF.ReadOnly = true;
            this.NIF.Width = 49;
            // 
            // Telefone
            // 
            this.Telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Telefone.DataPropertyName = "Telefone_Contacto";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 74;
            // 
            // Morada
            // 
            this.Morada.DataPropertyName = "Morada";
            this.Morada.HeaderText = "Morada";
            this.Morada.Name = "Morada";
            this.Morada.ReadOnly = true;
            this.Morada.Width = 150;
            // 
            // Localidade
            // 
            this.Localidade.DataPropertyName = "Localidade";
            this.Localidade.HeaderText = "Localidade";
            this.Localidade.Name = "Localidade";
            this.Localidade.ReadOnly = true;
            this.Localidade.Width = 150;
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CodigoPostal.DataPropertyName = "Codigo_Postal";
            this.CodigoPostal.HeaderText = "Código Postal";
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.ReadOnly = true;
            this.CodigoPostal.Width = 97;
            // 
            // GestaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 366);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNovo);
            this.Name = "GestaoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Activated += new System.EventHandler(this.GestaoClientes_Activated);
            this.Load += new System.EventHandler(this.GestaoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.BindingSource bsClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Morada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPostal;
    }
}