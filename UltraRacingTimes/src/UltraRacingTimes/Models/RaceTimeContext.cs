using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace UltraRacingTimes.Models
{
    public class RaceTimeContext: DbContext
    {
        public DbSet<Racetime> Racetimes { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Racer> Racers { get; set; }
        public DbSet<Racetrack> Racetracks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = Startup.Configuration["Data:RacingtimesConnection"];

            optionsBuilder.UseSqlServer(connString);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
