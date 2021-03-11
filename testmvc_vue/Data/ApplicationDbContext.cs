using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using testmvc_vue.Models;

namespace testmvc_vue.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        //postgres change
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<testmvc_vue.Models.Table_A> Table_A { get; set; }
        public DbSet<testmvc_vue.Models.Table_B> Table_B { get; set; }
    }
}

//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using testmvc_vue.Models;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;

//namespace testmvc_vue.Data
//{
//    public class ApplicationDbContext : DbContext
//    {
//        public DbSet<testmvc_vue.Models.Table_A> Table_A { get; set; }
//        public DbSet<testmvc_vue.Models.Table_B> Table_B { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//            => optionsBuilder.UseNpgsql(Startup.ConnectionString);
//    }

//}
