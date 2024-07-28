using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StallosDotnetPleno.Domain.Entities;

namespace StallosDotnetPleno.Infrastructure.Mappings
{
    public class PessoaMap : EntityMap<Pessoa>
    {
        public override void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            base.Configure(builder);
            builder.ToTable("TB_PESSOA");

            builder.Property(p => p.IdTipoPessoa)
                   .HasColumnName("ID_TIPO_PESSOA");

            builder.Property(p => p.Nome)
                   .HasColumnName("NOME")
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(p => p.Documento)
                   .HasColumnName("DOCUMENTO")
                   .IsRequired().HasMaxLength(31)
                   .IsUnicode(false);

            builder.HasIndex(p => p.Documento)
                   .HasName("IDX_TB_PESSOA_DOCUMENTO").IsUnique();
        }
    }
}
