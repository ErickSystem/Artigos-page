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
    public partial class AreaInteresse : Form
    {

        private Conexao con = null;// abrir o banco
        public SqlConnection ConnectOpen = null; //Abrir a conexão
        private int codigoAreaClicado = 0;

        public AreaInteresse()
        {
            con = new Conexao();
            ConnectOpen = con.ConectarDatabase();
            InitializeComponent();
        }

        //Criando uma lista para usar na hora de editar a área
        public class Areas
        {
            public int codigo { get; set; }
            public string area { get; set; }
        }
        public List<Areas> listAreas = new List<Areas>();

        private void AreaInteresse_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
        }
        private void CarregarDataGridView()
        {
            //Ordenando na exibição dos dados na list por data
            grid_Areas.DataSource = listAreas.OrderBy(x => x.area);
            grid_Revisores.DataSource = listAreas.OrderBy(x => x.area);
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {

            if (text_areaInteresse.Text == "")
            {
                MessageBox.Show("Campo área precisa ser preenchido");
            }
            else
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into Area_interesse_artigo(area)");
                sql.Append("Values (@area)");

                SqlCommand command = null;
                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@area", text_areaInteresse.Text));

                    //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                    command.ExecuteNonQuery();
                    MessageBox.Show("Salvo com sucesso!");
                    LimparTela();
                    CarregarDataGridView();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao salvar");
                    throw;
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_ListarAreas_Click(object sender, EventArgs e)
        {
            var conn = Login.ConnectOpen;
            //Buscar usuário selecionado
            string sql = "Select idarea_interesse_artigo as Codigo, area as Area from Area_interesse_artigo";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grid_Areas.DataSource = true;
            grid_Areas.DataSource = dt;
            grid_Areas.Refresh();
        }

        private void btn_VerRevisor(object sender, EventArgs e)
        {
            var conn = Login.ConnectOpen;
            //Buscar usuário selecionado
            string sql = "Select idusuario as Codigo,nome as Nome, areaInteresse as 'Area de Interesse' from Usuarios where perfil = 2 order by nome";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grid_Revisores.DataSource = true;
            grid_Revisores.DataSource = dt;
            grid_Revisores.Refresh();
        }

        private void btn_AssociarRevisor_Click(object sender, EventArgs e)
        {
            var conn = Login.ConnectOpen;
            //Buscar codigo digitado, caso não encontre retornará com uma menssagem informando que o codigo não foi encontrado
            string sqlRevisor = "Select * from Usuarios where idusuario = '" + codigo_revisor.Value + "' and perfil = 2";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlRevisor, conn);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                string sql = "UPDATE Usuarios SET areaInteresse = @areaInteresse WHERE idusuario = '" + codigo_revisor.Value + "'";

                SqlCommand command = null;
                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@areaInteresse", cmd_Areas.Text));

                    //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                    command.ExecuteNonQuery();
                    MessageBox.Show("Associado com sucesso!");
                    CarregarDataGridView();
                    LimparTela();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao associar revisor!");
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Codigo não encontrado");
            }
        }
        private void cm_Areas(object sender, MouseEventArgs e)
        {
            var conn = Login.ConnectOpen;
            //Buscar usuário selecionado
            string sql = "Select * from Area_interesse_artigo";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dtResultado = new DataTable();
            dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
            cmd_Areas.DataSource = null;
            da.Fill(dtResultado);
            cmd_Areas.DataSource = dtResultado;
            // cmb_areaInter.ValueMember = "area";
            cmd_Areas.DisplayMember = "area";
            cmd_Areas.SelectedItem = "";
            cmd_Areas.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
        }

        public void LimparTela()
        {
            text_areaInteresse.Text = "";
            codigo_revisor.Value = 0;
            cmd_Areas.Text = "";
        }

        private void dtgrid_double(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            SqlDataReader rdr;
            SqlCommand cmd;
            var conn = Login.ConnectOpen;

            cmd = new SqlCommand("Select * from Area_interesse_artigo", conn);
            rdr = cmd.ExecuteReader();
            //Utilizando para adicionar o resultado do select no objeto "AREA" depois add na listAreas
            if (text_areaInteresse.Text != "")
            {
                listAreas.Clear();
                while (rdr.Read())
                {
                    var area = new Areas();
                    area.area = rdr.GetValue(1).ToString();
                    area.codigo = Convert.ToInt16(rdr.GetValue(0).ToString());
                    listAreas.Add(area);
                }
            }
            else
            {
                while (rdr.Read())
                {
                    var area = new Areas();
                    area.area = rdr.GetValue(1).ToString();
                    area.codigo = Convert.ToInt16(rdr.GetValue(0).ToString());
                    listAreas.Add(area);
                }
            }
            //Aqui é testado se a lista não está vazia, depois é apresentado na tela a area selecionada.
            if (listAreas.Count > 0)
            {

                int cod = Convert.ToInt16(grid_Areas.CurrentRow.Cells[0].Value);
                var areas = listAreas.SingleOrDefault(x => x.codigo == cod);
                text_areaInteresse.Text = areas.area;
                codigoAreaClicado = areas.codigo;
            }
            else
            {
                MessageBox.Show("Lista vazia!");
            }
            rdr.Close();
            btn_Alterar.Enabled = true;
            btn_Excluir.Enabled = true;
            btn_salvar.Visible = false;
            btn_Criarnovo.Visible = true;
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            btn_salvar.Visible = false;
            btn_Criarnovo.Visible = true;
            string sql = "UPDATE Area_interesse_artigo SET area = @area WHERE idarea_interesse_artigo = '" + codigoAreaClicado + "'";

            SqlCommand command = null;
            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@area", text_areaInteresse.Text));

                //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                command.ExecuteNonQuery();
                MessageBox.Show("Alterado com sucesso!");
                listAreas.Clear();
                CarregarDataGridView();
                LimparTela();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao alterar area!");
                throw;
            }
        }
        private void btn_Criarnovo_Click(object sender, EventArgs e)
        {
            listAreas.Clear();
            CarregarDataGridView();
            LimparTela();
            btn_Alterar.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_Criarnovo.Visible = false;
            btn_salvar.Visible = true;
        }
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //Gera uma caixa de alerta solicitando confirmação para excluir usuário.
            DialogResult resposta = MessageBox.Show("Deseja mesmo deletar esta área?", "Deletar Área de interesse", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                string sqlFk = "DELETE FROM Artigo WHERE id_area_interesse_fk = @id_area_interesse_fk";
                string sql = "DELETE FROM Area_interesse_artigo where idarea_interesse_artigo = @idarea_interesse_artigo";
                SqlCommand command = null;
                SqlCommand com = null;
                try
                {
                    com = new SqlCommand(sqlFk, ConnectOpen);
                    com.Parameters.Add(new SqlParameter("@id_area_interesse_fk", codigoAreaClicado));

                    command = new SqlCommand(sql, ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@idarea_interesse_artigo", codigoAreaClicado));
                    //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                    com.ExecuteNonQuery();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Artigo deletado!");
                    listAreas.Clear();
                    CarregarDataGridView();
                    LimparTela();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao deleter usuário!");
                    throw;
                }

                btn_Alterar.Enabled = false;
                btn_Excluir.Enabled = false;
                btn_Criarnovo.Visible = false;
                btn_salvar.Visible = true;
            }
        }
    }
}
