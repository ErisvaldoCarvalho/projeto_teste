using DAL;
using System.Data;

namespace BLL
{
    public class UsuarioBLL
    {
        public DataTable Buscar(string _senha)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Buscar(_senha);
        }
    }
}
