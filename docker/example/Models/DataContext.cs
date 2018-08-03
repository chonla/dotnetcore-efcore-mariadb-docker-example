using System;
using Microsoft.EntityFrameworkCore;

namespace example.Models {
    public class DataContext: DbContext {

        public DbSet<Data> Data { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySql("Server=mariadb;uid=myuser;pwd=mypassword;database=mydb");
        }
    }
}