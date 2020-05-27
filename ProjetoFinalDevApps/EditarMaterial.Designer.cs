namespace ProjetoFinalDevApps
{
    partial class EditarMaterial
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
            this.nudMinimo = new System.Windows.Forms.NumericUpDown();
            this.nudConsMed = new System.Windows.Forms.NumericUpDown();
            this.nudQuant = new System.Windows.Forms.NumericUpDown();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // nudMinimo
            // 
            this.nudMinimo.Location = new System.Drawing.Point(127, 130);
            this.nudMinimo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudMinimo.Name = "nudMinimo";
            this.nudMinimo.Size = new System.Drawing.Size(120, 20);
            this.nudMinimo.TabIndex = 15;
            // 
            // nudConsMed
            // 
            this.nudConsMed.Location = new System.Drawing.Point(127, 104);
            this.nudConsMed.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudConsMed.Name = "nudConsMed";
            this.nudConsMed.Size = new System.Drawing.Size(120, 20);
            this.nudConsMed.TabIndex = 14;
            // 
            // nudQuant
            // 
            this.nudQuant.Location = new System.Drawing.Point(127, 78);
            this.nudQuant.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudQuant.Name = "nudQuant";
            this.nudQuant.Size = new System.Drawing.Size(120, 20);
            this.nudQuant.TabIndex = 13;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(127, 12);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(198, 60);
            this.tbDescricao.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stock Mínimo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Consumo Méd. Diário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quantidade Atual:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descrição:";
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(133, 165);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 49;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // EditarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 200);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.nudMinimo);
            this.Controls.Add(this.nudConsMed);
            this.Controls.Add(this.nudQuant);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditarMaterial";
            this.Text = "EditarMaterial";
            this.Load += new System.EventHandler(this.EditarMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudMinimo;
        private System.Windows.Forms.NumericUpDown nudConsMed;
        private System.Windows.Forms.NumericUpDown nudQuant;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAlterar;
    }
}