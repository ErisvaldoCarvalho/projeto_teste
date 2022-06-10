using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class EquipamentoDAL
    {
        public void Inserir(Equipamento _equipamento)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SP_InserirEquipamento";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pdescricao = new SqlParameter("@Descricao", SqlDbType.VarChar);
                pdescricao.Value = _equipamento.Descricao;
                cmd.Parameters.Add(pdescricao);

                SqlParameter pdescricaoDetalhada = new SqlParameter("@DescricaoDetalhada", SqlDbType.VarChar);
                pdescricaoDetalhada.Value = _equipamento.DescricaoDetalhada;
                cmd.Parameters.Add(pdescricaoDetalhada);
                
                SqlParameter pimagem = new SqlParameter("@Imagem", SqlDbType.VarChar);
                pimagem.Value = _equipamento.Imagem;
                cmd.Parameters.Add(pimagem);

                SqlParameter pativo = new SqlParameter("@Ativo", SqlDbType.Bit);
                pativo.Value = _equipamento.Ativo;
                cmd.Parameters.Add(pativo);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable Buscar(string _descricao)
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.CommandText = "SP_BuscarEquipamento";
                SqlParameter psenha = new SqlParameter("@Descricao", SqlDbType.VarChar);
                psenha.Value = _descricao;
                da.SelectCommand.Parameters.Add(psenha);
                cn.Open();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SP_ExcluirEquipamento";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _id;
                cmd.Parameters.Add(pid);

                cn.Open();
                if (cmd.ExecuteNonQuery() != 1)
                    throw new Exception("Ocorreu um erro ao tentar excluir o equipamento: " + _id.ToString());
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}