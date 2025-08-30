using FinCore.Core.Domain.Entities;
using FinCore.Infrastructure.Identity.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinCore.Infrastructure.Persistence.Contexts
{
    public class FinCoreContext : DbContext
    {
        public FinCoreContext(DbContextOptions<FinCoreContext> options) : base(options) { }

        //
        // DB SETS
        //

        public DbSet<SavingsAccount> SavingsAccount { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<AmortizationInstallment> AmortizationInstallments { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Beneficiary> Beneficiaries { get; set; }
        public DbSet<Commerce> Commerces { get; set; }
        public DbSet<AppUser> Users { get; set; }

        //
        // ENTITY CONFIGURATIONS APPLICATION
        //

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AppUser>()
                .Property(u => u.InitialAmount)
                .HasColumnType("decimal(18, 2)"); // Especifica precisión 18 y escala 2 para valores decimales

            modelBuilder.Entity<Loan>()
                .Property(l => l.RemainingDebt)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<SavingsAccount>()
                .Property(s => s.Balance)
                .HasColumnType("decimal(18, 2)");
            modelBuilder.Entity<Transaction>()
                .Property(t => t.Amount)
                .HasColumnType("decimal(18, 2)");
        }
    }
}