using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UsuarioAPP.Services
{
    // criar logica para conexao como banco de dados e consultas
    public class BdAppTcc
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;database=BdappTcc;user=root;password=");
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQl;


        public bool verificaResposnavel(int resonsavelId)
        {
            try
            {
                strSQl = "select * from responsavel where id = @ID";
                comando = new MySqlCommand(strSQl, conexao);
                comando.Parameters.AddWithValue("@ID", resonsavelId.ToString());
                conexao.Open();
                comando.Prepare();
                dr = comando.ExecuteReader();

                var sla = dr.Read().ToString();
                return true;
                    
            }catch(Exception e)
            {
                return true;
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
