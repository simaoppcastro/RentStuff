using Microsoft.EntityFrameworkCore;
using System;
using StuffData.Models;

namespace StuffData
{
    public class StuffContext : DbContext 
    {
        public StuffContext(DbContextOptions options) : base(options) { }
        public DbSet<Client> Clients { get; set; }

    }
}
