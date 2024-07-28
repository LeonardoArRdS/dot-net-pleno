using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StallosDotnetPleno.Domain.Entities;

namespace StallosDotnetPleno.Infrastructure.Mappings
{
    public class EnderecoMap : EntityMap<Endereco>
    {
        public override void Configure(EntityTypeBuilder<Endereco> builder)
        {
            base.Configure(builder);
            builder.ToTable("TB_ENDERECO");
            builder.Property(e => e.Cep)
                   .HasColumnName("CEP")
                   .IsRequired()
                   .HasMaxLength(15);

            builder.Property(e => e.Logradouro)
                   .HasColumnName("LOGRADOURO")
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(e => e.Numero)
                   .HasColumnName("NUMERO")
                   .HasMaxLength(7);

            builder.Property(e => e.Bairro)
                   .HasColumnName("BAIRRO")
                   .IsRequired()
                   .HasMaxLength(63);

            builder.Property(e => e.Cidade)
                   .HasColumnName("CIDADE")
                   .IsRequired()
                   .HasMaxLength(31);

            builder.Property(e => e.Uf)
                   .HasColumnName("UF")
                   .IsRequired()
                   .HasMaxLength(2);
        }
    }
}
