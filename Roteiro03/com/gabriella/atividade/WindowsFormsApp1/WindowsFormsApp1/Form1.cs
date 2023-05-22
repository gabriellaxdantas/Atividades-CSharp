using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WindowsFormsApp1.classes;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkSenha_CheckedChanged(object sender, EventArgs e)
        {
            senhaUsuario.UseSystemPasswordChar = !checkSenha.Checked;
        }
        List<Usuario> listaUsuarios = new List<Usuario>();

        private void SalvarUsuarioEmXML(Usuario usuario)
        {
            // Ler os usuários existentes do arquivo XML, se houver
            List<Usuario> listaUsuarios = CarregarUsuariosDoXML();

            // Adicionar o novo usuário à lista
            listaUsuarios.Add(usuario);

            // Criar uma instância de XmlSerializer para a classe Usuario
            XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));

            // Abrir um fluxo de gravação para o arquivo XML
            using (StreamWriter writer = new StreamWriter("usuario.xml"))
            {
                // Serializar a lista de usuários atualizada e escrever os dados no fluxo de gravação
                serializer.Serialize(writer, listaUsuarios);

                // Fechar o fluxo de gravação
                writer.Close();
            }

            // Chamar o método para atualizar o ListView no formulário FormularioCliente.cs
            FormularioClientes formularioCliente = new FormularioClientes();
            formularioCliente.AtualizarListViewUsuarios(listaUsuarios);
        }

        private List<Usuario> CarregarUsuariosDoXML()
        {   
            List<Usuario> listaUsuarios = new List<Usuario>();

            // Verificar se o arquivo XML existe
            if (File.Exists("usuario.xml"))
            {
                // Criar uma instância de XmlSerializer para a classe Usuario
                XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));

                // Ler o arquivo XML e desserializar os usuários
                using (StreamReader reader = new StreamReader("usuario.xml"))
                {
                    listaUsuarios = (List<Usuario>)serializer.Deserialize(reader);
                }
            }

            return listaUsuarios;
        }

        private void nomeUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é uma letra
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // Define Handled como true para indicar que a tecla foi tratada
                e.Handled = true;
            }
        }

        private void nomeUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada não é uma letra
            if (!char.IsLetter((char)e.KeyCode) && !char.IsControl((char)e.KeyCode) && !char.IsWhiteSpace((char)e.KeyCode))
            {
                // Impede a entrada de teclas não permitidas
                e.SuppressKeyPress = true;
            }
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomeUsuario.Text) || string.IsNullOrEmpty(emailUsuario.Text) || string.IsNullOrEmpty(senhaUsuario.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return; // Sair do método para evitar a execução de código adicional
            }
            if (!IsValidEmail(emailUsuario.Text))
            {
                MessageBox.Show("Por favor, insira um endereço de email válido.");
                return; // Sair do método para evitar a execução de código adicional
            }

            Usuario novoUsuario = new Usuario();
            novoUsuario.Nome = nomeUsuario.Text;
            novoUsuario.Email = emailUsuario.Text;
            novoUsuario.Senha = senhaUsuario.Text;

            SalvarUsuarioEmXML(novoUsuario);



            MessageBox.Show("Usuário salvo com sucesso!");

            FormularioClientes form = new FormularioClientes();

            // Exibir o Form1
            form.Show();

            this.Hide();


        }



        private bool IsValidEmail(string email)
        {
            // Usar uma expressão regular para validar o formato de email
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            senhaUsuario.UseSystemPasswordChar = true;
           
        }

        private void nomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Redirecionar para a tela de cadastro
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void senhaUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
