using Microsoft.EntityFrameworkCore;
using SoccerApp.Infrestuctura.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerApp.Infrestuctura
{
    public class SoccerAppContext : DbContext
    {
        public SoccerAppContext()
        {

        }
        public SoccerAppContext(DbContextOptions<SoccerAppContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-A33CT8E\\MSSQL_DB;Database=ComercializadoraDB;User=sa;pwd=fvr1Vega#;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new JugadorConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
