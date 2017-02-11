using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAO
    {
        public void InserirUsuario(UsuarioInformation usu)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.con;
                command.CommandText = @"INSERT INTO usuario
                                            (usu_nome,usu_email,usu_senha,usu_telefone)
                                             VALUES (@usu_nome, @usu_email, @usu_senha,@usu_telefone)";

                command.Parameters.AddWithValue("@usu_nome", usu.usu_nome);
                command.Parameters.AddWithValue("@usu_email", usu.usu_email);
                command.Parameters.AddWithValue("@usu_senha", usu.usu_senha1);
                command.Parameters.AddWithValue("@usu_telefone", usu.usu_senha1);

                Conexao.Conectar();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Falha na Inserção do Usuario");
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        public int UsuarioExiste(UsuarioInformation usu)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.con;
                command.CommandText = @"SELECT usu_id FROM usuario WHERE usu_nome = @usu_nome AND usu_email = @usu_email";

                command.Parameters.AddWithValue("@usu_nome",usu.usu_nome);
                command.Parameters.AddWithValue("@usu_email", usu.usu_email);

                Conexao.Conectar();

                int id = Convert.ToInt32(command.ExecuteScalar());
                return id;
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

        public int RetornaID(UsuarioInformation usu)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.con;
                command.CommandText = @"SELECT usu_id
                                            FROM usuario
                                            WHERE usu_nome = @usu_nome AND
                                                usu_email = @usu_email AND
                                                usu_senha = @usu_senha";

                command.Parameters.AddWithValue("@usu_nome", usu.usu_nome);
                command.Parameters.AddWithValue("@usu_email", usu.usu_email);
                command.Parameters.AddWithValue("@usu_senha", usu.usu_senha1);

                Conexao.Conectar();
                int id = Convert.ToInt32(command.ExecuteScalar());
                return id;
            }
            catch (Exception)
            {
                throw new Exception("Falha da busca");
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        public void AlterarSenha(UsuarioInformation usu)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.con;
                command.CommandText = @"UPDATE usuario SET usu_senha = @usu_senha WHERE usu_id = @usu_id";

                command.Parameters.AddWithValue("@usu_id",usu.usu_id);
                command.Parameters.AddWithValue("@usu_senha", usu.usu_senha2);

                Conexao.Conectar();

                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("Falha na atulização do Usuario" + ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        public int ConfereSenha(UsuarioInformation usu)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.con;
                command.CommandText = @"SELECT count(usu_id) FROM usuario WHERE usu_id = @usu_id AND usu_senha = @usu_senha";

                command.Parameters.AddWithValue("@usu_id", usu.usu_id);
                command.Parameters.AddWithValue("@usu_senha", usu.usu_senha1);
                Conexao.Conectar();

                int qtd = Convert.ToInt32(command.ExecuteScalar());

                return qtd;
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

        public void AlterarDadosGerais(UsuarioInformation usu)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.con;
                command.CommandText = @"UPDATE usuario SET usu_email = @usu_email,
                                            usu_telefone = @usu_telefone
                                            WHERE usu_id = @usu_id";

                command.Parameters.AddWithValue("@usu_id",usu.usu_id);
                command.Parameters.AddWithValue("@usu_email", usu.usu_email);
                command.Parameters.AddWithValue("@usu_telefone", usu.usu_telefone);
                Conexao.Conectar();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha na atualização do Usuario" + ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        public UsuarioInformation Login(UsuarioInformation usu)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.con;
                command.CommandText = @"SELECT * FROM usuario WHERE usu_nome = @usu_nome AND usu_senha = @usu_senha";

                command.Parameters.AddWithValue("@usu_nome",usu.usu_nome);
                command.Parameters.AddWithValue("@usu_senha", usu.usu_senha1);

                Conexao.Conectar();

                var reader = command.ExecuteReader();

                UsuarioInformation usuario = null;

                while (reader.Read())
                {
                    usuario = new UsuarioInformation();
                    usuario.usu_id = Convert.ToInt32(reader["usu_id"]);
                    usuario.usu_nome = reader["usu_nome"].ToString();
                    usuario.usu_email = reader["usu_email"].ToString();
                    usuario.usu_senha1 = reader["usu_senha"].ToString();
                }

                return usuario;
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

        public UsuarioInformation RetornaDados(int id)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.con;
                command.CommandText = "SELECT * FROM usuario WHERE usu_id = @usu_id";

                command.Parameters.AddWithValue("@usu_id", id);

                Conexao.Conectar();

                var reader = command.ExecuteReader();

                UsuarioInformation usuario = null;

                while (reader.Read())
                {
                    usuario = new UsuarioInformation();

                    usuario.usu_id = Convert.ToInt32(reader["usu_id"]);
                    usuario.usu_nome = reader["usu_nome"].ToString();
                    usuario.usu_email = reader["usu_email"].ToString();
                    usuario.usu_senha1 = reader["usu_senha"].ToString();
                    usuario.usu_telefone = reader["usu_telefone"].ToString();
                }

                return usuario;
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
    }
}
