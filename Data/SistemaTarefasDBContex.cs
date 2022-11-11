using Microsoft.EntityFrameworkCore;
using SistemadeTarefas.Data.Map;
using SistemadeTarefas.Models;

namespace SistemadeTarefas.Data
{
    public class SistemaTarefasDBContex : DbContext
    {
        public SistemaTarefasDBContex(DbContextOptions<SistemaTarefasDBContex> options)
            : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new UsuarioMap());
            modelbuilder.ApplyConfiguration(new TarefaMap());

            base.OnModelCreating(modelbuilder);
        }
    }
}
