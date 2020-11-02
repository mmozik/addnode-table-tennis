using AddnodeBalkan.TableTennis.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddnodeBalkan.TableTennis.Data
{
    public class TableTennisContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }

        public TableTennisContext()
        {

        }

        public TableTennisContext(DbContextOptions<TableTennisContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=tabletennis.db");
            base.OnConfiguring(options);
        }
    }
}
