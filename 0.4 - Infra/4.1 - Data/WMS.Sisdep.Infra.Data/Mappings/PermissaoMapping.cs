using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WMS.Sisdep.Infra.Data.Entities;

namespace WMS.Sisdep.Infra.Data.Mappings
{

    public class PermissaoMapping : IEntityTypeConfiguration<Permissao>
    {
        public void Configure(EntityTypeBuilder<Permissao> builder)
        {
            builder.HasKey(p => p.Id);
            // Propriedades
            builder
                .Property(p => p.TelaReferencia)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(p => p.PermiteVisualizar)
                .IsRequired();
            builder
                .Property(p => p.PermiteEditar)
                .IsRequired();
            builder
                .Property(p => p.PermiteInativar)
                .IsRequired();
            builder
                .Property(p => p.PermiteAdicionar)
                .IsRequired();

            // Relacionamentos
            builder
                .HasOne(p => p.Perfil)
                .WithMany(c => c.Permissao)
                .HasForeignKey(p => p.PerfilId);
            builder
                .HasOne(p => p.Usuario)
                .WithMany(c => c.Permissao)
                .HasForeignKey(p => p.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

        }
        public static void PreLoadedData(ModelBuilder modelBuilder)
        {
            List<Permissao> data = new()
            {
                new Permissao()
                {
                    Id = new Guid("d8defa05-3568-4c90-a0be-47090346feae"),
                    TelaReferencia = "Cadastro" ,
                    PermiteVisualizar = true,
                    PermiteEditar  = true,
                    PermiteInativar = true,
                    PermiteAdicionar= true,
                    PerfilId = new Guid("0295242e-3dff-4588-b19a-17c911872ed2"),
                    UsuarioId = new Guid("F53B9069-7A32-4E50-B4C3-6ECB1CCB7091"),
                }   
            };

            data.ForEach(item => modelBuilder.Entity<Permissao>().HasData(item));
        }
    }
}
