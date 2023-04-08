using Microsoft.EntityFrameworkCore;
using Methods.Models;
public class DbContextDemo:DbContext
{
   
        public DbContextDemo(DbContextOptions<DbContextDemo> options) : base(options)
        {

        }

        public DbSet<Student> Student { get; set; }

    }
	

