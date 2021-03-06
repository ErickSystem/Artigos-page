﻿using System;
using System.Collections;
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
        public static int idartigo;
        private int idArea;
        public static int reprovar = 0;

        public Artigo()
        {
            con = new Conexao();
            ConnectOpen = con.ConectarDatabase();
            InitializeComponent();
        }


        //Criando uma lista para usar na hora de editar a área
        public class Area
        {
            public int id { get; set; }
            public string area { get; set; }
        }
        public List<Area> listAreas = new List<Area>();


        private void Artigo_Load(object sender, EventArgs e)
        {
            if (Dashboard.esconderSubmeter > 0)
            {
                btn_Submeter.Visible = false;
                Dashboard da = new Dashboard();
                da.buttonSubmeter(0);
            }

            if (Login.perfilUser == 2 || Login.perfilUser == 3)
            {
                btn_listarArtigo.Visible = true;

            }
            //quando for clicado para criar o artigo, o botão listar vai sumir
            if (Dashboard.criarArtigo > 0)
            {
                btn_listarArtigo.Visible = false;

                /*instanciado obj, utilizadno metodo "buttonListarArtigo para zerar a variável. Deste modo, o bottun listar será 
                * novamente habilitado quando o buttun "Revisar artigo" for clicado.
                 */
                Dashboard dash = new Dashboard();
                dash.buttonListarArtigo(0);
            }
        }

        private void btn_Justificar_Click(object sender, EventArgs e)
        {
            Justificar justificar = new Justificar();
            justificar.ShowDialog();
        }

        private void btn_Submeter_Click(object sender, EventArgs e)
        {
            SqlDataReader rdr;
            SqlCommand cmd;
            var conn = Login.ConnectOpen;

            if (artigo_Titulo.Text == "" && artigo_Conteudo.Text == "" && cmb_areaInter.Text == "")
            {
                MessageBox.Show("Preencha todos os campos para salvar");
            }
            else if(artigo_Titulo.Text != "" && artigo_Conteudo.Text != "" && cmb_areaInter.Text != "")
            {
                cmd = new SqlCommand("Select * from Area_interesse_artigo", conn);
                rdr = cmd.ExecuteReader();
                //Utilizando para adicionar o resultado do select no objeto "AREA" depois add na listAreas
                if (cmb_areaInter.Text != "")
                {
                    listAreas.Clear();
                    while (rdr.Read())
                    {
                        var area = new Area();
                        area.area = rdr.GetValue(1).ToString();
                        area.id = Convert.ToInt16(rdr.GetValue(0).ToString());
                        listAreas.Add(area);
                    }
                }
                else
                {
                    while (rdr.Read())
                    {
                        var area = new Area();
                        area.area = rdr.GetValue(1).ToString();
                        area.id = Convert.ToInt16(rdr.GetValue(0).ToString());
                        listAreas.Add(area);
                    }
                }
                //Aqui é testado se a lista não está vazia, depois é apresentado na tela a area selecionada.
                if (listAreas.Count > 0)
                {
                    string areaTela = cmb_areaInter.Text;
                    var areas = listAreas.SingleOrDefault(x => x.area == areaTela);
                    //Pegando o id da area de interesse
                    idArea = areas.id;
                }
                else
                {
                    MessageBox.Show("Lista vazia!");
                    return;
                }

                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into Artigo(titulo, conteudo, enviado, datahora_submissao,id_usuario,id_area_interesse_fk)");
                sql.Append("Values (@titulo, @conteudo,@enviado, @datahora_submissao,@id_usuario,@id_area_interesse_fk)");
                var id_usuario = Login.idusuario;
                string enviado = "nao";
                DataLogin ds = new DataLogin();
                string datahora_submissao = ds.retornarData();
                SqlCommand command = null;
                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@titulo", artigo_Titulo.Text));
                    command.Parameters.Add(new SqlParameter("@conteudo", artigo_Conteudo.Text));
                    command.Parameters.Add(new SqlParameter("@datahora_submissao", datahora_submissao));
                    command.Parameters.Add(new SqlParameter("@enviado", enviado));
                    command.Parameters.Add(new SqlParameter("@id_usuario", id_usuario));
                    command.Parameters.Add(new SqlParameter("@id_area_interesse_fk", idArea));

                    //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                    command.ExecuteNonQuery();
                    MessageBox.Show("Artigo submetido com sucesso!");
                    rdr.Close();
                    Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao submeter artigo");
                    throw;
                }
            }//Fim do if else
            else
            {
                MessageBox.Show("Ainda há campos vazios.");
            }
        }
        private void btn_listarArtigo_Click(object sender, EventArgs e)
        {
            var listarArtigos = new ListarArtigo();
            listarArtigos.ShowDialog();

            if (listarArtigos.artigoSelecionado == "")
                return;
            //Retornando apenas o artigo selecionado
            var conn = Login.ConnectOpen;
            //Buscar usuário selecionado
            string sqlArtigo = "Select * from Artigo where idartigo = '" + listarArtigos.artigoSelecionado + "'";
            DataTable dtArtigo = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlArtigo, conn);
            da.Fill(dtArtigo);

            int codArea_fk = Convert.ToInt16(dtArtigo.Rows[0][8]);

            //Retornando apenas a area associada ao artigo
            var con = Login.ConnectOpen;
            //Buscar usuário selecionado
            string sqlArea = "select ai.area from Artigo a inner join Area_interesse_artigo ai on a.id_area_interesse_fk = ai.idarea_interesse_artigo where ai.idarea_interesse_artigo = " + codArea_fk;
            DataTable dtArea = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlArea, con);
            sda.Fill(dtArea);
            //Preenchendo campos com retorno do banco
            artigo_Titulo.Text = Convert.ToString(dtArtigo.Rows[0][1]);
            artigo_Conteudo.Text = Convert.ToString(dtArtigo.Rows[0][2]);
            cmb_areaInter.Text = Convert.ToString(dtArea.Rows[0][0]);

            idartigo = Convert.ToInt16(listarArtigos.artigoSelecionado);

            btn_Aprovar.Visible = true;
            btn_Justificar.Visible = true;
            btn_Reprovar.Visible = true;
            btn_Deletar.Visible = true;
            btn_Submeter.Visible = false;
            btn_Alterar.Visible = true;

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_Aprovar_Click(object sender, EventArgs e)
        {
            int id_usuario = Login.idusuario;
            string status = "Aprovado";
            DataLogin ds = new DataLogin();
            string datahora_aprovacao = ds.retornarData();

            var conn = Login.ConnectOpen;
            //Buscar codigo digitado, caso não encontre retornará com uma menssagem informando que o codigo não foi encontrado
            string sqlRevisor = "Select * from Revisao where id_artigo = " + idartigo;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlRevisor, conn);
            da.Fill(dt);

                string sql = "UPDATE Revisao SET status = @status WHERE id_artigo = " + idartigo;

                SqlCommand command = null;
                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@status", status));
                    command.Parameters.Add(new SqlParameter("@datahora_avaliacao", datahora_aprovacao));
                    command.Parameters.Add(new SqlParameter("@id_artigo", idartigo));
                    command.Parameters.Add(new SqlParameter("@id_usuario", id_usuario));

                    //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                    command.ExecuteNonQuery();
                    MessageBox.Show("Aprovado com sucesso!");

                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao Aprovado!");
                    throw;
                }

            //Alterando justificativa
            string sqlJustificativa = "UPDATE Revisao SET  justificativa = @justificativa WHERE id_artigo = " + Artigo.idartigo;

            SqlCommand cmm = null;
            try
            {
                string justificativa = " ";
                cmm = new SqlCommand(sqlJustificativa.ToString(), ConnectOpen);
                cmm.Parameters.Add(new SqlParameter("@justificativa", justificativa));
                cmm.Parameters.Add(new SqlParameter("@id_artigo", Artigo.idartigo));
                cmm.Parameters.Add(new SqlParameter("@id_usuario", Login.idusuario));

                //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                cmm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Justificar!");
                throw;
            }
        }

        private void btn_Reprovar_Click(object sender, EventArgs e)
        {
            //receberá um valor 1 quando for clicado, para poder user de referencia na teal Justificativa.
            reprovar++;

            int id_usuario = Login.idusuario;
            string status = "Reprovado";
            DataLogin ds = new DataLogin();
            string datahora_aprovacao = ds.retornarData();

            var conn = Login.ConnectOpen;
            //Buscar codigo digitado, caso não encontre retornará com uma menssagem informando que o codigo não foi encontrado
            string sqlRevisor = "Select * from Revisao where id_artigo = " + idartigo;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlRevisor, conn);
            da.Fill(dt);
            //Se o artigo ainda não tiver sido avaliado, será inserido na tabela Revisao
            if (dt.Rows.Count <= 0)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into Revisao(status, datahora_avaliacao,id_artigo,id_usuario)");
                sql.Append("Values (@status, @datahora_avaliacao,@id_artigo,@id_usuario)");

                SqlCommand command = null;
                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@status", status));
                    command.Parameters.Add(new SqlParameter("@datahora_avaliacao", datahora_aprovacao));
                    command.Parameters.Add(new SqlParameter("@id_artigo", idartigo));
                    command.Parameters.Add(new SqlParameter("@id_usuario", id_usuario));

                    //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                    command.ExecuteNonQuery();
                    Justificar justificar = new Justificar();
                    justificar.ShowDialog();
                    MessageBox.Show("Reprovado com sucesso!");
                    Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao Reprovado");
                    throw;
                }
            }
            //Se o artigo já tiver sido inserido, será apenas ataulizado a avaliação
            else
            {
                string sql = "UPDATE Revisao SET status = @status WHERE id_artigo = " + idartigo;

                SqlCommand command = null;
                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@status", status));
                    command.Parameters.Add(new SqlParameter("@datahora_avaliacao", datahora_aprovacao));
                    command.Parameters.Add(new SqlParameter("@id_artigo", idartigo));
                    command.Parameters.Add(new SqlParameter("@id_usuario", id_usuario));

                    //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                    command.ExecuteNonQuery();
                    Justificar justificar = new Justificar();
                    justificar.ShowDialog();
                    MessageBox.Show("Reprovado com sucesso!");
                    Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao Reprovado!");
                    throw;
                }
            }
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            //Gera uma caixa de alerta solicitando confirmação para excluir usuário.
            DialogResult resposta = MessageBox.Show("Deseja mesmo deletar este Artigo?", "Deletar Artigo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                if (idartigo > 0 && Login.perfilUser == 3)
                {
                    string sqlFk = "DELETE FROM Revisao WHERE id_artigo = @id_artigo";
                    string sql = "DELETE FROM Artigo WHERE idartigo = @idartigo";
                    SqlCommand command = null;
                    SqlCommand com = null;

                    try
                    {
                        com = new SqlCommand(sqlFk, ConnectOpen);
                        com.Parameters.Add(new SqlParameter("@id_artigo", idartigo));
                        command = new SqlCommand(sql, ConnectOpen);
                        command.Parameters.Add(new SqlParameter("@idartigo", idartigo));
                        //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                        com.ExecuteNonQuery();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Artigo deletado!");
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

        //Utilizado para preencher com os dados da tabela: Area_interesse_artigo
        private void cmd_AreaInteresse(object sender, MouseEventArgs e)
        {
            var conn = Login.ConnectOpen;
            //Buscar usuário selecionado
            string sql = "Select * from Area_interesse_artigo";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            //da.Fill(dt);

            DataTable dtResultado = new DataTable();
            dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
            cmb_areaInter.DataSource = null;
            da.Fill(dtResultado);
            cmb_areaInter.DataSource = dtResultado;
            // cmb_areaInter.ValueMember = "area";
            cmb_areaInter.DisplayMember = "area";
            cmb_areaInter.SelectedItem = "";
            cmb_areaInter.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            SqlDataReader rdr;
            SqlCommand cmd;
            var conn = Login.ConnectOpen;

            if (artigo_Titulo.Text == "" && artigo_Conteudo.Text == "" && cmb_areaInter.Text == "")
            {
                MessageBox.Show("Preencha todos os campos para salvar");
            }
            else if (artigo_Titulo.Text != "" && artigo_Conteudo.Text != "" && cmb_areaInter.Text != "")
            {
                cmd = new SqlCommand("Select * from Area_interesse_artigo", conn);
                rdr = cmd.ExecuteReader();
                //Utilizando para adicionar o resultado do select no objeto "AREA" depois add na listAreas
                if (cmb_areaInter.Text != "")
                {
                    listAreas.Clear();
                    while (rdr.Read())
                    {
                        var area = new Area();
                        area.area = rdr.GetValue(1).ToString();
                        area.id = Convert.ToInt16(rdr.GetValue(0).ToString());
                        listAreas.Add(area);
                    }
                }
                else
                {
                    while (rdr.Read())
                    {
                        var area = new Area();
                        area.area = rdr.GetValue(1).ToString();
                        area.id = Convert.ToInt16(rdr.GetValue(0).ToString());
                        listAreas.Add(area);
                    }
                }
                //Aqui é testado se a lista não está vazia, depois é apresentado na tela a area selecionada.
                if (listAreas.Count > 0)
                {
                    string areaTela = cmb_areaInter.Text;
                    var areas = listAreas.SingleOrDefault(x => x.area == areaTela);
                    //Pegando o id da area de interesse
                    idArea = areas.id;
                }
                else
                {
                    MessageBox.Show("Lista vazia!");
                    return;
                }

                string sql = "UPDATE Artigo SET titulo = @titulo, conteudo = @conteudo, datahora_atualizado = @datahora_atualizado WHERE idartigo = " + idartigo;

                DataLogin ds = new DataLogin();
                string datahora_atualizao = ds.retornarData();
                SqlCommand command = null;
                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@titulo", artigo_Titulo.Text));
                    command.Parameters.Add(new SqlParameter("@conteudo", artigo_Conteudo.Text));
                    command.Parameters.Add(new SqlParameter("@datahora_atualizado", datahora_atualizao));
                    command.Parameters.Add(new SqlParameter("@id_usuario", Login.idusuario));
                    command.Parameters.Add(new SqlParameter("@id_area_interesse_fk", idArea));

                    //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                    command.ExecuteNonQuery();
                    MessageBox.Show("Artigo atualizado com sucesso!");
                    rdr.Close();
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao atualizar Artigo");
                    throw;
                }
            }//Fim do if else
            else
            {
                MessageBox.Show("Ainda há campos vazios.");
            }

        }
        public void setReprovar(int zerar)
        {
            Artigo.reprovar = zerar;
        }
    }
}
