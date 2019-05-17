using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PayMan.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PayMan.Data
{
    public class PayContext : IdentityDbContext<ApplicationUser>
    {
        protected PayContext()
        {
        }

        public PayContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Banner> Banners { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<UsersAccounts> UsersAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersAccounts>().HasKey(x => new { x.AccountId, x.UserId });

            modelBuilder.Entity<Transaction>()
                        .HasOne(x => x.SenderAccount)
                        .WithMany(x => x.SendersTransactions)
                        .HasForeignKey(m => m.SenderAccountId)
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

            modelBuilder.Entity<Transaction>()
                        .HasOne(x => x.ReceiverAccount)
                        .WithMany(x => x.ReceiversTransactions)
                        .HasForeignKey(m => m.SenderAccountId)
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
