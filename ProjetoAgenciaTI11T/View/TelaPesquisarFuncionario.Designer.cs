
namespace ProjetoAgenciaTI11T.View
{
    partial class TelaPesquisarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisarFuncionario));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxPesquisaNomeFun = new System.Windows.Forms.TextBox();
            this.btnBuscaNomeFun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeletarCodFun = new System.Windows.Forms.Button();
            this.btnAlterarCodFun = new System.Windows.Forms.Button();
            this.tbxSenhaFun = new System.Windows.Forms.TextBox();
            this.tbxEmailFun = new System.Windows.Forms.TextBox();
            this.tbxNomeFun = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxCodFun = new System.Windows.Forms.TextBox();
            this.btnCodFun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(689, 301);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.tbxPesquisaNomeFun);
            this.tabPage1.Controls.Add(this.btnBuscaNomeFun);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(681, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar por Nome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nome,
            this.Email,
            this.Foto});
            this.dataGridView1.Location = new System.Drawing.Point(10, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(665, 200);
            this.dataGridView1.TabIndex = 4;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            // 
            // tbxPesquisaNomeFun
            // 
            this.tbxPesquisaNomeFun.Location = new System.Drawing.Point(257, 29);
            this.tbxPesquisaNomeFun.Name = "tbxPesquisaNomeFun";
            this.tbxPesquisaNomeFun.Size = new System.Drawing.Size(251, 23);
            this.tbxPesquisaNomeFun.TabIndex = 3;
            // 
            // btnBuscaNomeFun
            // 
            this.btnBuscaNomeFun.Location = new System.Drawing.Point(514, 29);
            this.btnBuscaNomeFun.Name = "btnBuscaNomeFun";
            this.btnBuscaNomeFun.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaNomeFun.TabIndex = 2;
            this.btnBuscaNomeFun.Text = "Buscar";
            this.btnBuscaNomeFun.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite o Nome do Funcionario:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeletarCodFun);
            this.tabPage2.Controls.Add(this.btnAlterarCodFun);
            this.tabPage2.Controls.Add(this.tbxSenhaFun);
            this.tabPage2.Controls.Add(this.tbxEmailFun);
            this.tabPage2.Controls.Add(this.tbxNomeFun);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tbxCodFun);
            this.tabPage2.Controls.Add(this.btnCodFun);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(681, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar por Codigo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeletarCodFun
            // 
            this.btnDeletarCodFun.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeletarCodFun.Location = new System.Drawing.Point(323, 223);
            this.btnDeletarCodFun.Name = "btnDeletarCodFun";
            this.btnDeletarCodFun.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarCodFun.TabIndex = 24;
            this.btnDeletarCodFun.Text = "Deletar";
            this.btnDeletarCodFun.UseVisualStyleBackColor = true;
            this.btnDeletarCodFun.Click += new System.EventHandler(this.btnDeletarCodFun_Click);
            // 
            // btnAlterarCodFun
            // 
            this.btnAlterarCodFun.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlterarCodFun.Location = new System.Drawing.Point(208, 223);
            this.btnAlterarCodFun.Name = "btnAlterarCodFun";
            this.btnAlterarCodFun.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCodFun.TabIndex = 23;
            this.btnAlterarCodFun.Text = "Alterar";
            this.btnAlterarCodFun.UseVisualStyleBackColor = true;
            this.btnAlterarCodFun.Click += new System.EventHandler(this.btnAlterarCodFun_Click);
            // 
            // tbxSenhaFun
            // 
            this.tbxSenhaFun.Location = new System.Drawing.Point(90, 140);
            this.tbxSenhaFun.Name = "tbxSenhaFun";
            this.tbxSenhaFun.Size = new System.Drawing.Size(135, 23);
            this.tbxSenhaFun.TabIndex = 20;
            // 
            // tbxEmailFun
            // 
            this.tbxEmailFun.Location = new System.Drawing.Point(90, 98);
            this.tbxEmailFun.Name = "tbxEmailFun";
            this.tbxEmailFun.Size = new System.Drawing.Size(308, 23);
            this.tbxEmailFun.TabIndex = 19;
            // 
            // tbxNomeFun
            // 
            this.tbxNomeFun.Location = new System.Drawing.Point(90, 57);
            this.tbxNomeFun.Name = "tbxNomeFun";
            this.tbxNomeFun.Size = new System.Drawing.Size(308, 23);
            this.tbxNomeFun.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(11, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Senha:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(8, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "E-mail:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(11, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nome:";
            // 
            // tbxCodFun
            // 
            this.tbxCodFun.Location = new System.Drawing.Point(268, 22);
            this.tbxCodFun.Name = "tbxCodFun";
            this.tbxCodFun.Size = new System.Drawing.Size(251, 23);
            this.tbxCodFun.TabIndex = 6;
            // 
            // btnCodFun
            // 
            this.btnCodFun.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCodFun.Location = new System.Drawing.Point(525, 22);
            this.btnCodFun.Name = "btnCodFun";
            this.btnCodFun.Size = new System.Drawing.Size(75, 23);
            this.btnCodFun.TabIndex = 5;
            this.btnCodFun.Text = "Buscar";
            this.btnCodFun.UseVisualStyleBackColor = true;
            this.btnCodFun.Click += new System.EventHandler(this.btnCodFun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Digite o Codigo do Funcionario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(197, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar Funcionario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TelaPesquisarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(712, 406);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "TelaPesquisarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Funcionario";
            this.Load += new System.EventHandler(this.TelaPesquisarFuncionario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
        private System.Windows.Forms.TextBox tbxPesquisaNomeFun;
        private System.Windows.Forms.Button btnBuscaNomeFun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDeletarCodFun;
        private System.Windows.Forms.Button btnAlterarCodFun;
        private System.Windows.Forms.TextBox tbxSenhaFun;
        private System.Windows.Forms.TextBox tbxEmailFun;
        private System.Windows.Forms.TextBox tbxNomeFun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxCodFun;
        private System.Windows.Forms.Button btnCodFun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}