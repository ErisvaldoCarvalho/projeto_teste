using Microsoft.EntityFrameworkCore;
using Model;
using DAL;

namespace WebApplication1
{
    public class DataBaseContext: DbContext
    {
        public DbSet<Equipamento> Equipamento { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Conexao.StringDeConexao);
        }
    }
}