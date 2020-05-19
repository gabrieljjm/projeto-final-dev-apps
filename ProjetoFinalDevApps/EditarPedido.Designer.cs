namespace ProjetoFinalDevApps
{
    partial class EditarPedido
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
            this.gbRadioButtons = new System.Windows.Forms.GroupBox();
            this.rbOrcamento = new System.Windows.Forms.RadioButton();
            this.rbPedidoTabelado = new System.Windows.Forms.RadioButton();
            this.btAlterar = new System.Windows.Forms.Button();
            this.tbObservacoes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataPedido = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ckPago = new System.Windows.Forms.CheckBox();
            this.ckLevantado = new System.Windows.Forms.CheckBox();
            this.gbRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRadioButtons
            // 
            this.gbRadioButtons.Controls.Add(this.rbOrcamento);
            this.gbRadioButtons.Controls.Add(this.rbPedidoTabelado);
            this.gbRadioButtons.Location = new System.Drawing.Point(123, 85);
            this.gbRadioButtons.Name = "gbRadioButtons";
            this.gbRadioButtons.Size = new System.Drawing.Size(297, 37);
            this.gbRadioButtons.TabIndex = 30;
            this.gbRadioButtons.TabStop = false;
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
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(170, 335);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(106, 33);
            this.btAlterar.TabIndex = 29;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btRegistar_Click);
            // 
            // tbObservacoes
            // 
            this.tbObservacoes.Location = new System.Drawing.Point(123, 137);
            this.tbObservacoes.Multiline = true;
            this.tbObservacoes.Name = "tbObservacoes";
            this.tbObservacoes.Size = new System.Drawing.Size(297, 72);
            this.tbObservacoes.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Observações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Data do pedido";
            // 
            // dtpDataPedido
            // 
            this.dtpDataPedido.Location = new System.Drawing.Point(123, 50);
            this.dtpDataPedido.Name = "dtpDataPedido";
            this.dtpDataPedido.Size = new System.Drawing.Size(297, 20);
            this.dtpDataPedido.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cliente";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(123, 15);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(35, 13);
            this.lbCliente.TabIndex = 31;
            this.lbCliente.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Levantado";
            // 
            // ckPago
            // 
            this.ckPago.AutoSize = true;
            this.ckPago.Location = new System.Drawing.Point(123, 228);
            this.ckPago.Name = "ckPago";
            this.ckPago.Size = new System.Drawing.Size(15, 14);
            this.ckPago.TabIndex = 34;
            this.ckPago.UseVisualStyleBackColor = true;
            this.ckPago.CheckedChanged += new System.EventHandler(this.ckPago_CheckedChanged);
            this.ckPago.Click += new System.EventHandler(this.ckPago_Click);
            // 
            // ckLevantado
            // 
            this.ckLevantado.AutoSize = true;
            this.ckLevantado.Enabled = false;
            this.ckLevantado.Location = new System.Drawing.Point(123, 268);
            this.ckLevantado.Name = "ckLevantado";
            this.ckLevantado.Size = new System.Drawing.Size(15, 14);
            this.ckLevantado.TabIndex = 35;
            this.ckLevantado.UseVisualStyleBackColor = true;
            // 
            // EditarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 397);
            this.Controls.Add(this.ckLevantado);
            this.Controls.Add(this.ckPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.gbRadioButtons);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.tbObservacoes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarPedido";
            this.Activated += new System.EventHandler(this.EditarPedido_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditarPedido_FormClosed);
            this.Load += new System.EventHandler(this.EditarPedido_Load);
            this.gbRadioButtons.ResumeLayout(false);
            this.gbRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRadioButtons;
        private System.Windows.Forms.RadioButton rbOrcamento;
        private System.Windows.Forms.RadioButton rbPedidoTabelado;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.TextBox tbObservacoes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckPago;
        private System.Windows.Forms.CheckBox ckLevantado;
    }
}