using InternshipChat.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace InternshipChat.Domain.Factories {
	public static class DbContextFactory {
		public static InternshipChatDbContext GetInternshipChatDbContext() {
			var options = new DbContextOptionsBuilder()
				.UseNpgsql(ConfigurationManager.ConnectionStrings["InternshipChat"].ConnectionString)
				.Options;

			return new InternshipChatDbContext(options);
		}
	}
}
