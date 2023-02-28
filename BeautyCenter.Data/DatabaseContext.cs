using BeautyCenter.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyCenter.Data
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Brand> Brands { get; set; }
		public DbSet<List> Lists { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Country> Countries { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			
			optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; database=BeautyCenterDb; integrated security=true;");
			

			base.OnConfiguring(optionsBuilder);


			
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().HasData(
				new User
				{
					Id = 1,
					Phone = "",
					Email = "admin@projeuygulamasi.com",
					IsActive = true,
					IsAdmin = true,
					Name = "admin",
					Surname = "admin",
					Password = "123",
					CreateDate=DateTime.Now
					
				}
				);
			base.OnModelCreating(modelBuilder);
		}


	}
}
