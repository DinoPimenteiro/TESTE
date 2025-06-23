using System;
using System.IO;
using System.Windows.Forms;

namespace cadastroInsano
{
    public partial class Form1 : Form
    {
        decimal saldo = 1000;
        int notas100 = 20, notas50 = 20, notas20 = 25, notas10 = 30;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void DepositarBTN_Click(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(DepositoTXT.Text, out valor) && valor > 0 && valor % 10 == 0)
            {
                saldo += valor;
                MessageBox.Show("Depósito feito com sucesso!");
                Atualizar();
                DepositoTXT.Clear();
            }
            else
            {
                MessageBox.Show("Digite um valor válido (múltiplo de 10).");
            }
        }

        private void SacarBTN_Click(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(SaqueTXT.Text, out valor) && valor > 0 && valor % 10 == 0)
            {
                if (valor > saldo)
                {
                    MessageBox.Show("Saldo insuficiente.");
                    return;
                }

                int restante = (int)valor;
                int usar100 = Math.Min(restante / 100, notas100); restante -= usar100 * 100;
                int usar50 = Math.Min(restante / 50, notas50); restante -= usar50 * 50;
                int usar20 = Math.Min(restante / 20, notas20); restante -= usar20 * 20;
                int usar10 = Math.Min(restante / 10, notas10); restante -= usar10 * 10;

                if (restante == 0)
                {
                    saldo -= valor;
                    notas100 -= usar100;
                    notas50 -= usar50;
                    notas20 -= usar20;
                    notas10 -= usar10;

                    MessageBox.Show($"Saque de R$ {valor} feito com sucesso!\nNotas entregues:\n100: {usar100}, 50: {usar50}, 20: {usar20}, 10: {usar10}");

                    // Gera comprovante simples
                    string nome = $"comprovante_{DateTime.Now.Ticks}.txt";
                    File.WriteAllText(nome, $"Saque de R$ {valor} em {DateTime.Now}\nNotas: 100x{usar100}, 50x{usar50}, 20x{usar20}, 10x{usar10}\nSaldo final: R$ {saldo}");

                    Atualizar();
                    SaqueTXT.Clear();
                }
                else
                {
                    MessageBox.Show("O caixa não tem as notas certas para esse saque.");
                }
            }
            else
            {
                MessageBox.Show("Digite um valor válido (múltiplo de 10).");
            }
        }

        private void Atualizar()
        {
            saldoINT.Text = $"Saldo: R$ {saldo}";
            NotasTXT.Text = $"Notas disponíveis: 100({notas100}) 50({notas50}) 20({notas20}) 10({notas10})";
        }

        private void AtualizarBTN_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void LimparBTN_Click(object sender, EventArgs e)
        {
            SaqueTXT.Clear();
            DepositoTXT.Clear();
        }

        private void DepositoTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void saldoINT_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
