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
    public partial class Status_artigos : Form
    {
        public int idArtigo_status;

        public Status_artigos()
        {
            InitializeComponent();
        }

        //Criando uma lista para usar na hora de editar a área
        public class Status_artigo
        {
            public int idartigo { get; set; }
            public string titulo { get; set; }
            public string datahora_submissao { get; set; }
            public string status { get; set; }
        }
        public List<Status_artigo> listStatus = new List<Status_artigo>();

        private void CarregarDataGridView()
        {
            //Ordenando na exibição dos dados na list por data
            grid_status.DataSource = listStatus.OrderBy(x => x.datahora_submissao);
        }

        private void Status_artigos_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();

            var conn = Login.ConnectOpen;

            //Criar listar usuário
            string sql = "select a.idartigo,a.titulo, r.status,r.justificativa, a.datahora_submissao from Artigo a inner join Revisao r on a.idartigo = r.id_artigo";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                grid_status.DataSource = dt;
            }
        }

        private void datagrids_status(object sender, DataGridViewCellEventArgs e)
        {
            listStatus.Clear();

            if (e.RowIndex < 0)
                return;

            SqlDataReader rdr;
            SqlCommand cmd;
            var conn = Login.ConnectOpen;

            cmd = new SqlCommand("select a.idartigo,a.titulo,a.datahora_submissao, r.status from Artigo a inner join Revisao r on a.idartigo = r.id_artigo", conn);
            rdr = cmd.ExecuteReader();
            //Utilizando para adicionar o resultado do select no objeto "AREA" depois add na listAreas
            if (text_Titulo.Text != "" || text_dataSubmissao.Text != "" || text_Status.Text != "")
            {
                listStatus.Clear();
                while (rdr.Read())
                {
                    var status = new Status_artigo();
                    status.idartigo = Convert.ToInt16(rdr.GetValue(0).ToString());
                    status.titulo = rdr.GetValue(1).ToString();
                    status.datahora_submissao = rdr.GetValue(2).ToString();
                    status.status = rdr.GetValue(3).ToString();
                    listStatus.Add(status);
                }
            }
            else
            {
                while (rdr.Read())
                {
                    var status = new Status_artigo();
                    status.idartigo = Convert.ToInt16(rdr.GetValue(0).ToString());
                    status.titulo = rdr.GetValue(1).ToString();
                    status.datahora_submissao = rdr.GetValue(2).ToString();
                    status.status = rdr.GetValue(3).ToString();
                    listStatus.Add(status);
                }
            }
            //Aqui é testado se a lista não está vazia, depois é apresentado na tela a area selecionada.
            if (listStatus.Count > 0)
            {
                int cod = Convert.ToInt16(grid_status.CurrentRow.Cells[0].Value);
                var statuss = listStatus.SingleOrDefault(x => x.idartigo == cod);
                text_Titulo.Text = statuss.titulo;
                text_dataSubmissao.Text = statuss.datahora_submissao;
                text_Status.Text = statuss.status;
                //Pegando o id do artigo
                idArtigo_status = statuss.idartigo;

            }
            else
            {
                MessageBox.Show("Lista vazia!");
            }
            rdr.Close();

            btn_Enviar.Enabled = true;
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            var statusArtigo = new Status_artigo();
            var conn = Login.ConnectOpen;


            if(text_Status.Text == "Reprovado")
            {
                MessageBox.Show("Você não pode enviar o artigo 'Reprovado', apenas os 'Aprovados'");
                CarregarDataGridView();
                LimparTela();
                Hide();
            }
            else if(text_Titulo.Text == "" && text_dataSubmissao.Text == "" && text_Status.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                CarregarDataGridView();
                LimparTela();
                Hide();
            }
            else
            {
                string sql = "UPDATE Artigo SET enviado = @enviado, datahora_enviado = @datahora_enviado WHERE idartigo = " + idArtigo_status;
                string textEnviado = "sim";
                DataLogin ds = new DataLogin();
                string datahora_enviado = ds.retornarData();
                SqlCommand command = null;
                try
                {
                    command = new SqlCommand(sql.ToString(), conn);
                    command.Parameters.Add(new SqlParameter("@enviado", textEnviado));
                    command.Parameters.Add(new SqlParameter("@datahora_enviado", datahora_enviado));

                    //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                    command.ExecuteNonQuery();
                    MessageBox.Show("Enviado com sucesso!");
                    Hide();

                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao Enviar!");
                    throw;
                }
            }
            
        }

        public void LimparTela()
        {
            text_Titulo.Text = "";
            text_dataSubmissao.Text = "";
            text_Status.Text = "";
        }
    }
}
