using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fluent_validation.Models
{
    public class DbContextApp :DbContext
    {

        public DbContextApp(DbContextOptions<DbContextApp> options) : base(options)
        {

        }

        public DbSet<Developer> Developers { get; set; }

        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Developer>()
                .Property(b => b.LastName)
                .IsRequired();
        }
        #endregion
    }
}
