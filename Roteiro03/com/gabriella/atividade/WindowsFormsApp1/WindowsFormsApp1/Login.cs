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
    public partial class Login : Form
    {

        
        public Login()
        {
            InitializeComponent();
            
        }
       
        List<Usuario> listaUsuarios = new List<Usuario>();
      
        private void Login_Load(object sender, EventArgs e)
        {
            senhaUsuario.PasswordChar = '*';
            SetPasswordChar();
        }
        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            SetPasswordChar();
        }
        private void SetPasswordChar()
        {
            senhaUsuario.UseSystemPasswordChar = checkPassword.Checked;
        }



        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Carregar os usuários do arquivo XML
            listaUsuarios = CarregarUsuariosDoXML();

            // Procurar o usuário com base no email e senha fornecidos
            Usuario usuario = listaUsuarios.FirstOrDefault(u => u.Email == emailUsuario.Text && u.Senha == senhaUsuario.Text);

            if (usuario != null)
            {
                MessageBox.Show("Login efetuado com sucesso!");
                this.Hide();

                // Redirecionar para a tela principal após o login bem sucedido
                FormularioClientes form = new FormularioClientes();
                form.Show();
            }
            else
            {
                MessageBox.Show("Email ou senha inválidos!");
            }
        }

        private List<Usuario> CarregarUsuariosDoXML()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            if (File.Exists("usuario.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));

                using (StreamReader reader = new StreamReader("usuario.xml"))
                {
                    listaUsuarios = (List<Usuario>)serializer.Deserialize(reader);
                }
            }

            return listaUsuarios;
        }

       

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            // Redirecionar para a tela de cadastro
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
 
        private void senhaUsuario_TextChanged(object sender, EventArgs e)
        {
         
        }

       
    }
}
