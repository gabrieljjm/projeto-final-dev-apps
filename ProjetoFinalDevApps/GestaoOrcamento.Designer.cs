namespace ProjetoFinalDevApps
{
    partial class GestaoOrcamento
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
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.btRegistar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(120, 58);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(348, 95);
            this.tbDescricao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // nudValor
            // 
            this.nudValor.Location = new System.Drawing.Point(120, 159);
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(120, 20);
            this.nudValor.TabIndex = 3;
            this.nudValor.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btRegistar
            // 
            this.btRegistar.Location = new System.Drawing.Point(186, 200);
            this.btRegistar.Name = "btRegistar";
            this.btRegistar.Size = new System.Drawing.Size(111, 36);
            this.btRegistar.TabIndex = 4;
            this.btRegistar.Text = "Registar";
            this.btRegistar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cliente";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(120, 8);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(35, 13);
            this.lbCliente.TabIndex = 6;
            this.lbCliente.Text = "label4";
            // 
            // GestaoOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 275);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btRegistar);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label1);
            this.Name = "GestaoOrcamento";
            this.Text = "GestaoOrcamento";
            this.Load += new System.EventHandler(this.GestaoOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.Button btRegistar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCliente;
    }
}