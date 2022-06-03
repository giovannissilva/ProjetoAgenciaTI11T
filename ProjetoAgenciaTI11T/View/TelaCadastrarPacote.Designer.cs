
namespace ProjetoAgenciaTI11T.View
{
    partial class TelaCadastrarPacote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarPacote));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.cbxOrigem = new System.Windows.Forms.ComboBox();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.dateIda = new System.Windows.Forms.DateTimePicker();
            this.dateVolta = new System.Windows.Forms.DateTimePicker();
            this.mtbValor = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SalvarImagem = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar os Pacotes de Viagens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Origem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Destino:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data Ida:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data Volta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(11, 299);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descrição:";
            // 
            // cbxDestino
            // 
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Items.AddRange(new object[] {
            "Osasco",
            "São Paulo",
            "Rio de Janeiro"});
            this.cbxDestino.Location = new System.Drawing.Point(130, 100);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(246, 29);
            this.cbxDestino.TabIndex = 9;
            this.cbxDestino.SelectedIndexChanged += new System.EventHandler(this.cbxDestino_SelectedIndexChanged);
            // 
            // cbxOrigem
            // 
            this.cbxOrigem.FormattingEnabled = true;
            this.cbxOrigem.Items.AddRange(new object[] {
            "Osasco",
            "São Paulo",
            "Rio de Janeiro",
            "Paris",
            "Washington",
            "Nova Iorque"});
            this.cbxOrigem.Location = new System.Drawing.Point(130, 141);
            this.cbxOrigem.Name = "cbxOrigem";
            this.cbxOrigem.Size = new System.Drawing.Size(246, 29);
            this.cbxOrigem.TabIndex = 10;
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Location = new System.Drawing.Point(123, 283);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(253, 50);
            this.rtbDescricao.TabIndex = 11;
            this.rtbDescricao.Text = "";
            // 
            // dateIda
            // 
            this.dateIda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIda.Location = new System.Drawing.Point(130, 174);
            this.dateIda.Name = "dateIda";
            this.dateIda.Size = new System.Drawing.Size(130, 29);
            this.dateIda.TabIndex = 12;
            // 
            // dateVolta
            // 
            this.dateVolta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVolta.Location = new System.Drawing.Point(130, 209);
            this.dateVolta.Name = "dateVolta";
            this.dateVolta.Size = new System.Drawing.Size(130, 29);
            this.dateVolta.TabIndex = 13;
            // 
            // mtbValor
            // 
            this.mtbValor.Location = new System.Drawing.Point(130, 248);
            this.mtbValor.Name = "mtbValor";
            this.mtbValor.Size = new System.Drawing.Size(161, 29);
            this.mtbValor.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(427, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 127);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // SalvarImagem
            // 
            this.SalvarImagem.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SalvarImagem.Location = new System.Drawing.Point(481, 233);
            this.SalvarImagem.Name = "SalvarImagem";
            this.SalvarImagem.Size = new System.Drawing.Size(101, 21);
            this.SalvarImagem.TabIndex = 17;
            this.SalvarImagem.Text = "Buscar Imagem";
            this.SalvarImagem.UseVisualStyleBackColor = true;
            this.SalvarImagem.Click += new System.EventHandler(this.SalvarImagem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(481, 310);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 37);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // TelaCadastrarPacote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(681, 397);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.SalvarImagem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtbValor);
            this.Controls.Add(this.dateVolta);
            this.Controls.Add(this.dateIda);
            this.Controls.Add(this.rtbDescricao);
            this.Controls.Add(this.cbxOrigem);
            this.Controls.Add(this.cbxDestino);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TelaCadastrarPacote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Agência de Viagens - Cadastrar Pacote";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxDestino;
        private System.Windows.Forms.ComboBox cbxOrigem;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.DateTimePicker dateIda;
        private System.Windows.Forms.DateTimePicker dateVolta;
        private System.Windows.Forms.MaskedTextBox mtbValor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SalvarImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSalvar;
    }
}