using AspNetCoreApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApi.Data
{
	public class ToDoDbContext : DbContext
	{
		public DbSet<ToDoItem> ToDos { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Server=.;database=NetCore; User Id=Dragos;Password=kmgi12345");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder
				.Entity<ToDoItem>()
				.Property(p => p.Title)
				.HasMaxLength(500);
		}
	}
}
