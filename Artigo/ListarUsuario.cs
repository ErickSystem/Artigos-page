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
    public partial class ListarUsuario : Form
    {
        public string usuarioSelecionado = "";
        public ListarUsuario()
        {
            InitializeComponent();
        }

        private void data_Grid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //Recuperar linha selecionada
            usuarioSelecionado = data_Grid.Rows[e.RowIndex].Cells[0].Value.ToString();

            Hide();
            
        }

        private void data_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarUsuario_Load(object sender, EventArgs e)
        {
            var conn = Login.ConnectOpen;
            
            //Criar listar usuário
            string sql = "Select * from Usuarios";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                data_Grid.DataSource = dt;
            }

        }
    }
}
