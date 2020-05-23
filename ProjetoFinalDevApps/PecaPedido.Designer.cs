namespace ProjetoFinalDevApps
{
    partial class PecaPedido
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
            this.btAdicionarPedido = new System.Windows.Forms.Button();
            this.btAdicionarPeca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAdicionarPedido
            // 
            this.btAdicionarPedido.Location = new System.Drawing.Point(15, 10);
            this.btAdicionarPedido.Name = "btAdicionarPedido";
            this.btAdicionarPedido.Size = new System.Drawing.Size(189, 23);
            this.btAdicionarPedido.TabIndex = 0;
            this.btAdicionarPedido.Text = "Gerir pedidos tabelados";
            this.btAdicionarPedido.UseVisualStyleBackColor = true;
            this.btAdicionarPedido.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAdicionarPeca
            // 
            this.btAdicionarPeca.Location = new System.Drawing.Point(210, 10);
            this.btAdicionarPeca.Name = "btAdicionarPeca";
            this.btAdicionarPeca.Size = new System.Drawing.Size(189, 23);
            this.btAdicionarPeca.TabIndex = 1;
            this.btAdicionarPeca.Text = "Gerir peças e arranjos";
            this.btAdicionarPeca.UseVisualStyleBackColor = true;
            this.btAdicionarPeca.Click += new System.EventHandler(this.btAdicionarPeca_Click);
            // 
            // PecaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 43);
            this.Controls.Add(this.btAdicionarPeca);
            this.Controls.Add(this.btAdicionarPedido);
            this.Name = "PecaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pedidos tabelados e peças/arranjos";
            this.Load += new System.EventHandler(this.PecaPedido_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdicionarPedido;
        private System.Windows.Forms.Button btAdicionarPeca;
    }
}