using Microsoft.EntityFrameworkCore;
using System;

namespace FirstWeb{

    public class MyMvcContext : DbContext
    {
        //public MyMvcContext(DbContextOptions<MyMvcContext> options) : base(options){}                   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseNpgsql("User ID= Jroslove;Password=Jroslove;Server=localhost;Port=5432;Database=FirstWeb.Db;Integrated Security=true;Pooling=true;");   
        }
        public DbSet<User> Users { get; set; }        
    }
}