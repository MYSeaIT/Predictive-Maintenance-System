using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DailyMonitoringCMC.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using DailyMonitoringCMC.Migrations;

namespace DailyMonitoringCMC.Models
{
    public class DailyMonitoringCMCContext : DbContext
    {    
        public DailyMonitoringCMCContext() : base("name=DailyMonitoringCMCContext")
        {
        }

        public DbSet<WindPark> WindPark { get; set; }
        public DbSet<ConnectionControl> ConnectionControl { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Node> Node { get; set; }
        public DbSet<Trend> Trend { get; set; }
        public DbSet<WindMill> WindMill { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DailyMonitoringCMCContext, Configuration>());
           // modelBuilder.Entity<WindPark>().HasOptional(c => c.Connectioncontrol);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


        }
    }

    
}
