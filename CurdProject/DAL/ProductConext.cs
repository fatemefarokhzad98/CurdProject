using CurdProject.Entity;
using Microsoft.EntityFrameworkCore;

namespace CurdProject.DAL
{
    public class ProductContext:DbContext
    {

        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder )
        {

            optionsBuilder.UseSqlServer("Server=DESKTOP-CGR2LP5\\MSSQLSERVER2022;Initial Catalog=Productdb;Integrated Security=True;TrustServerCertificate=True");

        }
        public DbSet<Product> Products { get; set; }
    }
}
