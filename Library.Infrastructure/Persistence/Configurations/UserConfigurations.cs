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
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
            .HasKey(x => x.Id);

            builder
                .HasMany(u => u.UserLoans) // Um usuário pode ter muitos UserLoans
                .WithOne(ul => ul.User) // Cada UserLoan pertence a um usuário
                .HasForeignKey(ul => ul.IdUser) // Chave estrangeira para IdUser em UserLoan
                .OnDelete(DeleteBehavior.Restrict); // Restringir exclusão
        }
    }
}
