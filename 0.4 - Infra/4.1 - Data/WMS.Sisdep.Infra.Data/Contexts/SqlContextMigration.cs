using Microsoft.EntityFrameworkCore;
using WMS.Sisdep.Infra.Data.Entities;
using WMS.Sisdep.Infra.Data.Mappings;

namespace WMS.Sisdep.Infra.Data.Contexts
{
    public class SqlContextMigration : DbContext
    {
        public SqlContextMigration(DbContextOptions<SqlContextMigration> options) : base(options) { }

        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<UsuarioEmpresa> UsuarioEmpresa { get; set; }
        public DbSet<Versao> Versao { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Permissao> Permissao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmpresaMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            modelBuilder.ApplyConfiguration(new UsuarioEmpresaMapping());
            modelBuilder.ApplyConfiguration(new VersaoMapping());
            modelBuilder.ApplyConfiguration(new PerfilMapping());
            modelBuilder.ApplyConfiguration(new PermissaoMapping());

            EmpresaMapping.PreLoadedData(modelBuilder);
            UsuarioMapping.PreLoadedData(modelBuilder);
            UsuarioEmpresaMapping.PreLoadedData(modelBuilder);
            VersaoMapping.PreLoadedData(modelBuilder);
            PerfilMapping.PreLoadedData(modelBuilder);
            PermissaoMapping.PreLoadedData(modelBuilder);
        }
    }
}
