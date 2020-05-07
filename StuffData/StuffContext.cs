using Microsoft.EntityFrameworkCore;
using System;
using StuffData.Models;

namespace StuffData
{
    public class StuffContext : DbContext 
    {
        public StuffContext() { }
        public StuffContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Stuff> Stuffs { get; set; }
        public virtual DbSet<Checkout> Checkouts { get; set; }
        public virtual DbSet<CheckoutHistory> CheckoutHistories { get; set; }
        public virtual DbSet<StuffLocation> StuffLocations { get; set; }
        public virtual DbSet<LocalHours> LocalHours { get; set; }
        public virtual DbSet<RentStuffCard> RentStuffCards  { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<StuffAsset> StuffAssets { get; set; }
        public virtual DbSet<Hold> Holds { get; set; }


    }
}
