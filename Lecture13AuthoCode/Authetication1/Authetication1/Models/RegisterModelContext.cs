using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authetication1.Models
{
    public class RegisterModelContext:DbContext
    {
        public RegisterModelContext(DbContextOptions<RegisterModelContext> options) : base(options)
        {

        }
        public DbSet<RegisterModel> RegisterModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegisterModel>().HasData(
                new RegisterModel { Id=1, Name = "Admin", Password = "password" },
                new RegisterModel { Id=2, Name = "Shamim",Password= "shamim" }
                );
        }
    }
}
