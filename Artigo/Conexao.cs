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

                con = new SqlConnection();
                /*
                 * Utilizar quando eu estiver no Lab da Universidade
                 * con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\executaveis liberados\Artigo\Artigo\DbArtigos.mdf;Integrated Security=True;Connect Timeout=30";
                 */
                 /*
                  * Utilizar quanto eu estiver em casa
                  */
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Erick\Desktop\Mega-Nuvem\PROGRAMMING\C#\Artigo\Artigo\DbArtigos.mdf;Integrated Security=True;Connect Timeout=30";
                con.Open();
                return con;
            }

            catch (Exception e) {

                throw e;
            }
        }

    }
}
