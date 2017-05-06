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

             //Mostrar na tela qual tipo de usuário está logado
            if (Login.perfilUser == 3)
            {
                btn_cadastro_user.Visible = true;
                label_tipoUser.Text = "Gerente";
            }
            else if(Login.perfilUser == 2)
            {
                label_tipoUser.Text = "Revisor";
            }else if(Login.perfilUser == 1)
            {
                label_tipoUser.Text = "Autor";
            }else
            {
                label_tipoUser.Text = "sem permissões";
            }
        }

       private void btn_cadastro(object sender, EventArgs e)
        {
            Cadastrar frms = new Cadastrar();
            frms.ShowDialog();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.ShowDialog();
            
        }
    }
}
