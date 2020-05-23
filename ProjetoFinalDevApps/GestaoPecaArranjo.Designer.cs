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
            this.btAdicionarPeca = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPreco = new System.Windows.Forms.NumericUpDown();
            this.btAdicionarArranjo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).BeginInit();
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
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Combinação da peça com arranjo";
            // 
            // cbPeca
            // 
            this.cbPeca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeca.FormattingEnabled = true;
            this.cbPeca.Location = new System.Drawing.Point(235, 187);
            this.cbPeca.Name = "cbPeca";
            this.cbPeca.Size = new System.Drawing.Size(121, 21);
            this.cbPeca.TabIndex = 6;
            this.cbPeca.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbPeca_DrawItem);
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
            // btAdicionarPeca
            // 
            this.btAdicionarPeca.Location = new System.Drawing.Point(28, 107);
            this.btAdicionarPeca.Name = "btAdicionarPeca";
            this.btAdicionarPeca.Size = new System.Drawing.Size(149, 23);
            this.btAdicionarPeca.TabIndex = 8;
            this.btAdicionarPeca.Text = "Adicionar peça";
            this.btAdicionarPeca.UseVisualStyleBackColor = true;
            this.btAdicionarPeca.Click += new System.EventHandler(this.btAdicionarPecaArranjo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preço";
            // 
            // nudPreco
            // 
            this.nudPreco.Location = new System.Drawing.Point(235, 235);
            this.nudPreco.Name = "nudPreco";
            this.nudPreco.Size = new System.Drawing.Size(120, 20);
            this.nudPreco.TabIndex = 10;
            // 
            // btAdicionarArranjo
            // 
            this.btAdicionarArranjo.Location = new System.Drawing.Point(183, 107);
            this.btAdicionarArranjo.Name = "btAdicionarArranjo";
            this.btAdicionarArranjo.Size = new System.Drawing.Size(149, 23);
            this.btAdicionarArranjo.TabIndex = 11;
            this.btAdicionarArranjo.Text = "Adicionar arranjo";
            this.btAdicionarArranjo.UseVisualStyleBackColor = true;
            this.btAdicionarArranjo.Click += new System.EventHandler(this.btAdicionarArranjo_Click);
            // 
            // GestaoPecaArranjo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAdicionarArranjo);
            this.Controls.Add(this.nudPreco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btAdicionarPeca);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).EndInit();
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
        private System.Windows.Forms.Button btAdicionarPeca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPreco;
        private System.Windows.Forms.Button btAdicionarArranjo;
    }
}