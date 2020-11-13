using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPainelDeControle
{
    class Conexao
    {
        //CONEXAO COM O BANCO DE DADOS LOCAL
        string conec = "SERVER=localhost; DATABASE=cronograma; UID=root; PWD=; PORT=;";
        public MySqlConnection con = null;

        public void abrirConexao()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void fecharConexao()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
