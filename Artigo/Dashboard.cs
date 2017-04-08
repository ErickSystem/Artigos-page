using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            //recebe a data atual
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();
            //passa a data para o Label e apresenta na tela
            label_data.Text = "0" + dia + "/" + "0" + mes + "/" + ano;
            //Mostrar na tela qual tipo de usuário está logado
            if (Login.perfilUser == 3)
            {
                btn_cadastro_user.Visible = true;
                label_user.Text = "Gerente";
            }
            else if(Login.perfilUser == 2)
            {
                label_user.Text = "Revisor";
            }else if(Login.perfilUser == 1)
            {
                label_user.Text = "Autor";
            }else
            {
                label_user.Text = "sem permissões";
            }
        }

       private void btn_cadastro(object sender, EventArgs e)
        {
            Cadastrar frms = new Cadastrar();
            frms.ShowDialog();
        }
    }
}
