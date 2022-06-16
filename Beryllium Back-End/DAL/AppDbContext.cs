using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Beryllium_Back_End.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Beryllium_Back_End.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<AnotherSetting> AnotherSettings { get; set; }
    }
}
