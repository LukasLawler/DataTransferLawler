using Microsoft.EntityFrameworkCore;

namespace DataTransferLawler.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options)
            : base(options)
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Sport> Sports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Game>().HasData(
                new Game { GameID = "winter", Name = "Winter Olympics" },
                new Game { GameID = "summer", Name = "Summer Olympics" },
                new Game { GameID = "para", Name = "Paralympics" },
                new Game { GameID = "youth", Name = "Youth Olympic Games" }
            );
            modelBuilder.Entity<Sport>().HasData(
                new Sport { SportID = "curl", Name = "Curling/Indoor" },
                new Sport { SportID = "bob", Name = "Bobsleigh/Outdoor" },
                new Sport { SportID = "dive", Name = "Diving/Indoor" },
                new Sport { SportID = "road", Name = "Road Cycling/Outdoor" },
                new Sport { SportID = "arch", Name = "Archery/Indoor" },
                new Sport { SportID = "canoe", Name = "Canoe Sprint/Outdoor" },
                new Sport { SportID = "break", Name = "Breakdancing/Indoor" },
                new Sport { SportID = "skate", Name = "Skateboarding/Outdoor" }
            );
            modelBuilder.Entity<Country>().HasData(
                new { CountryID = "can", Name = "Canada", GameID = "winter", SportID = "curl", CountryFlag = "Canada.jpg" },
                new { CountryID = "swe", Name = "Sweden", GameID = "winter", SportID = "curl", CountryFlag = "Sweden.jpg" },
                new { CountryID = "gb", Name = "Great Britain", GameID = "winter", SportID = "curl", CountryFlag = "Britain.jpg" },
                new { CountryID = "jam", Name = "Jamaica", GameID = "winter", SportID = "bob", CountryFlag = "Jamaica.jpg" },
                new { CountryID = "ita", Name = "Italy", GameID = "winter", SportID = "bob", CountryFlag = "Italy.jpg" },
                new { CountryID = "jap", Name = "Japan", GameID = "winter", SportID = "bob", CountryFlag = "Japan.jpg" },
                new { CountryID = "ger", Name = "Germany", GameID = "summer", SportID = "dive", CountryFlag = "Germany.jpg" },
                new { CountryID = "chi", Name = "China", GameID = "summer", SportID = "dive", CountryFlag = "China.jpg" },
                new { CountryID = "mex", Name = "Mexico", GameID = "summer", SportID = "dive", CountryFlag = "Maxico.jpg" },
                new { CountryID = "bra", Name = "Brazil", GameID = "summer", SportID = "road", CountryFlag = "Brazil.jpg" },
                new { CountryID = "net", Name = "Netherlands", GameID = "summer", SportID = "road", CountryFlag = "Netherlands.jpg" },
                new { CountryID = "usa", Name = "USA", GameID = "summer", SportID = "road", CountryFlag = "USA.jpg" },
                new { CountryID = "tha", Name = "Thailand", GameID = "para", SportID = "arch", CountryFlag = "Thailand.jpg" },
                new { CountryID = "uru", Name = "Uruguay", GameID = "para", SportID = "arch", CountryFlag = "Uruguay.jpg" },
                new { CountryID = "ukr", Name = "Ukraine", GameID = "para", SportID = "arch", CountryFlag = "Ukraine.jpg" },
                new { CountryID = "aus", Name = "Austria", GameID = "para", SportID = "canoe", CountryFlag = "Austria.jpg" },
                new { CountryID = "pak", Name = "Pakistan", GameID = "para", SportID = "canoe", CountryFlag = "Pakistan.jpg" },
                new { CountryID = "zim", Name = "Zimbabwe", GameID = "para", SportID = "canoe", CountryFlag = "Zimbabwe.jpg" },
                new { CountryID = "fra", Name = "France", GameID = "youth", SportID = "break", CountryFlag = "France.jpg" },
                new { CountryID = "cyp", Name = "Cyprus", GameID = "youth", SportID = "break", CountryFlag = "Cyprus.jpg" },
                new { CountryID = "rus", Name = "Russia", GameID = "youth", SportID = "break", CountryFlag = "Russia.jpg" },
                new { CountryID = "fin", Name = "Finland", GameID = "youth", SportID = "skate", CountryFlag = "Finland.jpg" },
                new { CountryID = "slo", Name = "Slovakia", GameID = "youth", SportID = "skate", CountryFlag = "Slovakia.jpg" },
                new { CountryID = "por", Name = "Portugal", GameID = "youth", SportID = "skate", CountryFlag = "Portugal.jpg" }
            );
        }
    }
}
