using System;
using Microsoft.EntityFrameworkCore;
using AncorAPI.Models;

namespace AncorAPI.Models
{
    public class TransferDbContext:DbContext
    {
        public TransferDbContext(DbContextOptions<TransferDbContext> options): base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Transfer> Transfers { get; set; }
    }
}
