using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WMS.Sisdep.Infra.Data.Entities;

namespace WMS.Sisdep.Infra.Data.Mappings
{
    public class VersaoMapping : IEntityTypeConfiguration<Versao>
    {
        public void Configure(EntityTypeBuilder<Versao> builder)
        {
            builder
                .HasKey(u => u.Id);
            builder
                .Property(b => b.Titulo)
                .HasColumnType("varchar(100)")
                .IsRequired();
            builder
                .Property(b => b.Descricao)
                .HasColumnType("text");
        }
        public static void PreLoadedData(ModelBuilder modelBuilder)
        {
            List<Versao> data = new()
            {
                new Versao()
                {
                    Id = Guid.NewGuid(),
                    Titulo = "1.00"
                },
            };

            data.ForEach(item => modelBuilder.Entity<Versao>().HasData(item));
        }
    }
}
