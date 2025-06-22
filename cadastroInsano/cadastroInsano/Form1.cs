using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cadastroInsano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nomeProdutoTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastrarBTN_Click(object sender, EventArgs e)
        {
            string nome = nomeProdutoTXT.Text.Trim();
            string precoTexto = precoTXT.Text.Trim();
            string categoria = categoriaCBX.SelectedItem?.ToString();
            bool disponivel = disponibilidadeCKB.Checked;
            DateTime validade = validadeDATE.Value;

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O nome do produto não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(precoTexto, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("O preço deve ser um número maior que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (validade <= DateTime.Today)
            {
                MessageBox.Show("A data de validade deve ser maior que a data atual.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mensagem = $"Produto {nome} cadastrado com sucesso!\nPreço: R$ {preco:F2}.\nCategoria: {categoria}.\nDisponível: {(disponivel ? "Sim" : "Não")}.\nData de Validade: {validade.ToShortDateString()}.";
            MessageBox.Show(mensagem, "Cadastro realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limparBTN_Click(object sender, EventArgs e)
        {
            nomeProdutoTXT.Clear();
            precoTXT.Clear();
            categoriaCBX.SelectedIndex = -1;
            disponibilidadeCKB.Checked = false;
            validadeDATE.Value = DateTime.Today.AddDays(1); // ou DateTime.Today se preferir
        }

    }
}