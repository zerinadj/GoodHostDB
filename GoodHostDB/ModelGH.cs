namespace GoodHostDB
{
    using System;
    using System.Data.Entity;
 

    public class ModelGH : DbContext
    {

        public DbSet Addresses { get; set; }
        public DbSet Devices { get; set; }
        public DbSet Offers { get; set; }
        public DbSet Places { get; set; }
        public DbSet Ratings { get; set; }
        public DbSet Rents { get; set; }
        public DbSet Reviews { get; set; }
        public DbSet Roles { get; set; }
        public DbSet Specs { get; set; }
        public DbSet Users { get; set; }
        public DbSet UserRoles { get; set; }

        
    }
}
