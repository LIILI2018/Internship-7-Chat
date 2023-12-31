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
			//Treba provjeriti postoji li canal
			DbContext.Canals.Remove(canal);
			return SaveChanges();
		}

		public List<Canal> FindAll() {
			return DbContext.Canals.ToList();
		}
	}
}
