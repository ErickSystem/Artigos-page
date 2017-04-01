using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artigo
{
    public partial class Cadastrar : Form
    {

        public bool logado = false; //utilizada para saber se o usuário está logado
        public Conexao con = null;// abrir o banco
        public SqlConnection ConnectOpen = null; //Abrir a conexão
        public int perfil { get; set; } = 3;

        public Cadastrar()
        {
            InitializeComponent();
        }
              
        public void setPerfil_test(int perfil)
        {
            this.perfil = perfil;
        }
        public int getPerfil_Test()
        {
            return perfil;
        }

       public Cadastrar(int perfil)
        {
            InitializeComponent();
            int p = getPerfil_Test();

            if (p == 3)
            {
                cmdPerfil.Visible = true;
                btn_Listar.Visible = true;
            }
        }




        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into usuarios(Usuario, senha, perfil)");
            sql.Append("Values (@usuario, @senha, @perfil)");
            SqlCommand command = null;

            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@usuario", textUsuario.Text));
                command.Parameters.Add(new SqlParameter("@senha", textSenha.Text));
                command.Parameters.Add(new SqlParameter("@perfil", perfil));

                MessageBox.Show("Cadastra com sucesso!");
                Hide();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar");
                throw;
            }
        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {

        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {
            textSenha.PasswordChar = '*';
        }
    }
}
