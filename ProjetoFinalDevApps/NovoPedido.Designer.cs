namespace ProjetoFinalDevApps
{
    partial class NovoPedido
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbOrcamento = new System.Windows.Forms.RadioButton();
            this.rbPedidoTabelado = new System.Windows.Forms.RadioButton();
            this.dtpDataPedido = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbObservacoes = new System.Windows.Forms.TextBox();
            this.btRegistar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tipo";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(123, 15);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(297, 21);
            this.cbCliente.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cliente";
            // 
            // rbOrcamento
            // 
            this.rbOrcamento.AutoSize = true;
            this.rbOrcamento.Location = new System.Drawing.Point(47, 12);
            this.rbOrcamento.Name = "rbOrcamento";
            this.rbOrcamento.Size = new System.Drawing.Size(77, 17);
            this.rbOrcamento.TabIndex = 12;
            this.rbOrcamento.TabStop = true;
            this.rbOrcamento.Text = "Orçamento";
            this.rbOrcamento.UseVisualStyleBackColor = true;
            this.rbOrcamento.CheckedChanged += new System.EventHandler(this.rbOrcamento_CheckedChanged);
            // 
            // rbPedidoTabelado
            // 
            this.rbPedidoTabelado.AutoSize = true;
            this.rbPedidoTabelado.Location = new System.Drawing.Point(157, 12);
            this.rbPedidoTabelado.Name = "rbPedidoTabelado";
            this.rbPedidoTabelado.Size = new System.Drawing.Size(102, 17);
            this.rbPedidoTabelado.TabIndex = 13;
            this.rbPedidoTabelado.TabStop = true;
            this.rbPedidoTabelado.Text = "Pedido tabelado";
            this.rbPedidoTabelado.UseVisualStyleBackColor = true;
            // 
            // dtpDataPedido
            // 
            this.dtpDataPedido.Location = new System.Drawing.Point(123, 50);
            this.dtpDataPedido.Name = "dtpDataPedido";
            this.dtpDataPedido.Size = new System.Drawing.Size(297, 20);
            this.dtpDataPedido.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data do pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Observações";
            // 
            // tbObservacoes
            // 
            this.tbObservacoes.Location = new System.Drawing.Point(123, 137);
            this.tbObservacoes.Multiline = true;
            this.tbObservacoes.Name = "tbObservacoes";
            this.tbObservacoes.Size = new System.Drawing.Size(297, 72);
            this.tbObservacoes.TabIndex = 17;
            // 
            // btRegistar
            // 
            this.btRegistar.Location = new System.Drawing.Point(165, 225);
            this.btRegistar.Name = "btRegistar";
            this.btRegistar.Size = new System.Drawing.Size(106, 33);
            this.btRegistar.TabIndex = 18;
            this.btRegistar.Text = "Registar";
            this.btRegistar.UseVisualStyleBackColor = true;
            this.btRegistar.Click += new System.EventHandler(this.btRegistar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOrcamento);
            this.groupBox1.Controls.Add(this.rbPedidoTabelado);
            this.groupBox1.Location = new System.Drawing.Point(123, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 37);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // NovoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 280);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btRegistar);
            this.Controls.Add(this.tbObservacoes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label1);
            this.Name = "NovoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo pedido";
            this.Load += new System.EventHandler(this.NovoPedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbOrcamento;
        private System.Windows.Forms.RadioButton rbPedidoTabelado;
        private System.Windows.Forms.DateTimePicker dtpDataPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbObservacoes;
        private System.Windows.Forms.Button btRegistar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}