using InternshipChat.Data.Entities;
using InternshipChat.Data.Entities.Models;
using InternshipChat.Data.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace InternshipChat.Data.Entities {
	public class InternshipChatDbContext :DbContext{
        public InternshipChatDbContext(DbContextOptions options) : base(options) {}

		public DbSet<Canal> Canals => Set<Canal>();
		public DbSet<User> Users => Set<User>();
		public DbSet<Message> Messages => Set<Message>();
		public DbSet<UserCanal> UserCanals => Set<UserCanal>();
		protected override void OnModelCreating(ModelBuilder modelBuilder) {

			modelBuilder.Entity<UserCanal>()
				.HasKey(uc => new { uc.UserId, uc.CanalId });

			modelBuilder.Entity<UserCanal>()
				.HasOne(uc => uc.User)
				.WithMany(u => u.UserCanals)
				.HasForeignKey(uc => uc.UserId);

			modelBuilder.Entity<UserCanal>()
				.HasOne(uc => uc.Canal)
				.WithMany(c => c.UserCanals)
				.HasForeignKey(uc => uc.CanalId);

			modelBuilder.Entity<Message>()
				.HasOne(m => m.Canal)
				.WithMany(c => c.Messages);

			modelBuilder.Entity<Message>()
				.HasOne(m => m.User)
				.WithMany(u => u.Messages);

			Seeder.Seed(modelBuilder);
			base.OnModelCreating(modelBuilder);
		}
	}
}
public class InternshipChatContextFactory : IDesignTimeDbContextFactory<InternshipChatDbContext> {
	public InternshipChatDbContext CreateDbContext(string[] args) {
		var config = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddXmlFile("App.config")
			.Build();

		config.Providers
			.First()
			.TryGet("connectionStrings:add:InternshipChat:connectionString", out var connectionString);

		var options = new DbContextOptionsBuilder<InternshipChatDbContext>()
			.UseNpgsql(connectionString)
			.Options;

		return new InternshipChatDbContext(options);
	}
}