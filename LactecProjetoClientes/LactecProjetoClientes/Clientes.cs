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
    public class Clientes
    {
        private static string DataB = "Cliente_db.xml";
        private static XmlReader File;

        public static void ListarClientes(DataGridView DataG, bool Ordenar)
        {
            // le os dados do XML para o cache
            File = XmlReader.Create(DataB, new XmlReaderSettings());
            DataSet ds = new DataSet();
            ds.ReadXml(File);

            //define a fonte dos dados para o dataGridView exibir 
            DataG.DataSource = ds.Tables[0];

            //Ordena as linhas do datagridview com base na 3 coluna em ordem decrescente se Ordenar for iqual a 1
            if (Ordenar == true)
            {
                DataG.Sort(DataG.Columns[2], ListSortDirection.Ascending);
            }
                    //Torna as colunas de telefone e idade visiveis ou nao
                    DataG.Columns[2].Visible = Ordenar;
                    DataG.Columns[3].Visible = Ordenar;

                //encerra a leitura do arquivo
                File.Close();
        }
        public static void AdicionarCliente(string NOME, string TELEFONE, string IDADE)
        {
            XElement x = new XElement("Cliente"); //Cria um elemento XML chamado Cliente
            XElement xml = XElement.Load(DataB); //Carrega os elementos do arquivo XML

            int ID = int.Parse(xml.Descendants("ID").Last().Value) + 1; //Lee o ID do ultimo elemento do arquivo e guarda em uma variavel ID adicionando mais uma unidade

            //Adiciona ao elemento cliente os demais elementos com os conteudos mandados
            x.Add(new XElement("ID", ID));
            x.Add(new XElement("Nome", NOME));
            x.Add(new XElement("Idade", IDADE));
            x.Add(new XElement("Telefone", TELEFONE));
            xml.Add(x);

            //Salva o arquivo com o novo elemento cliente 
            xml.Save(DataB);
        }
        public static void BuscarCliente(String Procurador, LactecProjetoClientes.Buscar JanelaBusca,LactecProjetoClientes.Erro JanelaErro , DataGridView DataG)
        {
            int val;

            // le os dados do XML para o cache
            File = XmlReader.Create(DataB, new XmlReaderSettings());
            DataSet ds = new DataSet();
            ds.ReadXml(File);

            DataView dv = new DataView(ds.Tables[0])
            {
                Sort = "ID"
            };

            val = dv.Find(Procurador); // pesquisa uma linha no DataView, retorna -1 se nao encontrada
            if (val == -1)
            {
                dv.Sort = "Nome";
                val = dv.Find(Procurador);
                if (val == -1)
                {
                    JanelaErro.ShowDialog();
                    JanelaBusca.Close();
                }
                else
                {
                    DataG.Rows.Add(dv[val]["ID"].ToString(),
                                   dv[val]["Nome"].ToString(),
                                   dv[val]["Idade"].ToString(),
                                   dv[val]["Telefone"].ToString());

                }
            }
            else
            {
                DataG.Rows.Add(dv[val]["ID"].ToString(),
                               dv[val]["Nome"].ToString(),
                               dv[val]["Idade"].ToString(),
                               dv[val]["Telefone"].ToString());

            }
            //encerra a leitura do arquivo
            File.Close();
        }
        public static void ExcluirCliente(string Procurador, LactecProjetoClientes.Excluir Janela)
        {
            bool Achou = false;

            //Abre o documento XML
            XmlDocument doc = new XmlDocument();
            doc.Load(DataB);

            //Pesquisa os elementos ID e nome e compara com o buscado
            foreach (XmlNode xNode in doc.SelectNodes("/Clientes/Cliente"))
                if (xNode.SelectSingleNode("ID").InnerText == Procurador)
                {
                    Achou = true;
                    xNode.ParentNode.RemoveChild(xNode);
                }
                else if (xNode.SelectSingleNode("Nome").InnerText == Procurador)
                {
                    Achou = true;
                    xNode.ParentNode.RemoveChild(xNode);
                }
            //Mostra janela de erro
            if (Achou == false)
            {
                Erro abaErro = new Erro();
                abaErro.ShowDialog();
            }
            //Mostra janela de sucesso
            else
            {
                AvisoExcluido sucesso = new AvisoExcluido();
                sucesso.ShowDialog();
            }
            //salva documento XML
            doc.Save(DataB);
            Janela.Close();
        }
    }
}