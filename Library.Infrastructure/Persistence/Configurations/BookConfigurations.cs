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
    public class BookConfigurations : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder
            .HasKey(x => x.Id);

            builder
                .HasMany(b => b.Loans) // Um livro pode ter muitos empréstimos
                .WithOne(l => l.Book) // Cada empréstimo pertence a um livro
                .HasForeignKey(l => l.IdBook) // Chave estrangeira para IdBook em Loan
                .OnDelete(DeleteBehavior.Restrict); // Restringir exclusão
        }
    }
}
