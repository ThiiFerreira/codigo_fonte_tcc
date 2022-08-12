using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using FluentResults;

namespace UsuarioAPP.Services
{
    // criar logica para conexao como banco de dados e consultas
    public class BdAppTcc
    {
        private MySqlConnection bdConn = new MySqlConnection("server=localhost;database=bdapptcc;user=root;password=");//MySQL
        
        public Result verificaResposnavel(int responsavelId)
        {
            try
            {
                bdConn.Open();
                if (bdConn.State != ConnectionState.Open) return Result.Fail("Falha ao abrir conexão");

                MySqlCommand commS = new MySqlCommand($"select * from responsavel where id ={responsavelId}", bdConn);
                var select = commS.ExecuteReader();
                select.Read();
                Console.WriteLine(select.HasRows);
                if (select.HasRows) return Result.Ok();
                return Result.Fail("Responsavel não encontrado para criação de usuario");

            }
            catch (Exception e)
            {
                return Result.Fail("Falha na conexão com o banco de dados" + e.Message);
            }
            finally
            {
                bdConn.Close();
            }
            
        }
    }
}
