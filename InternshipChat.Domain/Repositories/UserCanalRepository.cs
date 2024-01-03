using InternshipChat.Data.Entities;
using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Enums;


namespace InternshipChat.Domain.Repositories {
	public class UserCanalRepository : RepositoryPreset {
        public UserCanalRepository(InternshipChatDbContext dbContext) : base(dbContext){}

		public OperationResult Add(UserCanal userCanal) {
			DbContext.UserCanals.Add(userCanal);
			return SaveChanges();
		}
		public OperationResult Delete(UserCanal userCanal) {
			DbContext.UserCanals.Remove(userCanal);
			return SaveChanges();
		}
		public List<UserCanal> FindAll() {
			return DbContext.UserCanals.ToList();
		}
	}
}
