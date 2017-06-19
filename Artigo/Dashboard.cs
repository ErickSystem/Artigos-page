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
    public partial class Dashboard : Form
    {
        private int logado = 0;
        public static int criarArtigo = 0;
        public static int esconderSubmeter = 0;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            //mostrar a data que o usuario está logado
            DataLogin data = new DataLogin();
            label_data.Text = data.retornarData();
            label_user.Text = Login.nomeUser;
            text_areaInteresse.Text = Login.area_interesse;
            //Mostrar na tela qual tipo de usuário está logado
            if (Login.perfilUser == 3)
            {
                btn_cadastro_user.Visible = true;
                label_tipoUser.Text = "Gerente";
            }
            else if (Login.perfilUser == 2)
            {
                label_tipoUser.Text = "Revisor";
                btn_revisar.Visible = true;

            }
            else if (Login.perfilUser == 1)
            {
                label_tipoUser.Text = "Autor";
            }
            else
            {
                label_tipoUser.Text = "sem permissões";
            }
            if (Login.perfilUser == 3)
            {
                btn_areaInteresse.Visible = true;
                btn_revisar.Visible = true;
            }
        }
        private void btn_cadastro(object sender, EventArgs e)
        {
            Cadastrar frms = new Cadastrar();
            frms.ShowDialog();
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Login.perfilUser = 0;

            //Gera uma caixa de alerta solicitando confirmação para excluir usuário.
            DialogResult resposta = MessageBox.Show("Deseja mesmo sair?", "Deslogar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
        }
        public int deslogar(int logado)
        {
            this.logado = logado;
            return logado;
        }

        private void btn_Artigos_Click(object sender, EventArgs e)
        {
            criarArtigo++;
            Artigo artigo = new Artigo();
            artigo.ShowDialog();

        }

        private void btn_Status_Click(object sender, EventArgs e)
        {
            Status_artigos sa = new Status_artigos();
            sa.ShowDialog();
        }

        private void btn_areaInteresse_Click(object sender, EventArgs e)
        {
            var area = new AreaInteresse();
            area.ShowDialog();
        }

        private void btn_endiados_Click(object sender, EventArgs e)
        {
            var enviados = new Enviados();
            enviados.ShowDialog();
        }

        private void btn_revisarArtigo(object sender, EventArgs e)
        {
            esconderSubmeter++;
            var artigos = new Artigo();
            artigos.ShowDialog();
        }

        public int buttonListarArtigo(int criarArtigo)
        {
            Dashboard.criarArtigo = criarArtigo;
            return Dashboard.criarArtigo;
        }
        public int buttonSubmeter(int escondeSubmter)
        {
            Dashboard.esconderSubmeter = escondeSubmter;
            return Dashboard.esconderSubmeter;
        }

    }
}
