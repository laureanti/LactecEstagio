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
    public partial class Inserir : Form
    {
        public Inserir()
        {
            InitializeComponent();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        { 
            Clientes.AdicionarCliente(textBoxNome.Text, textBoxTelefone.Text, textBoxIdade.Text);
            this.Close();
        }
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
