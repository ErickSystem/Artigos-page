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
           /* var frm = new Login();
            frm.ShowDialog();

            if (frm.logado)
            {
                frm.Hide();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para acessar o Dashboard");
                frm.Hide();
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar frms = new Cadastrar(3);
            frms.ShowDialog();

        }
    }
}
