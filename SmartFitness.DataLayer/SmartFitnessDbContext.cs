using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace SmartFitness.DataLayer
{
    public class SmartFitnessDbContext : IdentityDbContext
    {
        public SmartFitnessDbContext(DbContextOptions<SmartFitnessDbContext> options) : base(options)
        {

        }
    }
}
