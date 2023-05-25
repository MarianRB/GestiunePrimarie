using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PrimarieWeb.Models
{

    public class GestiunePrimarieContext : IdentityDbContext<IdentityUser>
    {

        public GestiunePrimarieContext(DbContextOptions<GestiunePrimarieContext> options)
        : base(options) { }

        public DbSet<Chat> Chats { get; set; }
        public DbSet<Cetatean> Cetateans { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Eveniment> Eveniments { get; set; }



        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                {
                     Configure your database provider here
                    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TestEntityFrameworkCoreDb;Trusted_Connection=True;ConnectRetryCount=0");
                }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Cetatean>()
            //    .HasOne(p => p.Rol)
            //    .WithMany(s => s.Users) // Specify the navigation property in Supplier entity
            //    .HasForeignKey(p => p.RolId);


            //modelBuilder.Entity<Product>()
            //   .HasOne(p => p.Supplier)
            //   .WithMany(s => s.Products) // Specify the navigation property in Supplier entity
            //   .HasForeignKey(p => p.SupplierId);

            modelBuilder.Entity<Eveniment>()
                .HasOne(sp => sp.Cetatean)
                .WithMany(s => s.Eveniments)
                .HasForeignKey(sp => sp.CetateanId);

            modelBuilder.Entity<Chat>()
                .HasOne(sc => sc.Cetatean)
                .WithMany(s => s.Chats)
                .HasForeignKey(sc => sc.CetateanId);

            modelBuilder.Entity<Document>()
                .HasOne(sc => sc.Cetatean)
                .WithMany(s => s.Documents)
                .HasForeignKey(sc => sc.CetateanId);


            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Ignore<IdentityUserLogin<string>>();


            modelBuilder.Entity<IdentityUserLogin<string>>()
              .HasKey(l => new { l.LoginProvider, l.ProviderKey });

            // Alte configurări ale modelului

            base.OnModelCreating(modelBuilder);




        }
    }
}
