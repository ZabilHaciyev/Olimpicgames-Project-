using BaseApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Entity
{
    public class OlimpicDBContext : DbContext
    {
        public OlimpicDBContext() : base("Connection"){}
        public DbSet<Country> Contries { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<WeightLimite> WeightLimites { get; set; }
        public DbSet<SportType> SportTypes { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Medal> Medals { get; set; }
        public DbSet<Athlet> Athlets { get; set; }
    }
}
