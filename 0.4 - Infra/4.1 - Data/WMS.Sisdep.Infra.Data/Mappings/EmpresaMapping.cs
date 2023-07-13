using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WMS.Sisdep.Infra.Data.Entities;

namespace WMS.Sisdep.Infra.Data.Mappings
{
    public class EmpresaMapping : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder
                .HasKey(u => u.Id);
            builder
                .Property(i => i.DataCadastro);
            builder
                .Property(i => i.UltimaAlteracao);
            builder
                .Property(i => i.RazaoSocial)
                .HasColumnType("varchar(200)")
                .IsRequired();
            builder
                .Property(i => i.CNPJ)
                .HasColumnType("varchar(30)")
                .IsRequired();
            builder
               .Property(i => i.Endereço)
               .HasColumnType("varchar(200)")
               .IsRequired();
            builder
               .Property(i => i.Numero)
               .HasColumnType("int")
               .IsRequired();
            builder
              .Property(i => i.Complemento)
              .HasColumnType("varchar(200)");
            builder
               .Property(i => i.Cidade)
               .HasColumnType("varchar(200)")
               .IsRequired();
            builder
               .Property(i => i.Bairro)
               .HasColumnType("varchar(200)")
               .IsRequired();
            builder
              .Property(i => i.CEP)
              .HasColumnType("varchar(8)")
              .IsRequired();
            builder
               .Property(i => i.IE)
               .HasColumnType("int");
            builder
               .Property(i => i.UF)
               .HasColumnType("varchar(2)")
               .IsRequired();
            builder
               .Property(i => i.Contato)
               .HasColumnType("varchar(200)");
            builder
               .Property(i => i.Telefone)
               .HasColumnType("varchar(50)");
            builder
               .Property(i => i.Email)
               .HasColumnType("varchar(200)")
               .IsRequired();
            builder
               .Property(i => i.NomeServidor)
               .HasColumnType("varchar(200)")
               .IsRequired();
            builder
               .Property(i => i.PortaServidor)
               .HasColumnType("int")
               .IsRequired();
            builder
               .Property(i => i.RequerAutenticacao)
               .HasColumnType("bit")
               .IsRequired();
            builder
               .Property(i => i.UsuarioServidor)
               .HasColumnType("varchar(200)")
               .IsRequired();
            builder
               .Property(i => i.SenhaServidor)
               .HasColumnType("varchar(200)")
               .IsRequired();

        }
        public static void PreLoadedData(ModelBuilder modelBuilder)
        {
            List<Empresa> data = new()
            {
                new Empresa()
                {
                    Id = new Guid("BF006C54-99FF-4893-9881-0D30EC7406B1"),
                    RazaoSocial = "NEMAG INFORMÁTICA LTDA",
                    CNPJ = "68348630000195",
                    Endereço = "Rua Rocha",
                    Numero = 71,
                    Complemento = "",
                    Cidade = "São Paulo",
                    Bairro = "Bela Vista",
                    CEP = "03132125",
                    IE = 0,
                    UF ="SP",
                    Contato = "",
                    Telefone = "",
                    Email = "nemag@nemag.com",
                    NomeServidor = "Nemag",
                    PortaServidor = 200,
                    RequerAutenticacao = true,
                    UsuarioServidor = "Nemag",
                    SenhaServidor = "Nemag"
                },
                new Empresa()
                {
                    Id= new Guid("BFABBB8F-2D40-43D0-A9E9-6B34D70565C7"),
                    RazaoSocial = "NEMAG TECNOLOGIA LTDA",
                    CNPJ = "11117385000198",
                    Endereço = "Rua Rocha",
                    Numero = 71,
                    Complemento = "",
                    Cidade = "São Paulo",
                    Bairro = "Bela Vista",
                    CEP = "03132125",
                    IE = 0,
                    UF ="SP",
                    Contato = "",
                    Telefone = "",
                    Email = "nemag@nemag.com",
                    NomeServidor = "Nemag",
                    PortaServidor = 200,
                    RequerAutenticacao = true,
                    UsuarioServidor = "Nemag",
                    SenhaServidor = "Nemag"
                },
            };

            data.ForEach(item => modelBuilder.Entity<Empresa>().HasData(item));
        }
    }
}
