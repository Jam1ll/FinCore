using FinCore.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinCore.Infrastructure.Persistence.EntityConfigurations
{
    public class TransactionEntityConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Amount)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(t => t.SavingsAccountId)
                .HasMaxLength(100);

            builder.Property(t => t.Type)
                .HasMaxLength(50);

            builder.Property(t => t.Origin)
                .HasMaxLength(255);

            builder.Property(t => t.Beneficiary)
                .HasMaxLength(255);

            builder.Property(t => t.Date);

            builder.Property(t => t.CashierId)
                .HasMaxLength(100);

            builder.Property(t => t.SourceAccountId)
                .HasMaxLength(100);

            builder.Property(t => t.DestinationAccountId)
                .HasMaxLength(100);

            builder.Property(t => t.TransactionDate);

            builder.Property(t => t.DestinationLoanId);

            builder.Property(t => t.TransactionType)
                .HasConversion<string>()
                .HasMaxLength(50);

            builder.Property(t => t.Description)
                .HasMaxLength(500);

            builder.Property(t => t.DestinationCardId)
                .HasMaxLength(100);

            builder.Property(t => t.Status)
                .HasConversion<string>()
                .HasMaxLength(50);

            builder.Property(t => t.CreditCardId);
        }
    }
}