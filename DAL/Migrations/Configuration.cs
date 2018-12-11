using DAL.Entities;

namespace DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.KekContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DAL.KekContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var cookers = new Dictionary<string, Cooker>
            {
                {"kek", new Cooker() {Id = 1, Name = "kek"}},
                {"Danulo", new Cooker() {Id = 2, Name = "Danylo"}},
                {"Vova", new Cooker() {Id = 3, Name = "Vova"}},
                {"Vasya", new Cooker() {Id = 4, Name = "Vasya"}},
                {"Oleh", new Cooker() {Id = 5, Name = "Oleh"}},
                {"lol", new Cooker {Id = 6, Name = "lol"}}
            };

            foreach (var cooker in cookers.Values)
            {
                context.Cookers.AddOrUpdate(t => t.Id, cooker);
            }

            var orders = new List<Order>()
            {
                new Order(){Id = 1, Name = "Order 1", IsReady = false, IsTaken = false, CookerId = null, Time = DateTime.Now},
                new Order(){Id = 2, Name = "Order 2", IsReady = false, IsTaken = false, CookerId = null, Time = DateTime.Now},
                new Order(){Id = 3, Name = "Order 3", IsReady = false, IsTaken = false, CookerId = null, Time = DateTime.Now}
            };

            foreach (var order in orders)
            {
                context.Orders.AddOrUpdate(o => o.Id, order);
            }

            var sushies = new List<Sushi>()
            {
                new Sushi(){Id = 1, Name = "Rolls", OrderId = 1},
                new Sushi(){Id = 2, Name = "Sashimi", OrderId = 1},
                new Sushi(){Id = 3, Name = "Uramaki", OrderId = 1},
                new Sushi(){Id = 4, Name = "Maki", OrderId = 2},
                new Sushi(){Id = 5, Name = "Nigiri", OrderId = 2},
                new Sushi(){Id = 6, Name = "Cheaps", OrderId = 3},
                new Sushi(){Id = 7, Name = "Rolls", OrderId = 3}
            };

            foreach (var sushi in sushies)
            {
                context.Sushies.AddOrUpdate(s => s.Id, sushi);
            }
        }
    }
}
