using InternshipChat.Domain.Repositories;

namespace InternshipChat.Domain.Factories {
	public class RepositoryFactory {
		public static TRepository Create<TRepository>()
			where TRepository : RepositoryPreset {
			var dbContext = DbContextFactory.GetInternshipChatDbContext();
			var repositoryInstance = Activator.CreateInstance(typeof(TRepository), dbContext) as TRepository;

			return repositoryInstance!;
		}
	}
}
