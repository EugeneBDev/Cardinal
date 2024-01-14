using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Nodes;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace CardinalProj.Data
{
    internal class DataContext : DbContext
    {
        public DbSet<Entityes.User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = JsonSerializer.Deserialize<JsonNode>(File.ReadAllText("CardinalPconfig.json"));
            var connectionString = config["databases"]["planetScale"]["connectionString"].ToString();
            optionsBuilder.UseMySql(
                connectionString,
                new MySqlServerVersion(new Version(8, 0, 34))
            );
        }
    }
}
