using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AnuncianteAnuncioDAO
    {
        public void Inserir(AnuncianteAnuncioInformation aai)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.con;
                command.CommandText = @"INSERT INTO AnuncianteAnuncio
                                            (fk_anu_id,fk_usu_id) VALUES
                                            (@fk_anu_id, @fk_usu_id)";

                command.Parameters.AddWithValue("@fk_anu_id", aai.fk_anu_id);
                command.Parameters.AddWithValue("@fk_usu_id", aai.fk_usu_id);

                Conexao.Conectar();

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha na vinculação" + ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }
    }
}
