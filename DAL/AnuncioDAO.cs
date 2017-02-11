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

                command.Parameters.AddWithValue("@anu_titulo", anu.anu_titulo);
                command.Parameters.AddWithValue("@anu_descricao", anu.anu_descricao);
                command.Parameters.AddWithValue("@anu_tipo", anu.anu_tipo);
                command.Parameters.AddWithValue("@anu_preco", anu.anu_preco);
                command.Parameters.AddWithValue("@anu_foto1", anu.anu_foto1);
                command.Parameters.AddWithValue("@anu_foto2", anu.anu_foto2);
                command.Parameters.AddWithValue("@anu_foto3", anu.anu_foto3);
                command.Parameters.AddWithValue("@anu_datacad", anu.anu_datacad);

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

        public AnuncioInformation RetornaDadosAnuncio(int id_anuncio)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.con;
                cmd.CommandText = @"SELECT anu_id, anu_titulo, anu_descricao, anu_tipo
                                        ,anu_preco,anu_foto1,anu_foto2,anu_foto3,anu_datacad
                                        FROM anuncio
                                        WHERE anu_id = @anu_id";
                cmd.Parameters.AddWithValue("@anu_id",id_anuncio);
                Conexao.Conectar();

                var reader = cmd.ExecuteReader();

                AnuncioInformation anu = null;

                while(reader.Read()){
                    anu = new AnuncioInformation();

                    anu.anu_id = Convert.ToInt32(reader["anu_id"]);
                    anu.anu_titulo = reader["anu_titulo"].ToString();
                    anu.anu_descricao = reader["anu_descricao"].ToString();
                    anu.anu_tipo = reader["anu_tipo"].ToString();
                    anu.anu_preco = Convert.ToDecimal(reader["anu_preco"]);
                    anu.anu_foto1 = reader["anu_foto1"].ToString();
                    anu.anu_foto2 = reader["anu_foto2"].ToString();
                    anu.anu_foto3 = reader["anu_foto3"].ToString();
                    anu.anu_datacad = Convert.ToDateTime(reader["anu_datacad"]);
                }
                return anu;
            }
            catch(Exception e)
            {
                throw;
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        public void AlterarAnuncio(AnuncioInformation anu)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.con;
                cmd.CommandText = @"UPDATE anuncio SET usu_titulo = @usu_titulo
                                            ,anu_descricao = @anu_descricao
                                            ,anu_tipo = @anu_tipo
                                            ,anu_preco = @anu_preco
                                        WHERE anu_id = @anu_id";

                cmd.Parameters.AddWithValue("@anu_id", anu.anu_id);
                cmd.Parameters.AddWithValue("@usu_titulo", anu.anu_titulo);
                cmd.Parameters.AddWithValue("@anu_descricao", anu.anu_descricao);
                cmd.Parameters.AddWithValue("@anu_tipo", anu.anu_tipo);
                cmd.Parameters.AddWithValue("@anu_preco", anu.anu_preco);

                Conexao.Conectar();

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        public UsuarioeAnuncioInformation DadosGeraisAnuncio(int id_anuncio)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.con;
                cmd.CommandText = @"SELECT 
		                             anu_id
		                            ,anu_titulo
		                            ,anu_descricao
		                            ,anu_tipo
		                            ,anu_preco
		                            ,anu_foto1
		                            ,anu_foto2
		                            ,anu_foto3
		                            ,anu_datacad
                                    ,usu_id
                                    ,usu_nome
                                    ,usu_email
                                    ,usu_telefone
	                            FROM Anuncio
		                            INNER JOIN AnuncianteAnuncio ON anu_id = fk_anu_id
		                            INNER JOIN Usuario ON usu_id = fk_usu_id
	                            WHERE anu_id = @anu_id";

                cmd.Parameters.AddWithValue("@anu_id", id_anuncio);

                Conexao.Conectar();

                var reader = cmd.ExecuteReader();

                UsuarioeAnuncioInformation dados = null;

                while (reader.Read())
                {
                    dados = new UsuarioeAnuncioInformation();

                    dados.anu_id = Convert.ToInt32(reader["anu_id"]);
                    dados.anu_titulo = reader["anu_titulo"].ToString();
                    dados.anu_descricao = reader["anu_descricao"].ToString();
                    dados.anu_tipo = reader["anu_tipo"].ToString();
                    dados.anu_preco = Convert.ToDecimal(reader["anu_preco"]);
                    dados.anu_foto1 = reader["anu_foto1"].ToString();
                    dados.anu_foto2 = reader["anu_foto2"].ToString();
                    dados.anu_foto3 = reader["anu_foto3"].ToString();
                    dados.anu_datacad = Convert.ToDateTime(reader["anu_datacad"].ToString());
                    dados.usu_id = Convert.ToInt32(reader["usu_id"]);
                    dados.usu_nome = reader["usu_nome"].ToString();
                    dados.usu_email = reader["usu_email"].ToString();
                    dados.usu_telefone = reader["usu_telefone"].ToString();
                }

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
