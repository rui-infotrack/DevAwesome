using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTrack.DevAwesome.Models
{
    public class LdmCoreContext : DbContext
    {
        public DbSet<Login> Logins { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Retailer> Retailers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Role>().ToTable("Roles")
                .Collection(typeof(LoginRole), "LoginRoles")
                .InverseReference("Role");

            modelBuilder.Entity<Login>().ToTable("Logins")
                .Collection(typeof(LoginRole), "LoginRoles")
                .InverseReference("Login");

            modelBuilder.Entity<LoginRole>().ToTable("LoginRoles")
                .Key("LoginId", "RoleId");


            modelBuilder.Entity<Role>()
                .Collection(typeof(RetailerRole), "RetailerRoles")
                .InverseReference("Role");

            modelBuilder.Entity<Retailer>().ToTable("Retailers")
                .Collection(typeof(RetailerRole), "RetailerRoles")
                .InverseReference("Retailer");

            modelBuilder.Entity<RetailerRole>().ToTable("RetailerRoles")
                .Key("RetailerId", "RoleId");

            modelBuilder.Entity<Role>()
                .Collection(typeof(ClientRole), "ClientRoles")
                .InverseReference("Role");

            modelBuilder.Entity<Client>().ToTable("Clients")
                .Collection(typeof(ClientRole), "ClientRoles")
                .InverseReference("Client");

            modelBuilder.Entity<ClientRole>().ToTable("ClientRoles")
                .Key("ClientId", "RoleId");
        }
    }
}
