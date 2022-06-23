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
            optionsBuilder.UseSqlite("Data Source = SDDDataFile.db"); //Creates the database called "SDDDataFile" if it doesn't already exist
        }

        public DbSet<User> User { get; set; } //Creates the User tablee within the database
        public DbSet<Workout> Workouts { get; set; } //Creates the workout table within the database
    }
}
