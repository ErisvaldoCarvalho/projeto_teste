using DAL;
using System.Data;

namespace BLL
{
    public class PerfilBLL
    {
        public DataTable Buscar(int _id)
        {
            PerfilDAL perfilDAL = new PerfilDAL();
            return perfilDAL.Buscar(_id);
        }
    }
}
