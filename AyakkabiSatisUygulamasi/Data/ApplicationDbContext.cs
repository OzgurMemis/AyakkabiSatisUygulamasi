﻿using AyakkabiSatisUygulamasi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AyakkabiSatisUygulamasi.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser,AppRole,int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Products>? Products { get; set; }
        public DbSet<Slider>? Slider { get; set; }
    }
}
