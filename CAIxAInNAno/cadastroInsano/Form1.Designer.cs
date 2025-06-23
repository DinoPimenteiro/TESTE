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
            this.DepositoTXT = new System.Windows.Forms.TextBox();
            this.SaqueTXT = new System.Windows.Forms.TextBox();
            this.LimparBTN = new System.Windows.Forms.Button();
            this.AtualizarBTN = new System.Windows.Forms.Button();
            this.saldoINT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NotasTXT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SacarBTN = new System.Windows.Forms.Button();
            this.DepositarBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DepositoTXT
            // 
            this.DepositoTXT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositoTXT.Location = new System.Drawing.Point(474, 276);
            this.DepositoTXT.Name = "DepositoTXT";
            this.DepositoTXT.Size = new System.Drawing.Size(105, 29);
            this.DepositoTXT.TabIndex = 0;
            this.DepositoTXT.TextChanged += new System.EventHandler(this.DepositoTXT_TextChanged);
            // 
            // SaqueTXT
            // 
            this.SaqueTXT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaqueTXT.Location = new System.Drawing.Point(474, 231);
            this.SaqueTXT.Name = "SaqueTXT";
            this.SaqueTXT.Size = new System.Drawing.Size(105, 29);
            this.SaqueTXT.TabIndex = 1;
            // 
            // LimparBTN
            // 
            this.LimparBTN.BackColor = System.Drawing.SystemColors.Control;
            this.LimparBTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimparBTN.Location = new System.Drawing.Point(409, 393);
            this.LimparBTN.Name = "LimparBTN";
            this.LimparBTN.Size = new System.Drawing.Size(96, 30);
            this.LimparBTN.TabIndex = 5;
            this.LimparBTN.Text = "Limpar";
            this.LimparBTN.UseVisualStyleBackColor = false;
            this.LimparBTN.Click += new System.EventHandler(this.LimparBTN_Click);
            // 
            // AtualizarBTN
            // 
            this.AtualizarBTN.BackColor = System.Drawing.SystemColors.Control;
            this.AtualizarBTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtualizarBTN.Location = new System.Drawing.Point(378, 340);
            this.AtualizarBTN.Name = "AtualizarBTN";
            this.AtualizarBTN.Size = new System.Drawing.Size(157, 47);
            this.AtualizarBTN.TabIndex = 6;
            this.AtualizarBTN.Text = "Atualizar saldo e notas";
            this.AtualizarBTN.UseVisualStyleBackColor = false;
            this.AtualizarBTN.Click += new System.EventHandler(this.AtualizarBTN_Click);
            // 
            // saldoINT
            // 
            this.saldoINT.AutoSize = true;
            this.saldoINT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoINT.Location = new System.Drawing.Point(374, 82);
            this.saldoINT.Name = "saldoINT";
            this.saldoINT.Size = new System.Drawing.Size(96, 21);
            this.saldoINT.TabIndex = 8;
            this.saldoINT.Text = "Saldo Atual";
            this.saldoINT.Click += new System.EventHandler(this.saldoINT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Engravers MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(639, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Caixa Eletrônico Mais Insano";
            // 
            // NotasTXT
            // 
            this.NotasTXT.AutoSize = true;
            this.NotasTXT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotasTXT.Location = new System.Drawing.Point(374, 113);
            this.NotasTXT.Name = "NotasTXT";
            this.NotasTXT.Size = new System.Drawing.Size(149, 21);
            this.NotasTXT.TabIndex = 11;
            this.NotasTXT.Text = "Notas disponíveis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Valor para depósito:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Valor para saque:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SacarBTN
            // 
            this.SacarBTN.BackColor = System.Drawing.SystemColors.Control;
            this.SacarBTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SacarBTN.Location = new System.Drawing.Point(602, 231);
            this.SacarBTN.Name = "SacarBTN";
            this.SacarBTN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SacarBTN.Size = new System.Drawing.Size(76, 33);
            this.SacarBTN.TabIndex = 14;
            this.SacarBTN.Text = "Sacar";
            this.SacarBTN.UseVisualStyleBackColor = false;
            this.SacarBTN.Click += new System.EventHandler(this.SacarBTN_Click);
            // 
            // DepositarBTN
            // 
            this.DepositarBTN.BackColor = System.Drawing.SystemColors.Control;
            this.DepositarBTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositarBTN.Location = new System.Drawing.Point(602, 279);
            this.DepositarBTN.Name = "DepositarBTN";
            this.DepositarBTN.Size = new System.Drawing.Size(76, 33);
            this.DepositarBTN.TabIndex = 15;
            this.DepositarBTN.Text = "Depositar";
            this.DepositarBTN.UseVisualStyleBackColor = false;
            this.DepositarBTN.Click += new System.EventHandler(this.DepositarBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(909, 433);
            this.Controls.Add(this.DepositarBTN);
            this.Controls.Add(this.SacarBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotasTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saldoINT);
            this.Controls.Add(this.AtualizarBTN);
            this.Controls.Add(this.LimparBTN);
            this.Controls.Add(this.SaqueTXT);
            this.Controls.Add(this.DepositoTXT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DepositoTXT;
        private System.Windows.Forms.TextBox SaqueTXT;
        private System.Windows.Forms.Button LimparBTN;
        private System.Windows.Forms.Button AtualizarBTN;
        private System.Windows.Forms.Label saldoINT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NotasTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SacarBTN;
        private System.Windows.Forms.Button DepositarBTN;
    }
}

