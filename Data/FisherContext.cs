using Microsoft.EntityFrameworkCore;
using FisherInsuranceApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FisherInsuranceApi.Data
{
    public class FisherContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "User ID=fisher-user;Password=123qwe;Host=localhost;Port=5432;Database=fisher-insurance;Pooling=false;";

            optionsBuilder.UseNpgsql(connection);
        }
    }
}