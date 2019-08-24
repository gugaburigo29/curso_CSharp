using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AppWinForms
{
    public partial class FormPrincipal : Form
    {
        public List<Veiculo> Veiculos { get; set; }
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Veiculos = new List<Veiculo>();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var form = new CadastroVeiculo();
            form.ShowDialog();

            Veiculos.Add(form.Veiculo);
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxbPesquisa.Text))
            {
                foreach (var item in Veiculos)
                {
                    string[] row = { item.Cor, item.Marca, item.Modelo, item.QuantidadePortas.ToString() };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                }
            } else {
                foreach (var item in Veiculos.Where(veiculo => veiculo.Marca.Contains(TxbPesquisa.Text)))
                {
                    string[] row = { item.Cor, item.Marca, item.Modelo, item.QuantidadePortas.ToString() };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                }
            }
        }
    }
}
