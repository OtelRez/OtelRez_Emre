﻿using Microsoft.EntityFrameworkCore;
using OtelRez.Entity.Config.Abstract;
using OtelRez.Entity.Config.Concrete;
using OtelRez.Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OtelRez.DAL.DbContexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Oda> Odalar { get; set; }
        public DbSet<OdaTur> OdaTurleri { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<PersonelMeslek> PersonelMeslekler { get; set; }
        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }
        public DbSet<PersonelGiris> PersonelGiris { get; set; }
        public DbSet<Role> Roller {  get; set; } 
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<IletisimeGec> IletisimeGec { get; set; }
        public DbSet<Galery> Galeriler { get; set; }
        public DbSet<Menu> Menuler { get; set; }
        public DbSet<MenuKategori> MenuKategoriler { get; set; }

        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=.;Database=OtelRezDb;Trusted_Connection=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BaseConfig<>).Assembly);
        }

    }
}
