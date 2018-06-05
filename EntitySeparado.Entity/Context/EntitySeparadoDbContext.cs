using EntitySeparado.Entity.Configuration;
using System.Data.Entity;

namespace EntitySeparado.Entity.Context
{
    public class EntitySeparadoDbContext : DbContext
    {
        public EntitySeparadoDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PessoaConfiguration());
        }

        public System.Data.Entity.DbSet<EntitySeparado.Classes.Pessoa> Pessoas { get; set; }
    }
}
