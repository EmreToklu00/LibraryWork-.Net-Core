using System;
using librarywork.src.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySqlConnector.Logging;

namespace librarywork.src.context
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() { }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;user=root;password=123456;database=libraryDb";

            var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));

            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

    }
}

