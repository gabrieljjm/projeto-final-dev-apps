﻿namespace ProjetoFinalDevApps
{
    partial class RegistarFornecedor
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
            this.btRegistar = new System.Windows.Forms.Button();
            this.tbCodPostal = new System.Windows.Forms.MaskedTextBox();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbNif = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLocalidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMorada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btRegistar
            // 
            this.btRegistar.Location = new System.Drawing.Point(287, 175);
            this.btRegistar.Name = "btRegistar";
            this.btRegistar.Size = new System.Drawing.Size(75, 23);
            this.btRegistar.TabIndex = 61;
            this.btRegistar.Text = "Registar";
            this.btRegistar.UseVisualStyleBackColor = true;
            this.btRegistar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Location = new System.Drawing.Point(96, 84);
            this.tbCodPostal.Mask = "0000-000";
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(52, 20);
            this.tbCodPostal.TabIndex = 60;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(96, 136);
            this.tbTelefone.Mask = "000 000 000";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(68, 20);
            this.tbTelefone.TabIndex = 59;
            // 
            // tbNif
            // 
            this.tbNif.Location = new System.Drawing.Point(96, 111);
            this.tbNif.Mask = "000 000 000";
            this.tbNif.Name = "tbNif";
            this.tbNif.Size = new System.Drawing.Size(68, 20);
            this.tbNif.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Telefone: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "NIF: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Código-Postal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Localidade:";
            // 
            // tbLocalidade
            // 
            this.tbLocalidade.Location = new System.Drawing.Point(96, 58);
            this.tbLocalidade.Name = "tbLocalidade";
            this.tbLocalidade.Size = new System.Drawing.Size(266, 20);
            this.tbLocalidade.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Morada:";
            // 
            // tbMorada
            // 
            this.tbMorada.Location = new System.Drawing.Point(96, 32);
            this.tbMorada.Name = "tbMorada";
            this.tbMorada.Size = new System.Drawing.Size(266, 20);
            this.tbMorada.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(96, 6);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(266, 20);
            this.tbNome.TabIndex = 49;
            this.tbNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNome_KeyPress);
            // 
            // RegistarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 210);
            this.Controls.Add(this.btRegistar);
            this.Controls.Add(this.tbCodPostal);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.tbNif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLocalidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMorada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNome);
            this.Name = "RegistarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registar Fornecedor";
            this.Load += new System.EventHandler(this.EditarFornecedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegistar;
        private System.Windows.Forms.MaskedTextBox tbCodPostal;
        private System.Windows.Forms.MaskedTextBox tbTelefone;
        private System.Windows.Forms.MaskedTextBox tbNif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLocalidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMorada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
    }
}