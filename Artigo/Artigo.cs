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
    public partial class Artigo : Form
    {
        private Conexao con = null;// abrir o banco
        public SqlConnection ConnectOpen = null; //Abrir a conexão
        private int id;
        private string saberStatus;

        public Artigo()
        {
            con = new Conexao();
            ConnectOpen = con.ConectarDatabase();
            InitializeComponent();
        }

        private void Artigo_Load(object sender, EventArgs e)
        {
            if(Login.perfilUser == 2 || Login.perfilUser == 3)
            {
                btn_listarArtigo.Visible = true;
               
            }
        }

        private void btn_Justificar_Click(object sender, EventArgs e)
        {
            Justificar justificar = new Justificar();
            justificar.ShowDialog();
        }

        private void btn_Submeter_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into Artigo(nome_autor, titulo, conteudo, datahora_submissao)");
            sql.Append("Values (@nome_autor, @titulo, @conteudo, @datahora_submissao)");

            string nome_autor = Login.nomeUser;
            DataLogin ds = new DataLogin();
            string datahora_submissao = ds.retornarData();

            SqlCommand command = null;
            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@nome_autor", nome_autor));
                command.Parameters.Add(new SqlParameter("@titulo", artigo_Titulo.Text));
                command.Parameters.Add(new SqlParameter("@conteudo", artigo_Conteudo.Text));
                command.Parameters.Add(new SqlParameter("@datahora_submissao", datahora_submissao));

                //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                command.ExecuteNonQuery();
                MessageBox.Show("Artigo submetido com sucesso!");
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao submeter artigo");
                throw;
            }
        }

        private void btn_listarArtigo_Click(object sender, EventArgs e)
        {
            var listarArtigos = new ListarArtigo();
            listarArtigos.ShowDialog();

            if (listarArtigos.artigoSelecionado == "")
                return;

            var conn = Login.ConnectOpen;
            //Buscar usuário selecionado
            string sql = "Select * from Artigo where id = '" + listarArtigos.artigoSelecionado + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            artigo_Titulo.Text = Convert.ToString(dt.Rows[0][2]);
            artigo_Conteudo.Text = Convert.ToString(dt.Rows[0][3]);

            id = Convert.ToInt16(listarArtigos.artigoSelecionado);

            btn_Aprovar.Visible = true;
            btn_Justificar.Visible = true;
            btn_Reprovar.Visible = true;
            btn_Deletar.Visible = true;
            btn_Submeter.Visible = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_Aprovar_Click(object sender, EventArgs e)
        {
                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into Revisao(nome_revisor, status, datahora_avaliacao,id_artigo)");
                sql.Append("Values (@nome_revisor, @status, @datahora_avaliacao,@id_artigo)");

                string nome_revisor = Login.nomeUser;
                string status = "Aprovado";
                DataLogin ds = new DataLogin();
                string datahora_aprovacao = ds.retornarData();

                SqlCommand command = null;
                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@nome_revisor", nome_revisor));
                    command.Parameters.Add(new SqlParameter("@status", status));
                    command.Parameters.Add(new SqlParameter("@datahora_avaliacao", datahora_aprovacao));
                    command.Parameters.Add(new SqlParameter("@id_artigo", id));

                    //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                    command.ExecuteNonQuery();
                    MessageBox.Show("Aprovação realizada com sucesso!");
                    Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao aprovar");
                    throw;
                }
            }

        private void btn_Reprovar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
