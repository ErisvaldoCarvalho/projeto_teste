using Microsoft.EntityFrameworkCore;
using Model;
using DAL;

namespace WebApplication1
{
    public class DataBaseContext: DbContext
    {
        public DbSet<Equipamento> Equipamento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Conexao.StringDeConexao);
        }
    }
}
