using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WMS.Sisdep.Infra.Data.Entities;

namespace WMS.Sisdep.Infra.Data.Mappings
{

    public class PerfilMapping : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder
                .HasKey(u => u.Id);
            builder
                .Property(i => i.DataCadastro);
            builder
                .Property(i => i.UltimaAlteracao);
            builder
                .Property(b => b.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
            builder
                .HasMany(b => b.Usuario)
                .WithOne(b => b.Perfil)
                .HasForeignKey(b => b.PerfilId);
        }
        public static void PreLoadedData(ModelBuilder modelBuilder)
        {
            List<Perfil> data = new()
            {
                new Perfil()
                {
                    Id = new Guid("0295242e-3dff-4588-b19a-17c911872ed2"),
                    Nome = "GESTOR",

                },
                new Perfil()
                {
                    Id = new Guid("3fd34b96-f0de-430f-838a-03bab572a776"),
                    Nome = "COORDENADOR",

                },
            };

            data.ForEach(item => modelBuilder.Entity<Perfil>().HasData(item));
        }
    }

}
