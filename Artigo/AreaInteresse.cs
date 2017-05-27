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
    public partial class AreaInteresse : Form
    {

        private Conexao con = null;// abrir o banco
        public SqlConnection ConnectOpen = null; //Abrir a conexão

        public AreaInteresse()
        {
            con = new Conexao();
            ConnectOpen = con.ConectarDatabase();
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into Area_interesse_artigo(area, id_usuario)");
            sql.Append("Values (@area, @id_usuario)");

            int id_usuario = Login.idusuario;

            SqlCommand command = null;
            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@area", text_areaInteresse.Text));
                command.Parameters.Add(new SqlParameter("@id_usuario", id_usuario));

                //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                command.ExecuteNonQuery();
                MessageBox.Show("Salvo com sucesso!");
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salvar");
                throw;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
