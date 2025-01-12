﻿using Alquilandome.Data.entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace Alquilandome.Data.Context

{
    public class MyDbContext : DbContext, IMyDbContext
    {
        private readonly IConfiguration configuration;

        public MyDbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public DbSet<Alquiler> Alquiler { get; set; }
        public DbSet<AlquilerDetalle> AlquilerDetalle { get; set; }
        public DbSet<Articulo> Articulo { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: configuration.GetConnectionString(name: "MSSQL"));
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }

}
