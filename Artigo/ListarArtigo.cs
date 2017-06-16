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
    public partial class ListarArtigo : Form
    {
        public string artigoSelecionado = "";

        public ListarArtigo()
        {
            InitializeComponent();
        }

        private void ListarArtigo_Load(object sender, EventArgs e)
        {
            var conn = Login.ConnectOpen;

            //Criar listar usuário
            string sql = "Select idartigo,titulo,conteudo,datahora_submissao from Artigo where enviado like '%nao%'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                datagrid_ListarArtigos.DataSource = dt;
            }
        }

        private void datagrid_listarArtigoss(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //Recuperar linha selecionada
            artigoSelecionado = datagrid_ListarArtigos.Rows[e.RowIndex].Cells[0].Value.ToString();
            Hide();
        }
    }
}
