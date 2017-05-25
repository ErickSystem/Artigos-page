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

        private int perfilUser=1;
        private int id;

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

              /*  Dashboard dash = new Dashboard();
                int logado = 0;
                logado = dash.deslogar(logado);
                //se o buttun "Sair" criado em Dashboard retornar FALSE (retorno do metodo deslogar()), então os buttuns abaixo serão desabilitados.
                if (logado == 1)
                {
                    btn_Listar.Visible = false;
                    label_perfil.Visible = false;
                    cmdPerfil.Visible = false;
                }*/
            }
        }
        
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        //Metodo Cadastrar
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            //variável que recebe o retorno do metódo
            int validacao = validaForm();
            /*Se o retorno do MetodoForm for 0, significa que todos os campos do formulário estão preenchidos, portanto
             * será permitido armazenar os dados no banco.
             */
            if (validacao == 0)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into Usuarios(nome, login, senha, perfil)");
                sql.Append("Values (@nome, @login, @senha, @perfil)");
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
                        case "Selecionar":
                            perfilUser = 4;
                            break;
                    }
                SqlCommand command = null;
                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@nome", text_nome.Text));
                    command.Parameters.Add(new SqlParameter("@login", textUsuario.Text));
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

        //Metedo listar
        private void btn_Listar_Click(object sender, EventArgs e)
        {  
            ListarUsuario listuser = new ListarUsuario();
            listuser.ShowDialog();

            //Verifica se foi selecionado algum item
            if (listuser.usuarioSelecionado == "")
                return;

            var conn = Login.ConnectOpen;
            //Buscar usuário selecionado
            string sql = "Select * from Usuarios where idusuario = '" + listuser.usuarioSelecionado + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            string perfilSelecionado="";

            //Retorma ps dado por linha e coluna da tabela
            text_nome.Text = dt.Rows[0][1].ToString();
            textUsuario.Text = dt.Rows[0][2].ToString();
            textSenha.Text = dt.Rows[0][3].ToString();

            //Converte o perfil de numero para o nome do perfil
             switch (dt.Rows[0][4].ToString())
            {
                case "1":
                    perfilSelecionado = "Autor";
                    break;
                case "2":
                    perfilSelecionado = "Revisor";
                    break;
                case "3":
                    perfilSelecionado = "Gerente";
                    break;
            }
            btn_Excluir.Visible = true;
            cmdPerfil.Text = perfilSelecionado;
            btn_Cadastrar.Visible = false;
            btn_alterar.Visible = true;
            //utilizado para saber qual ID foi selecionado, para realizar o update
            id = Convert.ToInt16(listuser.usuarioSelecionado);

        }
        //Método para alterar usuário
        private void btn_alterar_Click(object sender, EventArgs e)
        {
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
            //Verifica se foi selecionado o usuário no "LOAD"
            if(id > 0)
            {
                string sql = "UPDATE Usuarios SET nome = @nome, login = @login, senha = @senha, perfil = @perfil WHERE idusuario = @id";
                SqlCommand command = null;
                try
                {
                    command = new SqlCommand(sql, ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@idusuario", id));
                    command.Parameters.Add(new SqlParameter("@nome", text_nome.Text));
                    command.Parameters.Add(new SqlParameter("@login", textUsuario.Text));
                    command.Parameters.Add(new SqlParameter("@senha", textSenha.Text));
                    command.Parameters.Add(new SqlParameter("@perfil", perfilUser));

                    //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                    command.ExecuteNonQuery();

                    MessageBox.Show("Atualizado com sucesso!!");
                    Hide();

                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao editar!");
                    throw;
                }
            }

        }
        //Metodo para tranformar o digito da senha em *
        private void textSenha_TextChanged(object sender, EventArgs e)
        {
            textSenha.PasswordChar = '*';
        }
        //metodo para validar formulario
        public int validaForm()
        {
            int result = 0;
            if(text_nome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome");
                text_nome.Focus();
                result++;
            }

            else if (textUsuario.Text == "")
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
        //Metodo para excluir usuário
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //Gera uma caixa de alerta solicitando confirmação para excluir usuário.
            DialogResult resposta = MessageBox.Show("Deseja mesmo deletar este usuário?", "Deletar usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if( resposta == DialogResult.Yes)
            {
                if (id > 0 && Login.perfilUser == 3)
                {
                    string sql = "DELETE FROM Usuarios WHERE idusuario = @id";
                    SqlCommand command = null;
                    try
                    {
                        command = new SqlCommand(sql, ConnectOpen);
                        command.Parameters.Add(new SqlParameter("@idusuario", id));

                        //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                        command.ExecuteNonQuery();

                        MessageBox.Show("Usuario deletado!");
                        Hide();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao deleter usuário!");
                        throw;
                    }
                }//if de confirmação de permissão e retorno do ID
            }//id de resposta
        }

        private void cmdPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
