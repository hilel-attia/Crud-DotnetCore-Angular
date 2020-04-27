using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class APIDBContext : DbContext
    {
        public APIDBContext(DbContextOptions<APIDBContext> options) : base(options)
        {
       
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<BankAccount>()
            //.HasOne(p => p.Bank)
            //.WithMany(b => b.BankAccounts)
            //.HasForeignKey(p => p.BankID);

            modelBuilder.Entity<Bank>()
                .HasMany(p => p.BankAccounts)
                .WithOne(x => x.Bank)
                .HasForeignKey(y => y.BankID);

        }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }

    }
   
}