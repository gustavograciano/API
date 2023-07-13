using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WMS.Sisdep.Infra.Data.Entities;

namespace WMS.Sisdep.Infra.Data.Mappings
{
    public class UsuarioEmpresaMapping : IEntityTypeConfiguration<UsuarioEmpresa>
    {
        public void Configure(EntityTypeBuilder<UsuarioEmpresa> builder)
        {
            builder
                .HasKey(x => x.Id);
            builder
                .HasOne(bc => bc.Usuario)
                .WithMany(b => b.UsuarioEmpresa)
                .HasForeignKey(bc => bc.UsuarioId);
            builder
                .HasOne(bc => bc.Empresa)
                .WithMany(c => c.UsuarioEmpresa)
                .HasForeignKey(bc => bc.EmpresaId);
        }
        public static void PreLoadedData(ModelBuilder modelBuilder)
        {
            List<UsuarioEmpresa> data = new()
            {
                new UsuarioEmpresa()
                {
                    UsuarioId = new Guid("F53B9069-7A32-4E50-B4C3-6ECB1CCB7091"),
                    EmpresaId = new Guid("BF006C54-99FF-4893-9881-0D30EC7406B1"),
                },
                 new UsuarioEmpresa()
                {
                    UsuarioId = new Guid("91A02238-897F-48B0-ACD4-A040AB922743"),
                    EmpresaId= new Guid("BFABBB8F-2D40-43D0-A9E9-6B34D70565C7"),
                },
                new UsuarioEmpresa()
                {
                    UsuarioId = new Guid("143AB2B1-D7AF-4864-A9ED-F16E3B24B619"),
                    EmpresaId = new Guid("BF006C54-99FF-4893-9881-0D30EC7406B1"),
                },
                new UsuarioEmpresa()
                {
                    UsuarioId = new Guid("143AB2B1-D7AF-4864-A9ED-F16E3B24B619"),
                    EmpresaId= new Guid("BFABBB8F-2D40-43D0-A9E9-6B34D70565C7"),
                }

            };

            data.ForEach(item => modelBuilder.Entity<UsuarioEmpresa>().HasData(item));
        }
    }
}
