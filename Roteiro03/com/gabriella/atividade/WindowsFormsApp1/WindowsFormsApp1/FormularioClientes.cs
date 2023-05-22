using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WindowsFormsApp1.classes;

namespace WindowsFormsApp1
{
    public partial class FormularioClientes : Form
    {

        public FormularioClientes()
        {
            InitializeComponent();
        }

        private void FormularioClientes_Load(object sender, EventArgs e)
        {
            CarregarUsuariosDoXML();
        }
        List<Usuario> listaUsuarios = new List<Usuario>();

        public void AtualizarListViewUsuarios(List<Usuario> listaUsuarios)
        {
            // Limpar o ListView
            listViewUsuarios.Items.Clear();

            // Adicionar os usuários ao ListView
            foreach (Usuario usuario in listaUsuarios)
            {
                ListViewItem item = new ListViewItem(usuario.Nome);
                item.SubItems.Add(usuario.Email);
                item.SubItems.Add(usuario.Senha);
                listViewUsuarios.Items.Add(item);
            }
        }
        private void CarregarUsuariosDoXML()
        {


            // Criar uma instância de XmlSerializer para a classe Usuario
            XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));

            // Ler o arquivo XML e desserializar os usuários
            using (StreamReader reader = new StreamReader("usuario.xml"))
            {
                listaUsuarios = (List<Usuario>)serializer.Deserialize(reader);
            }

            // Adicionar os usuários ao ListView
            foreach (Usuario usuario in listaUsuarios)
            {
                ListViewItem item = new ListViewItem(usuario.Nome);
                item.SubItems.Add(usuario.Email);
                listViewUsuarios.Items.Add(item);
            }
        }

        // Evento para carregar os usuários quando o botão for clicado
       


        private void btnExibir_Click(object sender, EventArgs e)
        {
            CarregarUsuariosDoXML();
        }

        private void listViewUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            // Exibir o Form1
            form.Show();

            this.Close();
        }
        private void SalvarUsuariosNoXML()
        {
            // Criar uma instância de XmlSerializer para a classe Usuario
            XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));

            // Criar ou substituir o arquivo XML existente
            using (StreamWriter writer = new StreamWriter("usuario.xml"))
            {
                // Serializar a lista de usuários e gravar no arquivo
                serializer.Serialize(writer, listaUsuarios);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listViewUsuarios.SelectedItems.Count > 0)
            {
                // Obter o índice do item selecionado
                int indice = listViewUsuarios.SelectedIndices[0];

                // Remover o item da lista de usuários
                listaUsuarios.RemoveAt(indice);

                // Salvar a lista atualizada no arquivo XML
                SalvarUsuariosNoXML();

                // Atualizar o ListView
                AtualizarListViewUsuarios(listaUsuarios);
            }
        }
    }
}
