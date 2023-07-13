using Microsoft.EntityFrameworkCore;
using WMS.Sisdep.Infra.OldData.Entities;
using WMS.Sisdep.Infra.OldData.Mappings;

namespace WMS.Sisdep.Infra.OldData.Context
{
    public class OldDataContext : DbContext
    {
        public OldDataContext(DbContextOptions<OldDataContext> options) : base(options) { }
        public DbSet<UsuarioOld>? TAB_PASW { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioOldMapping());
        }
    }
}
