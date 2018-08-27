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

    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Clientes.ListarClientes(dataGridViewMenu,false);
        }
        private void ButtomListarClientes_Click(object sender, EventArgs e)
        {
            Clientes.ListarClientes(dataGridViewMenu,false);
        }
        private void ButtonOrdenarClientes_Click(object sender, EventArgs e)
        {
            Clientes.ListarClientes(dataGridViewMenu,true);
        }
        private void ButtomInserirClientes_Click(object sender, EventArgs e)
        {
            Inserir abaInserir = new Inserir();
            abaInserir.ShowDialog();
            Clientes.ListarClientes(dataGridViewMenu,false);
        }
        private void ButtomBuscarClientes_Click(object sender, EventArgs e)
        {
            Buscar abaBuscar = new Buscar();
            abaBuscar.ShowDialog();
        }
        private void ButtonExluirClientes_Click(object sender, EventArgs e)
        {
            Excluir abaExcluir = new Excluir();
            abaExcluir.ShowDialog();
            Clientes.ListarClientes(dataGridViewMenu,false);
        }
        private void ButtomSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
