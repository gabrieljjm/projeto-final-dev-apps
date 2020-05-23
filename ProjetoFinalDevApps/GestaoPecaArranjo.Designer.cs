namespace ProjetoFinalDevApps
{
    partial class GestaoPecaArranjo
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
            this.tbPeca = new System.Windows.Forms.TextBox();
            this.tbArranjo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPeca = new System.Windows.Forms.ComboBox();
            this.cbArranjo = new System.Windows.Forms.ComboBox();
            this.btAdicionarPecaArranjo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de peça";
            // 
            // tbPeca
            // 
            this.tbPeca.Location = new System.Drawing.Point(112, 27);
            this.tbPeca.Name = "tbPeca";
            this.tbPeca.Size = new System.Drawing.Size(185, 20);
            this.tbPeca.TabIndex = 1;
            // 
            // tbArranjo
            // 
            this.tbArranjo.Location = new System.Drawing.Point(112, 63);
            this.tbArranjo.Name = "tbArranjo";
            this.tbArranjo.Size = new System.Drawing.Size(185, 20);
            this.tbArranjo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de arranjo";
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(206, 285);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 4;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fazer combinação de peça com arranjo";
            // 
            // cbPeca
            // 
            this.cbPeca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeca.FormattingEnabled = true;
            this.cbPeca.Location = new System.Drawing.Point(235, 187);
            this.cbPeca.Name = "cbPeca";
            this.cbPeca.Size = new System.Drawing.Size(121, 21);
            this.cbPeca.TabIndex = 6;
            // 
            // cbArranjo
            // 
            this.cbArranjo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArranjo.FormattingEnabled = true;
            this.cbArranjo.Location = new System.Drawing.Point(363, 186);
            this.cbArranjo.Name = "cbArranjo";
            this.cbArranjo.Size = new System.Drawing.Size(121, 21);
            this.cbArranjo.TabIndex = 7;
            // 
            // btAdicionarPecaArranjo
            // 
            this.btAdicionarPecaArranjo.Location = new System.Drawing.Point(112, 105);
            this.btAdicionarPecaArranjo.Name = "btAdicionarPecaArranjo";
            this.btAdicionarPecaArranjo.Size = new System.Drawing.Size(149, 23);
            this.btAdicionarPecaArranjo.TabIndex = 8;
            this.btAdicionarPecaArranjo.Text = "Adicionar peça ou arranjo";
            this.btAdicionarPecaArranjo.UseVisualStyleBackColor = true;
            this.btAdicionarPecaArranjo.Click += new System.EventHandler(this.btAdicionarPecaArranjo_Click);
            // 
            // GestaoPecaArranjo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAdicionarPecaArranjo);
            this.Controls.Add(this.cbArranjo);
            this.Controls.Add(this.cbPeca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.tbArranjo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPeca);
            this.Controls.Add(this.label1);
            this.Name = "GestaoPecaArranjo";
            this.Text = "GestaoPecaArranjo";
            this.Load += new System.EventHandler(this.GestaoPecaArranjo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPeca;
        private System.Windows.Forms.TextBox tbArranjo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPeca;
        private System.Windows.Forms.ComboBox cbArranjo;
        private System.Windows.Forms.Button btAdicionarPecaArranjo;
    }
}