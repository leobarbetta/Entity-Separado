using EntitySeparado.Classes;
using System.Data.Entity.ModelConfiguration;

namespace EntitySeparado.Entity.Configuration
{
    public class PessoaConfiguration : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfiguration()
        {
            HasKey(p => p.PessoaId);

            Property(p => p.Nome)
                .HasMaxLength(200);

            Property(p => p.Sexo)
                .HasColumnType("varchar");
        }
    }
}
