namespace ProjetoFinalDevApps
{
    partial class NovoPedidoTabelado
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
            this.btRegistarTabelado = new System.Windows.Forms.Button();
            this.tbObservacoes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpPedido = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bsTrabalhos = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsTrabalhos)).BeginInit();
            this.SuspendLayout();
            // 
            // btRegistarTabelado
            // 
            this.btRegistarTabelado.Location = new System.Drawing.Point(105, 211);
            this.btRegistarTabelado.Name = "btRegistarTabelado";
            this.btRegistarTabelado.Size = new System.Drawing.Size(202, 23);
            this.btRegistarTabelado.TabIndex = 30;
            this.btRegistarTabelado.Text = "Registar pedido";
            this.btRegistarTabelado.UseVisualStyleBackColor = true;
            this.btRegistarTabelado.Click += new System.EventHandler(this.btRegistarTabelado_Click);
            // 
            // tbObservacoes
            // 
            this.tbObservacoes.Location = new System.Drawing.Point(142, 105);
            this.tbObservacoes.Multiline = true;
            this.tbObservacoes.Name = "tbObservacoes";
            this.tbObservacoes.Size = new System.Drawing.Size(241, 80);
            this.tbObservacoes.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Observações";
            // 
            // dtpPedido
            // 
            this.dtpPedido.Location = new System.Drawing.Point(142, 65);
            this.dtpPedido.Name = "dtpPedido";
            this.dtpPedido.Size = new System.Drawing.Size(241, 20);
            this.dtpPedido.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Data pedido";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(142, 34);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(241, 21);
            this.cbCliente.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cliente";
            // 
            // NovoPedidoTabelado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 268);
            this.Controls.Add(this.btRegistarTabelado);
            this.Controls.Add(this.tbObservacoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label1);
            this.Name = "NovoPedidoTabelado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo pedido tabelado";
            this.Activated += new System.EventHandler(this.GestaoPedidoTabelado_Activated);
            this.Load += new System.EventHandler(this.GestaoPedidoTabelado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTrabalhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btRegistarTabelado;
        private System.Windows.Forms.TextBox tbObservacoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsTrabalhos;
    }
}