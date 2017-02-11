using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data.SqlClient;

namespace DAL
{
    public class AnuncioDAO
    {
        public int InserirAnuncio(AnuncioInformation anu)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.con;
                command.CommandText = @"INSERT INTO anuncio (anu_titulo, anu_descricao,anu_tipo,
                                                    anu_preco,anu_foto1,anu_foto2,anu_foto3, anu_datacad) 
                                                values
                                                    (@anu_titulo, @anu_descricao, @anu_tipo,
                                                    @anu_preco, @anu_foto1, @anu_foto2, @anu_foto3, @anu_datacad);
                                                    SELECT scope_identity();";

                command.Parameters.AddWithValue("@anu_titulo",anu.anu_titulo);
                command.Parameters.AddWithValue("@anu_descricao",anu.anu_descricao);
                command.Parameters.AddWithValue("@anu_tipo",anu.anu_tipo);
                command.Parameters.AddWithValue("@anu_preco",anu.anu_preco);
                command.Parameters.AddWithValue("@anu_foto1",anu.anu_foto1);
                command.Parameters.AddWithValue("@anu_foto2",anu.anu_foto2);
                command.Parameters.AddWithValue("@anu_foto3",anu.anu_foto3);
                command.Parameters.AddWithValue("@anu_datacad",anu.anu_datacad);

                Conexao.Conectar();

                int id = Convert.ToInt32(command.ExecuteScalar());

                return id;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha na inserção do Usuario: " + ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        public SqlDataReader RetornaAnunciosVitrine()
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.con;
                command.CommandText = @"SELECT top 8 anu_id, anu_titulo,anu_preco, anu_foto1
                                            FROM anuncio ORDER BY anu_id desc";
                Conexao.Conectar();
                SqlDataReader dr = command.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha no retorno da vitrine: " + ex.Message);
            }
        }
    }
}
