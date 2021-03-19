using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
<<<<<<< Updated upstream
=======
using testmvc_vue_core.Models;
>>>>>>> Stashed changes

namespace testmvc_vue.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
<<<<<<< Updated upstream
=======


        //postgres change
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Table_A> Table_A { get; set; }
        public DbSet<Table_B> Table_B { get; set; }
        public DbSet<TestA> TestA { get; set; }
>>>>>>> Stashed changes
    }
}
