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

            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();

            label_data.Text = "0" + dia + "/" + "0" + mes + "/" + ano;
            if (Login.perfilUser == 3)
            {
                btn_cadastro_user.Visible = true;
                label_user.Text = "Gerente";
            }
            else if(Login.perfilUser == 2)
            {
                label_user.Text = "Revisor";
            }else
            {
                label_user.Text = "Autor";
            }
        }

       private void btn_cadastro(object sender, EventArgs e)
        {
            Cadastrar frms = new Cadastrar();
            frms.ShowDialog();
        }
    }
}
