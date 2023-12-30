using InternshipChat.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Kopirao sa gita*/
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
