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

        private Conexao con = null;// abrir o banco
        public SqlConnection ConnectOpen = null; //Abrir a conexão
        private int perfilUser=0;

        public Cadastrar()
        {
            InitializeComponent();
            con = new Conexao();
            ConnectOpen = con.ConectarDatabase();
        }

        
        //Habilita alguns button e o tipo de user no cadastro, somente se o perfil for tipo 3 (Gerente)
        private void Cadastrar_Load(object sender, EventArgs e)
        {
            if (Login.perfilUser == 3)
            {
                btn_Listar.Visible = true;
                btn_Cadastrar.Visible = true;
                label_perfil.Visible = true;
                cmdPerfil.Visible = true;
            }
        }
        
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            //variável que recebe o retorno do metódo
            int validacao = validaForm();
            /*Se p retprmp dp MetodoForm for 0, significa que todos os campos do formulário estão preenchidos, portanto
             * será permitido armazenar os dados no banco.
             */
            if (validacao == 0)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into Usuarios(usuario, senha, perfil)");
                sql.Append("Values (@usuario, @senha, @perfil)");

                //Utilizado para validar o tipo de usuário cadastrado
                if (cmdPerfil.Visible)
                    switch (cmdPerfil.Text)
                    {
                        case "Autor":
                            perfilUser = 1;
                            break;
                        case "Revisor":
                            perfilUser = 2;
                            break;
                        case "Gerente":
                            perfilUser = 3;
                            break;
                    }

                SqlCommand command = null;
                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@usuario", textUsuario.Text));
                    command.Parameters.Add(new SqlParameter("@senha", textSenha.Text));
                    command.Parameters.Add(new SqlParameter("@perfil", perfilUser));

                    //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                    command.ExecuteNonQuery();

                    MessageBox.Show("Cadastrado com sucesso!");
                    Hide();

                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao cadastrar");
                    throw;
                }

            }//fim do metodo cadastrar
        }//fim do if de validação do Formulário

     
        private void btn_Listar_Click(object sender, EventArgs e)
        {

        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {
            textSenha.PasswordChar = '*';
        }

        //metodo para validar formulario
        public int validaForm()
        {
            int result = 0;
            if (textUsuario.Text == "")
            {
                MessageBox.Show("Preencha o campo usuário");
                textUsuario.Focus();
                result++;
            }
            else if (textSenha.Text == "")

            {
                MessageBox.Show("Informe uma senha");
                textSenha.Focus();
                result++;
            }
            //verifica se o tipo de usuário que está cadastrando é do tipo Gerente
            else if (Login.perfilUser == 3)
            {
                if (cmdPerfil.Text == "")
                {
                    MessageBox.Show("Informe o perfil");
                    result++;
                }

            }
            return result;
        }

    }
}
