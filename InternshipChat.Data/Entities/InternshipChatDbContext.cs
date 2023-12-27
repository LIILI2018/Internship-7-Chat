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

		/*Manualno radiš veze između tablica*/
		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			modelBuilder.Entity<UserCanal>()
				.HasKey(uc => new { uc.UserId, uc.CanalId });//Radi primary key za user canal

			modelBuilder.Entity<UserCanal>()
				.HasOne(uc => uc.User)//Referencira user iz UserCanal
				.WithMany(u => u.UserCanals)//Referencira collection iz Usera nazvanu UserCanals
				.HasForeignKey(uc => uc.UserId);//Stvara forigen key UserId

			modelBuilder.Entity<UserCanal>()
				.HasOne(uc => uc.Canal)
				.WithMany(c => c.UserCanals)
				.HasForeignKey(uc => uc.CanalId);
			/*Ovo je many to many veza između User-UserCanal-Canal vljd*/

			modelBuilder.Entity<Message>()
				.HasOne(m => m.Canal)
				.WithMany(c => c.Messages);
			//Message Canal veza
			modelBuilder.Entity<Message>()
				.HasOne(m => m.User)
				.WithMany(u => u.Messages);
			//Message User veza
			Seeder.Seed(modelBuilder);
			base.OnModelCreating(modelBuilder);
		}
	}
}
/*Ovo sam copy pasteao sa gita i samo zamijenio varijablu konteksta*/
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
