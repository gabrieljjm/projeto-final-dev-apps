namespace ProjetoFinalDevApps
{
    partial class RegistarTrabalho
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
            this.label1 = new System.Windows.Forms.Label();
            this.btRegistar = new System.Windows.Forms.Button();
            this.tbDescricaoPeca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpLevantamento = new System.Windows.Forms.DateTimePicker();
            this.tbObservacoes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbArranjo = new System.Windows.Forms.ComboBox();
            this.cbPeca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição da Peça:";
            // 
            // btRegistar
            // 
            this.btRegistar.Location = new System.Drawing.Point(461, 225);
            this.btRegistar.Name = "btRegistar";
            this.btRegistar.Size = new System.Drawing.Size(75, 23);
            this.btRegistar.TabIndex = 1;
            this.btRegistar.Text = "Registar";
            this.btRegistar.UseVisualStyleBackColor = true;
            this.btRegistar.Click += new System.EventHandler(this.btRegistar_Click);
            // 
            // tbDescricaoPeca
            // 
            this.tbDescricaoPeca.Location = new System.Drawing.Point(122, 12);
            this.tbDescricaoPeca.Multiline = true;
            this.tbDescricaoPeca.Name = "tbDescricaoPeca";
            this.tbDescricaoPeca.Size = new System.Drawing.Size(414, 59);
            this.tbDescricaoPeca.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cor da Peça:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Levantamento:";
            // 
            // dtpLevantamento
            // 
            this.dtpLevantamento.Location = new System.Drawing.Point(122, 104);
            this.dtpLevantamento.Name = "dtpLevantamento";
            this.dtpLevantamento.Size = new System.Drawing.Size(200, 20);
            this.dtpLevantamento.TabIndex = 8;
            // 
            // tbObservacoes
            // 
            this.tbObservacoes.Location = new System.Drawing.Point(122, 130);
            this.tbObservacoes.Multiline = true;
            this.tbObservacoes.Name = "tbObservacoes";
            this.tbObservacoes.Size = new System.Drawing.Size(414, 60);
            this.tbObservacoes.TabIndex = 9;
            this.tbObservacoes.TextChanged += new System.EventHandler(this.tbObservacoes_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Observações:";
            // 
            // cbArranjo
            // 
            this.cbArranjo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArranjo.Enabled = false;
            this.cbArranjo.FormattingEnabled = true;
            this.cbArranjo.Location = new System.Drawing.Point(249, 196);
            this.cbArranjo.Name = "cbArranjo";
            this.cbArranjo.Size = new System.Drawing.Size(121, 21);
            this.cbArranjo.TabIndex = 13;
            this.cbArranjo.SelectedIndexChanged += new System.EventHandler(this.cbArranjo_SelectedIndexChanged);
            // 
            // cbPeca
            // 
            this.cbPeca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeca.FormattingEnabled = true;
            this.cbPeca.Location = new System.Drawing.Point(122, 196);
            this.cbPeca.Name = "cbPeca";
            this.cbPeca.Size = new System.Drawing.Size(121, 21);
            this.cbPeca.TabIndex = 14;
            this.cbPeca.SelectedIndexChanged += new System.EventHandler(this.cbPeca_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Peça e arranjo:";
            // 
            // cbCor
            // 
            this.cbCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Items.AddRange(new object[] {
            "Amarelo",
            "Azul",
            "Bege",
            "Bordô",
            "Branco",
            "Cinza",
            "Castanho",
            "Dourado",
            "Laranja",
            "Lilás",
            "Magenta",
            "Naval",
            "Prata",
            "Preto",
            "Púrpura",
            "Rosa",
            "Roxo",
            "Salmão",
            "Verde",
            "Vermelho",
            "Violeta"});
            this.cbCor.Location = new System.Drawing.Point(122, 77);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(121, 21);
            this.cbCor.TabIndex = 16;
            // 
            // RegistarTrabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 260);
            this.Controls.Add(this.cbCor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbPeca);
            this.Controls.Add(this.cbArranjo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbObservacoes);
            this.Controls.Add(this.dtpLevantamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDescricaoPeca);
            this.Controls.Add(this.btRegistar);
            this.Controls.Add(this.label1);
            this.Name = "RegistarTrabalho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registar Trabalho";
            this.Load += new System.EventHandler(this.NovoTrabalho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRegistar;
        private System.Windows.Forms.TextBox tbDescricaoPeca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpLevantamento;
        private System.Windows.Forms.TextBox tbObservacoes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbArranjo;
        private System.Windows.Forms.ComboBox cbPeca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCor;
    }
}