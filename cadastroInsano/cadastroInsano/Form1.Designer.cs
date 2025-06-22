namespace cadastroInsano
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nomeProdutoTXT = new System.Windows.Forms.TextBox();
            this.precoTXT = new System.Windows.Forms.TextBox();
            this.categoriaCBX = new System.Windows.Forms.ComboBox();
            this.disponibilidadeCKB = new System.Windows.Forms.CheckBox();
            this.validadeDATE = new System.Windows.Forms.DateTimePicker();
            this.cadastrarBTN = new System.Windows.Forms.Button();
            this.limparBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nomeProdutoTXT
            // 
            this.nomeProdutoTXT.Location = new System.Drawing.Point(330, 110);
            this.nomeProdutoTXT.Name = "nomeProdutoTXT";
            this.nomeProdutoTXT.Size = new System.Drawing.Size(110, 20);
            this.nomeProdutoTXT.TabIndex = 0;
            this.nomeProdutoTXT.TextChanged += new System.EventHandler(this.nomeProdutoTXT_TextChanged);
            // 
            // precoTXT
            // 
            this.precoTXT.Location = new System.Drawing.Point(480, 110);
            this.precoTXT.Name = "precoTXT";
            this.precoTXT.Size = new System.Drawing.Size(110, 20);
            this.precoTXT.TabIndex = 1;
            // 
            // categoriaCBX
            // 
            this.categoriaCBX.FormattingEnabled = true;
            this.categoriaCBX.Items.AddRange(new object[] {
            "Alimentos",
            "Vestuários",
            "Eletrônicos",
            "Beleza",
            "Outros"});
            this.categoriaCBX.Location = new System.Drawing.Point(330, 181);
            this.categoriaCBX.Name = "categoriaCBX";
            this.categoriaCBX.Size = new System.Drawing.Size(131, 21);
            this.categoriaCBX.TabIndex = 2;
            // 
            // disponibilidadeCKB
            // 
            this.disponibilidadeCKB.AutoSize = true;
            this.disponibilidadeCKB.Location = new System.Drawing.Point(333, 243);
            this.disponibilidadeCKB.Name = "disponibilidadeCKB";
            this.disponibilidadeCKB.Size = new System.Drawing.Size(97, 17);
            this.disponibilidadeCKB.TabIndex = 3;
            this.disponibilidadeCKB.Text = "Disponibilidade";
            this.disponibilidadeCKB.UseVisualStyleBackColor = true;
            // 
            // validadeDATE
            // 
            this.validadeDATE.Location = new System.Drawing.Point(330, 282);
            this.validadeDATE.Name = "validadeDATE";
            this.validadeDATE.Size = new System.Drawing.Size(240, 20);
            this.validadeDATE.TabIndex = 4;
            // 
            // cadastrarBTN
            // 
            this.cadastrarBTN.Location = new System.Drawing.Point(464, 361);
            this.cadastrarBTN.Name = "cadastrarBTN";
            this.cadastrarBTN.Size = new System.Drawing.Size(96, 30);
            this.cadastrarBTN.TabIndex = 5;
            this.cadastrarBTN.Text = "Cadastrar";
            this.cadastrarBTN.UseVisualStyleBackColor = true;
            this.cadastrarBTN.Click += new System.EventHandler(this.cadastrarBTN_Click);
            // 
            // limparBTN
            // 
            this.limparBTN.Location = new System.Drawing.Point(361, 361);
            this.limparBTN.Name = "limparBTN";
            this.limparBTN.Size = new System.Drawing.Size(90, 30);
            this.limparBTN.TabIndex = 6;
            this.limparBTN.Text = "Limpar";
            this.limparBTN.UseVisualStyleBackColor = true;
            this.limparBTN.Click += new System.EventHandler(this.limparBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Preço (R$)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Categorias";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 539);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.limparBTN);
            this.Controls.Add(this.cadastrarBTN);
            this.Controls.Add(this.validadeDATE);
            this.Controls.Add(this.disponibilidadeCKB);
            this.Controls.Add(this.categoriaCBX);
            this.Controls.Add(this.precoTXT);
            this.Controls.Add(this.nomeProdutoTXT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeProdutoTXT;
        private System.Windows.Forms.TextBox precoTXT;
        private System.Windows.Forms.ComboBox categoriaCBX;
        private System.Windows.Forms.CheckBox disponibilidadeCKB;
        private System.Windows.Forms.DateTimePicker validadeDATE;
        private System.Windows.Forms.Button cadastrarBTN;
        private System.Windows.Forms.Button limparBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

