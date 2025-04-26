﻿using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Context
{
	public class PortfolioContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-PUNASPD;initial Catalog=PortfolioDayDb;integrated security=true;");
		}
		public DbSet<Education> Educations { get; set; }
		public DbSet<Experience> Experiences { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
		public DbSet<Skill> Skills { get; set; }
		public DbSet<Portfolio> Portfolios { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Work> Works { get; set; }
		public DbSet<About> Abouts { get; set; }
		public DbSet<Statistic> Statistics { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
	}
}
