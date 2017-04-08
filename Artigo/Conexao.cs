using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Artigo
{
    public class Conexao
    {
        SqlConnection con = null;
        public SqlConnection ConectarDatabase() {
            try {

                //Criar uma nova instancia
                con = new SqlConnection();
                //Utilizado para poder pegar qualquer diretorio para o localDB
                string path = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("bin\\Debug\\", "").Replace("bin\\Debug", "");
                con.ConnectionString = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}DbArtigos.mdf;Integrated Security=True;Connect Timeout=30", path);
                con.Open();
                return con;
            }

            catch (Exception) {

                throw;
            }
        }

    }
}
