
namespace ProjetoAgenciaTI11T.View
{
    partial class TelaPesquisarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisarCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxPesquisaNomeCli = new System.Windows.Forms.TextBox();
            this.btnBuscaNomeCli = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletarCodCli = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscarImg = new System.Windows.Forms.Button();
            this.tbxSenhaCli = new System.Windows.Forms.TextBox();
            this.tbxEmailCli = new System.Windows.Forms.TextBox();
            this.tbxNomeCli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxCodCli = new System.Windows.Forms.TextBox();
            this.btnCodCli = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar Cliente";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(689, 301);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.tbxPesquisaNomeCli);
            this.tabPage1.Controls.Add(this.btnBuscaNomeCli);
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
            // tbxPesquisaNomeCli
            // 
            this.tbxPesquisaNomeCli.Location = new System.Drawing.Point(224, 30);
            this.tbxPesquisaNomeCli.Name = "tbxPesquisaNomeCli";
            this.tbxPesquisaNomeCli.Size = new System.Drawing.Size(251, 23);
            this.tbxPesquisaNomeCli.TabIndex = 3;
            // 
            // btnBuscaNomeCli
            // 
            this.btnBuscaNomeCli.Location = new System.Drawing.Point(482, 31);
            this.btnBuscaNomeCli.Name = "btnBuscaNomeCli";
            this.btnBuscaNomeCli.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaNomeCli.TabIndex = 2;
            this.btnBuscaNomeCli.Text = "Buscar";
            this.btnBuscaNomeCli.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite o Nome do Cliente:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAlterar);
            this.tabPage2.Controls.Add(this.btnDeletarCodCli);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.btnBuscarImg);
            this.tabPage2.Controls.Add(this.tbxSenhaCli);
            this.tabPage2.Controls.Add(this.tbxEmailCli);
            this.tabPage2.Controls.Add(this.tbxNomeCli);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tbxCodCli);
            this.tabPage2.Controls.Add(this.btnCodCli);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(681, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar por Codigo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(217, 223);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 25;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeletarCodCli
            // 
            this.btnDeletarCodCli.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeletarCodCli.Location = new System.Drawing.Point(323, 223);
            this.btnDeletarCodCli.Name = "btnDeletarCodCli";
            this.btnDeletarCodCli.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarCodCli.TabIndex = 24;
            this.btnDeletarCodCli.Text = "Deletar";
            this.btnDeletarCodCli.UseVisualStyleBackColor = true;
            this.btnDeletarCodCli.Click += new System.EventHandler(this.btnDeletarCodCli_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(476, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscarImg
            // 
            this.btnBuscarImg.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarImg.Location = new System.Drawing.Point(487, 190);
            this.btnBuscarImg.Name = "btnBuscarImg";
            this.btnBuscarImg.Size = new System.Drawing.Size(96, 21);
            this.btnBuscarImg.TabIndex = 21;
            this.btnBuscarImg.Text = "Buscar Imagem";
            this.btnBuscarImg.UseVisualStyleBackColor = true;
            this.btnBuscarImg.Click += new System.EventHandler(this.btnBuscarImg_Click);
            // 
            // tbxSenhaCli
            // 
            this.tbxSenhaCli.Location = new System.Drawing.Point(90, 140);
            this.tbxSenhaCli.Name = "tbxSenhaCli";
            this.tbxSenhaCli.Size = new System.Drawing.Size(135, 23);
            this.tbxSenhaCli.TabIndex = 20;
            // 
            // tbxEmailCli
            // 
            this.tbxEmailCli.Location = new System.Drawing.Point(90, 98);
            this.tbxEmailCli.Name = "tbxEmailCli";
            this.tbxEmailCli.Size = new System.Drawing.Size(308, 23);
            this.tbxEmailCli.TabIndex = 19;
            // 
            // tbxNomeCli
            // 
            this.tbxNomeCli.Location = new System.Drawing.Point(90, 57);
            this.tbxNomeCli.Name = "tbxNomeCli";
            this.tbxNomeCli.Size = new System.Drawing.Size(308, 23);
            this.tbxNomeCli.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(8, 138);
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
            this.label8.Location = new System.Drawing.Point(5, 98);
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
            this.label9.Location = new System.Drawing.Point(8, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nome:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tbxCodCli
            // 
            this.tbxCodCli.Location = new System.Drawing.Point(230, 21);
            this.tbxCodCli.Name = "tbxCodCli";
            this.tbxCodCli.Size = new System.Drawing.Size(251, 23);
            this.tbxCodCli.TabIndex = 6;
            // 
            // btnCodCli
            // 
            this.btnCodCli.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCodCli.Location = new System.Drawing.Point(487, 21);
            this.btnCodCli.Name = "btnCodCli";
            this.btnCodCli.Size = new System.Drawing.Size(75, 23);
            this.btnCodCli.TabIndex = 5;
            this.btnCodCli.Text = "Buscar";
            this.btnCodCli.UseVisualStyleBackColor = true;
            this.btnCodCli.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Digite o Codigo do Cliente:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TelaPesquisarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(713, 401);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "TelaPesquisarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Cliente";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscaNomeCli;
        private System.Windows.Forms.TextBox tbxPesquisaNomeCli;
        private System.Windows.Forms.TextBox tbxCodCli;
        private System.Windows.Forms.Button btnCodCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscarImg;
        private System.Windows.Forms.TextBox tbxSenhaCli;
        private System.Windows.Forms.TextBox tbxEmailCli;
        private System.Windows.Forms.TextBox tbxNomeCli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeletarCodCli;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}