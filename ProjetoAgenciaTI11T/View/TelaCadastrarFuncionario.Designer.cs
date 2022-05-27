
namespace ProjetoAgenciaTI11T.View
{
    partial class TelaCadastrarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarFuncionario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNomeFuncionario = new System.Windows.Forms.TextBox();
            this.tbxEmailFuncionario = new System.Windows.Forms.TextBox();
            this.tbxSenhaFuncionario = new System.Windows.Forms.TextBox();
            this.btnSalvarFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(70, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(70, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Senha:";
            // 
            // tbxNomeFuncionario
            // 
            this.tbxNomeFuncionario.Location = new System.Drawing.Point(135, 116);
            this.tbxNomeFuncionario.Name = "tbxNomeFuncionario";
            this.tbxNomeFuncionario.Size = new System.Drawing.Size(287, 23);
            this.tbxNomeFuncionario.TabIndex = 5;
            // 
            // tbxEmailFuncionario
            // 
            this.tbxEmailFuncionario.Location = new System.Drawing.Point(135, 157);
            this.tbxEmailFuncionario.Name = "tbxEmailFuncionario";
            this.tbxEmailFuncionario.Size = new System.Drawing.Size(287, 23);
            this.tbxEmailFuncionario.TabIndex = 6;
            // 
            // tbxSenhaFuncionario
            // 
            this.tbxSenhaFuncionario.Location = new System.Drawing.Point(137, 198);
            this.tbxSenhaFuncionario.Name = "tbxSenhaFuncionario";
            this.tbxSenhaFuncionario.Size = new System.Drawing.Size(161, 23);
            this.tbxSenhaFuncionario.TabIndex = 7;
            // 
            // btnSalvarFuncionario
            // 
            this.btnSalvarFuncionario.Location = new System.Drawing.Point(359, 245);
            this.btnSalvarFuncionario.Name = "btnSalvarFuncionario";
            this.btnSalvarFuncionario.Size = new System.Drawing.Size(80, 30);
            this.btnSalvarFuncionario.TabIndex = 8;
            this.btnSalvarFuncionario.Text = "Salvar";
            this.btnSalvarFuncionario.UseVisualStyleBackColor = true;
            // 
            // TelaCadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(492, 306);
            this.Controls.Add(this.btnSalvarFuncionario);
            this.Controls.Add(this.tbxSenhaFuncionario);
            this.Controls.Add(this.tbxEmailFuncionario);
            this.Controls.Add(this.tbxNomeFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaCadastrarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Agência de Viagens - Cadastrar Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNomeFuncionario;
        private System.Windows.Forms.TextBox tbxEmailFuncionario;
        private System.Windows.Forms.TextBox tbxSenhaFuncionario;
        private System.Windows.Forms.Button btnSalvarFuncionario;
    }
}