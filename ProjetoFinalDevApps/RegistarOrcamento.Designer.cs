namespace ProjetoFinalDevApps
{
    partial class RegistarOrcamento
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
            this.label3 = new System.Windows.Forms.Label();
            this.dtpPedido = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.tbObservacoes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.btRegistarOrcamento = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ckAceite = new System.Windows.Forms.CheckBox();
            this.ckPago = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ckLevantado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Observações:";
            // 
            // dtpPedido
            // 
            this.dtpPedido.Location = new System.Drawing.Point(91, 39);
            this.dtpPedido.Name = "dtpPedido";
            this.dtpPedido.Size = new System.Drawing.Size(267, 20);
            this.dtpPedido.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data Pedido:";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(91, 12);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(267, 21);
            this.cbCliente.TabIndex = 0;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(12, 15);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(42, 13);
            this.lbCliente.TabIndex = 5;
            this.lbCliente.Text = "Cliente:";
            // 
            // tbObservacoes
            // 
            this.tbObservacoes.Location = new System.Drawing.Point(91, 65);
            this.tbObservacoes.Multiline = true;
            this.tbObservacoes.Name = "tbObservacoes";
            this.tbObservacoes.Size = new System.Drawing.Size(267, 80);
            this.tbObservacoes.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descrição:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(91, 151);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(267, 80);
            this.tbDescricao.TabIndex = 3;
            // 
            // btRegistarOrcamento
            // 
            this.btRegistarOrcamento.Location = new System.Drawing.Point(283, 326);
            this.btRegistarOrcamento.Name = "btRegistarOrcamento";
            this.btRegistarOrcamento.Size = new System.Drawing.Size(75, 23);
            this.btRegistarOrcamento.TabIndex = 8;
            this.btRegistarOrcamento.Text = "Registar";
            this.btRegistarOrcamento.UseVisualStyleBackColor = true;
            this.btRegistarOrcamento.Click += new System.EventHandler(this.btRegistarOrcamento_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Aceite:";
            // 
            // ckAceite
            // 
            this.ckAceite.AutoSize = true;
            this.ckAceite.Location = new System.Drawing.Point(91, 263);
            this.ckAceite.Name = "ckAceite";
            this.ckAceite.Size = new System.Drawing.Size(15, 14);
            this.ckAceite.TabIndex = 5;
            this.ckAceite.UseVisualStyleBackColor = true;
            this.ckAceite.CheckedChanged += new System.EventHandler(this.ckAceite_CheckedChanged);
            this.ckAceite.Click += new System.EventHandler(this.ckAceite_Click);
            // 
            // ckPago
            // 
            this.ckPago.AutoSize = true;
            this.ckPago.Enabled = false;
            this.ckPago.Location = new System.Drawing.Point(91, 283);
            this.ckPago.Name = "ckPago";
            this.ckPago.Size = new System.Drawing.Size(15, 14);
            this.ckPago.TabIndex = 6;
            this.ckPago.UseVisualStyleBackColor = true;
            this.ckPago.CheckedChanged += new System.EventHandler(this.ckPago_CheckedChanged);
            this.ckPago.Click += new System.EventHandler(this.ckPago_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pago:";
            // 
            // ckLevantado
            // 
            this.ckLevantado.AutoSize = true;
            this.ckLevantado.Enabled = false;
            this.ckLevantado.Location = new System.Drawing.Point(91, 303);
            this.ckLevantado.Name = "ckLevantado";
            this.ckLevantado.Size = new System.Drawing.Size(15, 14);
            this.ckLevantado.TabIndex = 7;
            this.ckLevantado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Levantado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Valor:";
            // 
            // nudValor
            // 
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.Location = new System.Drawing.Point(91, 237);
            this.nudValor.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(120, 20);
            this.nudValor.TabIndex = 4;
            // 
            // RegistarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 361);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ckLevantado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ckPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ckAceite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btRegistarOrcamento);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbObservacoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lbCliente);
            this.Name = "RegistarOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registar Orçamento";
            this.Load += new System.EventHandler(this.NovoOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.TextBox tbObservacoes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Button btRegistarOrcamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckAceite;
        private System.Windows.Forms.CheckBox ckPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckLevantado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudValor;
    }
}