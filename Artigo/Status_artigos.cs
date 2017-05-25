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
        public string statusSelecionado = "";

        public Status_artigos()
        {
            InitializeComponent();
        }

        private void Status_artigos_Load(object sender, EventArgs e)
        {
            var conn = Login.ConnectOpen;

            //Criar listar usuário
            string sql = "select a.idartigo,a.titulo, r.status,r.justificativa, a.datahora_submissao from Artigo a inner join Revisao r on a.idartigo = r.id_artigo";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                datagrid_status.DataSource = dt;
            }
        }

        private void datagrids_status(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
