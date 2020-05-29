namespace ProjetoFinalDevApps
{
    partial class RegistarFornecimento
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
            this.nudPreco = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btRegistar = new System.Windows.Forms.Button();
            this.nudPrazoEntrega = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrazoEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Material:";
            // 
            // cbMateriais
            // 
            this.cbMateriais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriais.FormattingEnabled = true;
            this.cbMateriais.Location = new System.Drawing.Point(110, 64);
            this.cbMateriais.Name = "cbMateriais";
            this.cbMateriais.Size = new System.Drawing.Size(200, 21);
            this.cbMateriais.TabIndex = 2;
            // 
            // nudPreco
            // 
            this.nudPreco.DecimalPlaces = 2;
            this.nudPreco.Location = new System.Drawing.Point(110, 12);
            this.nudPreco.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPreco.Name = "nudPreco";
            this.nudPreco.Size = new System.Drawing.Size(120, 20);
            this.nudPreco.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Prazo de Entrega:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Preço:";
            // 
            // btRegistar
            // 
            this.btRegistar.Location = new System.Drawing.Point(235, 91);
            this.btRegistar.Name = "btRegistar";
            this.btRegistar.Size = new System.Drawing.Size(75, 23);
            this.btRegistar.TabIndex = 3;
            this.btRegistar.Text = "Registar";
            this.btRegistar.UseVisualStyleBackColor = true;
            this.btRegistar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // nudPrazoEntrega
            // 
            this.nudPrazoEntrega.Location = new System.Drawing.Point(110, 38);
            this.nudPrazoEntrega.Name = "nudPrazoEntrega";
            this.nudPrazoEntrega.Size = new System.Drawing.Size(120, 20);
            this.nudPrazoEntrega.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "dias";
            // 
            // RegistarFornecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 124);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudPrazoEntrega);
            this.Controls.Add(this.btRegistar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMateriais);
            this.Controls.Add(this.nudPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistarFornecimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registar Fornecimento";
            this.Load += new System.EventHandler(this.EditarFornecimentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrazoEntrega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMateriais;
        private System.Windows.Forms.NumericUpDown nudPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRegistar;
        private System.Windows.Forms.NumericUpDown nudPrazoEntrega;
        private System.Windows.Forms.Label label4;
    }
}