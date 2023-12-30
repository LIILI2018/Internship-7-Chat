using InternshipChat.Data.Entities;
using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace InternshipChat.Domain.Repositories {
	public class UserRepository : RepositoryPreset {
		public UserRepository(InternshipChatDbContext dbContext) : base(dbContext) { }//new InternshipChatDbContext(new DbContextOptionsBuilder(''))) {}

		public QueryResponse Add(User user) {
			DbContext.Users.Add(user);
			return SaveChanges();
		}
		public QueryResponse Delete(User user) {
			//Treba provjeriti postoji li user
			DbContext.Users.Remove(user);
			return SaveChanges();
		}
		public User? FindById(int id) {
			var user = DbContext.Users.Find(id);
			return user;/*Ako ne neđe usera vratit će null*/
		}
		public User? FindByEmail(string email) {
			var user = DbContext.Users.FirstOrDefault(u => u.Email == email);
			return user;/*Ako ne neđe usera vratit će null*/

		}

		public List<User> FindAll() {
			return DbContext.Users.ToList();
		}
	
	}
}
