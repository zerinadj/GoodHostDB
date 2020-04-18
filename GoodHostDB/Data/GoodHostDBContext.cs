using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Projekat_1.Data
{
    public class Projekat_1Context : DbContext
    {
        public Projekat_1Context(DbContextOptions<Projekat_1Context> options) : base(options)
        {
        }

        public DbSet<Models.Device> Devices { get; set; }

        public DbSet<Models.Address> Addresses { get; set; }

        public DbSet<Models.Place> Places { get; set; }

        public DbSet<Models.Offer> Offers { get; set; }

        public DbSet<Models.User> Users { get; set; }

        public DbSet<Models.UserRole> UserRoles { get; set; }

        public DbSet<Models.Role> Roles { get; set; }

        public DbSet<Models.Rating> Ratings { get; set; }

        public DbSet<Models.Rent> Rents { get; set; }

        public DbSet<Models.Review> Reviews { get; set; }

        public DbSet<Models.Spec> Specs { get; set; }

    }
}
