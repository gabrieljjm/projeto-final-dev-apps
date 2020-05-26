namespace ProjetoFinalDevApps
{
    partial class EditarPedidoTabelado
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
            this.btAlterarPedido = new System.Windows.Forms.Button();
            this.tbObservacoes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpPedido = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAlterarPedido
            // 
            this.btAlterarPedido.Location = new System.Drawing.Point(105, 196);
            this.btAlterarPedido.Name = "btAlterarPedido";
            this.btAlterarPedido.Size = new System.Drawing.Size(202, 23);
            this.btAlterarPedido.TabIndex = 35;
            this.btAlterarPedido.Text = "Alterar";
            this.btAlterarPedido.UseVisualStyleBackColor = true;
            this.btAlterarPedido.Click += new System.EventHandler(this.btAlterarPedido_Click);
            // 
            // tbObservacoes
            // 
            this.tbObservacoes.Location = new System.Drawing.Point(142, 90);
            this.tbObservacoes.Multiline = true;
            this.tbObservacoes.Name = "tbObservacoes";
            this.tbObservacoes.Size = new System.Drawing.Size(241, 80);
            this.tbObservacoes.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Observações";
            // 
            // dtpPedido
            // 
            this.dtpPedido.Location = new System.Drawing.Point(142, 50);
            this.dtpPedido.Name = "dtpPedido";
            this.dtpPedido.Size = new System.Drawing.Size(241, 20);
            this.dtpPedido.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Data pedido";
            // 
            // EditarPedidoTabelado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 268);
            this.Controls.Add(this.btAlterarPedido);
            this.Controls.Add(this.tbObservacoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpPedido);
            this.Controls.Add(this.label2);
            this.Name = "EditarPedidoTabelado";
            this.Text = "EditarPedidoTabelado";
            this.Load += new System.EventHandler(this.EditarPedidoTabelado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAlterarPedido;
        private System.Windows.Forms.TextBox tbObservacoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpPedido;
        private System.Windows.Forms.Label label2;
    }
}