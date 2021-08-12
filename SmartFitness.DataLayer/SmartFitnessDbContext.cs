using Microsoft.EntityFrameworkCore;
using SmartFitness.DataLayer.Models;
using System;

namespace SmartFitness.DataLayer
{
    public class SmartFitnessDbContext : DbContext
    {
        public SmartFitnessDbContext(DbContextOptions<SmartFitnessDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
