namespace ProjetoFinalDevApps
{
    partial class EditarFornecimentos
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
            this.cbMateriais = new System.Windows.Forms.ComboBox();
            this.dtpPrazo = new System.Windows.Forms.DateTimePicker();
            this.nudPreco = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Material:";
            // 
            // cbMateriais
            // 
            this.cbMateriais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriais.FormattingEnabled = true;
            this.cbMateriais.Location = new System.Drawing.Point(153, 73);
            this.cbMateriais.Name = "cbMateriais";
            this.cbMateriais.Size = new System.Drawing.Size(200, 21);
            this.cbMateriais.TabIndex = 16;
            // 
            // dtpPrazo
            // 
            this.dtpPrazo.Location = new System.Drawing.Point(153, 47);
            this.dtpPrazo.Name = "dtpPrazo";
            this.dtpPrazo.Size = new System.Drawing.Size(200, 20);
            this.dtpPrazo.TabIndex = 15;
            // 
            // nudPreco
            // 
            this.nudPreco.Location = new System.Drawing.Point(153, 21);
            this.nudPreco.Name = "nudPreco";
            this.nudPreco.Size = new System.Drawing.Size(120, 20);
            this.nudPreco.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Prazo de Entrega:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Preço:";
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(167, 122);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 18;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // EditarFornecimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 178);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMateriais);
            this.Controls.Add(this.dtpPrazo);
            this.Controls.Add(this.nudPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditarFornecimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarFornecimentos";
            this.Load += new System.EventHandler(this.EditarFornecimentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMateriais;
        private System.Windows.Forms.DateTimePicker dtpPrazo;
        private System.Windows.Forms.NumericUpDown nudPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAlterar;
    }
}