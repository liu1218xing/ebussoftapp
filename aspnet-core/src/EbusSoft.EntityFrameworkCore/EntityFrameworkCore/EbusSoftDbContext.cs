using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EbusSoft.Authorization.Roles;
using EbusSoft.Authorization.Users;
using EbusSoft.MultiTenancy;
using EbusSoft.Lines;
using EbusSoft.Stations;
using EbusSoft.LineStations;
using EbusSoft.Provinces;
using EbusSoft.Cities;
using EbusSoft.Base.BusCompanies;

namespace EbusSoft.EntityFrameworkCore
{
    public class EbusSoftDbContext : AbpZeroDbContext<Tenant, Role, User, EbusSoftDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Line> Lines { get; set; }
        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<LineStation> LineStations { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public DbSet<BusCompany> BusCompanies {get;set;}
        public EbusSoftDbContext(DbContextOptions<EbusSoftDbContext> options)
            : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<LineStation>().HasOne(x => x.Line).WithMany(x => x.LineStations)
            //    .HasForeignKey(x => x.LineId);
            //modelBuilder.Entity<LineStation>().HasOne(x => x.Station).WithMany(x => x.LineStations)
            //    .HasForeignKey(x => x.StationId);
            //modelBuilder.Entity<Station>().HasOne(x => x.City).WithMany(x => x.Stations)
            //    .HasForeignKey(x => x.CityId);
            //modelBuilder.Entity<City>().HasOne(x => x.Province).WithMany(x => x.Cities)
            //    .HasForeignKey(x => x.PrivinceId);
        }
    }
}
