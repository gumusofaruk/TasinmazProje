using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class TasinmazContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=TasinmazDetaylari;Trusted_Connection=True;MultipleActiveResultSets=True;");
        }
        public DbSet<Tasinmaz> Tasinmazs { get; set; }
        public DbSet<Il> Ils { get; set; }
        public DbSet<Core.Entities.Concrete.User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Ilce> Ilces { get; set; }
    }
}
