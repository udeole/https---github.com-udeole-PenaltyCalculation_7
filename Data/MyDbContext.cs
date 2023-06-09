
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using PenaltyCalculation_7.Models;

namespace PenaltyCalculation_7.Data
{
    
    public class MyDbContext : DbContext

{

    public DbSet<RegisterViewModel>? RegisterViewModels { get; set; }
    public DbSet<LoginViewModel>? LoginViewModels { get; set; }
    
     MyDbContext(DbContextOptions <MyDbContext> options): base(options)
    {
        
    }

        public MyDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    {

        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=SignUp;Username=postgres;Password=XCV*bn@692");

    }

}
}