using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class ComentarioBLL
    {
        public void Inserir(Comentario _comentario)
        {
            ComentarioDAL equipamentoDAL = new ComentarioDAL();
            equipamentoDAL.Inserir(_comentario);
        }
        public DataTable Buscar(int _id_Equipamento)
        {
            ComentarioDAL comentarioDAL = new ComentarioDAL();
            return comentarioDAL.Buscar(_id_Equipamento);
        }
    }
}
