using Microsoft.EntityFrameworkCore;
using MinTurnering.Web.Data;
using System;

namespace PopulateDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MinTurnering;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            using (var db = new ApplicationDbContext(options))
            {
                Console.WriteLine("Deleting Db");
                db.Database.EnsureDeleted();
                Console.WriteLine("Db deleted");
                Console.WriteLine("Creating Db");
                db.Database.EnsureCreated();
                Console.WriteLine("Db Created");
            }
        }
    }
}