using Library.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Persistence.Configurations
{
    public class UserLoanConfigurations : IEntityTypeConfiguration<UserLoan>
    {
        public void Configure(EntityTypeBuilder<UserLoan> builder)
        {
            builder
                .HasKey(ul => new { ul.IdUser, ul.IdLoan });

            builder
                .HasOne(ul => ul.User)
                .WithMany(u => u.UserLoans)
                .HasForeignKey(ul => ul.IdUser);

            builder
                .HasOne(ul => ul.Loan)
                .WithOne(l => l.UserLoan)
                .HasForeignKey<UserLoan>(ul => ul.IdLoan); 
        }
    }
}
