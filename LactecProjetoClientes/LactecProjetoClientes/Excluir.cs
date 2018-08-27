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
    public partial class Excluir : Form
    {
        public Excluir()
        {
            InitializeComponent();
        }
        private void ButtonExcluir_Click(object sender, EventArgs e)
        {
            Clientes.ExcluirCliente(textBoxExluir.Text, this);
            this.Close();
        }
    }
}
