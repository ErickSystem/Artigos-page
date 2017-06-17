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
    public partial class Justificar : Form
    {
        private Conexao con = null;// abrir o banco
        public SqlConnection ConnectOpen = null; //Abrir a conexão

        public Justificar()
        {
            con = new Conexao();
            ConnectOpen = con.ConectarDatabase();
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            DataLogin data = new DataLogin();
            string datahora_avaliacao = data.retornarData();

            var conn = Login.ConnectOpen;
            //Buscar codigo digitado, caso não encontre retornará com uma menssagem informando que o codigo não foi encontrado
            string sqlRevisor = "Select * from Revisao where id_artigo = " + Artigo.idartigo; 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlRevisor, conn);
            da.Fill(dt);

            /* if(dt.Rows.Count <= 0)
             {
                   StringBuilder sql = new StringBuilder();
                 sql.Append("Insert into Revisao(status, justificativa, datahora_avaliacao,id_artigo,id_usuario)");
                 sql.Append("Values (@status, @justificativa, @datahora_avaliacao,@id_artigo,@id_usuario)");

                 SqlCommand command = null;
                 try
                 {
                     command = new SqlCommand(sql.ToString(), ConnectOpen);
                     command.Parameters.Add(new SqlParameter("@justificativa", text_Justificativa.Text));
                     command.Parameters.Add(new SqlParameter("@datahora_avaliacao", datahora_avaliacao));
                     command.Parameters.Add(new SqlParameter("@id_artigo", Artigo.idartigo));
                     command.Parameters.Add(new SqlParameter("@id_usuario", Login.idusuario));

                     //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                     command.ExecuteNonQuery();
                     MessageBox.Show("Justificativa salva!");
                     Hide();
                 }
                 catch (Exception)
                 {
                     MessageBox.Show("Erro ao Justificar");
                     throw;
                 }
             }
             */
            //Se já existir será apenas atualizado

            if (dt.Rows.Count > 0)
            {
                string sql = "UPDATE Revisao SET justificativa = @justificativa,datahora_avaliacao = @datahora_avaliacao,id_artigo = @id_artigo, id_usuario = @id_usuario WHERE id_artigo = " + Artigo.idartigo;

                SqlCommand command = null;
                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@justificativa", text_Justificativa.Text));
                    command.Parameters.Add(new SqlParameter("@datahora_avaliacao", datahora_avaliacao));
                    command.Parameters.Add(new SqlParameter("@id_artigo", Artigo.idartigo));
                    command.Parameters.Add(new SqlParameter("@id_usuario", Login.idusuario));

                    //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                    command.ExecuteNonQuery();
                    MessageBox.Show("Justificativa salva!");
                    Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao Justificar!");
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Artigo nao associado, não pode ser justificado");
            }
            
                

            Artigo artigo = new Artigo();
            artigo.Hide();
       } 
   }
}

