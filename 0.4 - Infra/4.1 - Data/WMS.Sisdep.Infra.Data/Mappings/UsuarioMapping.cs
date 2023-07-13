using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WMS.Sisdep.Infra.Data.Entities;

namespace WMS.Sisdep.Infra.Data.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .HasKey(u => u.Id);
            builder
                .Property(i => i.DataCadastro);
            builder
                .Property(i => i.UltimaAlteracao);
            builder
                .HasIndex(i => i.UsuarioNome)
                .IsUnique();
            builder
                .Property(b => b.UsuarioNome)
                .HasColumnName("Usuario")
                .HasColumnType("varchar(100)")
                .IsRequired();
            builder
                .Property(b => b.Senha)
                .HasColumnType("varchar(100)")
                .IsRequired();
            builder
                .Property(b => b.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
            builder
                .Property(b => b.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();
            builder
                .Property(b => b.PermiteAlterarArquivos)
                .HasColumnType("bit")
                .IsRequired();
            builder
                .Property(b => b.PermiteAlterarEquipes)
                .HasColumnType("bit")
                .IsRequired();
            builder
                .Property(b => b.PermiteAlterarNotaFiscal)
                .HasColumnType("bit")
                .IsRequired();

            builder
                .Property(b => b.QuedaInatividade)
                .HasColumnType("bit")
                .IsRequired();



        }
        public static void PreLoadedData(ModelBuilder modelBuilder)
        {
            List<Usuario> data = new()
            {
                new Usuario()
                {
                    Id = new Guid("F53B9069-7A32-4E50-B4C3-6ECB1CCB7091"),
                    UsuarioNome = "PANTOJA",
                    Nome = "Gabriel Pantoja",
                    Email = "gabriel.pantoja@nemag.com.br",
                    Senha = "12345",
                    PermiteAlterarArquivos= true,
                    PermiteAlterarEquipes= true,
                    PermiteAlterarNotaFiscal= true,
                    PerfilId = new Guid("0295242e-3dff-4588-b19a-17c911872ed2"),
                    QuedaInatividade = false,

                },
                new Usuario()
                {
                    Id = new Guid("91A02238-897F-48B0-ACD4-A040AB922743"),
                    UsuarioNome = "GUSTAVO",
                    Nome = "Luiz Gustavo",
                    Email = "gustavo.graciano@nemag.com.br",
                    Senha = "12345",
                    PermiteAlterarArquivos= true,
                    PermiteAlterarEquipes= true,
                    PermiteAlterarNotaFiscal= true,
                    PerfilId = new Guid("0295242e-3dff-4588-b19a-17c911872ed2"),
                    QuedaInatividade = false
                },
                 new Usuario()
                {
                    Id = new Guid("143AB2B1-D7AF-4864-A9ED-F16E3B24B619"),
                    UsuarioNome = "FILIPPE",
                    Nome = "Filippe Ferreira",
                    Email = "filippe@nemag.com.br",
                    Senha = "12345",
                    PermiteAlterarArquivos= true,
                    PermiteAlterarEquipes= true,
                    PermiteAlterarNotaFiscal= true,
                    PerfilId = new Guid("0295242e-3dff-4588-b19a-17c911872ed2"),
                    QuedaInatividade = false
                },
                 new Usuario()
                {
                    Id = Guid.NewGuid(),
                    UsuarioNome = "SUPER",
                    Nome = "Super",
                    Email = "super@super.com",
                    Senha = "12345",
                    PermiteAlterarArquivos= true,
                    PermiteAlterarEquipes= true,
                    PermiteAlterarNotaFiscal= true,
                    PerfilId = new Guid("0295242e-3dff-4588-b19a-17c911872ed2"),
                    QuedaInatividade = false
                },
                new Usuario()
                {
                    Id = Guid.NewGuid(),
                    UsuarioNome = "ADMIN",
                    Nome = "Admin",
                    Email = "admin@admin.com",
                    Senha = "12345",
                    PermiteAlterarArquivos= true,
                    PermiteAlterarEquipes= true,
                    PermiteAlterarNotaFiscal= true,
                    PerfilId = new Guid("0295242e-3dff-4588-b19a-17c911872ed2"),
                    QuedaInatividade = false
                },
            };

            data.ForEach(item => modelBuilder.Entity<Usuario>().HasData(item));
        }
    }
}

