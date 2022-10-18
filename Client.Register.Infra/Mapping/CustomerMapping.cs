using Client.Register.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Client.Register.Infra.Mapping;

public class CustomerMapping : IEntityTypeConfiguration<CustomerEntity>
{
    public void Configure(EntityTypeBuilder<CustomerEntity> builder)
    {
        builder.ToTable("TB_CUSTOMER");

        builder.HasKey(u => u.Id);

        builder.Property(p => p.Cpf).IsRequired();
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.BirthDate).IsRequired();
        builder.Property(p => p.Sex).IsRequired();
        builder.Property(p => p.PublicPlace).IsRequired();
        builder.Property(p => p.District).IsRequired();
        builder.Property(p => p.PostalCode).IsRequired();
        builder.Property(p => p.City).IsRequired();
        builder.Property(p => p.Uf).IsRequired();
    }
}