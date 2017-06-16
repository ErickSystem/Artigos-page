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
    public partial class Enviados : Form
    {
        public Enviados()
        {
            InitializeComponent();
        }

        private void datagrid_enviados(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Enviados_Load(object sender, EventArgs e)
        {
            var conn = Login.ConnectOpen;

            //Criar listar usuário
            string sql = "select a.idartigo,a.titulo,ra.area, u.nome as 'Enviado por', a.datahora_enviado FROM (Artigo a INNER JOIN Area_interesse_artigo ra ON a.id_area_interesse_fk = ra.idarea_interesse_artigo) INNER JOIN Usuarios u ON a.id_usuario = u.idusuario WHERE a.enviado like '%sim%'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dtgrid_Enviados.DataSource = dt;
            }
        }
    }
}
