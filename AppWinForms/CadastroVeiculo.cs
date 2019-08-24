using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinForms
{
    public partial class CadastroVeiculo : Form
    {
        public Veiculo Veiculo { get; set; }
        public CadastroVeiculo()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var cor = TxbCor.Text;
            var marca = TxbMarca.Text;
            var qtdPortas = TxbQtdPortas.Text;
            var modelo = TxbModelo.Text;
            int quantidadePortas = 0;

            if(!int.TryParse(qtdPortas, out quantidadePortas))
            {
                MessageBox.Show("Quantidade de portas deve ser um valor numerico", "Error");
            }

            Veiculo = new Veiculo(cor, quantidadePortas, marca, modelo);
            Close();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
