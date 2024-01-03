using InternshipChat.Data.Entities;
using InternshipChat.Domain.Enums;

namespace InternshipChat.Domain.Repositories {
	public abstract class RepositoryPreset {
		protected readonly InternshipChatDbContext DbContext;

		protected RepositoryPreset(InternshipChatDbContext dbContext) {
			DbContext = dbContext;
		}

		protected OperationResult SaveChanges() {
			var hasChanges = DbContext.SaveChanges() > 0;
			if (hasChanges)
				return OperationResult.Success;

			return OperationResult.NoChanges;
		}
	}
}
