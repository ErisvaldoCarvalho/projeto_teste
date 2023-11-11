using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ComentarioDAL
    {
        public void Inserir(Comentario _comentario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SP_InserirComentario";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pdescricao = new SqlParameter("@Descricao", SqlDbType.VarChar);
                pdescricao.Value = _comentario.Descricao;
                cmd.Parameters.Add(pdescricao);

                //SqlParameter pid_Perfil = new SqlParameter("@Id_Perfil", SqlDbType.Int);
                //pid_Perfil.Value = _comentario.PerfilId;
                //cmd.Parameters.Add(pid_Perfil);

                //SqlParameter pid_Equipamento = new SqlParameter("@Id_Equipamento", SqlDbType.Int);
                //pid_Equipamento.Value = _comentario.EquipamentoId;
                //cmd.Parameters.Add(pid_Equipamento);

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
        public DataTable Buscar(int _id_Comentario)
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
                da.SelectCommand.CommandText = "SP_BuscarComentario";
               
                SqlParameter pid_Equipamento = new SqlParameter("@Id_Equipamento", SqlDbType.Int);
                pid_Equipamento.Value = _id_Comentario;
                da.SelectCommand.Parameters.Add(pid_Equipamento);

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
    }
}
