﻿namespace ProjetoFinalDevApps
{
    partial class EditarTrabalho
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
            this.label7 = new System.Windows.Forms.Label();
            this.cbPeca = new System.Windows.Forms.ComboBox();
            this.cbArranjo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbObservacoes = new System.Windows.Forms.TextBox();
            this.dtpLevantamento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudValorPago = new System.Windows.Forms.NumericUpDown();
            this.tbCorPeca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescricaoPeca = new System.Windows.Forms.TextBox();
            this.btAlterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorPago)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Peça e arranjo";
            // 
            // cbPeca
            // 
            this.cbPeca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeca.FormattingEnabled = true;
            this.cbPeca.Location = new System.Drawing.Point(132, 225);
            this.cbPeca.Name = "cbPeca";
            this.cbPeca.Size = new System.Drawing.Size(121, 21);
            this.cbPeca.TabIndex = 28;
            this.cbPeca.SelectedIndexChanged += new System.EventHandler(this.cbPeca_SelectedIndexChanged);
            // 
            // cbArranjo
            // 
            this.cbArranjo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArranjo.Enabled = false;
            this.cbArranjo.FormattingEnabled = true;
            this.cbArranjo.Location = new System.Drawing.Point(257, 226);
            this.cbArranjo.Name = "cbArranjo";
            this.cbArranjo.Size = new System.Drawing.Size(121, 21);
            this.cbArranjo.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Observações";
            // 
            // tbObservacoes
            // 
            this.tbObservacoes.Location = new System.Drawing.Point(132, 159);
            this.tbObservacoes.Multiline = true;
            this.tbObservacoes.Name = "tbObservacoes";
            this.tbObservacoes.Size = new System.Drawing.Size(414, 60);
            this.tbObservacoes.TabIndex = 25;
            // 
            // dtpLevantamento
            // 
            this.dtpLevantamento.Location = new System.Drawing.Point(132, 132);
            this.dtpLevantamento.Name = "dtpLevantamento";
            this.dtpLevantamento.Size = new System.Drawing.Size(200, 20);
            this.dtpLevantamento.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Data levantamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Valor pago";
            // 
            // nudValorPago
            // 
            this.nudValorPago.Location = new System.Drawing.Point(132, 106);
            this.nudValorPago.Name = "nudValorPago";
            this.nudValorPago.Size = new System.Drawing.Size(120, 20);
            this.nudValorPago.TabIndex = 21;
            // 
            // tbCorPeca
            // 
            this.tbCorPeca.Location = new System.Drawing.Point(132, 77);
            this.tbCorPeca.Name = "tbCorPeca";
            this.tbCorPeca.Size = new System.Drawing.Size(177, 20);
            this.tbCorPeca.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cor peça";
            // 
            // tbDescricaoPeca
            // 
            this.tbDescricaoPeca.Location = new System.Drawing.Point(132, 12);
            this.tbDescricaoPeca.Multiline = true;
            this.tbDescricaoPeca.Name = "tbDescricaoPeca";
            this.tbDescricaoPeca.Size = new System.Drawing.Size(414, 59);
            this.tbDescricaoPeca.TabIndex = 18;
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(243, 277);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 17;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Descrição da peça";
            // 
            // EditarTrabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 311);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbPeca);
            this.Controls.Add(this.cbArranjo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbObservacoes);
            this.Controls.Add(this.dtpLevantamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudValorPago);
            this.Controls.Add(this.tbCorPeca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDescricaoPeca);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.label1);
            this.Name = "EditarTrabalho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarTrabalho";
            this.Load += new System.EventHandler(this.EditarTrabalho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudValorPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPeca;
        private System.Windows.Forms.ComboBox cbArranjo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbObservacoes;
        private System.Windows.Forms.DateTimePicker dtpLevantamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudValorPago;
        private System.Windows.Forms.TextBox tbCorPeca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescricaoPeca;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Label label1;
    }
}