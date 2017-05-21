using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Artigo
{
    public partial class Login : Form
    {
        public bool logado = false; //utilizada para saber se o usuário está logado
        public Conexao con = null;// abrir o banco
        public static SqlConnection ConnectOpen = null;//Abrir a conexão
        public char PasswordChar { get; set; }
        public static int perfilUser;
        public static string nomeUser;

        public Login()
        {
            con = new Conexao(); //Instancia da classe conexão
            ConnectOpen = con.ConectarDatabase(); //ConnectOpen recebe os parâmetros de conexão com o banco
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            string SqlCommand = "Select * from Usuarios where login = '"+textUsuario.Text +"'and senha = '" + textSenha.Text+"'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(SqlCommand, ConnectOpen);// Adapta os dados para linguagem SQL
            da.Fill(dt); //passa os dados para serem executados.
            if (dt.Rows.Count > 0)/*
                                 Testa se alguma linha do banco de dados foi afetada, caso
                                 não retorne, signifca que o usuário não está cadastrado.
                                 */

            {

                this.Hide();
                logado = true;
                perfilUser = Convert.ToInt16(dt.Rows[0][4]);
                nomeUser = Convert.ToString(dt.Rows[0][1]);
                var frm = new Dashboard();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Usuário e senha incorretos!");
            }
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            var frm = new Cadastrar();
            frm.ShowDialog();
        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {
            textSenha.PasswordChar = '*';
        }
    }
}
