using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WMS.Sisdep.Infra.OldData.Entities;

namespace WMS.Sisdep.Infra.OldData.Mappings
{
    public class UsuarioOldMapping : IEntityTypeConfiguration<UsuarioOld>
    {
        public void Configure(EntityTypeBuilder<UsuarioOld> builder)
        {
            builder
                .HasKey(u => u.Usuario);
            builder
                .Property(b => b.Nome)
                .HasColumnName("NOME");
            builder
                .Property(b => b.Senha)
                .HasColumnName("SENHA");
            builder
                .Property(b => b.Idioma)
                .HasColumnName("LINGUA");
            builder
                .Property(b => b.Acesso)
                .HasColumnName("ACESSO");
            builder
                .Property(b => b.VoltarNF)
                .HasColumnName("VOLTANF");
            builder
                .Property(b => b.GerarRelatorio)
                .HasColumnName("GERAREL");
            builder
                .Property(b => b.InformarPreco)
                .HasColumnName("INFPRECO");
            builder
                .Property(b => b.DiasSenha)
                .HasColumnName("DIAS_SENHA");
            builder
                .Property(b => b.DataSenha)
                .HasColumnName("DT_SENHA");
            builder
                .Property(b => b.SEG_ATUALIZA)
                .HasColumnName("SEG_ATUALIZA");
            builder
                .Property(b => b.AlterarPallets)
                .HasColumnName("ALTERA_PALLETS");
            builder
                .Property(b => b.Estabelecimento)
                .HasColumnName("ESTABELECIMENTO");
            builder
                .Property(b => b.TipoTela)
                .HasColumnName("TIPO_TELA");
            builder
                .Property(b => b.DataRelatorio)
                .HasColumnName("DATA_RELATORIO");
            builder
                .Property(b => b.AlterarDono)
                .HasColumnName("ALTERA_DONO");
            builder
                .Property(b => b.AlterarInventario)
                .HasColumnName("ALT_INV");
            builder
                .Property(b => b.LIB_STAT_ESP)
                .HasColumnName("LIB_STAT_ESP");
            builder
                .Property(b => b.UltimaVersaoLida)
                .HasColumnName("ULT_VERSAO_LIDA");
            builder
                .Property(b => b.CalcularFrete)
                .HasColumnName("CALC_FRETE");
            builder
                .Property(b => b.QuedaInativo)
                .HasColumnName("QUEDA_INATIVO");
            builder
                .Property(b => b.VersaoLida)
                .HasColumnName("VERSAO_LIDA");
            builder
                .Property(b => b.ImpressoraTermica)
                .HasColumnName("IMPR_TERMICA");
            builder
                .Property(b => b.ALT_PROT)
                .HasColumnName("ALT_PROT");
            builder
                .Property(b => b.EXCL_MOTO)
                .HasColumnName("EXCL_MOTO");
        }
    }
}
