using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace LactecProjetoClientes
{
    public partial class Buscar : Form
    {
        Erro JanelaErro = new Erro();

        public Buscar()
        {
            InitializeComponent();
            this.dataGridViewBusca.Columns.Add("ColunaID", "ID");
            this.dataGridViewBusca.Columns.Add("ColunaNome", "Nome");
            this.dataGridViewBusca.Columns.Add("ColunaIdade", "Idade");
            this.dataGridViewBusca.Columns.Add("ColunaTelefone", "Telefone");
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Clientes.BuscarCliente(textBoxBusca.Text,this,JanelaErro, dataGridViewBusca);
        }
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
