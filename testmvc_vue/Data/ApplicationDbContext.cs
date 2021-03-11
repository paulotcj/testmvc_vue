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


        public DbSet<testmvc_vue.Models.Table_A> Table_A { get; set; }
        public DbSet<testmvc_vue.Models.Table_B> Table_B { get; set; }
    }
}
