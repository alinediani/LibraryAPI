using Library.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Persistence.Configurations
{
    public class LoanConfigurations : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder
            .HasKey(x => x.Id);

            builder
                .HasOne(l => l.Book) // Um empréstimo pertence a um livro
                .WithMany(b => b.Loans) // Um livro pode ter muitos empréstimos
                .HasForeignKey(l => l.IdBook) // Chave estrangeira para IdBook em Loan
                .OnDelete(DeleteBehavior.Restrict); // Restringir exclusão

            builder
                .HasOne(l => l.User) // Um empréstimo pertence a um usuário
                .WithMany(u => u.Loans) // Um usuário pode ter muitos empréstimos
                .HasForeignKey(l => l.IdUser) // Chave estrangeira para IdUser em Loan
                .OnDelete(DeleteBehavior.Restrict); // Restringir exclusão
        }
    }
}
