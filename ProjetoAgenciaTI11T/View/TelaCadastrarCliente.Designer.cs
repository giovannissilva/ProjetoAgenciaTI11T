﻿
namespace ProjetoAgenciaTI11T.View
{
    partial class TelaCadastrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNomeCliente = new System.Windows.Forms.TextBox();
            this.tbxEmailCliente = new System.Windows.Forms.TextBox();
            this.tbxSenhaCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarImagem = new System.Windows.Forms.Button();
            this.pictureBoxFotoCliente = new System.Windows.Forms.PictureBox();
            this.btnSalvarCliente = new System.Windows.Forms.Button();
            this.openFileDialogImagem = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(185, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha:";
            // 
            // tbxNomeCliente
            // 
            this.tbxNomeCliente.Location = new System.Drawing.Point(122, 123);
            this.tbxNomeCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxNomeCliente.Name = "tbxNomeCliente";
            this.tbxNomeCliente.Size = new System.Drawing.Size(351, 27);
            this.tbxNomeCliente.TabIndex = 4;
            // 
            // tbxEmailCliente
            // 
            this.tbxEmailCliente.Location = new System.Drawing.Point(122, 169);
            this.tbxEmailCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmailCliente.Name = "tbxEmailCliente";
            this.tbxEmailCliente.Size = new System.Drawing.Size(351, 27);
            this.tbxEmailCliente.TabIndex = 5;
            // 
            // tbxSenhaCliente
            // 
            this.tbxSenhaCliente.Location = new System.Drawing.Point(122, 219);
            this.tbxSenhaCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSenhaCliente.Name = "tbxSenhaCliente";
            this.tbxSenhaCliente.Size = new System.Drawing.Size(154, 27);
            this.tbxSenhaCliente.TabIndex = 6;
            // 
            // btnBuscarImagem
            // 
            this.btnBuscarImagem.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarImagem.Location = new System.Drawing.Point(513, 252);
            this.btnBuscarImagem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarImagem.Name = "btnBuscarImagem";
            this.btnBuscarImagem.Size = new System.Drawing.Size(110, 28);
            this.btnBuscarImagem.TabIndex = 7;
            this.btnBuscarImagem.Text = "Buscar Imagem";
            this.btnBuscarImagem.UseVisualStyleBackColor = true;
            this.btnBuscarImagem.Click += new System.EventHandler(this.btnBuscarImagem_Click);
            // 
            // pictureBoxFotoCliente
            // 
            this.pictureBoxFotoCliente.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxFotoCliente.Location = new System.Drawing.Point(498, 120);
            this.pictureBoxFotoCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxFotoCliente.Name = "pictureBoxFotoCliente";
            this.pictureBoxFotoCliente.Size = new System.Drawing.Size(142, 124);
            this.pictureBoxFotoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFotoCliente.TabIndex = 8;
            this.pictureBoxFotoCliente.TabStop = false;
            // 
            // btnSalvarCliente
            // 
            this.btnSalvarCliente.Location = new System.Drawing.Point(280, 303);
            this.btnSalvarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvarCliente.Name = "btnSalvarCliente";
            this.btnSalvarCliente.Size = new System.Drawing.Size(91, 40);
            this.btnSalvarCliente.TabIndex = 10;
            this.btnSalvarCliente.Text = "Salvar";
            this.btnSalvarCliente.UseVisualStyleBackColor = true;
            this.btnSalvarCliente.Click += new System.EventHandler(this.btnSalvarCliente_Click);
            // 
            // TelaCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(677, 381);
            this.Controls.Add(this.btnSalvarCliente);
            this.Controls.Add(this.pictureBoxFotoCliente);
            this.Controls.Add(this.btnBuscarImagem);
            this.Controls.Add(this.tbxSenhaCliente);
            this.Controls.Add(this.tbxEmailCliente);
            this.Controls.Add(this.tbxNomeCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "TelaCadastrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Agência de Viagens - Cadastrar Cliente";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaCadastrarCliente_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNomeCliente;
        private System.Windows.Forms.TextBox tbxEmailCliente;
        private System.Windows.Forms.TextBox tbxSenhaCliente;
        private System.Windows.Forms.Button btnBuscarImagem;
        private System.Windows.Forms.PictureBox pictureBoxFotoCliente;
        private System.Windows.Forms.Button btnSalvarCliente;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagem;
    }
}