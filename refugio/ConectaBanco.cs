using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace refugio
{
    class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;database=banco_refugio;user=root;password=;");
        public string mensagem = "";

        public DataTable listaCategorias()
        {
            mensagem = "";
            MySqlCommand cmd = new MySqlCommand("sp_listaCategorias", conexao);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException er)
            {
                mensagem = "Erro: " + er.Message;
                return null;
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        public DataTable listaAnimais()
        {
            mensagem = "";
            MySqlCommand cmd = new MySqlCommand("sp_listaAnimais", conexao);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException er)
            {
                mensagem = "Erro: " + er.Message;
                return null;
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        public DataTable consultaAnimalPorNome(string nome)
        {
            mensagem = "";
            MySqlCommand cmd = new MySqlCommand("sp_consultaAnimalPorNome", conexao);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("p_nome", nome);

            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException er)
            {
                mensagem = "Erro: " + er.Message;
                return null;
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        public DataTable consultaAnimalPorId(int id)
        {
            mensagem = "";
            MySqlCommand cmd = new MySqlCommand("sp_consultaAnimalPorId", conexao);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("p_id", id);

            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException er)
            {
                mensagem = "Erro: " + er.Message;
                return null;
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        public bool insereCategoria(string nomeCategoria)
        {
            mensagem = "";
            MySqlCommand cmd = new MySqlCommand("sp_insereCategoria", conexao);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("p_categoria", nomeCategoria);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException er)
            {
                mensagem = "Erro: " + er.Message;
                return false;
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        public bool insereAnimal(AnimalResgatado animal)
        {
            mensagem = "";
            MySqlCommand cmd = new MySqlCommand("sp_insereAnimal", conexao);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("p_nome", animal.Nome);
            cmd.Parameters.AddWithValue("p_id_categoria", animal.IdCategoria);
            cmd.Parameters.AddWithValue("p_especie", animal.Especie);
            cmd.Parameters.AddWithValue("p_sexo", animal.Sexo);
            cmd.Parameters.AddWithValue("p_idade", (object)animal.Idade ?? DBNull.Value);
            cmd.Parameters.AddWithValue("p_situacao", animal.Situacao);
            cmd.Parameters.AddWithValue("p_local_resgate", (object)animal.LocalResgate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("p_data_resgate", (object)animal.DataResgate ?? DBNull.Value);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException er)
            {
                mensagem = "Erro: " + er.Message;
                return false;
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        public bool alteraAnimal(AnimalResgatado animal)
        {
            mensagem = "";
            MySqlCommand cmd = new MySqlCommand("sp_alteraAnimal", conexao);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("p_id", animal.Id);
            cmd.Parameters.AddWithValue("p_nome", animal.Nome);
            cmd.Parameters.AddWithValue("p_id_categoria", animal.IdCategoria);
            cmd.Parameters.AddWithValue("p_especie", animal.Especie);
            cmd.Parameters.AddWithValue("p_sexo", animal.Sexo);
            cmd.Parameters.AddWithValue("p_idade", (object)animal.Idade ?? DBNull.Value);
            cmd.Parameters.AddWithValue("p_situacao", animal.Situacao);
            cmd.Parameters.AddWithValue("p_local_resgate", (object)animal.LocalResgate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("p_data_resgate", (object)animal.DataResgate ?? DBNull.Value);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException er)
            {
                mensagem = "Erro: " + er.Message;
                return false;
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        public bool deletaAnimal(int id)
        {
            mensagem = "";
            MySqlCommand cmd = new MySqlCommand("sp_removeAnimal", conexao);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("p_id", id);

            try
            {
                conexao.Open();
                int linhas = cmd.ExecuteNonQuery();
                if (linhas == 0)
                {
                    mensagem = "Animal não encontrado.";
                    return false;
                }
                return true;
            }
            catch (MySqlException er)
            {
                mensagem = "Erro: " + er.Message;
                return false;
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }


        public bool Verifica(string user, string pass)
        {
            mensagem = "";

            string senhaHash = Biblioteca.makeHash(pass);

            MySqlCommand comando = new MySqlCommand(
                "consultaLogin", conexao);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("usuario", user);
            comando.Parameters.AddWithValue("senha", senhaHash);

            try
            {
                conexao.Open();

                MySqlDataAdapter adaptador =
                    new MySqlDataAdapter(comando);

                DataTable tabela = new DataTable();

                adaptador.Fill(tabela);

                if (tabela.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

            return false;
        }

    }
}
