using InternshipChat.Data.Entities;
using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Enums;

namespace InternshipChat.Domain.Repositories {
	public class CanalRepository : RepositoryPreset {
		public CanalRepository(InternshipChatDbContext dbContext) : base(dbContext) { }

		public QueryResponse Add(Canal canal) {
			DbContext.Canals.Add(canal);
			return SaveChanges();
		}
		public QueryResponse Delete(Canal canal) {
			DbContext.Canals.Remove(canal);
			return SaveChanges();
		}
		public Canal? GetById(int id) {
			var canal = DbContext.Canals.Find(id);
			return canal;
		}
		public List<Canal> GetAll() {
			return DbContext.Canals.ToList();
		}
	}
}
