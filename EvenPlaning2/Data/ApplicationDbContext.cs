﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EvenPlaning2.Models;
using EvenPlaning2.Data.DataModels;

namespace EvenPlaning2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<EventModel> EventModel { get; set; }
        public DbSet<EventInfo> EventInfo { get; set; }
        public DbSet<SubThem> SubThems { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);



           
        }

    }
}
