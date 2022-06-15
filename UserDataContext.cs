using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MajorProject2022
{
    public class UserDataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = SDDDataFile.db");
        }

        public DbSet<User> User { get; set; }
        public DbSet<Workout> Workouts { get; set; }

    }
}
