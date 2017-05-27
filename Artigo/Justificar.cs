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

            int id_usuario = Login.idusuario;
            int id_artigo = Artigo.idartigo;
            string status = "sem revisao";
            DataLogin data = new DataLogin();
            string datahora_avaliacao = data.retornarData();

            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into Revisao(status, justificativa, datahora_avaliacao,id_artigo,id_usuario)");
            sql.Append("Values (@status, @justificativa, @datahora_avaliacao,@id_artigo,@id_usuario)");

            SqlCommand command = null;
            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@status", status));
                command.Parameters.Add(new SqlParameter("@justificativa", text_Justificativa.Text));
                command.Parameters.Add(new SqlParameter("@datahora_avaliacao", datahora_avaliacao));
                command.Parameters.Add(new SqlParameter("@id_artigo", id_artigo));
                command.Parameters.Add(new SqlParameter("@id_usuario", id_usuario));

                //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                command.ExecuteNonQuery();
                MessageBox.Show("Justificativa salva!");
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar");
                throw;
            }
            Artigo artigo = new Artigo();
            artigo.Hide();
        }
    }
}
