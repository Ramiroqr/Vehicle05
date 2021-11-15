﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles05.API.Data.Entities;

namespace Vehicles05.API.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehiclePhoto> GetVehiclePhotos { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VehicleType>()
                .HasIndex(x => x.Description).IsUnique();

            modelBuilder.Entity<Procedure>()
                .HasIndex(x => x.Description).IsUnique();

            modelBuilder.Entity<Brand>()
                .HasIndex(X => X.Description).IsUnique();

            modelBuilder.Entity<DocumentType>()
                .HasIndex(x => x.Description).IsUnique();

            modelBuilder.Entity<Vehicle>()
                .HasIndex(x => x.Plaque).IsUnique();
        }
    }
}
