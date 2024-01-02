using InternshipChat.Data.Entities;
using InternshipChat.Data.Entities.Models;
using InternshipChat.Domain.Enums;

namespace InternshipChat.Domain.Repositories {
	public class UserRepository : RepositoryPreset {
		public UserRepository(InternshipChatDbContext dbContext) : base(dbContext) { }

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
		public QueryResponse Update(User user, UserVariableChange userVariableChange, string change) {
			
			switch (userVariableChange) {
				case UserVariableChange.Name:
					user.Name = change;
					break;
				case UserVariableChange.Surename:
					user.Surename = change;
					break;
				case UserVariableChange.Email:
					user.Email = change;
					break;
				case UserVariableChange.Password:
					user.Password = change;
					break;
				case UserVariableChange.AdminStatus:
					user.IsAdmin = !user.IsAdmin;
					break;
			}
			return SaveChanges();
		}

	}
}
